namespace ControlEscolar
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAppaterno = new System.Windows.Forms.Label();
            this.lblApmaterno = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAppaterno = new System.Windows.Forms.TextBox();
            this.txtApmatero = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Location = new System.Drawing.Point(7, 153);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.Size = new System.Drawing.Size(548, 132);
            this.dtgUsuario.TabIndex = 0;
            this.dtgUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_CellDoubleClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAppaterno
            // 
            this.lblAppaterno.AutoSize = true;
            this.lblAppaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppaterno.Location = new System.Drawing.Point(12, 46);
            this.lblAppaterno.Name = "lblAppaterno";
            this.lblAppaterno.Size = new System.Drawing.Size(124, 16);
            this.lblAppaterno.TabIndex = 2;
            this.lblAppaterno.Text = "Apellido Paterno";
            // 
            // lblApmaterno
            // 
            this.lblApmaterno.AutoSize = true;
            this.lblApmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApmaterno.Location = new System.Drawing.Point(12, 78);
            this.lblApmaterno.Name = "lblApmaterno";
            this.lblApmaterno.Size = new System.Drawing.Size(126, 16);
            this.lblApmaterno.TabIndex = 3;
            this.lblApmaterno.Text = "Apellido Materno";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(12, 110);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(87, 16);
            this.lblContrasenia.TabIndex = 4;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtAppaterno
            // 
            this.txtAppaterno.Location = new System.Drawing.Point(139, 39);
            this.txtAppaterno.Name = "txtAppaterno";
            this.txtAppaterno.Size = new System.Drawing.Size(253, 20);
            this.txtAppaterno.TabIndex = 6;
            // 
            // txtApmatero
            // 
            this.txtApmatero.Location = new System.Drawing.Point(139, 75);
            this.txtApmatero.Name = "txtApmatero";
            this.txtApmatero.Size = new System.Drawing.Size(253, 20);
            this.txtApmatero.TabIndex = 7;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(139, 110);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(253, 20);
            this.txtContrasenia.TabIndex = 8;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(437, 62);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(118, 33);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(437, 101);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 29);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(331, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(449, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 36);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(534, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 24);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "0";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(420, 36);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 20);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buscar";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtApmatero);
            this.Controls.Add(this.txtAppaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblApmaterno);
            this.Controls.Add(this.lblAppaterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtgUsuario);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAppaterno;
        private System.Windows.Forms.Label lblApmaterno;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAppaterno;
        private System.Windows.Forms.TextBox txtApmatero;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
    }
}

