using System;
using System.Linq;
using System.Windows.Forms;
using BLL;
using Models;
using DAL;

namespace CapaPresentacion
{
    public partial class FormProveedores : Form
    {
        private readonly ProveedorService _proveedorService;

        public FormProveedores(AppDbContext context)
        {
            InitializeComponent();
            _proveedorService = new ProveedorService(context);
            CargarProveedores();
        }

        // Cargar proveedores en el DataGridView
        private void CargarProveedores()
        {
            var proveedores = _proveedorService.ObtenerProveedores()
                .Select(p => new
                {
                    p.IdProveedor,
                    p.Nombre,
                    p.Ruc,
                    p.Direccion,
                    p.Telefono,
                    p.Email,
                    p.TipoProveedor,
                    Estado = p.Estado ? "Activo" : "Inactivo",
                    p.Observaciones, // Asegúrate de incluir la columna Observaciones
                    p.Web
                })
                .ToList();

            dgvProveedores.DataSource = proveedores;

            // Asegúrate de que las columnas estén bien definidas
            dgvProveedores.Columns["Observaciones"].Visible = true;
        }


        // Botón para agregar un nuevo proveedor
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombre.Text;
                var ruc = txtRuc.Text;
                var direccion = txtDireccion.Text;
                var telefono = txtTelefono.Text;
                var email = txtEmail.Text;
                var tipoProveedor = txtTipoProveedor.Text;
                var estado = chkEstado.Checked;
                var observaciones = txtObservaciones.Text;
                var web = txtWeb.Text;

                // Llamada al servicio para agregar el proveedor
                _proveedorService.AgregarProveedor(nombre, ruc, direccion, telefono, email, tipoProveedor, estado, observaciones, web);

                MessageBox.Show("Proveedor agregado con éxito.");
                CargarProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Botón para actualizar un proveedor
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedores.SelectedRows.Count > 0)
                {
                    int idProveedor = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["IdProveedor"].Value);
                    var proveedor = new Proveedor
                    {
                        IdProveedor = idProveedor,
                        Nombre = txtNombre.Text,
                        Ruc = txtRuc.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text,
                        TipoProveedor = txtTipoProveedor.Text,
                        Estado = chkEstado.Checked,
                        Observaciones = txtObservaciones.Text,
                        Web = txtWeb.Text
                    };

                    _proveedorService.ActualizarProveedor(proveedor);
                    MessageBox.Show("Proveedor actualizado con éxito.");
                    CargarProveedores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Seleccione un proveedor para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Botón para eliminar un proveedor
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedores.SelectedRows.Count > 0)
                {
                    int idProveedor = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["IdProveedor"].Value);
                    _proveedorService.EliminarProveedor(idProveedor);
                    MessageBox.Show("Proveedor eliminado con éxito.");
                    CargarProveedores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Seleccione un proveedor para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Seleccionar fila en el DataGridView y mostrar en los campos de texto
        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedores.Rows[e.RowIndex];

                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtRuc.Text = row.Cells["Ruc"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTipoProveedor.Text = row.Cells["TipoProveedor"].Value.ToString();
                txtObservaciones.Text = row.Cells["Observaciones"].Value.ToString();  // Aquí accedes correctamente a la columna Observaciones
                txtWeb.Text = row.Cells["Web"].Value.ToString();
                chkEstado.Checked = row.Cells["Estado"].Value.ToString() == "Activo";
            }
        }

        // Método para limpiar los campos de texto
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtRuc.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtTipoProveedor.Clear();
            txtObservaciones.Clear();
            txtWeb.Clear();
            chkEstado.Checked = true;
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
