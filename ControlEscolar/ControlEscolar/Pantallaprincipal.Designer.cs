namespace ControlEscolar
{
    partial class Pantallaprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantallaprincipal));
            this.msMenuprincipal = new System.Windows.Forms.MenuStrip();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escuelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuprincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuprincipal
            // 
            this.msMenuprincipal.BackColor = System.Drawing.Color.SkyBlue;
            this.msMenuprincipal.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem});
            this.msMenuprincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuprincipal.Name = "msMenuprincipal";
            this.msMenuprincipal.Size = new System.Drawing.Size(645, 35);
            this.msMenuprincipal.TabIndex = 0;
            this.msMenuprincipal.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.escuelaToolStripMenuItem});
            this.catalogosToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("catalogosToolStripMenuItem.Image")));
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(160, 31);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnosToolStripMenuItem.Image")));
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Image = global::ControlEscolar.Properties.Resources.new_add_user_16734;
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("materiasToolStripMenuItem.Image")));
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // escuelaToolStripMenuItem
            // 
            this.escuelaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("escuelaToolStripMenuItem.Image")));
            this.escuelaToolStripMenuItem.Name = "escuelaToolStripMenuItem";
            this.escuelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escuelaToolStripMenuItem.Text = "Escuela";
            this.escuelaToolStripMenuItem.Click += new System.EventHandler(this.escuelaToolStripMenuItem_Click);
            // 
            // Pantallaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(645, 282);
            this.Controls.Add(this.msMenuprincipal);
            this.MainMenuStrip = this.msMenuprincipal;
            this.Name = "Pantallaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantallaprincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenuprincipal.ResumeLayout(false);
            this.msMenuprincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuprincipal;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escuelaToolStripMenuItem;
    }
}