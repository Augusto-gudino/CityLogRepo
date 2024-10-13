namespace C1_UI
{
    partial class MenuPrincipal
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
            this.panel_barra_titulo = new System.Windows.Forms.Panel();
            this.menu_vertical_principal = new System.Windows.Forms.Panel();
            this.panel_contenedor_principal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_barra_titulo
            // 
            this.panel_barra_titulo.BackColor = System.Drawing.Color.DarkOrange;
            this.panel_barra_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra_titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_barra_titulo.Name = "panel_barra_titulo";
            this.panel_barra_titulo.Size = new System.Drawing.Size(1300, 38);
            this.panel_barra_titulo.TabIndex = 0;
            // 
            // menu_vertical_principal
            // 
            this.menu_vertical_principal.BackColor = System.Drawing.Color.BurlyWood;
            this.menu_vertical_principal.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_vertical_principal.Location = new System.Drawing.Point(0, 38);
            this.menu_vertical_principal.Name = "menu_vertical_principal";
            this.menu_vertical_principal.Size = new System.Drawing.Size(220, 612);
            this.menu_vertical_principal.TabIndex = 0;
            // 
            // panel_contenedor_principal
            // 
            this.panel_contenedor_principal.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel_contenedor_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor_principal.Location = new System.Drawing.Point(220, 38);
            this.panel_contenedor_principal.Name = "panel_contenedor_principal";
            this.panel_contenedor_principal.Size = new System.Drawing.Size(1080, 612);
            this.panel_contenedor_principal.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panel_contenedor_principal);
            this.Controls.Add(this.menu_vertical_principal);
            this.Controls.Add(this.panel_barra_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barra_titulo;
        private System.Windows.Forms.Panel menu_vertical_principal;
        private System.Windows.Forms.Panel panel_contenedor_principal;
    }
}