using System;
using System.Windows.Forms;

namespace SISTEMA_DE_VENTA
{
    partial class FormPersonas
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDni;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private ComboBox cmbUbigeo;
        private DataGridView dgvPersonas;
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnEliminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDni = new TextBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            cmbUbigeo = new ComboBox();
            dgvPersonas = new DataGridView();
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            txtSexo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 10.8F);
            txtDni.Location = new Point(41, 20);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(237, 31);
            txtDni.TabIndex = 0;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Segoe UI", 10.8F);
            txtNombres.Location = new Point(41, 57);
            txtNombres.Name = "txtNombres";
            txtNombres.PlaceholderText = "Nombres";
            txtNombres.Size = new Size(237, 31);
            txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Segoe UI", 10.8F);
            txtApellidos.Location = new Point(41, 94);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "Apellidos";
            txtApellidos.Size = new Size(237, 31);
            txtApellidos.TabIndex = 2;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 10.8F);
            dtpFechaNacimiento.Location = new Point(41, 131);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(237, 31);
            dtpFechaNacimiento.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10.8F);
            txtDireccion.Location = new Point(41, 207);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(237, 31);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10.8F);
            txtTelefono.Location = new Point(41, 244);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(237, 31);
            txtTelefono.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F);
            txtEmail.Location = new Point(41, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(237, 31);
            txtEmail.TabIndex = 7;
            // 
            // cmbUbigeo
            // 
            cmbUbigeo.Font = new Font("Segoe UI", 10.8F);
            cmbUbigeo.Location = new Point(41, 318);
            cmbUbigeo.Name = "cmbUbigeo";
            cmbUbigeo.Size = new Size(237, 33);
            cmbUbigeo.TabIndex = 8;
            // 
            // dgvPersonas
            // 
            dgvPersonas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersonas.BackgroundColor = Color.White;
            dgvPersonas.ColumnHeadersHeight = 29;
            dgvPersonas.Location = new Point(312, 20);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.Size = new Size(762, 575);
            dgvPersonas.TabIndex = 9;
            dgvPersonas.SelectionChanged += dgvPersonas_SelectionChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(93, 176, 188);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.8F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(41, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(237, 50);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Silver;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10.8F);
            btnBuscar.Location = new Point(41, 526);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(237, 50);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(51, 194, 108);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10.8F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(41, 414);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(237, 50);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(206, 83, 99);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.8F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(41, 470);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(237, 50);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtSexo
            // 
            txtSexo.Font = new Font("Segoe UI", 10.8F);
            txtSexo.FormattingEnabled = true;
            txtSexo.Items.AddRange(new object[] { "MASCULINO", "FEMENITO" });
            txtSexo.Location = new Point(41, 168);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(237, 33);
            txtSexo.TabIndex = 14;
            // 
            // FormPersonas
            // 
            BackColor = Color.White;
            ClientSize = new Size(1100, 619);
            Controls.Add(txtSexo);
            Controls.Add(txtDni);
            Controls.Add(txtNombres);
            Controls.Add(txtApellidos);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(cmbUbigeo);
            Controls.Add(dgvPersonas);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Name = "FormPersonas";
            Text = "Gestión de Personas";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox txtSexo;
    }
}
