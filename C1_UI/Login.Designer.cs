namespace C1_UI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnCancelarLogin = new System.Windows.Forms.Button();
            this.btnIngresarLogin = new System.Windows.Forms.Button();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.PictureBoxLoginLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBoxLogin.Controls.Add(this.btnCancelarLogin);
            this.groupBoxLogin.Controls.Add(this.btnIngresarLogin);
            this.groupBoxLogin.Controls.Add(this.txt_login);
            this.groupBoxLogin.Controls.Add(this.labelContrasena);
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxLogin.Location = new System.Drawing.Point(65, 174);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Size = new System.Drawing.Size(507, 256);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Bienvenido";
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarLogin.Location = new System.Drawing.Point(159, 189);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(162, 48);
            this.btnCancelarLogin.TabIndex = 3;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = true;
            this.btnCancelarLogin.Click += new System.EventHandler(this.btnCancelarLogin_Click);
            // 
            // btnIngresarLogin
            // 
            this.btnIngresarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarLogin.Location = new System.Drawing.Point(159, 120);
            this.btnIngresarLogin.Name = "btnIngresarLogin";
            this.btnIngresarLogin.Size = new System.Drawing.Size(162, 48);
            this.btnIngresarLogin.TabIndex = 2;
            this.btnIngresarLogin.Text = "Ingresar";
            this.btnIngresarLogin.UseVisualStyleBackColor = true;
            this.btnIngresarLogin.Click += new System.EventHandler(this.btnIngresarLogin_Click);
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(159, 79);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(162, 26);
            this.txt_login.TabIndex = 1;
            this.txt_login.UseSystemPasswordChar = true;
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(144, 45);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(189, 20);
            this.labelContrasena.TabIndex = 0;
            this.labelContrasena.Text = "Ingrese su contraseña";
            // 
            // PictureBoxLoginLogo
            // 
            this.PictureBoxLoginLogo.BackColor = System.Drawing.Color.SandyBrown;
            this.PictureBoxLoginLogo.Image = global::C1_UI.Properties.Resources.LogoCityLog_Photoroom1;
            this.PictureBoxLoginLogo.Location = new System.Drawing.Point(196, 12);
            this.PictureBoxLoginLogo.Name = "PictureBoxLoginLogo";
            this.PictureBoxLoginLogo.Size = new System.Drawing.Size(229, 155);
            this.PictureBoxLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLoginLogo.TabIndex = 1;
            this.PictureBoxLoginLogo.TabStop = false;
            this.PictureBoxLoginLogo.Click += new System.EventHandler(this.PictureBoxLoginLogo_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(640, 443);
            this.Controls.Add(this.PictureBoxLoginLogo);
            this.Controls.Add(this.groupBoxLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLoginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Button btnCancelarLogin;
        private System.Windows.Forms.Button btnIngresarLogin;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.PictureBox PictureBoxLoginLogo;
    }
}

