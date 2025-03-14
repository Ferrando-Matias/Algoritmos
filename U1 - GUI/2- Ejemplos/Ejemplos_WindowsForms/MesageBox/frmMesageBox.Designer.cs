namespace Ejemplos_WindowsForms
{
    partial class frmMesageBox
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAnularReintentarOmitir = new Button();
            btnReintentarCancelar = new Button();
            btnSiNoCancelar = new Button();
            btnSiNo = new Button();
            btnAceptarCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 23);
            label1.TabIndex = 14;
            label1.Text = "Cantidad y tipo de botones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnularReintentarOmitir
            // 
            btnAnularReintentarOmitir.Location = new Point(14, 223);
            btnAnularReintentarOmitir.Margin = new Padding(4, 3, 4, 3);
            btnAnularReintentarOmitir.Name = "btnAnularReintentarOmitir";
            btnAnularReintentarOmitir.Size = new Size(270, 27);
            btnAnularReintentarOmitir.TabIndex = 13;
            btnAnularReintentarOmitir.Text = "ANULAR / REINTENTAR / OMITIR";
            btnAnularReintentarOmitir.UseVisualStyleBackColor = true;
            btnAnularReintentarOmitir.Click += btnAnularReintentarOmitir_Click;
            // 
            // btnReintentarCancelar
            // 
            btnReintentarCancelar.Location = new Point(14, 189);
            btnReintentarCancelar.Margin = new Padding(4, 3, 4, 3);
            btnReintentarCancelar.Name = "btnReintentarCancelar";
            btnReintentarCancelar.Size = new Size(270, 27);
            btnReintentarCancelar.TabIndex = 12;
            btnReintentarCancelar.Text = "REINTENTAR / CANCELAR";
            btnReintentarCancelar.UseVisualStyleBackColor = true;
            btnReintentarCancelar.Click += btnReintentarCancelar_Click;
            // 
            // btnSiNoCancelar
            // 
            btnSiNoCancelar.Location = new Point(14, 156);
            btnSiNoCancelar.Margin = new Padding(4, 3, 4, 3);
            btnSiNoCancelar.Name = "btnSiNoCancelar";
            btnSiNoCancelar.Size = new Size(270, 27);
            btnSiNoCancelar.TabIndex = 11;
            btnSiNoCancelar.Text = "SI / NO / CANCELAR";
            btnSiNoCancelar.UseVisualStyleBackColor = true;
            btnSiNoCancelar.Click += btnSiNoCancelar_Click;
            // 
            // btnSiNo
            // 
            btnSiNo.Location = new Point(14, 122);
            btnSiNo.Margin = new Padding(4, 3, 4, 3);
            btnSiNo.Name = "btnSiNo";
            btnSiNo.Size = new Size(270, 27);
            btnSiNo.TabIndex = 10;
            btnSiNo.Text = "SI / NO";
            btnSiNo.UseVisualStyleBackColor = true;
            btnSiNo.Click += btnSiNo_Click;
            // 
            // btnAceptarCancelar
            // 
            btnAceptarCancelar.Location = new Point(14, 89);
            btnAceptarCancelar.Margin = new Padding(4, 3, 4, 3);
            btnAceptarCancelar.Name = "btnAceptarCancelar";
            btnAceptarCancelar.Size = new Size(270, 27);
            btnAceptarCancelar.TabIndex = 9;
            btnAceptarCancelar.Text = "ACEPTAR / CANCELAR";
            btnAceptarCancelar.UseVisualStyleBackColor = true;
            btnAceptarCancelar.Click += btnAceptarCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(14, 55);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(270, 27);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // MessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 263);
            Controls.Add(label1);
            Controls.Add(btnAnularReintentarOmitir);
            Controls.Add(btnReintentarCancelar);
            Controls.Add(btnSiNoCancelar);
            Controls.Add(btnSiNo);
            Controls.Add(btnAceptarCancelar);
            Controls.Add(btnAceptar);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBox";
            FormClosing += MessageBox_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnularReintentarOmitir;
        private System.Windows.Forms.Button btnReintentarCancelar;
        private System.Windows.Forms.Button btnSiNoCancelar;
        private System.Windows.Forms.Button btnSiNo;
        private System.Windows.Forms.Button btnAceptarCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}