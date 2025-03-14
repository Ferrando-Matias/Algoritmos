namespace TrabajosUnidad1_UI_
{
    partial class FrmTP77
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.txtDato3 = new System.Windows.Forms.TextBox();
            this.lblDato3 = new System.Windows.Forms.Label();
            this.txtDato4 = new System.Windows.Forms.TextBox();
            this.lblDato4 = new System.Windows.Forms.Label();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.lblTipoTriangulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Forma:";
            // 
            // cmbFormas
            // 
            this.cmbFormas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormas.FormattingEnabled = true;
            this.cmbFormas.Location = new System.Drawing.Point(57, 6);
            this.cmbFormas.Name = "cmbFormas";
            this.cmbFormas.Size = new System.Drawing.Size(187, 21);
            this.cmbFormas.TabIndex = 4;
            this.cmbFormas.SelectedIndexChanged += new System.EventHandler(this.cmbFormas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Perimetro:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPerimetro.Location = new System.Drawing.Point(76, 246);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(168, 23);
            this.lblPerimetro.TabIndex = 14;
            this.lblPerimetro.Text = "0";
            this.lblPerimetro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Area:";
            // 
            // lblArea
            // 
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.Location = new System.Drawing.Point(76, 212);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(168, 23);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "0";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(8, 176);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.Location = new System.Drawing.Point(15, 58);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(35, 13);
            this.lblDato1.TabIndex = 16;
            this.lblDato1.Text = "label4";
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(78, 55);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(166, 20);
            this.txtDato1.TabIndex = 17;
            this.txtDato1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato1_KeyPress);
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(78, 81);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(166, 20);
            this.txtDato2.TabIndex = 19;
            this.txtDato2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato2_KeyPress);
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Location = new System.Drawing.Point(15, 84);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(35, 13);
            this.lblDato2.TabIndex = 18;
            this.lblDato2.Text = "label5";
            // 
            // txtDato3
            // 
            this.txtDato3.Location = new System.Drawing.Point(78, 107);
            this.txtDato3.Name = "txtDato3";
            this.txtDato3.Size = new System.Drawing.Size(166, 20);
            this.txtDato3.TabIndex = 21;
            this.txtDato3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato3_KeyPress);
            // 
            // lblDato3
            // 
            this.lblDato3.AutoSize = true;
            this.lblDato3.Location = new System.Drawing.Point(15, 110);
            this.lblDato3.Name = "lblDato3";
            this.lblDato3.Size = new System.Drawing.Size(35, 13);
            this.lblDato3.TabIndex = 20;
            this.lblDato3.Text = "label6";
            // 
            // txtDato4
            // 
            this.txtDato4.Location = new System.Drawing.Point(78, 133);
            this.txtDato4.Name = "txtDato4";
            this.txtDato4.Size = new System.Drawing.Size(166, 20);
            this.txtDato4.TabIndex = 23;
            this.txtDato4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato4_KeyPress);
            // 
            // lblDato4
            // 
            this.lblDato4.AutoSize = true;
            this.lblDato4.Location = new System.Drawing.Point(15, 136);
            this.lblDato4.Name = "lblDato4";
            this.lblDato4.Size = new System.Drawing.Size(35, 13);
            this.lblDato4.TabIndex = 22;
            this.lblDato4.Text = "label7";
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(12, 291);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(54, 13);
            this.lblTriangulo.TabIndex = 25;
            this.lblTriangulo.Text = "Triangulo:";
            // 
            // lblTipoTriangulo
            // 
            this.lblTipoTriangulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTipoTriangulo.Location = new System.Drawing.Point(76, 281);
            this.lblTipoTriangulo.Name = "lblTipoTriangulo";
            this.lblTipoTriangulo.Size = new System.Drawing.Size(168, 23);
            this.lblTipoTriangulo.TabIndex = 24;
            this.lblTipoTriangulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(174, 176);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(93, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmTP77
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 316);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.lblTipoTriangulo);
            this.Controls.Add(this.txtDato4);
            this.Controls.Add(this.lblDato4);
            this.Controls.Add(this.txtDato3);
            this.Controls.Add(this.lblDato3);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.lblDato2);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.lblDato1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFormas);
            this.Name = "FrmTP77";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejercicio 77";
            this.Load += new System.EventHandler(this.FrmTP77_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.TextBox txtDato3;
        private System.Windows.Forms.Label lblDato3;
        private System.Windows.Forms.TextBox txtDato4;
        private System.Windows.Forms.Label lblDato4;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.Label lblTipoTriangulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}