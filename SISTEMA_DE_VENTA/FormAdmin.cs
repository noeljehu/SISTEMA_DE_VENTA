using System;
using System.Windows.Forms;
using BLL;
using DAL;
using Models; // Para usar la clase Usuario
using Microsoft.EntityFrameworkCore;
using SISTEMA_DE_VENTA;
using Microsoft.Extensions.DependencyInjection;

namespace CapaPresentacion
{
    public partial class FormAdmin : Form
    {
        private readonly AppDbContext _context; // Contexto de base de datos
        private readonly Usuario _usuarioActual; // Usuario autenticado
        private readonly IServiceProvider _serviceProvider; // Proveedor de servicios

        public FormAdmin(AppDbContext context, Usuario usuario, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

            label1.Text = $"Bienvenido, {_usuarioActual.Username}";

            ConfigurarPermisos(); // Configurar la visibilidad de los botones
        }

        private void ConfigurarPermisos()
        {
            // Verifica si el usuario NO es "Admin"
            if (_usuarioActual.Rol.NombreRol.ToLower() != "admin")
            {
                btnUsuario.Visible = false;    // Ocultar botón de Usuarios
                btnTrabajador.Visible = false; // Ocultar botón de Trabajadores
            }
        }

        private void AbrirFormulario(Form formHijo)
        {
            panelContenedor.Controls.Clear(); // Limpiar contenido del panel

            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            formHijo.BackColor = Color.White;
            panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios formUsuarios = new FrmUsuarios(_context);
            AbrirFormulario(formUsuarios);
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            // ✅ Obtener el DbContext desde el ServiceProvider
            var context = _serviceProvider.GetRequiredService<AppDbContext>();

            // ✅ Crear FormPersonas con los parámetros en el orden correcto
            FormPersonas formPersona = new FormPersonas(_usuarioActual, context);

            // ✅ Método para abrir el formulario
            AbrirFormulario(formPersona);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos(_context);
            AbrirFormulario(formProductos);
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            FormTrabajadores formTrabajadores = new FormTrabajadores(_context);
            AbrirFormulario(formTrabajadores);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FormProveedores formProveedores = new FormProveedores(_context);
            AbrirFormulario(formProveedores);
        }
    }
}
