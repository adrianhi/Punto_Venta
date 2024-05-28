using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Punto_Venta.Model.EF;
using Punto_Venta.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Punto_Venta.Controllers
{
    public class FacturasController
    {
        private readonly Punto_ventasEntities context;

        public FacturasController ( )
        {
            context = new Punto_ventasEntities();
        }

        public void CreateFactura (Maestro_ventas venta, string EstadoFactura)
        {
            try
            {
                Factura nuevaFactura = new Factura
                {
                    Id_Venta = venta.Id_venta,
                    Id_TipoTransaccion = venta.Id_TipoTransaccion ?? 0,
                    Id_Transaccion = venta.Id_Transaccion,
                    FechaEmision = venta.Fecha.Value,
                    Id_Cliente = venta.Id_cliente ?? 0,
                    Total = venta.Monto_total ?? 0,
                    Total_Pagado = venta.Monto_recibido ?? 0,
                    EstadoPago = EstadoFactura
                };

                context.Facturas.Add(nuevaFactura);
                context.SaveChanges();

                int facturaId = nuevaFactura.Id_Factura;

                GenerarFacturaReporte(venta.Id_venta);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error al crear la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void GenerarFacturaReporte (int ventaId)
        {
            try
            {
                var query = from f in context.Facturas
                            join mv in context.Maestro_ventas on f.Id_Venta equals mv.Id_venta
                            join mc in context.Maestro_Clientes on f.Id_Cliente equals mc.idCliente
                            join dv in context.Detalles_ventas on f.Id_Venta equals dv.Id_venta
                            join p in context.Productos on dv.Id_producto equals p.Id_producto
                            where mv.Id_venta == ventaId
                            select new
                            {
                                idFactura = f.Id_Factura,
                                nombreCliente = mc.nombre,
                                CodigoProducto = p.Codigo,
                                nombreProducto = p.Nombre,
                                cantidad = dv.Cantidad,
                                precioVenta = dv.Precio_venta,
                                montoTotal = mv.Monto_total,
                                Fecha = f.FechaEmision
                            };
                var resultado = query.ToList();

                // Crear un DataTable con las columnas apropiadas
                DataTable dt = new DataTable();
                dt.Columns.Add("Id_Factura", typeof(int));
                dt.Columns.Add("NombreCliente", typeof(string));
                dt.Columns.Add("Codigo", typeof(string));
                dt.Columns.Add("NombreProducto", typeof(string));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Precio_venta", typeof(decimal));
                dt.Columns.Add("Monto_recibido", typeof(decimal));
                dt.Columns.Add("Monto_total", typeof(decimal));

                foreach (var item in resultado)
                {
                    // Agregar cada resultado como una nueva fila al DataTable
                    dt.Rows.Add(item.idFactura, item.nombreCliente, item.CodigoProducto, item.nombreProducto, item.cantidad, item.precioVenta, item.montoTotal);
                }
                // Iterar sobre cada fila en el DataTable e imprimir sus valores
                foreach (DataRow row in dt.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write(item.ToString() + "\t");
                    }
                    Console.WriteLine();
                }

         


                ReportSale rpt = new ReportSale();
                rpt.DataSource=dt;

                // Mostrar el diálogo de vista previa del reporte
                rpt.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
               Console.WriteLine($"Error al generar el informe de factura: {ex.Message}");
            }
        }
        private Producto GetProductInfo (int id_producto)
        {
            return context.Productos.FirstOrDefault(p => p.Id_producto== id_producto);

        }

        private List<Detalles_ventas> GetVentaInfo (int ventaId)
        {
            return context.Detalles_ventas.Where(v => v.Id_venta == ventaId).ToList();
        }


        private Maestro_Clientes GetClienteInfo (int clienteId)
        {
                return context.Maestro_Clientes.FirstOrDefault(c => c.idCliente == clienteId);
        }


    }
}
