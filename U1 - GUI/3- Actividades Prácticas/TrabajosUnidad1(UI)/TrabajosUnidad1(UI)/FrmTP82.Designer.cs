namespace TrabajosUnidad1_UI_
{
    partial class FrmTP82
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbHoras = new System.Windows.Forms.GroupBox();
            this.nudHoraExtra = new System.Windows.Forms.NumericUpDown();
            this.nudHoraMes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbEmpleado = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grbHoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraMes)).BeginInit();
            this.grbEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(400, 107);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(238, 108);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grbHoras
            // 
            this.grbHoras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbHoras.Controls.Add(this.nudHoraExtra);
            this.grbHoras.Controls.Add(this.nudHoraMes);
            this.grbHoras.Controls.Add(this.label6);
            this.grbHoras.Controls.Add(this.label5);
            this.grbHoras.Location = new System.Drawing.Point(238, 12);
            this.grbHoras.Name = "grbHoras";
            this.grbHoras.Size = new System.Drawing.Size(274, 89);
            this.grbHoras.TabIndex = 13;
            this.grbHoras.TabStop = false;
            this.grbHoras.Text = "Horas";
            // 
            // nudHoraExtra
            // 
            this.nudHoraExtra.Location = new System.Drawing.Point(144, 53);
            this.nudHoraExtra.Maximum = new decimal(new int[] {
            552,
            0,
            0,
            0});
            this.nudHoraExtra.Name = "nudHoraExtra";
            this.nudHoraExtra.Size = new System.Drawing.Size(120, 20);
            this.nudHoraExtra.TabIndex = 6;
            // 
            // nudHoraMes
            // 
            this.nudHoraMes.Location = new System.Drawing.Point(144, 27);
            this.nudHoraMes.Maximum = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.nudHoraMes.Name = "nudHoraMes";
            this.nudHoraMes.Size = new System.Drawing.Size(120, 20);
            this.nudHoraMes.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Horas Extras trabajadas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Horas por Mes trabajadas:";
            // 
            // grbEmpleado
            // 
            this.grbEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbEmpleado.Controls.Add(this.txtNombre);
            this.grbEmpleado.Controls.Add(this.label4);
            this.grbEmpleado.Controls.Add(this.label1);
            this.grbEmpleado.Controls.Add(this.dtpFechaIngreso);
            this.grbEmpleado.Controls.Add(this.txtApellido);
            this.grbEmpleado.Controls.Add(this.label3);
            this.grbEmpleado.Controls.Add(this.label2);
            this.grbEmpleado.Controls.Add(this.cmbCategoria);
            this.grbEmpleado.Location = new System.Drawing.Point(12, 12);
            this.grbEmpleado.Name = "grbEmpleado";
            this.grbEmpleado.Size = new System.Drawing.Size(220, 192);
            this.grbEmpleado.TabIndex = 12;
            this.grbEmpleado.TabStop = false;
            this.grbEmpleado.Text = "Datos del Empleado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Ingreso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CustomFormat = "";
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(6, 145);
            this.dtpFechaIngreso.MaxDate = new System.DateTime(2024, 3, 5, 0, 0, 0, 0);
            this.dtpFechaIngreso.MinDate = new System.DateTime(1923, 10, 3, 0, 0, 0, 0);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaIngreso.TabIndex = 4;
            this.dtpFechaIngreso.Value = new System.DateTime(2024, 3, 5, 0, 0, 0, 0);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 40);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(6, 87);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(206, 21);
            this.cmbCategoria.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total a Cobrar";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(318, 154);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(194, 18);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "$ 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmTP82
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 214);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbHoras);
            this.Controls.Add(this.grbEmpleado);
            this.Name = "FrmTP82";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejercicio 82";
            this.Load += new System.EventHandler(this.FrmTP82_Load);
            this.grbHoras.ResumeLayout(false);
            this.grbHoras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraMes)).EndInit();
            this.grbEmpleado.ResumeLayout(false);
            this.grbEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grbHoras;
        private System.Windows.Forms.NumericUpDown nudHoraExtra;
        private System.Windows.Forms.NumericUpDown nudHoraMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
    }
}