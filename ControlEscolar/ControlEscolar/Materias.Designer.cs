namespace ControlEscolar
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.cmbMateriadespues = new System.Windows.Forms.ComboBox();
            this.cmbMateriaantes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtPractica = new System.Windows.Forms.TextBox();
            this.txtTeoria = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtgMaterias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMateriadespues
            // 
            this.cmbMateriadespues.FormattingEnabled = true;
            this.cmbMateriadespues.Location = new System.Drawing.Point(342, 116);
            this.cmbMateriadespues.Name = "cmbMateriadespues";
            this.cmbMateriadespues.Size = new System.Drawing.Size(201, 21);
            this.cmbMateriadespues.TabIndex = 47;
            // 
            // cmbMateriaantes
            // 
            this.cmbMateriaantes.FormattingEnabled = true;
            this.cmbMateriaantes.Location = new System.Drawing.Point(342, 46);
            this.cmbMateriaantes.Name = "cmbMateriaantes";
            this.cmbMateriaantes.Size = new System.Drawing.Size(201, 21);
            this.cmbMateriaantes.TabIndex = 46;
            this.cmbMateriaantes.SelectedIndexChanged += new System.EventHandler(this.cmbMateriaantes_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Materia Anterior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(339, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Materia que sigue";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(87, 12);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(242, 20);
            this.txtClave.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(617, 45);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 20);
            this.txtBuscar.TabIndex = 51;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(634, 307);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 38);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(493, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 38);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(634, 117);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 45);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Location = new System.Drawing.Point(634, 71);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNuevo.Size = new System.Drawing.Size(118, 39);
            this.btnNuevo.TabIndex = 52;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtPractica
            // 
            this.txtPractica.Location = new System.Drawing.Point(287, 84);
            this.txtPractica.Name = "txtPractica";
            this.txtPractica.Size = new System.Drawing.Size(42, 20);
            this.txtPractica.TabIndex = 45;
            // 
            // txtTeoria
            // 
            this.txtTeoria.Location = new System.Drawing.Point(87, 84);
            this.txtTeoria.Name = "txtTeoria";
            this.txtTeoria.Size = new System.Drawing.Size(43, 20);
            this.txtTeoria.TabIndex = 44;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 20);
            this.txtNombre.TabIndex = 43;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 54;
            this.lblNombre.Text = "Nombre";
            // 
            // dtgMaterias
            // 
            this.dtgMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMaterias.Location = new System.Drawing.Point(12, 168);
            this.dtgMaterias.Name = "dtgMaterias";
            this.dtgMaterias.Size = new System.Drawing.Size(740, 133);
            this.dtgMaterias.TabIndex = 53;
            this.dtgMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMaterias_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Teoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Horas de practica";
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(87, 117);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(242, 20);
            this.txtSemestre.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Semestre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(737, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 66;
            this.lblId.Text = "0";
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 354);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMateriadespues);
            this.Controls.Add(this.cmbMateriaantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtPractica);
            this.Controls.Add(this.txtTeoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dtgMaterias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Materias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMateriadespues;
        private System.Windows.Forms.ComboBox cmbMateriaantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtPractica;
        private System.Windows.Forms.TextBox txtTeoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgMaterias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblId;
    }
}