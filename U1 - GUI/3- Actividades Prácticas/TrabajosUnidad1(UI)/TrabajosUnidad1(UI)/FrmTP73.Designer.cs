namespace TrabajosUnidad1_UI_
{
    partial class FrmTP73
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEspacios = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAlinIzq = new System.Windows.Forms.Button();
            this.btnAlinDer = new System.Windows.Forms.Button();
            this.btnAlinCen = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 12);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(770, 323);
            this.txtTexto.TabIndex = 5;
            this.txtTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Caracteres";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Location = new System.Drawing.Point(73, 379);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(13, 13);
            this.lblCaracteres.TabIndex = 7;
            this.lblCaracteres.Text = "0";
            // 
            // lblPalabras
            // 
            this.lblPalabras.AutoSize = true;
            this.lblPalabras.Location = new System.Drawing.Point(198, 379);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(13, 13);
            this.lblPalabras.TabIndex = 9;
            this.lblPalabras.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Palabras";
            // 
            // lblEspacios
            // 
            this.lblEspacios.AutoSize = true;
            this.lblEspacios.Location = new System.Drawing.Point(387, 379);
            this.lblEspacios.Name = "lblEspacios";
            this.lblEspacios.Size = new System.Drawing.Size(13, 13);
            this.lblEspacios.TabIndex = 11;
            this.lblEspacios.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Espacios en blanco";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alineacion";
            // 
            // btnAlinIzq
            // 
            this.btnAlinIzq.Location = new System.Drawing.Point(590, 369);
            this.btnAlinIzq.Name = "btnAlinIzq";
            this.btnAlinIzq.Size = new System.Drawing.Size(60, 23);
            this.btnAlinIzq.TabIndex = 13;
            this.btnAlinIzq.Text = "Izquierda";
            this.btnAlinIzq.UseVisualStyleBackColor = true;
            this.btnAlinIzq.Click += new System.EventHandler(this.btnAlinIzq_Click);
            // 
            // btnAlinDer
            // 
            this.btnAlinDer.Location = new System.Drawing.Point(722, 369);
            this.btnAlinDer.Name = "btnAlinDer";
            this.btnAlinDer.Size = new System.Drawing.Size(60, 23);
            this.btnAlinDer.TabIndex = 14;
            this.btnAlinDer.Text = "Derecha";
            this.btnAlinDer.UseVisualStyleBackColor = true;
            this.btnAlinDer.Click += new System.EventHandler(this.btnAlinDer_Click);
            // 
            // btnAlinCen
            // 
            this.btnAlinCen.Location = new System.Drawing.Point(656, 369);
            this.btnAlinCen.Name = "btnAlinCen";
            this.btnAlinCen.Size = new System.Drawing.Size(60, 23);
            this.btnAlinCen.TabIndex = 15;
            this.btnAlinCen.Text = "Centro";
            this.btnAlinCen.UseVisualStyleBackColor = true;
            this.btnAlinCen.Click += new System.EventHandler(this.btnAlinCen_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(472, 369);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar Texto";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmTP73
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 401);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAlinCen);
            this.Controls.Add(this.btnAlinDer);
            this.Controls.Add(this.btnAlinIzq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEspacios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPalabras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCaracteres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Name = "FrmTP73";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejercicio 73";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEspacios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAlinIzq;
        private System.Windows.Forms.Button btnAlinDer;
        private System.Windows.Forms.Button btnAlinCen;
        private System.Windows.Forms.Button btnLimpiar;
    }
}