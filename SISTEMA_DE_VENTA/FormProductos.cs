using System;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DAL;
using Microsoft.EntityFrameworkCore;
using Models;

namespace CapaPresentacion
{
    public partial class FormProductos : Form
    {
        private readonly AppDbContext _context;
        private readonly ProductoService _productoService;
        private readonly CategoriaProductoService _categoriaService;

        public FormProductos(ProductoService productoService, CategoriaProductoService categoriaService, AppDbContext context)
        {
            InitializeComponent();
            _productoService = productoService;
            _categoriaService = categoriaService;
            _context = context;

            CargarCategorias();
            CargarProductos();

            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            this.Activated += FormProductos_Activated;
        }

        private void CargarCategorias()
        {
            try
            {
                var categorias = _categoriaService.ObtenerCategorias();

                if (categorias == null || categorias.Count == 0)
                {
                    MessageBox.Show("No hay categorías disponibles. Agrega categorías antes de continuar.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _productoService.ObtenerProductos();

            if (dgvProductos.Columns["Estado"] is null)
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
                {
                    Name = "Estado",
                    HeaderText = "Estado",
                    DataPropertyName = "Estado"
                };
                dgvProductos.Columns.Add(chk);
            }

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Estado" && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                bool estadoActual = Convert.ToBoolean(row.Cells["Estado"].Value);

                try
                {
                    if (estadoActual)
                        _productoService.HabilitarProducto(idProducto);
                    else
                        _productoService.DeshabilitarProducto(idProducto);

                    MessageBox.Show("Estado actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cmbCategoria.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);

                _productoService.AgregarProducto(nombre, descripcion, precio, stock, idCategoria);
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IdProducto"].Value);
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);

                _productoService.ActualizarProducto(idProducto, nombre, descripcion, precio, stock, idCategoria);
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IdProducto"].Value);

                var confirmacion = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    _productoService.EliminarProducto(idProducto);
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProductos_Activated(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}
