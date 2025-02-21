namespace CapaPresentacion
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUsuarios = new DataGridView();
            labelDNI = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            labelRol = new Label();
            labelActivo = new Label();
            txtDNI = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cbRol = new ComboBox();
            chkActivo = new CheckBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(284, 31);
            dgvUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(848, 512);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Segoe UI", 10.8F);
            labelDNI.Location = new Point(26, 31);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(47, 25);
            labelDNI.TabIndex = 1;
            labelDNI.Text = "DNI:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10.8F);
            labelUsername.Location = new Point(26, 161);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(95, 25);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10.8F);
            labelPassword.Location = new Point(26, 225);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(91, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Segoe UI", 10.8F);
            labelRol.Location = new Point(26, 95);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(41, 25);
            labelRol.TabIndex = 4;
            labelRol.Text = "Rol:";
            // 
            // labelActivo
            // 
            labelActivo.AutoSize = true;
            labelActivo.Font = new Font("Segoe UI", 10.8F);
            labelActivo.Location = new Point(26, 289);
            labelActivo.Name = "labelActivo";
            labelActivo.Size = new Size(70, 25);
            labelActivo.TabIndex = 5;
            labelActivo.Text = "Estado:";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 10.8F);
            txtDNI.Location = new Point(26, 60);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "DNI";
            txtDNI.Size = new Size(228, 31);
            txtDNI.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.8F);
            txtUsername.Location = new Point(26, 190);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(228, 31);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F);
            txtPassword.Location = new Point(26, 254);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(228, 31);
            txtPassword.TabIndex = 8;
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.Font = new Font("Segoe UI", 10.8F);
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(26, 124);
            cbRol.Margin = new Padding(3, 4, 3, 4);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(228, 33);
            cbRol.TabIndex = 9;
            // 
            // chkActivo
            // 
            chkActivo.Font = new Font("Segoe UI", 10.8F);
            chkActivo.Location = new Point(26, 318);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(114, 27);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(93, 176, 188);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.8F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(26, 353);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(228, 58);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(51, 194, 108);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10.8F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(26, 419);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(228, 58);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(206, 83, 99);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.8F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(26, 485);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(228, 58);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 569);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(chkActivo);
            Controls.Add(cbRol);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtDNI);
            Controls.Add(labelActivo);
            Controls.Add(labelRol);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelDNI);
            Controls.Add(dgvUsuarios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmUsuarios";
            Text = "o";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelActivo;
    }
}
