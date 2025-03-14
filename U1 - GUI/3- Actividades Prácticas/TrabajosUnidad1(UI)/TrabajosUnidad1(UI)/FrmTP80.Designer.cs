namespace TrabajosUnidad1_UI_
{
    partial class FrmTP80
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbIngredientes = new System.Windows.Forms.GroupBox();
            this.chkAceitunas = new System.Windows.Forms.CheckBox();
            this.chkJamon = new System.Windows.Forms.CheckBox();
            this.chkPanceta = new System.Windows.Forms.CheckBox();
            this.chkHuevo = new System.Windows.Forms.CheckBox();
            this.cmbPizzaT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbIngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 32);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.grbIngredientes);
            this.groupBox1.Controls.Add(this.cmbPizzaT);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza";
            // 
            // grbIngredientes
            // 
            this.grbIngredientes.Controls.Add(this.chkAceitunas);
            this.grbIngredientes.Controls.Add(this.chkJamon);
            this.grbIngredientes.Controls.Add(this.chkPanceta);
            this.grbIngredientes.Controls.Add(this.chkHuevo);
            this.grbIngredientes.Location = new System.Drawing.Point(9, 46);
            this.grbIngredientes.Name = "grbIngredientes";
            this.grbIngredientes.Size = new System.Drawing.Size(281, 64);
            this.grbIngredientes.TabIndex = 4;
            this.grbIngredientes.TabStop = false;
            this.grbIngredientes.Text = "Extras";
            // 
            // chkAceitunas
            // 
            this.chkAceitunas.AutoSize = true;
            this.chkAceitunas.Location = new System.Drawing.Point(6, 19);
            this.chkAceitunas.Name = "chkAceitunas";
            this.chkAceitunas.Size = new System.Drawing.Size(73, 17);
            this.chkAceitunas.TabIndex = 3;
            this.chkAceitunas.Text = "Aceitunas";
            this.chkAceitunas.UseVisualStyleBackColor = true;
            // 
            // chkJamon
            // 
            this.chkJamon.AutoSize = true;
            this.chkJamon.Location = new System.Drawing.Point(6, 42);
            this.chkJamon.Name = "chkJamon";
            this.chkJamon.Size = new System.Drawing.Size(57, 17);
            this.chkJamon.TabIndex = 0;
            this.chkJamon.Text = "Jamon";
            this.chkJamon.UseVisualStyleBackColor = true;
            // 
            // chkPanceta
            // 
            this.chkPanceta.AutoSize = true;
            this.chkPanceta.Location = new System.Drawing.Point(168, 41);
            this.chkPanceta.Name = "chkPanceta";
            this.chkPanceta.Size = new System.Drawing.Size(66, 17);
            this.chkPanceta.TabIndex = 2;
            this.chkPanceta.Text = "Panceta";
            this.chkPanceta.UseVisualStyleBackColor = true;
            // 
            // chkHuevo
            // 
            this.chkHuevo.AutoSize = true;
            this.chkHuevo.Location = new System.Drawing.Point(168, 19);
            this.chkHuevo.Name = "chkHuevo";
            this.chkHuevo.Size = new System.Drawing.Size(58, 17);
            this.chkHuevo.TabIndex = 1;
            this.chkHuevo.Text = "Huevo";
            this.chkHuevo.UseVisualStyleBackColor = true;
            // 
            // cmbPizzaT
            // 
            this.cmbPizzaT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizzaT.FormattingEnabled = true;
            this.cmbPizzaT.Location = new System.Drawing.Point(9, 19);
            this.cmbPizzaT.Name = "cmbPizzaT";
            this.cmbPizzaT.Size = new System.Drawing.Size(281, 21);
            this.cmbPizzaT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(115, 6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(196, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(190, 32);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmTP80
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLimpiar;
            this.ClientSize = new System.Drawing.Size(325, 200);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FrmTP80";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejercicio 80";
            this.Load += new System.EventHandler(this.FrmTP80_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbIngredientes.ResumeLayout(false);
            this.grbIngredientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbIngredientes;
        private System.Windows.Forms.CheckBox chkAceitunas;
        private System.Windows.Forms.CheckBox chkJamon;
        private System.Windows.Forms.CheckBox chkPanceta;
        private System.Windows.Forms.CheckBox chkHuevo;
        private System.Windows.Forms.ComboBox cmbPizzaT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnLimpiar;
    }
}