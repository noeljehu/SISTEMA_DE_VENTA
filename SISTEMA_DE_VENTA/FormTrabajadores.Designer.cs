namespace CapaPresentacion
{
    partial class FormTrabajadores
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaContratacion;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.DataGridView dataGridViewTrabajadores;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;

        private void InitializeComponent()
        {
            lblDNI = new Label();
            lblCargo = new Label();
            lblSalario = new Label();
            lblFechaContratacion = new Label();
            lblEstado = new Label();
            txtDNI = new TextBox();
            txtCargo = new TextBox();
            txtSalario = new TextBox();
            dateTimePickerFechaContratacion = new DateTimePicker();
            chkEstado = new CheckBox();
            dataGridViewTrabajadores = new DataGridView();
            btnAgregar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrabajadores).BeginInit();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.Font = new Font("Segoe UI", 10.8F);
            lblDNI.Location = new Point(38, 57);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(100, 23);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI:";
            // 
            // lblCargo
            // 
            lblCargo.Font = new Font("Segoe UI", 10.8F);
            lblCargo.Location = new Point(38, 94);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(100, 31);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo:";
            // 
            // lblSalario
            // 
            lblSalario.Font = new Font("Segoe UI", 10.8F);
            lblSalario.Location = new Point(38, 131);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(100, 23);
            lblSalario.TabIndex = 4;
            lblSalario.Text = "Salario:";
            // 
            // lblFechaContratacion
            // 
            lblFechaContratacion.Font = new Font("Segoe UI", 10.8F);
            lblFechaContratacion.Location = new Point(38, 170);
            lblFechaContratacion.Name = "lblFechaContratacion";
            lblFechaContratacion.Size = new Size(132, 50);
            lblFechaContratacion.TabIndex = 6;
            lblFechaContratacion.Text = "Fecha de Contratación:";
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 10.8F);
            lblEstado.Location = new Point(38, 236);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(100, 23);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 10.8F);
            txtDNI.Location = new Point(176, 57);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(252, 31);
            txtDNI.TabIndex = 1;
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI", 10.8F);
            txtCargo.Location = new Point(176, 94);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(252, 31);
            txtCargo.TabIndex = 3;
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Segoe UI", 10.8F);
            txtSalario.Location = new Point(176, 131);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(252, 31);
            txtSalario.TabIndex = 5;
            // 
            // dateTimePickerFechaContratacion
            // 
            dateTimePickerFechaContratacion.Font = new Font("Segoe UI", 10.8F);
            dateTimePickerFechaContratacion.ImeMode = ImeMode.NoControl;
            dateTimePickerFechaContratacion.Location = new Point(176, 189);
            dateTimePickerFechaContratacion.Name = "dateTimePickerFechaContratacion";
            dateTimePickerFechaContratacion.Size = new Size(252, 31);
            dateTimePickerFechaContratacion.TabIndex = 7;
            // 
            // chkEstado
            // 
            chkEstado.Font = new Font("Segoe UI", 10.8F);
            chkEstado.Location = new Point(176, 235);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(104, 24);
            chkEstado.TabIndex = 9;
            chkEstado.Text = "Activo";
            // 
            // dataGridViewTrabajadores
            // 
            dataGridViewTrabajadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTrabajadores.BackgroundColor = Color.White;
            dataGridViewTrabajadores.ColumnHeadersHeight = 29;
            dataGridViewTrabajadores.Location = new Point(455, 57);
            dataGridViewTrabajadores.Name = "dataGridViewTrabajadores";
            dataGridViewTrabajadores.RowHeadersWidth = 51;
            dataGridViewTrabajadores.Size = new Size(788, 529);
            dataGridViewTrabajadores.TabIndex = 10;
            dataGridViewTrabajadores.SelectionChanged += dataGridViewTrabajadores_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(93, 176, 188);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.8F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(38, 288);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(242, 58);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(51, 194, 108);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10.8F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(38, 352);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(242, 58);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // FormTrabajadores
            // 
            BackColor = Color.White;
            ClientSize = new Size(1307, 655);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(lblCargo);
            Controls.Add(txtCargo);
            Controls.Add(lblSalario);
            Controls.Add(txtSalario);
            Controls.Add(lblFechaContratacion);
            Controls.Add(dateTimePickerFechaContratacion);
            Controls.Add(lblEstado);
            Controls.Add(chkEstado);
            Controls.Add(dataGridViewTrabajadores);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Font = new Font("Segoe UI", 10.8F);
            Name = "FormTrabajadores";
            Text = "Gestión de Trabajadores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrabajadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}