namespace Ejemplo_Clases_Metodos
{
    partial class frmAccessors
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
            this.btnGetterSetter = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nmrEdad = new System.Windows.Forms.NumericUpDown();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetterSetter
            // 
            this.btnGetterSetter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetterSetter.Location = new System.Drawing.Point(90, 67);
            this.btnGetterSetter.Name = "btnGetterSetter";
            this.btnGetterSetter.Size = new System.Drawing.Size(109, 35);
            this.btnGetterSetter.TabIndex = 0;
            this.btnGetterSetter.Text = "Getter/Setter";
            this.btnGetterSetter.UseVisualStyleBackColor = true;
            this.btnGetterSetter.Click += new System.EventHandler(this.btnGetterSetter_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperty.Location = new System.Drawing.Point(90, 108);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(109, 35);
            this.btnProperty.TabIndex = 2;
            this.btnProperty.Text = "Property ";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(123, 14);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 13);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "label1";
            // 
            // nmrEdad
            // 
            this.nmrEdad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrEdad.Location = new System.Drawing.Point(91, 30);
            this.nmrEdad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrEdad.Name = "nmrEdad";
            this.nmrEdad.Size = new System.Drawing.Size(108, 21);
            this.nmrEdad.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 171);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(41, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "label3";
            // 
            // frmAccessors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 221);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.nmrEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.btnGetterSetter);
            this.Name = "frmAccessors";
            this.Text = "Accesors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetterSetter;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nmrEdad;
        private System.Windows.Forms.Label lblResultado;
    }
}

