using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Punto_Venta.View
{
    public partial class FrmDetalleVentas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmDetalleVentas ( )
        {
            InitializeComponent();
          
        }

        private void FrmDetalleVentas_Load (object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'detalleVentas.Detalles_ventas' Puede moverla o quitarla según sea necesario.
            this.detalles_ventasTableAdapter.Fill(this.detalleVentas.Detalles_ventas);

        }
    }
}