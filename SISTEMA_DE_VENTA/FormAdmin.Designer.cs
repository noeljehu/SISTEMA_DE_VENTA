using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormAdmin : Form
    {
        private Panel panelMenu;
        private Panel panelContenedor;
        private Label labelTitulo;


        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnPersona = new FontAwesome.Sharp.IconButton();
            btnProveedor = new FontAwesome.Sharp.IconButton();
            btnTrabajador = new FontAwesome.Sharp.IconButton();
            btnProducto = new FontAwesome.Sharp.IconButton();
            btnUsuario = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelContenedor = new Panel();
            labelTitulo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 153, 252);
            panelMenu.Controls.Add(btnPersona);
            panelMenu.Controls.Add(btnProveedor);
            panelMenu.Controls.Add(btnTrabajador);
            panelMenu.Controls.Add(btnProducto);
            panelMenu.Controls.Add(btnUsuario);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(240, 642);
            panelMenu.TabIndex = 0;
            // 
            // btnPersona
            // 
            btnPersona.Dock = DockStyle.Top;
            btnPersona.FlatStyle = FlatStyle.Flat;
            btnPersona.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPersona.ForeColor = Color.White;
            btnPersona.IconChar = FontAwesome.Sharp.IconChar.Male;
            btnPersona.IconColor = Color.White;
            btnPersona.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPersona.Location = new Point(0, 240);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(240, 60);
            btnPersona.TabIndex = 10;
            btnPersona.Text = "Persona";
            btnPersona.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Dock = DockStyle.Top;
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProveedor.ForeColor = Color.White;
            btnProveedor.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            btnProveedor.IconColor = Color.White;
            btnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedor.Location = new Point(0, 180);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(240, 60);
            btnProveedor.TabIndex = 9;
            btnProveedor.Text = "Proveedor";
            btnProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnTrabajador
            // 
            btnTrabajador.Dock = DockStyle.Top;
            btnTrabajador.FlatStyle = FlatStyle.Flat;
            btnTrabajador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrabajador.ForeColor = Color.White;
            btnTrabajador.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            btnTrabajador.IconColor = Color.White;
            btnTrabajador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrabajador.Location = new Point(0, 120);
            btnTrabajador.Name = "btnTrabajador";
            btnTrabajador.Size = new Size(240, 60);
            btnTrabajador.TabIndex = 8;
            btnTrabajador.Text = "Trabajador";
            btnTrabajador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrabajador.UseVisualStyleBackColor = true;
            btnTrabajador.Click += btnTrabajador_Click;
            // 
            // btnProducto
            // 
            btnProducto.Dock = DockStyle.Top;
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducto.ForeColor = Color.White;
            btnProducto.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            btnProducto.IconColor = Color.White;
            btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProducto.Location = new Point(0, 60);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(240, 60);
            btnProducto.TabIndex = 7;
            btnProducto.Text = "Producto";
            btnProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnUsuario.IconColor = Color.White;
            btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuario.Location = new Point(0, 0);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(240, 60);
            btnUsuario.TabIndex = 6;
            btnUsuario.Text = "Usuario";
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1056, 22);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(234, 239, 243);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(240, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1015, 642);
            panelContenedor.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial", 16F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(45, 22);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(384, 32);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Dashboard - Administración";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 153, 252);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1255, 72);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelContenedor);
            panel2.Controls.Add(panelMenu);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(1255, 642);
            panel2.TabIndex = 4;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // FormAdmin
            // 
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1255, 714);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAdmin";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        public Panel GetPanelContenedor() => panelContenedor;
        public Button GetBtnTrabajador() => btnTrabajador;
        public Button GetBtnProducto() => btnProducto;
        public Button GetBtnUsuario() => btnUsuario;
        //public Button GetBtnPersona() => btnPersona;

        private Label label1;
        private Button Provvedor;
        private Panel panel1;
        private Panel panel2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        //private FontAwesome.Sharp.IconButton btnPersona;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnProveedor;
        private FontAwesome.Sharp.IconButton btnTrabajador;
        private FontAwesome.Sharp.IconButton btnProducto;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton btnPersona;
    }

}
