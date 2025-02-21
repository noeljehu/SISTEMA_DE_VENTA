using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Microsoft.EntityFrameworkCore;
using Models;

namespace CapaPresentacion
{
    public partial class FormTrabajadores : Form

    {
        private readonly TrabajadorService _trabajadorService;
        private readonly AppDbContext _context;

        public FormTrabajadores(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); // ✅ Guardar contexto
            InitializeComponent();
            _trabajadorService = new TrabajadorService(context);
            CargarTrabajadores();
        }

        private void CargarTrabajadores()
        {
            try
            {
                var trabajadores = _trabajadorService.ObtenerTrabajadores();
                dataGridViewTrabajadores.DataSource = trabajadores.Select(t => new
                {
                    t.IdTrabajador,
                    t.Persona.DNI,
                    t.Persona.Nombres,
                    t.Cargo,
                    t.Salario,
                    t.FechaContratacion,
                    t.Estado
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar trabajadores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridViewTrabajadores.SelectedRows.Count > 0)
            {
                int idTrabajador = Convert.ToInt32(dataGridViewTrabajadores.SelectedRows[0].Cells["IdTrabajador"].Value);
                bool nuevoEstado = chkEstado.Checked; // Si está marcado, habilita; si no, deshabilita.

                try
                {
                    if (nuevoEstado)
                        _trabajadorService.HabilitarTrabajador(idTrabajador);
                    else
                        _trabajadorService.DeshabilitarTrabajador(idTrabajador);

                    MessageBox.Show("Estado actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTrabajadores(); // Recargar lista para reflejar cambios.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void dataGridViewTrabajadores_SelectionChanged(object sender, EventArgs e)
        {


            if (dataGridViewTrabajadores.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTrabajadores.SelectedRows[0];

                // ✅ Verifica si las columnas existen antes de acceder a ellas
                if (dataGridViewTrabajadores.Columns.Contains("Cargo") && selectedRow.Cells["Cargo"].Value != null)
                    txtCargo.Text = selectedRow.Cells["Cargo"].Value.ToString();
                else
                    txtCargo.Clear();

                if (dataGridViewTrabajadores.Columns.Contains("Salario") && selectedRow.Cells["Salario"].Value != null)
                    txtSalario.Text = selectedRow.Cells["Salario"].Value.ToString();
                else
                    txtSalario.Clear();

                if (dataGridViewTrabajadores.Columns.Contains("FechaContratacion") && selectedRow.Cells["FechaContratacion"].Value != null)
                    dateTimePickerFechaContratacion.Value = Convert.ToDateTime(selectedRow.Cells["FechaContratacion"].Value);
                else
                    dateTimePickerFechaContratacion.Value = DateTime.Now;

                // ✅ Verifica si la columna 'Estado' existe y tiene un valor antes de convertirlo
                if (dataGridViewTrabajadores.Columns.Contains("Estado") && selectedRow.Cells["Estado"].Value != null && selectedRow.Cells["Estado"].Value != DBNull.Value)
                    chkEstado.Checked = Convert.ToBoolean(selectedRow.Cells["Estado"].Value);
                else
                    chkEstado.Checked = false;
            }
        }



        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            dateTimePickerFechaContratacion.Value = DateTime.Now;
            chkEstado.Checked = true;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {



            string dni = txtDNI.Text.Trim();
            string cargo = txtCargo.Text.Trim();
            if (!decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                MessageBox.Show("El salario debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaContratacion = dateTimePickerFechaContratacion.Value;

            try
            {
                bool resultado = _trabajadorService.AgregarTrabajadorPorDNI(dni, cargo, salario, fechaContratacion);

                MessageBox.Show("Resultado del servicio: " + resultado, "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultado)
                {
                    MessageBox.Show("Trabajador agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTrabajadores();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el trabajador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTrabajadores.SelectedRows.Count > 0)
            {
                int idTrabajador = Convert.ToInt32(dataGridViewTrabajadores.SelectedRows[0].Cells["IdTrabajador"].Value);
                string cargo = txtCargo.Text.Trim();
                if (!decimal.TryParse(txtSalario.Text, out decimal salario))
                {
                    MessageBox.Show("El salario debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(cargo))
                {
                    MessageBox.Show("El cargo es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaContratacion = dateTimePickerFechaContratacion.Value;

                try
                {
                    _trabajadorService.ActualizarTrabajador(idTrabajador, cargo, salario, fechaContratacion);
                    MessageBox.Show("Trabajador actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTrabajadores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
