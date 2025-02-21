using System;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DAL;
using Models;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        private readonly AppDbContext _context;
        private readonly UsuarioService _usuarioService;
        private readonly RolService _rolService;

        public FrmUsuarios(AppDbContext context)
        {
            InitializeComponent();
            _context = context ?? throw new ArgumentNullException(nameof(context)); // ✅ Guardar contexto
            _rolService = new RolService(_context);
            _usuarioService = new UsuarioService(_context);

            CargarRoles();
            CargarUsuarios();
        }



        private void CargarRoles()
        {
            try
            {
                var roles = _rolService.ObtenerRoles();
                if (roles == null || roles.Count == 0)
                {
                    MessageBox.Show("No hay roles disponibles. Agrega roles antes de crear usuarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cbRol.DataSource = roles;
                cbRol.DisplayMember = "NombreRol";
                cbRol.ValueMember = "IdRol";
                cbRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = _usuarioService.ObtenerUsuarios()
                    .Select(u => new
                    {
                        u.IdUsuario,
                        u.Username,
                        Rol = u.Rol.NombreRol,
                        Trabajador = u.Trabajador.Persona.Nombres + " " + u.Trabajador.Persona.Apellidos,
                        u.Activo
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbRol.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un rol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRol = Convert.ToInt32(cbRol.SelectedValue);

            try
            {
                Trabajador trabajador = _usuarioService.BuscarTrabajadorPorDNI(dni);
                if (trabajador == null)
                {
                    MessageBox.Show("La persona con este DNI no está registrada como trabajador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Usuario nuevoUsuario = new Usuario
                {
                    Username = username,
                    Contraseña = password,
                    IdRol = idRol,
                    IdTrabajador = trabajador.IdTrabajador,
                    Activo = true
                };

                _usuarioService.AgregarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                txtDNI.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                cbRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);
                string username = txtUsername.Text.Trim();
                int idRol = Convert.ToInt32(cbRol.SelectedValue);
                bool activo = chkActivo.Checked;

                try
                {
                    Usuario usuario = new Usuario { IdUsuario = idUsuario, Username = username, IdRol = idRol, Activo = activo };
                    _usuarioService.ActualizarUsuario(usuario);
                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);
                DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _usuarioService.EliminarUsuario(idUsuario);
                    CargarUsuarios();
                }
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                txtUsername.Text = dgvUsuarios.SelectedRows[0].Cells["Username"].Value.ToString();
                cbRol.Text = dgvUsuarios.SelectedRows[0].Cells["Rol"].Value.ToString();
                chkActivo.Checked = (bool)dgvUsuarios.SelectedRows[0].Cells["Activo"].Value;
            }
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);
                bool nuevoEstado = chkActivo.Checked;
                DialogResult result = MessageBox.Show(
                    nuevoEstado ? "¿Seguro que deseas activar este usuario?" : "¿Seguro que deseas desactivar este usuario?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );
                if (result == DialogResult.Yes)
                {
                    _usuarioService.CambiarEstadoUsuario(idUsuario, nuevoEstado);
                    CargarUsuarios();
                }
                else
                {
                    chkActivo.CheckedChanged -= chkActivo_CheckedChanged;
                    chkActivo.Checked = !nuevoEstado;
                    chkActivo.CheckedChanged += chkActivo_CheckedChanged;
                }
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
