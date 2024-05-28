using DevExpress.XtraEditors;
using Punto_Venta.Model.EF;
using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Punto_Venta.Controllers
{
    public class CxcController
    {
        private readonly Punto_ventasEntities context;
        private readonly FacturasController facturasController;
        private readonly TransactionController transaction;

        public CxcController ( )
        {
            context = new Punto_ventasEntities();
            facturasController = new FacturasController();
            transaction = new TransactionController();
        }

        public void CreateCxC (Maestro_ventas venta)
        {
            try
            {
                decimal montoTotalVenta = venta.Monto_total ?? 0;
                decimal montoRecibido = GetAmountReceived(venta);
                decimal saldoPendiente = montoTotalVenta - venta.Monto_recibido ?? 0;

                AddCxC(venta, montoTotalVenta, saldoPendiente);

                XtraMessageBox.Show("Cuenta por cobrar generada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowErrorMessageBox("Error al generar la cuenta por cobrar", ex);
            }
        }

        private void AddCxC (Maestro_ventas venta, decimal montoTotalVenta, decimal saldoPendiente)
        {
            Maestro_ctasxcobrar nuevaCxC = new Maestro_ctasxcobrar
            {
                Id_venta = venta.Id_venta,
                Id_TipoTransaccion = venta.Id_TipoTransaccion,
                Id_Transaccion = venta.Id_Transaccion,
                Id_Cliente = venta.Id_cliente,
                Monto_total = montoTotalVenta,
                Monto_recibido = venta.Monto_recibido,
                Balance = saldoPendiente
            };

            facturasController.CreateFactura(venta, "Pendiente ");
            context.Maestro_ctasxcobrar.Add(nuevaCxC);
            context.SaveChanges();
        }

        private decimal GetAmountReceived (Maestro_ventas venta)
        {
            decimal montoRecibido = context.Transacciones
                                              .Where(t => t.Id_Venta == venta.Id_venta)
                                              .Sum(t => t.Total) ?? 0;
            return montoRecibido;
        }

        public bool InsertarDetallesCXC (int idCxC, decimal montoAbonado, DateTime fechaAbono)
        {
            try
            {
                int idTipoTransaccion = InsertTransactionType();
                Maestro_ctasxcobrar maestroCxC = context.Maestro_ctasxcobrar.FirstOrDefault(maestro => maestro.Id_CxC == idCxC);

                if (maestroCxC != null)
                {
                    string estado = (montoAbonado >= maestroCxC.Balance) ? "Pagado" : "Pendiente";
                    Detalles_ctasxcobrar nuevoDetalleCxC = CreateDetallesCxC(idCxC, montoAbonado, idTipoTransaccion, maestroCxC, estado, fechaAbono);

                    context.Detalles_ctasxcobrar.Add(nuevoDetalleCxC);
                    context.SaveChanges();

                    bool actualizacionCxCExitosa = ActualizarCxC(idCxC, montoAbonado);
                    if (!actualizacionCxCExitosa)
                    {
                        ShowErrorMessageBox("Error al actualizar el balance de la cuenta por cobrar", null);
                        return false;
                    }

                    XtraMessageBox.Show("Detalle de cuenta por cobrar insertado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("No se encontró cuenta por cobrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessageBox("Error en la cuenta por cobrar", ex);
                return false;
            }
        }

        private int InsertTransactionType ( )
        {
            Tipo_Transaccion tipoTransaccion = new Tipo_Transaccion
            {
                Descripcion = "Recibo de cobro",
                EsCredito = false
            };
            return transaction.InsertTransactionType(tipoTransaccion, true);
        }

        private Detalles_ctasxcobrar CreateDetallesCxC (int idCxC, decimal montoAbonado, int idTipoTransaccion, Maestro_ctasxcobrar maestroCxC, string estado, DateTime fechaAbono)
        {
            int transactionId = transaction.InsertTrasaction(maestroCxC.Id_venta ?? 0, fechaAbono, idTipoTransaccion, maestroCxC.Monto_total ?? 0);
            return new Detalles_ctasxcobrar
            {
                Id_CxC = idCxC,
                Id_Transaccion = transactionId,
                Id_TipoTransaccion = idTipoTransaccion,
                Ref_IdTransaccion = maestroCxC.Id_Transaccion ?? 0,
                Balance = maestroCxC.Balance ?? 0,
                Estado = estado,
                Monto_Abonado = montoAbonado,
                Fecha = fechaAbono
            };
        }

        public bool ActualizarCxC (int idCxC, decimal montoAbonado)
        {
            try
            {
                Maestro_ctasxcobrar maestroCxC = context.Maestro_ctasxcobrar.FirstOrDefault(maestro => maestro.Id_CxC == idCxC);

                if (maestroCxC != null)
                {
                    if (montoAbonado >= maestroCxC.Balance)
                    {
                        maestroCxC.Balance = 0.0m;
                    }
                    else
                    {
                        maestroCxC.Balance -= montoAbonado;
                    }

                    UpdateDetallesCxCBalance(idCxC, maestroCxC.Balance ?? 0);
                    context.SaveChanges();

                    XtraMessageBox.Show("Actualización de cuenta por cobrar exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("No se encontró el registro correspondiente en la tabla Maestro_ctasxcobrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessageBox("Error al actualizar cuenta por cobrar", ex);
                return false;
            }
        }

        private void UpdateDetallesCxCBalance (int idCxC, decimal balance)
        {
            var detallesCxC = context.Detalles_ctasxcobrar.Where(detalle => detalle.Id_CxC == idCxC);
            foreach (var detalle in detallesCxC)
            {
                detalle.Balance = balance;
            }
        }

        public Detalles_ctasxcobrar GetDetallesCxC (int idCxC)
        {
            return context.Detalles_ctasxcobrar.FirstOrDefault(detalle => detalle.Id_CxC == idCxC);
        }

        private void ShowErrorMessageBox (string message, Exception ex)
        {
            if (ex != null)
            {
                XtraMessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show($"{message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
