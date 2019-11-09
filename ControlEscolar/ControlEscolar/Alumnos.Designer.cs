namespace ControlEscolar
{
    partial class Alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtApmatero = new System.Windows.Forms.TextBox();
            this.txtAppaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblApmaterno = new System.Windows.Forms.Label();
            this.lblAppaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtgAlumnos = new System.Windows.Forms.DataGridView();
            this.txtnocontrol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(701, 33);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 20);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(815, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 24);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "0";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(701, 303);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 38);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(553, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 38);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(701, 106);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 45);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(701, 61);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(135, 39);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtApmatero
            // 
            this.txtApmatero.Location = new System.Drawing.Point(142, 90);
            this.txtApmatero.Name = "txtApmatero";
            this.txtApmatero.Size = new System.Drawing.Size(250, 20);
            this.txtApmatero.TabIndex = 4;
            // 
            // txtAppaterno
            // 
            this.txtAppaterno.Location = new System.Drawing.Point(142, 63);
            this.txtAppaterno.Name = "txtAppaterno";
            this.txtAppaterno.Size = new System.Drawing.Size(250, 20);
            this.txtAppaterno.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(408, 71);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(47, 16);
            this.lblContrasenia.TabIndex = 20;
            this.lblContrasenia.Text = "Email";
            // 
            // lblApmaterno
            // 
            this.lblApmaterno.AutoSize = true;
            this.lblApmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApmaterno.Location = new System.Drawing.Point(12, 93);
            this.lblApmaterno.Name = "lblApmaterno";
            this.lblApmaterno.Size = new System.Drawing.Size(126, 16);
            this.lblApmaterno.TabIndex = 19;
            this.lblApmaterno.Text = "Apellido Materno";
            // 
            // lblAppaterno
            // 
            this.lblAppaterno.AutoSize = true;
            this.lblAppaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppaterno.Location = new System.Drawing.Point(12, 67);
            this.lblAppaterno.Name = "lblAppaterno";
            this.lblAppaterno.Size = new System.Drawing.Size(124, 16);
            this.lblAppaterno.TabIndex = 18;
            this.lblAppaterno.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // dtgAlumnos
            // 
            this.dtgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnos.Location = new System.Drawing.Point(7, 157);
            this.dtgAlumnos.Name = "dtgAlumnos";
            this.dtgAlumnos.Size = new System.Drawing.Size(829, 133);
            this.dtgAlumnos.TabIndex = 16;
            this.dtgAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlumnos_CellContentClick);
            this.dtgAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlumnos_CellDoubleClick);
            // 
            // txtnocontrol
            // 
            this.txtnocontrol.Location = new System.Drawing.Point(142, 8);
            this.txtnocontrol.Name = "txtnocontrol";
            this.txtnocontrol.Size = new System.Drawing.Size(250, 20);
            this.txtnocontrol.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "No. control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Domicilio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "fecha de nacimiento";
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(500, 36);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(174, 20);
            this.txtdomicilio.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Sexo";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(500, 66);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(174, 20);
            this.txtemail.TabIndex = 7;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cmbSexo.Location = new System.Drawing.Point(500, 97);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(174, 21);
            this.cmbSexo.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(561, 10);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(113, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(191, 127);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(201, 21);
            this.cmbEstado.TabIndex = 9;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            this.cmbEstado.SelectionChangeCommitted += new System.EventHandler(this.cmbEstado_SelectionChangeCommitted);
            this.cmbEstado.StyleChanged += new System.EventHandler(this.cmbEstado_StyleChanged);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(500, 130);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(174, 21);
            this.cmbCiudad.TabIndex = 10;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 353);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnocontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtApmatero);
            this.Controls.Add(this.txtAppaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblApmaterno);
            this.Controls.Add(this.lblAppaterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtgAlumnos);
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtApmatero;
        private System.Windows.Forms.TextBox txtAppaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblApmaterno;
        private System.Windows.Forms.Label lblAppaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgAlumnos;
        private System.Windows.Forms.TextBox txtnocontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbCiudad;
    }
}