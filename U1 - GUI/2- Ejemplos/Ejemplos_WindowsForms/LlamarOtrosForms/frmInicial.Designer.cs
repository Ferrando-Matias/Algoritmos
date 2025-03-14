namespace LlamarOtrosForms
{
    partial class frmInicial
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
            btnLocalidades = new Button();
            btnPartidos = new Button();
            btnProvincias = new Button();
            btnVacio = new Button();
            SuspendLayout();
            // 
            // btnLocalidades
            // 
            btnLocalidades.Location = new Point(119, 76);
            btnLocalidades.Margin = new Padding(4, 3, 4, 3);
            btnLocalidades.Name = "btnLocalidades";
            btnLocalidades.Size = new Size(88, 27);
            btnLocalidades.TabIndex = 0;
            btnLocalidades.Text = "Localidades";
            btnLocalidades.UseVisualStyleBackColor = true;
            btnLocalidades.Click += btnLocalidades_Click;
            // 
            // btnPartidos
            // 
            btnPartidos.Location = new Point(119, 43);
            btnPartidos.Margin = new Padding(4, 3, 4, 3);
            btnPartidos.Name = "btnPartidos";
            btnPartidos.Size = new Size(88, 27);
            btnPartidos.TabIndex = 1;
            btnPartidos.Text = "Partidos";
            btnPartidos.UseVisualStyleBackColor = true;
            btnPartidos.Click += btnPartidos_Click;
            // 
            // btnProvincias
            // 
            btnProvincias.Location = new Point(119, 110);
            btnProvincias.Margin = new Padding(4, 3, 4, 3);
            btnProvincias.Name = "btnProvincias";
            btnProvincias.Size = new Size(88, 27);
            btnProvincias.TabIndex = 2;
            btnProvincias.Text = "Provincias";
            btnProvincias.UseVisualStyleBackColor = true;
            btnProvincias.Click += btnProvincias_Click;
            // 
            // btnVacio
            // 
            btnVacio.Location = new Point(119, 143);
            btnVacio.Margin = new Padding(4, 3, 4, 3);
            btnVacio.Name = "btnVacio";
            btnVacio.Size = new Size(88, 27);
            btnVacio.TabIndex = 3;
            btnVacio.Text = "Vacio";
            btnVacio.UseVisualStyleBackColor = true;
            btnVacio.Click += btnVacio_Click;
            // 
            // frmInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 209);
            Controls.Add(btnVacio);
            Controls.Add(btnProvincias);
            Controls.Add(btnPartidos);
            Controls.Add(btnLocalidades);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Llamar Formularios";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLocalidades;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnProvincias;
        private System.Windows.Forms.Button btnVacio;
    }
}
