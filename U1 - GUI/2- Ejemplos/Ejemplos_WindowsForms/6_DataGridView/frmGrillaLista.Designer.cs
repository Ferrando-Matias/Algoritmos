namespace _6_DataGridView
{
    partial class frmGrillaLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPrueba = new DataGridView();
            lblId = new Label();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            lblBaja = new Label();
            chkBaja = new CheckBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            chkPermitirEdicion = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvPrueba).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPrueba
            // 
            dgvPrueba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrueba.Location = new Point(87, 230);
            dgvPrueba.Margin = new Padding(4, 3, 4, 3);
            dgvPrueba.Name = "dgvPrueba";
            dgvPrueba.Size = new Size(516, 275);
            dgvPrueba.TabIndex = 0;
            dgvPrueba.CellContentClick += dgvPrueba_CellContentClick;
            dgvPrueba.RowEnter += dgvPrueba_RowEnter;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(9, 10);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(74, 24);
            lblId.TabIndex = 1;
            lblId.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(lblBaja);
            groupBox1.Controls.Add(chkBaja);
            groupBox1.Controls.Add(lblDNI);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(lblNombres);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 54);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(669, 128);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Seleccionados  ";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Century Gothic", 9F);
            btnEliminar.Location = new Point(551, 82);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 28);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Century Gothic", 9F);
            btnModificar.Location = new Point(551, 53);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 28);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Century Gothic", 9F);
            btnAgregar.Location = new Point(551, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 28);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblBaja
            // 
            lblBaja.AutoSize = true;
            lblBaja.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaja.ForeColor = Color.Red;
            lblBaja.Location = new Point(297, 100);
            lblBaja.Margin = new Padding(4, 0, 4, 0);
            lblBaja.Name = "lblBaja";
            lblBaja.Size = new Size(182, 19);
            lblBaja.TabIndex = 11;
            lblBaja.Text = "Persona dada de Baja";
            lblBaja.TextAlign = ContentAlignment.BottomLeft;
            // 
            // chkBaja
            // 
            chkBaja.AutoSize = true;
            chkBaja.Enabled = false;
            chkBaja.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBaja.Location = new Point(342, 72);
            chkBaja.Margin = new Padding(4, 3, 4, 3);
            chkBaja.Name = "chkBaja";
            chkBaja.Size = new Size(117, 21);
            chkBaja.TabIndex = 10;
            chkBaja.Text = "Dado de Baja";
            chkBaja.TextAlign = ContentAlignment.BottomCenter;
            chkBaja.TextImageRelation = TextImageRelation.TextAboveImage;
            chkBaja.UseVisualStyleBackColor = true;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(21, 72);
            lblDNI.Margin = new Padding(4, 0, 4, 0);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(31, 17);
            lblDNI.TabIndex = 9;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Enabled = false;
            txtDNI.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDNI.Location = new Point(93, 68);
            txtDNI.Margin = new Padding(4, 3, 4, 3);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(116, 23);
            txtDNI.TabIndex = 8;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombres.Location = new Point(299, 30);
            lblNombres.Margin = new Padding(4, 0, 4, 0);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(66, 17);
            lblNombres.TabIndex = 7;
            lblNombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Enabled = false;
            txtNombres.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombres.Location = new Point(383, 27);
            txtNombres.Margin = new Padding(4, 3, 4, 3);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(157, 23);
            txtNombres.TabIndex = 6;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(15, 30);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(61, 17);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(93, 27);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(177, 23);
            txtApellido.TabIndex = 4;
            // 
            // chkPermitirEdicion
            // 
            chkPermitirEdicion.AutoSize = true;
            chkPermitirEdicion.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPermitirEdicion.Location = new Point(251, 200);
            chkPermitirEdicion.Margin = new Padding(4, 3, 4, 3);
            chkPermitirEdicion.Name = "chkPermitirEdicion";
            chkPermitirEdicion.Size = new Size(202, 24);
            chkPermitirEdicion.TabIndex = 7;
            chkPermitirEdicion.Text = "Permitir Edicion en Grilla";
            chkPermitirEdicion.UseVisualStyleBackColor = true;
            chkPermitirEdicion.CheckedChanged += chkPermitirEdicion_CheckedChanged;
            // 
            // frmGrillaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 517);
            Controls.Add(chkPermitirEdicion);
            Controls.Add(groupBox1);
            Controls.Add(lblId);
            Controls.Add(dgvPrueba);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmGrillaLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manejo de DataGridView";
            Load += frmGrillaLista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrueba).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrueba;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.CheckBox chkPermitirEdicion;
        private System.Windows.Forms.Label lblBaja;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
    }
}
