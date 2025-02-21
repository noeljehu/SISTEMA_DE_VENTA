namespace CapaPresentacion
{
    partial class FormProveedores
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
            txtNombre = new TextBox();
            txtRuc = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtTipoProveedor = new TextBox();
            chkEstado = new CheckBox();
            txtObservaciones = new TextBox();
            txtWeb = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvProveedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.8F);
            txtNombre.Location = new Point(38, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del proveedor";
            txtNombre.Size = new Size(225, 31);
            txtNombre.TabIndex = 0;
            // 
            // txtRuc
            // 
            txtRuc.Font = new Font("Segoe UI", 10.8F);
            txtRuc.Location = new Point(38, 75);
            txtRuc.Name = "txtRuc";
            txtRuc.PlaceholderText = "RUC (máx. 20 caracteres)";
            txtRuc.Size = new Size(225, 31);
            txtRuc.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10.8F);
            txtDireccion.Location = new Point(38, 112);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(225, 31);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10.8F);
            txtTelefono.Location = new Point(38, 149);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(225, 31);
            txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F);
            txtEmail.Location = new Point(38, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo electrónico";
            txtEmail.Size = new Size(225, 31);
            txtEmail.TabIndex = 4;
            // 
            // txtTipoProveedor
            // 
            txtTipoProveedor.Font = new Font("Segoe UI", 10.8F);
            txtTipoProveedor.Location = new Point(38, 223);
            txtTipoProveedor.Name = "txtTipoProveedor";
            txtTipoProveedor.PlaceholderText = "Tipo de proveedor";
            txtTipoProveedor.Size = new Size(225, 31);
            txtTipoProveedor.TabIndex = 5;
            // 
            // chkEstado
            // 
            chkEstado.Font = new Font("Segoe UI", 10.8F);
            chkEstado.Location = new Point(38, 260);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(104, 24);
            chkEstado.TabIndex = 6;
            chkEstado.Text = "Activo";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Segoe UI", 10.8F);
            txtObservaciones.Location = new Point(38, 290);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Observaciones";
            txtObservaciones.Size = new Size(225, 60);
            txtObservaciones.TabIndex = 7;
            // 
            // txtWeb
            // 
            txtWeb.Font = new Font("Segoe UI", 10.8F);
            txtWeb.Location = new Point(38, 356);
            txtWeb.Name = "txtWeb";
            txtWeb.PlaceholderText = "Página web";
            txtWeb.Size = new Size(225, 31);
            txtWeb.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(93, 176, 188);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.8F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(38, 393);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(225, 49);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(51, 194, 108);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10.8F);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(38, 448);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(225, 49);
            btnActualizar.TabIndex = 10;
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
            btnEliminar.Location = new Point(38, 503);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 49);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.ColumnHeadersHeight = 29;
            dgvProveedores.Location = new Point(296, 38);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(819, 514);
            dgvProveedores.TabIndex = 0;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 600);
            Controls.Add(txtNombre);
            Controls.Add(txtRuc);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtTipoProveedor);
            Controls.Add(chkEstado);
            Controls.Add(txtObservaciones);
            Controls.Add(txtWeb);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvProveedores);
            Name = "FormProveedores";
            Text = "Gestión de Proveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();



        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTipoProveedor;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvProveedores;
    }
}
