using System;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Models;
using System.Collections.Generic;
using DAL;

namespace UI
{
    public partial class CategoriaProductoForm : Form
    {
        private readonly CategoriaProductoService _categoriaService;

        public CategoriaProductoForm(CategoriaProductoService categoriaService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            CargarCategorias();
            dgvCategorias.CellClick += dgvCategorias_CellClick;
        }

        private void CargarCategorias()
        {
            var categorias = _categoriaService.ObtenerCategorias();
            dgvCategorias.DataSource = categorias;
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategorias.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                _categoriaService.AgregarCategoria(txtNombre.Text, txtDescripcion.Text);
                CargarCategorias();
                MessageBox.Show("Categoría agregada correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["IdCategoria"].Value);
                    _categoriaService.ActualizarCategoria(id, txtNombre.Text, txtDescripcion.Text);
                    CargarCategorias();
                    MessageBox.Show("Categoría actualizada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Seleccione una categoría antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["IdCategoria"].Value);
                    _categoriaService.EliminarCategoria(id);
                    CargarCategorias();
                    MessageBox.Show("Categoría eliminada correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Seleccione una categoría antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}