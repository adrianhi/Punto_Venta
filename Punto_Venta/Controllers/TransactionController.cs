using DevExpress.XtraEditors;
using Punto_Venta.Model.EF;
using System;



namespace Punto_Venta.Controllers
{
    public class TransactionController
    {
        private readonly Punto_ventasEntities context;
        public TransactionController() {
            context = new Punto_ventasEntities();
        }
        public int InsertTransactionType (Tipo_Transaccion TransactionType, bool IsCxC)
        {
            try
            {
                if (IsCxC)
                {
                    SetTransactionTypeForCxC(TransactionType);
                }
                else
                {
                    SetTransactionTypeBasedOnEsCredito(TransactionType);
                }

                // Agregar el objeto TransactionType al contexto de la base de datos
                context.Tipo_Transaccion.Add(TransactionType);
                context.SaveChanges();

                return TransactionType.Id_TipoTransaccion;
            }
            catch (Exception )
            { 
                return -1; 
            }
        }



        public int InsertTrasaction (int idVenta, DateTime fecha, int tipoTransaccionId, decimal total)
        {
            int transactionId = -1; // Valor predeterminado en caso de que ocurra un error

            try
            {
                // Crear una nueva instancia de Transacciones con los datos proporcionados
                Transaccione transaccion = new Transaccione
                {
                    Id_Venta = idVenta,
                    Fecha = fecha,
                    Tipo_transaccion_id = tipoTransaccionId,
                    Total = total
                };

                // Agregar la nueva transacción a la base de datos y guardar los cambios
                context.Transacciones.Add(transaccion);
                context.SaveChanges();

                // Obtener el ID de la transacción después de insertarla
                transactionId = transaccion.Id_Transaccion;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante el proceso
                XtraMessageBox.Show($"Error al insertar la transacción: {ex.Message}");
            }

            return transactionId; // Devolver el ID de la transacción
        }


        //Set

        private void SetTransactionTypeForCxC (Tipo_Transaccion TransactionType)
        {
            TransactionType.Recibo_Cobro = true;
            TransactionType.Fact_Credito = false;
            TransactionType.Fact_contado = false;
        }

        private void SetTransactionTypeBasedOnEsCredito (Tipo_Transaccion TransactionType)
        {
            TransactionType.Recibo_Cobro = false;
            if (TransactionType.EsCredito )
            {
                // Si la transacción es a crédito, establecer Fact_Credito en verdadero y Fact_contado en falso
                TransactionType.Fact_Credito = true;
                TransactionType.Fact_contado = false;
            }
            else
            {
                // Si la transacción no es a crédito, establecer Fact_Credito en falso y Fact_contado en verdadero
                TransactionType.Fact_Credito = false;
                TransactionType.Fact_contado = true;
            }
        }
    }
}
