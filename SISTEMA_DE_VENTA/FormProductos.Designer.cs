namespace CapaPresentacion
{
    partial class FormProductos
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNombre, lblDescripcion, lblPrecio, lblStock, lblBuscarNombre;
        private TextBox txtNombre, txtDescripcion, txtPrecio, txtStock, txtBuscarNombre;
        private Button btnAgregar, btnActualizar, btnHabilitar, btnDeshabilitar, btnBuscarNombre;
        private DataGridView dgvProductos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código del Diseñador
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            lblBuscarNombre = new Label();
            txtBuscarNombre = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnHabilitar = new Button();
            btnDeshabilitar = new Button();
            btnBuscarNombre = new Button();
            dgvProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 10.8F);
            lblNombre.Location = new Point(27, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(97, 28);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.8F);
            txtNombre.Location = new Point(142, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 31);
            txtNombre.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 10.8F);
            lblDescripcion.Location = new Point(27, 65);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(109, 23);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10.8F);
            txtDescripcion.Location = new Point(142, 62);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(200, 31);
            txtDescripcion.TabIndex = 3;
            // 
            // lblPrecio
            // 
            lblPrecio.Font = new Font("Segoe UI", 10.8F);
            lblPrecio.Location = new Point(27, 102);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(80, 23);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 10.8F);
            txtPrecio.Location = new Point(142, 99);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 31);
            txtPrecio.TabIndex = 5;
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Segoe UI", 10.8F);
            lblStock.Location = new Point(27, 139);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(80, 23);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 10.8F);
            txtStock.Location = new Point(142, 136);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 31);
            txtStock.TabIndex = 7;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.Font = new Font("Segoe UI", 10.8F);
            lblBuscarNombre.Location = new Point(367, 29);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(100, 23);
            lblBuscarNombre.TabIndex = 17;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Font = new Font("Segoe UI", 10.8F);
            txtBuscarNombre.Location = new Point(473, 25);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(288, 31);
            txtBuscarNombre.TabIndex = 18;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(93, 176, 188);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10.8F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(27, 202);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(215, 41);
            btnAgregar.TabIndex = 10;
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
            btnActualizar.Location = new Point(27, 249);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(215, 41);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnHabilitar
            // 
            btnHabilitar.BackColor = Color.LightCoral;
            btnHabilitar.FlatStyle = FlatStyle.Flat;
            btnHabilitar.Font = new Font("Segoe UI", 10.8F);
            btnHabilitar.ForeColor = Color.White;
            btnHabilitar.Location = new Point(27, 296);
            btnHabilitar.Name = "btnHabilitar";
            btnHabilitar.Size = new Size(215, 41);
            btnHabilitar.TabIndex = 12;
            btnHabilitar.Text = "Habilitar";
            btnHabilitar.UseVisualStyleBackColor = false;
            btnHabilitar.Click += btnHabilitar_Click_1;
            // 
            // btnDeshabilitar
            // 
            btnDeshabilitar.BackColor = Color.Goldenrod;
            btnDeshabilitar.FlatStyle = FlatStyle.Flat;
            btnDeshabilitar.Font = new Font("Segoe UI", 10.8F);
            btnDeshabilitar.ForeColor = Color.White;
            btnDeshabilitar.Location = new Point(27, 343);
            btnDeshabilitar.Name = "btnDeshabilitar";
            btnDeshabilitar.Size = new Size(215, 41);
            btnDeshabilitar.TabIndex = 13;
            btnDeshabilitar.Text = "Deshabilitar";
            btnDeshabilitar.UseVisualStyleBackColor = false;
            btnDeshabilitar.Click += btnDeshabilitar_Click_1;
            // 
            // btnBuscarNombre
            // 
            btnBuscarNombre.BackColor = Color.Silver;
            btnBuscarNombre.FlatStyle = FlatStyle.Flat;
            btnBuscarNombre.Font = new Font("Segoe UI", 10.8F);
            btnBuscarNombre.Location = new Point(767, 25);
            btnBuscarNombre.Name = "btnBuscarNombre";
            btnBuscarNombre.Size = new Size(161, 31);
            btnBuscarNombre.TabIndex = 19;
            btnBuscarNombre.Text = "Buscar";
            btnBuscarNombre.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeight = 29;
            dgvProductos.Location = new Point(368, 73);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(669, 387);
            dgvProductos.TabIndex = 20;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // FormProductos
            // 
            BackColor = Color.White;
            ClientSize = new Size(1060, 479);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblStock);
            Controls.Add(txtStock);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnHabilitar);
            Controls.Add(btnDeshabilitar);
            Controls.Add(lblBuscarNombre);
            Controls.Add(txtBuscarNombre);
            Controls.Add(btnBuscarNombre);
            Controls.Add(dgvProductos);
            Name = "FormProductos";
            Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
