using DevExpress.XtraEditors;
using Punto_Venta.Model.EF;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Punto_Venta.View.Mdi
{
    public partial class mdiProducts : XtraForm
    {
        public int IdSeleccionado { get; private set; }
        public string NombreSeleccionado { get; private set; }
        public decimal PrecioSeleccionado { get; private set; }
        public int StockSeleccionado { get; private set; }

        public mdiProducts ( )
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor
            // Instantiate a new DBContext
            Punto_Venta.Model.EF.Punto_ventasEntities dbContext = new Punto_Venta.Model.EF.Punto_ventasEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Productos.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControlProducts.DataSource = dbContext.Productos.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridViewProducts_DoubleClick (object sender, EventArgs e)
        {
            var productoSeleccionado = ObtenerProductoSeleccionado();

           
            IdSeleccionado = productoSeleccionado.Id_producto;
            NombreSeleccionado = productoSeleccionado.Nombre;
            PrecioSeleccionado = (decimal)productoSeleccionado.Precio_venta;
            StockSeleccionado = (int)productoSeleccionado.Stock;

           
            this.Close();
        }

        private Producto ObtenerProductoSeleccionado ( )
        {
            var selectedRow = gridViewProducts.GetFocusedRow() as Producto;
            return selectedRow;
        }
    }
}
