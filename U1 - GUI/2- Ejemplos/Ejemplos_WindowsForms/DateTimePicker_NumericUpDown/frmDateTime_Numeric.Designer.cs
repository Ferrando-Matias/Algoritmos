namespace DateTimePicker_NumericUpDown
{
    partial class frmDateTime_Numeric
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
            dtpFecha = new DateTimePicker();
            btnVerFecha = new Button();
            label1 = new Label();
            nupAño = new NumericUpDown();
            nupMes = new NumericUpDown();
            label2 = new Label();
            nupDia = new NumericUpDown();
            label3 = new Label();
            btnCambiarFecha = new Button();
            ((System.ComponentModel.ISupportInitialize)nupAño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupMes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupDia).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(29, 14);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(233, 23);
            dtpFecha.TabIndex = 0;
            dtpFecha.Value = new DateTime(2024, 5, 9, 11, 13, 27, 0);
            // 
            // btnVerFecha
            // 
            btnVerFecha.Location = new Point(203, 44);
            btnVerFecha.Margin = new Padding(4, 3, 4, 3);
            btnVerFecha.Name = "btnVerFecha";
            btnVerFecha.Size = new Size(59, 31);
            btnVerFecha.TabIndex = 1;
            btnVerFecha.Text = "Ver";
            btnVerFecha.UseVisualStyleBackColor = true;
            btnVerFecha.Click += btnVerFecha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "Año";
            // 
            // nupAño
            // 
            nupAño.Location = new Point(62, 92);
            nupAño.Margin = new Padding(4, 3, 4, 3);
            nupAño.Name = "nupAño";
            nupAño.Size = new Size(140, 23);
            nupAño.TabIndex = 3;
            // 
            // nupMes
            // 
            nupMes.Location = new Point(62, 122);
            nupMes.Margin = new Padding(4, 3, 4, 3);
            nupMes.Name = "nupMes";
            nupMes.Size = new Size(140, 23);
            nupMes.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "Mes";
            // 
            // nupDia
            // 
            nupDia.Location = new Point(62, 152);
            nupDia.Margin = new Padding(4, 3, 4, 3);
            nupDia.Name = "nupDia";
            nupDia.Size = new Size(140, 23);
            nupDia.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 155);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 6;
            label3.Text = "Dia";
            // 
            // btnCambiarFecha
            // 
            btnCambiarFecha.Location = new Point(14, 182);
            btnCambiarFecha.Margin = new Padding(4, 3, 4, 3);
            btnCambiarFecha.Name = "btnCambiarFecha";
            btnCambiarFecha.Size = new Size(188, 27);
            btnCambiarFecha.TabIndex = 10;
            btnCambiarFecha.Text = "Cambiar Date Time";
            btnCambiarFecha.UseVisualStyleBackColor = true;
            btnCambiarFecha.Click += btnCambiarFecha_Click;
            // 
            // frmDateTime_Numeric
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 219);
            Controls.Add(btnCambiarFecha);
            Controls.Add(nupDia);
            Controls.Add(label3);
            Controls.Add(nupMes);
            Controls.Add(label2);
            Controls.Add(nupAño);
            Controls.Add(label1);
            Controls.Add(btnVerFecha);
            Controls.Add(dtpFecha);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDateTime_Numeric";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmDateTime_Numeric_Load;
            ((System.ComponentModel.ISupportInitialize)nupAño).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupMes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupDia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnVerFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupAño;
        private System.Windows.Forms.NumericUpDown nupMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCambiarFecha;
    }
}
