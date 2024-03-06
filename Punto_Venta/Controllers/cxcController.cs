using DevExpress.XtraEditors;
using Punto_Venta.Model.EF;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Punto_Venta.Controllers
{
    public class CxcController
    {
        private readonly Punto_ventasEntities context;
        private readonly FacturasController facturasController;
        public CxcController ( )
        {
            context = new Punto_ventasEntities();
            facturasController = new FacturasController ();
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
                XtraMessageBox.Show($"Error al generar la cuenta por cobrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCxC (Maestro_ventas venta, decimal montoTotalVenta, decimal saldoPendiente)
        {
            Maestro_ctasxcobrar nuevaCxC = new Maestro_ctasxcobrar
            {
                Id_venta = venta.Id_venta,
                Id_TipoTransaccion = venta.Id_TipoTransaccion,
                Id_Transaccion=venta.Id_Transaccion,
                Id_Cliente = venta.Id_cliente,
                Monto_total = montoTotalVenta,
                Monto_recibido=venta.Monto_recibido,
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

       

    }
}
