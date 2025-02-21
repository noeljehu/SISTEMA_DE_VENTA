namespace CapaPresentacion
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

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
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            btncancelar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(417, 83);
            lblUsername.Margin = new Padding(5, 0, 5, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(417, 159);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(248, 248, 248);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10.8F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(417, 115);
            txtUsername.Margin = new Padding(5, 4, 5, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 248, 248);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.8F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(417, 189);
            txtPassword.Margin = new Padding(5, 4, 5, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(315, 31);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(37, 153, 252);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(417, 275);
            btnLogin.Margin = new Padding(5, 4, 5, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(315, 47);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(488, 39);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 5;
            label1.Text = "INICIAR SESIÓN";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = Color.FromArgb(206, 83, 99);
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI", 12F);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(417, 330);
            btncancelar.Margin = new Padding(5, 4, 5, 4);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(315, 47);
            btncancelar.TabIndex = 9;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 153, 252);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 403);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.collage_cajero;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(30, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 301);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 343);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(294, 38);
            label2.TabIndex = 11;
            label2.Text = "SISTEMA DE VENTAS";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 403);
            Controls.Add(panel1);
            Controls.Add(btncancelar);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btncancelar;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
    }
}
