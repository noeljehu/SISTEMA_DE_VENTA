namespace CapaPresentacion
{
    partial class FormProductos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblEstado;

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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();

            // FormProductos
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblEstado);
            this.Text = "Gestión de Productos";

            // Labels
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(20, 20);

            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Location = new System.Drawing.Point(20, 60);

            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Location = new System.Drawing.Point(20, 100);

            this.lblStock.Text = "Stock:";
            this.lblStock.Location = new System.Drawing.Point(20, 140);

            this.lblCategoria.Text = "Categoría:";
            this.lblCategoria.Location = new System.Drawing.Point(20, 180);

            this.lblEstado.Text = "Estado:";
            this.lblEstado.Location = new System.Drawing.Point(20, 220);

            // TextBoxes
            this.txtNombre.Location = new System.Drawing.Point(120, 20);
            this.txtDescripcion.Location = new System.Drawing.Point(120, 60);
            this.txtPrecio.Location = new System.Drawing.Point(120, 100);
            this.txtStock.Location = new System.Drawing.Point(120, 140);

            // ComboBox
            this.cmbCategoria.Location = new System.Drawing.Point(120, 180);

            // CheckBox
            this.chkEstado.Location = new System.Drawing.Point(120, 220);

            // Buttons
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Location = new System.Drawing.Point(20, 260);

            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Location = new System.Drawing.Point(120, 260);

            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(220, 260);

            // DataGridView
            this.dgvProductos.Location = new System.Drawing.Point(20, 300);
            this.dgvProductos.Size = new System.Drawing.Size(760, 130);
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
