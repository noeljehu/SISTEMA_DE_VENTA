using System;
using System.Windows.Forms;
using BLL;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; // Importar para IServiceProvider
using Models;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly AppDbContext _context;
        private readonly IServiceProvider _serviceProvider; // Agregado

        public FormLogin(AppDbContext context, IServiceProvider serviceProvider) // Modificado
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider; // Guardamos el ServiceProvider
            _usuarioService = new UsuarioService(context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                var usuario = _context.Usuarios
                    .Include(u => u.Rol)
                    .FirstOrDefault(u => u.Username == username);

                if (usuario == null)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (usuario.Contraseña != password)
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!usuario.Activo)
                {
                    MessageBox.Show("Su cuenta está inactiva. Contacte al administrador.", "Cuenta inactiva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Crear FormAdmin con el ServiceProvider
                FormAdmin formAdmin = new FormAdmin(_context, usuario, _serviceProvider);
                this.Hide();
                formAdmin.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
