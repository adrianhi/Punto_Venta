using DevExpress.XtraBars;
using Punto_Venta.Controller;
using Punto_Venta.Model.EF;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Punto_Venta.View
{
    public partial class FrmClientList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly ClientController clientController;

        public FrmClientList ( )
        {
            InitializeComponent();
            clientController = new ClientController();
            gridViewClients.FocusedRowChanged -= gridViewClients_FocusedRowChanged;
            LoadData();
            btnAgregar.Enabled = false;
            gridViewClients.FocusedRowChanged += gridViewClients_FocusedRowChanged;
        }

        private void LoadData ( )
        {
            var clientList = clientController.getClients();
            gridControlClients.DataSource = clientList;
            gridViewClients.Columns["Maestro_ventas"].Visible = false;
        }

        private void ClearTextBox ( )
        {
            txtNombreCliente.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void EmailValidation ( )
        {
            string email = txtCorreo.Text;

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            bool isValid = System.Text.RegularExpressions.Regex.IsMatch(email, pattern);

            btnAgregar.Enabled = isValid;

            txtCorreo.ForeColor = isValid ? System.Drawing.Color.Black : System.Drawing.Color.Red;
        }

        private void FillTextBox (Maestro_Cliente selectedClient)
        {
            txtNombreCliente.Text = selectedClient.Nombre;
            txtDireccion.Text = selectedClient.Direccion;
            txtTelefono.Text = selectedClient.Telefono;
            txtCorreo.Text = selectedClient.CorreoElectronico;
        }

        private void txtCorreo_TextChanged (object sender, EventArgs e)
        {
            EmailValidation();
        }

        private void gridViewClients_FocusedRowChanged (object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is DevExpress.XtraGrid.Views.Grid.GridView gridView && gridView.FocusedRowHandle >= 0)
            {
                if (gridView.GetRow(e.FocusedRowHandle) is Maestro_Cliente selectedClient)
                {
                    FillTextBox(selectedClient);
                    btnAgregar.Enabled = false;
                }
            }
        }

        private void AddClient ( )
        {
            Maestro_Cliente newClient = new Maestro_Cliente
            {
                Nombre = txtNombreCliente.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                CorreoElectronico = txtCorreo.Text
            };

            clientController.AddClient(newClient);
            LoadData();
            ClearTextBox();
            MessageBox.Show("Cliente agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteClient ( )
        {
            string correoElectronico = txtCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(correoElectronico))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clientController.ClientExists(correoElectronico))
            {
                MessageBox.Show("El cliente con el correo electrónico " + correoElectronico + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el cliente con el correo electrónico " + correoElectronico + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clientController.DeleteClientByEmail(correoElectronico);
                MessageBox.Show("Cliente con el correo electrónico " + correoElectronico + " eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearTextBox();
            }
        }


        private void UpdateClient ( )
        {
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                string nombre = txtNombreCliente.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string correoElectronico = txtCorreo.Text.Trim();

                clientController.UpdateClient(correoElectronico, nombre, direccion, telefono);

                MessageBox.Show("Cliente actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                LoadData();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click (object sender, EventArgs e)
        {
            DeleteClient();
        }

        private void btnActualizar_Click (object sender, EventArgs e)
        {
            UpdateClient();
        }

        private void btnAgregar_Click (object sender, EventArgs e)
        {
            AddClient();
        }

        private void btnLimpiar_Click (object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
