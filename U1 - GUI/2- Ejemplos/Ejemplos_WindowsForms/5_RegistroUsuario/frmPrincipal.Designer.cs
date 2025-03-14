namespace _5_RegistroUsuario
{
    partial class frmPrincipal
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            txtApellido = new TextBox();
            cmbProvincias = new ComboBox();
            cmbLocalidades = new ComboBox();
            lnkTerminos = new LinkLabel();
            chkTerminos = new CheckBox();
            mskTelefono = new MaskedTextBox();
            grpGeneros = new GroupBox();
            rdbOtro = new RadioButton();
            rdbMujer = new RadioButton();
            rdbHombre = new RadioButton();
            grpGeneros.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.Control;
            lblNombre.Cursor = Cursors.Help;
            lblNombre.Location = new Point(14, 27);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre *";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(14, 72);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(14, 115);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 23);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(116, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(20, 376);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(194, 27);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(94, 68);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(116, 23);
            txtApellido.TabIndex = 4;
            // 
            // cmbProvincias
            // 
            cmbProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincias.FlatStyle = FlatStyle.Popup;
            cmbProvincias.FormattingEnabled = true;
            cmbProvincias.Location = new Point(20, 285);
            cmbProvincias.Margin = new Padding(4, 3, 4, 3);
            cmbProvincias.Name = "cmbProvincias";
            cmbProvincias.Size = new Size(193, 23);
            cmbProvincias.TabIndex = 7;
            cmbProvincias.SelectedIndexChanged += cmbProvincias_SelectedIndexChanged;
            // 
            // cmbLocalidades
            // 
            cmbLocalidades.FormattingEnabled = true;
            cmbLocalidades.Location = new Point(20, 328);
            cmbLocalidades.Margin = new Padding(4, 3, 4, 3);
            cmbLocalidades.Name = "cmbLocalidades";
            cmbLocalidades.Size = new Size(193, 23);
            cmbLocalidades.TabIndex = 8;
            // 
            // lnkTerminos
            // 
            lnkTerminos.AutoSize = true;
            lnkTerminos.Location = new Point(35, 422);
            lnkTerminos.Margin = new Padding(4, 0, 4, 0);
            lnkTerminos.Name = "lnkTerminos";
            lnkTerminos.Size = new Size(134, 15);
            lnkTerminos.TabIndex = 9;
            lnkTerminos.TabStop = true;
            lnkTerminos.Text = "Terminos y Condiciones";
            lnkTerminos.LinkClicked += lnkTerminos_LinkClicked;
            // 
            // chkTerminos
            // 
            chkTerminos.AutoSize = true;
            chkTerminos.Enabled = false;
            chkTerminos.Location = new Point(181, 422);
            chkTerminos.Margin = new Padding(4, 3, 4, 3);
            chkTerminos.Name = "chkTerminos";
            chkTerminos.Size = new Size(15, 14);
            chkTerminos.TabIndex = 10;
            chkTerminos.UseVisualStyleBackColor = true;
            // 
            // mskTelefono
            // 
            mskTelefono.BeepOnError = true;
            mskTelefono.Location = new Point(94, 112);
            mskTelefono.Margin = new Padding(4, 3, 4, 3);
            mskTelefono.Mask = "(9999)00-0000-0000";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(116, 23);
            mskTelefono.TabIndex = 11;
            // 
            // grpGeneros
            // 
            grpGeneros.Controls.Add(rdbOtro);
            grpGeneros.Controls.Add(rdbMujer);
            grpGeneros.Controls.Add(rdbHombre);
            grpGeneros.Location = new Point(15, 152);
            grpGeneros.Margin = new Padding(4, 3, 4, 3);
            grpGeneros.Name = "grpGeneros";
            grpGeneros.Padding = new Padding(4, 3, 4, 3);
            grpGeneros.Size = new Size(196, 106);
            grpGeneros.TabIndex = 12;
            grpGeneros.TabStop = false;
            grpGeneros.Text = "Seleccione un Genero";
            // 
            // rdbOtro
            // 
            rdbOtro.AutoSize = true;
            rdbOtro.Location = new Point(23, 75);
            rdbOtro.Margin = new Padding(4, 3, 4, 3);
            rdbOtro.Name = "rdbOtro";
            rdbOtro.Size = new Size(49, 19);
            rdbOtro.TabIndex = 2;
            rdbOtro.TabStop = true;
            rdbOtro.Text = "Otro";
            rdbOtro.UseVisualStyleBackColor = true;
            // 
            // rdbMujer
            // 
            rdbMujer.AutoSize = true;
            rdbMujer.Location = new Point(23, 48);
            rdbMujer.Margin = new Padding(4, 3, 4, 3);
            rdbMujer.Name = "rdbMujer";
            rdbMujer.Size = new Size(56, 19);
            rdbMujer.TabIndex = 1;
            rdbMujer.TabStop = true;
            rdbMujer.Text = "Mujer";
            rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbHombre
            // 
            rdbHombre.AutoSize = true;
            rdbHombre.Location = new Point(23, 22);
            rdbHombre.Margin = new Padding(4, 3, 4, 3);
            rdbHombre.Name = "rdbHombre";
            rdbHombre.Size = new Size(69, 19);
            rdbHombre.TabIndex = 0;
            rdbHombre.Text = "Hombre";
            rdbHombre.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 448);
            Controls.Add(grpGeneros);
            Controls.Add(mskTelefono);
            Controls.Add(chkTerminos);
            Controls.Add(lnkTerminos);
            Controls.Add(cmbLocalidades);
            Controls.Add(cmbProvincias);
            Controls.Add(txtApellido);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Titulo del Formulario";
            Load += frmPrincipal_Load;
            grpGeneros.ResumeLayout(false);
            grpGeneros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.LinkLabel lnkTerminos;
        private System.Windows.Forms.CheckBox chkTerminos;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.GroupBox grpGeneros;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
    }
}
