using Punto_Venta.Controllers;
using Punto_Venta.Model.EF;
using System;
using System.Windows.Forms;

namespace Punto_Venta.View
{
    public partial class FrmCategoryList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly CategoryController productCategoryController;
        public FrmCategoryList()
        {
            InitializeComponent();
            productCategoryController = new CategoryController();
            gridViewCategories.FocusedRowChanged -= gridViewCategories_FocusedRowChanged;
            LoadCategories();
            gridViewCategories.FocusedRowChanged += gridViewCategories_FocusedRowChanged;

        }

        private void LoadCategories()
        {
            var categories = productCategoryController.GetCategories();
            gridControlCategories.DataSource = categories;
            gridViewCategories.Columns["Productos"].Visible = false;


        }
        private void ClearTextBox()
        {
            txtIdCategoria.Text = "";
            txtNombreCategoria.Text = "";
            rtxtDescripcion.Text = "";
            btnAgregar.Enabled = true;

        }
        private void FillCategoryTextBox(Categoria_productos selectedCategory)
        {
            txtIdCategoria.Text = selectedCategory.Id_categoria.ToString();
            txtNombreCategoria.Text = selectedCategory.Nombre_categoria;
            rtxtDescripcion.Text = selectedCategory.Descripcion;
        }


        //CRUD

        private void AddCategory()
        {
            Categoria_productos nuevaCategoria = new Categoria_productos
            {
                Id_categoria = int.Parse(txtIdCategoria.Text),
                Nombre_categoria = txtNombreCategoria.Text,
                Descripcion = rtxtDescripcion.Text
            };
           productCategoryController.AddCategory(nuevaCategoria);
            MessageBox.Show("Categoría agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategories();
            ClearTextBox();
        }
        private void DeleteCategory()
        {
            int idCategoriaEliminar;
            if (!int.TryParse(txtIdCategoria.Text, out idCategoriaEliminar))
            {
                MessageBox.Show("Por favor, ingrese un ID de categoría válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (!productCategoryController.CategoryExists(idCategoriaEliminar))
            {
                MessageBox.Show("La categoría con el ID " + idCategoriaEliminar + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Categoria_productos categoriaAEliminar = productCategoryController.GetCategoryById(idCategoriaEliminar);
            if (categoriaAEliminar == null)
            {
                MessageBox.Show("La categoría con el ID " + idCategoriaEliminar + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar la categoría con el ID " + idCategoriaEliminar + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productCategoryController.DeleteCategory(categoriaAEliminar);
                MessageBox.Show("Categoría con el ID " + idCategoriaEliminar + " eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategories();

            }
        }
        private void UpdateCategory()
        {
            int idCategoria;
            if (!int.TryParse(txtIdCategoria.Text.Trim(), out idCategoria))
            {
                MessageBox.Show("Por favor, ingrese un ID de categoría válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevoNombre = txtNombreCategoria.Text.Trim();
            string nuevaDescripcion = rtxtDescripcion.Text.Trim();
            productCategoryController.updateCategory(idCategoria, nuevoNombre, nuevaDescripcion);

            MessageBox.Show("Categoría actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategories();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddCategory();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void gridViewCategories_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is DevExpress.XtraGrid.Views.Grid.GridView gridView && gridView.FocusedRowHandle >= 0)
            {
                if (gridView.GetRow(e.FocusedRowHandle) is Categoria_productos selectedCategory)
                {
                    FillCategoryTextBox(selectedCategory);
                    btnAgregar.Enabled = false;

                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateCategory();
        }
    }
}