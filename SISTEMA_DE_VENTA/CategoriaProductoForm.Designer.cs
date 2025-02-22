namespace UI
{
    partial class CategoriaProductoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCategorias;

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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(20, 50);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(74, 23);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(100, 50);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(200, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(20, 90);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(100, 90);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(200, 90);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // dgvCategorias
            // 
            dgvCategorias.Location = new Point(20, 130);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(540, 180);
            dgvCategorias.TabIndex = 7;
            dgvCategorias.CellClick += dgvCategorias_CellClick;

            // 
            // CategoriaProductoForm
            // 
            ClientSize = new Size(600, 350);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvCategorias);
            Name = "CategoriaProductoForm";
            Text = "Gestión de Categorías";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}