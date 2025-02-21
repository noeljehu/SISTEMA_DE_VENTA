using System;
using System.Windows.Forms;
using BLL;
using Models;
using DAL;

namespace SISTEMA_DE_VENTA
{
    public partial class FormPersonas : Form
    {
        private readonly PersonaService personaService;
        private readonly UbigeoService ubigeoService;
        private readonly Usuario _usuarioActual;
        private readonly AppDbContext _context;

        // Constructor que recibe un Usuario y el DbContext
        public FormPersonas(Usuario usuario, AppDbContext context)
        {
            InitializeComponent();

            // ? Asignar variables correctamente
            _usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));
            _context = context ?? throw new ArgumentNullException(nameof(context));

            // ? Usar _context correctamente en los servicios
            personaService = new PersonaService(_context);
            ubigeoService = new UbigeoService(_context);

            // ? Cargar datos
            CargarPersonas();
            CargarUbigeos();
        }



        private void CargarPersonas()
        {
            dgvPersonas.DataSource = personaService.ObtenerPersonasConRoles();
        }

        private void CargarUbigeos()
        {
            var listaUbigeos = ubigeoService.ObtenerDistritos(); // Obtener lista de Ubigeos

            if (listaUbigeos.Count == 0)
            {
                MessageBox.Show("No hay Ubigeos disponibles.");
                return;
            }

            cmbUbigeo.DataSource = listaUbigeos;
            cmbUbigeo.DisplayMember = "Distrito";  // Mostrar el distrito en el ComboBox
            cmbUbigeo.ValueMember = "IdUbigeo";   // Guardar el IdUbigeo internamente
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado un Ubigeo válido
                if (cmbUbigeo.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un Ubigeo válido.");
                    return;
                }

                int idUbigeo = Convert.ToInt32(cmbUbigeo.SelectedValue);

                // Verificar si el Ubigeo existe en la base de datos
                if (!ubigeoService.ExisteUbigeo(idUbigeo))
                {
                    MessageBox.Show("El código de Ubigeo ingresado no existe.");
                    return;
                }

                // Guardar la persona con el Ubigeo correcto
                personaService.AgregarPersona(
                    txtDni.Text,
                    txtNombres.Text,
                    txtApellidos.Text,
                    dtpFechaNacimiento.Value,
                    txtSexo.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtEmail.Text,
                    idUbigeo // Ahora pasamos el ID correcto
                );

                MessageBox.Show("Persona guardada correctamente.");
                CargarPersonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var persona = personaService.BuscarPorDNI(txtDni.Text);
            if (persona != null)
            {
                txtNombres.Text = persona.Nombres;
                txtApellidos.Text = persona.Apellidos;
                dtpFechaNacimiento.Value = persona.FechaNacimiento;
                txtSexo.Text = persona.Sexo;
                txtDireccion.Text = persona.Direccion;
                txtTelefono.Text = persona.Telefono;
                txtEmail.Text = persona.Email;
                cmbUbigeo.SelectedValue = persona.IdUbigeo; // Cargar Ubigeo correctamente
            }
            else
            {
                MessageBox.Show("No se encontró a la persona.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una persona para actualizar.");
                    return;
                }

                if (cmbUbigeo.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un Ubigeo válido.");
                    return;
                }

                int idUbigeo = Convert.ToInt32(cmbUbigeo.SelectedValue);
                int idPersona = Convert.ToInt32(dgvPersonas.SelectedRows[0].Cells["IdPersona"].Value); // ?? Obtener el ID de la persona seleccionada

                var persona = new Persona
                {
                    IdPersona = idPersona, // ?? ID correcto
                    DNI = txtDni.Text,
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Sexo = txtSexo.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    IdUbigeo = idUbigeo
                };

                personaService.ActualizarPersona(persona);
                MessageBox.Show("Persona actualizada correctamente.");
                CargarPersonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                var selectedRow = dgvPersonas.SelectedRows[0];

                // Asigna valores a los TextBox y controles
                
                txtDni.Text = selectedRow.Cells["DNI"].Value?.ToString() ?? "";
                txtNombres.Text = selectedRow.Cells["Nombres"].Value?.ToString() ?? "";
                txtApellidos.Text = selectedRow.Cells["Apellidos"].Value?.ToString() ?? "";
                txtSexo.Text = selectedRow.Cells["Sexo"].Value?.ToString() ?? "";
                txtDireccion.Text = selectedRow.Cells["Direccion"].Value?.ToString() ?? "";
                txtTelefono.Text = selectedRow.Cells["Telefono"].Value?.ToString() ?? "";
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? "";

                // ? Manejo seguro de FechaNacimiento
                if (selectedRow.Cells["FechaNacimiento"].Value != null &&
                    DateTime.TryParse(selectedRow.Cells["FechaNacimiento"].Value.ToString(), out DateTime fechaNacimiento))
                {
                    dtpFechaNacimiento.Value = fechaNacimiento;
                }
                else
                {
                    dtpFechaNacimiento.Value = DateTime.Now;
                }

                
            }
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.SelectedRows.Count > 0)
                {
                    int idPersona = Convert.ToInt32(dgvPersonas.SelectedRows[0].Cells["IdPersona"].Value);
                    personaService.EliminarPersona(idPersona);
                    MessageBox.Show("Persona eliminada correctamente.");
                    CargarPersonas();
                }
                else
                {
                    MessageBox.Show("Seleccione una persona para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
