namespace ControlEscolar
{
    partial class Profesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesores));
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnocontrol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dtgProfesores = new System.Windows.Forms.DataGridView();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMas = new System.Windows.Forms.Button();
            this.gpbEstudios = new System.Windows.Forms.GroupBox();
            this.lblds = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtEstudio = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtgEstudios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesores)).BeginInit();
            this.gpbEstudios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(500, 140);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(174, 21);
            this.cmbCiudad.TabIndex = 51;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(191, 140);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(201, 21);
            this.cmbEstado.TabIndex = 50;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Ciudad";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(500, 20);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(174, 20);
            this.dtpFecha.TabIndex = 46;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(500, 76);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(174, 20);
            this.txtTitulo.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Numero de Cedula";
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(500, 46);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(174, 20);
            this.txtdomicilio.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "fechanacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Domicilio";
            // 
            // txtnocontrol
            // 
            this.txtnocontrol.Location = new System.Drawing.Point(103, 18);
            this.txtnocontrol.Name = "txtnocontrol";
            this.txtnocontrol.Size = new System.Drawing.Size(289, 20);
            this.txtnocontrol.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "No. control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(701, 43);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 20);
            this.txtBuscar.TabIndex = 55;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(815, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 24);
            this.lblId.TabIndex = 62;
            this.lblId.Text = "0";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(702, 306);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 38);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(553, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 38);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(701, 116);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 45);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(701, 71);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(135, 39);
            this.btnNuevo.TabIndex = 56;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtApmatero
            // 
            this.txtApmatero.Location = new System.Drawing.Point(103, 100);
            this.txtApmatero.Name = "txtApmatero";
            this.txtApmatero.Size = new System.Drawing.Size(289, 20);
            this.txtApmatero.TabIndex = 45;
            // 
            // txtAppaterno
            // 
            this.txtAppaterno.Location = new System.Drawing.Point(103, 73);
            this.txtAppaterno.Name = "txtAppaterno";
            this.txtAppaterno.Size = new System.Drawing.Size(289, 20);
            this.txtAppaterno.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 20);
            this.txtNombre.TabIndex = 43;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(408, 81);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(33, 13);
            this.lblContrasenia.TabIndex = 61;
            this.lblContrasenia.Text = "Titulo";
            // 
            // lblApmaterno
            // 
            this.lblApmaterno.AutoSize = true;
            this.lblApmaterno.Location = new System.Drawing.Point(12, 103);
            this.lblApmaterno.Name = "lblApmaterno";
            this.lblApmaterno.Size = new System.Drawing.Size(86, 13);
            this.lblApmaterno.TabIndex = 60;
            this.lblApmaterno.Text = "Apellido Materno";
            // 
            // lblAppaterno
            // 
            this.lblAppaterno.AutoSize = true;
            this.lblAppaterno.Location = new System.Drawing.Point(12, 77);
            this.lblAppaterno.Name = "lblAppaterno";
            this.lblAppaterno.Size = new System.Drawing.Size(84, 13);
            this.lblAppaterno.TabIndex = 59;
            this.lblAppaterno.Text = "Apellido Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 58;
            this.lblNombre.Text = "Nombre";
            // 
            // dtgProfesores
            // 
            this.dtgProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfesores.Location = new System.Drawing.Point(7, 197);
            this.dtgProfesores.Name = "dtgProfesores";
            this.dtgProfesores.Size = new System.Drawing.Size(829, 103);
            this.dtgProfesores.TabIndex = 57;
            this.dtgProfesores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProfesores_CellDoubleClick);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(500, 107);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(174, 20);
            this.txtCedula.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Estudios";
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.Lime;
            this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(500, 167);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(336, 24);
            this.btnMas.TabIndex = 74;
            this.btnMas.Text = "VER O AGREGAR ESTUDIOS";
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // gpbEstudios
            // 
            this.gpbEstudios.Controls.Add(this.lblds);
            this.gpbEstudios.Controls.Add(this.btnCargar);
            this.gpbEstudios.Controls.Add(this.label10);
            this.gpbEstudios.Controls.Add(this.label9);
            this.gpbEstudios.Controls.Add(this.btnCancel);
            this.gpbEstudios.Controls.Add(this.btnDelete);
            this.gpbEstudios.Controls.Add(this.txtDocumento);
            this.gpbEstudios.Controls.Add(this.txtEstudio);
            this.gpbEstudios.Controls.Add(this.btnSave);
            this.gpbEstudios.Controls.Add(this.dtgEstudios);
            this.gpbEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEstudios.Location = new System.Drawing.Point(74, 53);
            this.gpbEstudios.Name = "gpbEstudios";
            this.gpbEstudios.Size = new System.Drawing.Size(600, 177);
            this.gpbEstudios.TabIndex = 77;
            this.gpbEstudios.TabStop = false;
            this.gpbEstudios.Text = "ESTUDIOS";
            this.gpbEstudios.Enter += new System.EventHandler(this.gpbEstudios_Enter);
            // 
            // lblds
            // 
            this.lblds.AutoSize = true;
            this.lblds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblds.Location = new System.Drawing.Point(559, 13);
            this.lblds.Name = "lblds";
            this.lblds.Size = new System.Drawing.Size(21, 24);
            this.lblds.TabIndex = 63;
            this.lblds.Text = "0";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(539, 114);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(41, 32);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "...";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Cargar Documento (PDF)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Estudio";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(291, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(163, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(423, 87);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(157, 21);
            this.txtDocumento.TabIndex = 3;
            // 
            // txtEstudio
            // 
            this.txtEstudio.Location = new System.Drawing.Point(425, 40);
            this.txtEstudio.Name = "txtEstudio";
            this.txtEstudio.Size = new System.Drawing.Size(155, 21);
            this.txtEstudio.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(29, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtgEstudios
            // 
            this.dtgEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudios.Location = new System.Drawing.Point(3, 16);
            this.dtgEstudios.Name = "dtgEstudios";
            this.dtgEstudios.Size = new System.Drawing.Size(416, 108);
            this.dtgEstudios.TabIndex = 0;
            this.dtgEstudios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEstudios_CellContentClick);
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 363);
            this.Controls.Add(this.gpbEstudios);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtTitulo);
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
            this.Controls.Add(this.dtgProfesores);
            this.Name = "Profesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.Profesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesores)).EndInit();
            this.gpbEstudios.ResumeLayout(false);
            this.gpbEstudios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnocontrol;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridView dtgProfesores;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.GroupBox gpbEstudios;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtEstudio;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtgEstudios;
        private System.Windows.Forms.Label lblds;
    }
}