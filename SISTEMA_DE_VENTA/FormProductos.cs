using System;
using System.Windows.Forms;
using BLL;
using DAL;
using Models;

namespace CapaPresentacion
{
    public partial class FormProductos : Form
    {
        public readonly ProductoService _productoService;

        public FormProductos(AppDbContext context)
        {
            InitializeComponent();
            _productoService = new ProductoService(context);
            CargarProductos();
        }

        // Cargar productos en el DataGridView
        private void CargarProductos()
        {
            dgvProductos.DataSource = _productoService.ObtenerProductos();
        }

        // Buscar producto por Nombre
        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _productoService.BuscarProductoPorNombre(txtBuscarNombre.Text);
        }

        // Método para validar decimal
        private decimal ValidarDecimal(string texto)
        {
            decimal precio;
            if (!decimal.TryParse(texto, out precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return precio;
        }

        // Método para validar entero
        private int ValidarEntero(string texto)
        {
            int stock;
            if (!int.TryParse(texto, out stock))
            {
                MessageBox.Show("El stock debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return stock;
        }

        // Evento para seleccionar un producto desde el DataGridView
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya seleccionado una fila válida
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];


                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el precio sea un número decimal
                decimal precio = ValidarDecimal(txtPrecio.Text);
                if (precio == -1) return;

                // Validar que el stock sea un número entero
                int stock = ValidarEntero(txtStock.Text);
                if (stock == -1) return;

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamar al servicio para agregar el producto
                _productoService.AgregarProducto(
                    txtNombre.Text,
                    txtDescripcion.Text,
                    precio,
                    stock
                );
                MessageBox.Show("Producto agregado correctamente.");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un producto para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el ID del producto de la fila seleccionada
                int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value);

                // Validar que el precio sea un número decimal
                decimal precio = ValidarDecimal(txtPrecio.Text);
                if (precio == -1) return;

                // Validar que el stock sea un número entero
                int stock = ValidarEntero(txtStock.Text);
                if (stock == -1) return;

                _productoService.ActualizarProducto(
                    id,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    precio,
                    stock
                );
                MessageBox.Show("Producto actualizado correctamente.");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHabilitar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un producto para habilitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el ID del producto de la fila seleccionada
                int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value);

                _productoService.HabilitarProducto(id);
                MessageBox.Show("Producto habilitado.");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeshabilitar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un producto para deshabilitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el ID del producto de la fila seleccionada
                int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value);

                _productoService.DeshabilitarProducto(id);
                MessageBox.Show("Producto deshabilitado.");
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
