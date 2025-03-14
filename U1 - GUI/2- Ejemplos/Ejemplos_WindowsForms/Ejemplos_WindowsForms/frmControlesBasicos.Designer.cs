namespace Ejemplos_WindowsForms
{
    partial class frmControlesBasicos
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
            label1 = new Label();
            txtEjemplo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            chkEjemplo = new CheckBox();
            grpEjemplo = new GroupBox();
            rdbEjemplo3 = new RadioButton();
            rdbEjemplo2 = new RadioButton();
            rdbEjemplo1 = new RadioButton();
            lstEjemplo = new ListBox();
            label4 = new Label();
            label5 = new Label();
            cmbEjemplo = new ComboBox();
            chlbEjemplo = new CheckedListBox();
            label6 = new Label();
            label7 = new Label();
            dtpFechaEjemplo = new DateTimePicker();
            btnVerTxt = new Button();
            btnVerChk = new Button();
            btnVerRdb = new Button();
            btnVerLst = new Button();
            btnVerCmb = new Button();
            btnVerChlb = new Button();
            btnVerDtp = new Button();
            label8 = new Label();
            nmrEjemplo = new NumericUpDown();
            label9 = new Label();
            mskEjemplo = new MaskedTextBox();
            btnVerNmr = new Button();
            btnVerMsk = new Button();
            grpEjemplo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrEjemplo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 25);
            label1.TabIndex = 0;
            label1.Text = "Controles Windows Forms";
            // 
            // txtEjemplo
            // 
            txtEjemplo.Location = new Point(86, 53);
            txtEjemplo.Margin = new Padding(4, 3, 4, 3);
            txtEjemplo.Name = "txtEjemplo";
            txtEjemplo.Size = new Size(173, 23);
            txtEjemplo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "TextBox:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 160);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 9;
            label3.Text = "CheckBox:";
            // 
            // chkEjemplo
            // 
            chkEjemplo.AutoSize = true;
            chkEjemplo.Location = new Point(89, 160);
            chkEjemplo.Margin = new Padding(4, 3, 4, 3);
            chkEjemplo.Name = "chkEjemplo";
            chkEjemplo.Size = new Size(124, 19);
            chkEjemplo.TabIndex = 10;
            chkEjemplo.Text = "CheckBox Ejemplo";
            chkEjemplo.UseVisualStyleBackColor = true;
            // 
            // grpEjemplo
            // 
            grpEjemplo.Controls.Add(rdbEjemplo3);
            grpEjemplo.Controls.Add(rdbEjemplo2);
            grpEjemplo.Controls.Add(rdbEjemplo1);
            grpEjemplo.Location = new Point(18, 194);
            grpEjemplo.Margin = new Padding(4, 3, 4, 3);
            grpEjemplo.Name = "grpEjemplo";
            grpEjemplo.Padding = new Padding(4, 3, 4, 3);
            grpEjemplo.Size = new Size(246, 115);
            grpEjemplo.TabIndex = 12;
            grpEjemplo.TabStop = false;
            grpEjemplo.Text = "GroupBox Ejemplo";
            // 
            // rdbEjemplo3
            // 
            rdbEjemplo3.AutoSize = true;
            rdbEjemplo3.Location = new Point(8, 78);
            rdbEjemplo3.Margin = new Padding(4, 3, 4, 3);
            rdbEjemplo3.Name = "rdbEjemplo3";
            rdbEjemplo3.Size = new Size(146, 19);
            rdbEjemplo3.TabIndex = 15;
            rdbEjemplo3.TabStop = true;
            rdbEjemplo3.Text = "RadioButton Ejemplo 3";
            rdbEjemplo3.UseVisualStyleBackColor = true;
            // 
            // rdbEjemplo2
            // 
            rdbEjemplo2.AutoSize = true;
            rdbEjemplo2.Location = new Point(8, 51);
            rdbEjemplo2.Margin = new Padding(4, 3, 4, 3);
            rdbEjemplo2.Name = "rdbEjemplo2";
            rdbEjemplo2.Size = new Size(146, 19);
            rdbEjemplo2.TabIndex = 14;
            rdbEjemplo2.TabStop = true;
            rdbEjemplo2.Text = "RadioButton Ejemplo 2";
            rdbEjemplo2.UseVisualStyleBackColor = true;
            // 
            // rdbEjemplo1
            // 
            rdbEjemplo1.AutoSize = true;
            rdbEjemplo1.Location = new Point(8, 23);
            rdbEjemplo1.Margin = new Padding(4, 3, 4, 3);
            rdbEjemplo1.Name = "rdbEjemplo1";
            rdbEjemplo1.Size = new Size(146, 19);
            rdbEjemplo1.TabIndex = 13;
            rdbEjemplo1.TabStop = true;
            rdbEjemplo1.Text = "RadioButton Ejemplo 1";
            rdbEjemplo1.UseVisualStyleBackColor = true;
            // 
            // lstEjemplo
            // 
            lstEjemplo.FormattingEnabled = true;
            lstEjemplo.ItemHeight = 15;
            lstEjemplo.Location = new Point(18, 338);
            lstEjemplo.Margin = new Padding(4, 3, 4, 3);
            lstEjemplo.Name = "lstEjemplo";
            lstEjemplo.Size = new Size(245, 109);
            lstEjemplo.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 320);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 17;
            label4.Text = "ListBox Ejemplo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 457);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 20;
            label5.Text = "ComboBox Ejemplo";
            // 
            // cmbEjemplo
            // 
            cmbEjemplo.FormattingEnabled = true;
            cmbEjemplo.Location = new Point(18, 475);
            cmbEjemplo.Margin = new Padding(4, 3, 4, 3);
            cmbEjemplo.Name = "cmbEjemplo";
            cmbEjemplo.Size = new Size(245, 23);
            cmbEjemplo.TabIndex = 21;
            // 
            // chlbEjemplo
            // 
            chlbEjemplo.CheckOnClick = true;
            chlbEjemplo.FormattingEnabled = true;
            chlbEjemplo.Location = new Point(18, 527);
            chlbEjemplo.Margin = new Padding(4, 3, 4, 3);
            chlbEjemplo.Name = "chlbEjemplo";
            chlbEjemplo.Size = new Size(245, 94);
            chlbEjemplo.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 509);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 15);
            label6.TabIndex = 23;
            label6.Text = "CheckedListBox Ejemplo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 644);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 15);
            label7.TabIndex = 26;
            label7.Text = "DateTimePicker Ejemplo";
            // 
            // dtpFechaEjemplo
            // 
            dtpFechaEjemplo.Location = new Point(18, 663);
            dtpFechaEjemplo.Margin = new Padding(4, 3, 4, 3);
            dtpFechaEjemplo.Name = "dtpFechaEjemplo";
            dtpFechaEjemplo.Size = new Size(245, 23);
            dtpFechaEjemplo.TabIndex = 27;
            // 
            // btnVerTxt
            // 
            btnVerTxt.Location = new Point(272, 51);
            btnVerTxt.Margin = new Padding(4, 3, 4, 3);
            btnVerTxt.Name = "btnVerTxt";
            btnVerTxt.Size = new Size(88, 27);
            btnVerTxt.TabIndex = 2;
            btnVerTxt.Text = "Visualizar";
            btnVerTxt.UseVisualStyleBackColor = true;
            btnVerTxt.Click += btnVerTxt_Click;
            // 
            // btnVerChk
            // 
            btnVerChk.Location = new Point(272, 156);
            btnVerChk.Margin = new Padding(4, 3, 4, 3);
            btnVerChk.Name = "btnVerChk";
            btnVerChk.Size = new Size(88, 27);
            btnVerChk.TabIndex = 11;
            btnVerChk.Text = "Visualizar";
            btnVerChk.UseVisualStyleBackColor = true;
            btnVerChk.Click += btnVerChk_Click;
            // 
            // btnVerRdb
            // 
            btnVerRdb.Location = new Point(271, 241);
            btnVerRdb.Margin = new Padding(4, 3, 4, 3);
            btnVerRdb.Name = "btnVerRdb";
            btnVerRdb.Size = new Size(88, 27);
            btnVerRdb.TabIndex = 16;
            btnVerRdb.Text = "Visualizar";
            btnVerRdb.UseVisualStyleBackColor = true;
            btnVerRdb.Click += btnVerRdb_Click;
            // 
            // btnVerLst
            // 
            btnVerLst.Location = new Point(271, 380);
            btnVerLst.Margin = new Padding(4, 3, 4, 3);
            btnVerLst.Name = "btnVerLst";
            btnVerLst.Size = new Size(88, 27);
            btnVerLst.TabIndex = 19;
            btnVerLst.Text = "Visualizar";
            btnVerLst.UseVisualStyleBackColor = true;
            btnVerLst.Click += btnVerLst_Click;
            // 
            // btnVerCmb
            // 
            btnVerCmb.Location = new Point(272, 472);
            btnVerCmb.Margin = new Padding(4, 3, 4, 3);
            btnVerCmb.Name = "btnVerCmb";
            btnVerCmb.Size = new Size(88, 27);
            btnVerCmb.TabIndex = 22;
            btnVerCmb.Text = "Visualizar";
            btnVerCmb.UseVisualStyleBackColor = true;
            btnVerCmb.Click += btnVerCmb_Click;
            // 
            // btnVerChlb
            // 
            btnVerChlb.Location = new Point(271, 570);
            btnVerChlb.Margin = new Padding(4, 3, 4, 3);
            btnVerChlb.Name = "btnVerChlb";
            btnVerChlb.Size = new Size(88, 27);
            btnVerChlb.TabIndex = 25;
            btnVerChlb.Text = "Visualizar";
            btnVerChlb.UseVisualStyleBackColor = true;
            btnVerChlb.Click += btnVerChlb_Click;
            // 
            // btnVerDtp
            // 
            btnVerDtp.Location = new Point(271, 660);
            btnVerDtp.Margin = new Padding(4, 3, 4, 3);
            btnVerDtp.Name = "btnVerDtp";
            btnVerDtp.Size = new Size(88, 27);
            btnVerDtp.TabIndex = 28;
            btnVerDtp.Text = "Visualizar";
            btnVerDtp.UseVisualStyleBackColor = true;
            btnVerDtp.Click += btnVerDtp_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 90);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 3;
            label8.Text = "NumericUpDown:";
            // 
            // nmrEjemplo
            // 
            nmrEjemplo.Location = new Point(128, 88);
            nmrEjemplo.Margin = new Padding(4, 3, 4, 3);
            nmrEjemplo.Name = "nmrEjemplo";
            nmrEjemplo.Size = new Size(132, 23);
            nmrEjemplo.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 122);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 6;
            label9.Text = "MaskedTextBox:";
            // 
            // mskEjemplo
            // 
            mskEjemplo.Location = new Point(128, 119);
            mskEjemplo.Margin = new Padding(4, 3, 4, 3);
            mskEjemplo.Mask = "(9999)00-0000-0000";
            mskEjemplo.Name = "mskEjemplo";
            mskEjemplo.Size = new Size(131, 23);
            mskEjemplo.TabIndex = 7;
            // 
            // btnVerNmr
            // 
            btnVerNmr.Location = new Point(272, 84);
            btnVerNmr.Margin = new Padding(4, 3, 4, 3);
            btnVerNmr.Name = "btnVerNmr";
            btnVerNmr.Size = new Size(88, 27);
            btnVerNmr.TabIndex = 5;
            btnVerNmr.Text = "Visualizar";
            btnVerNmr.UseVisualStyleBackColor = true;
            btnVerNmr.Click += btnVerNmr_Click;
            // 
            // btnVerMsk
            // 
            btnVerMsk.Location = new Point(272, 117);
            btnVerMsk.Margin = new Padding(4, 3, 4, 3);
            btnVerMsk.Name = "btnVerMsk";
            btnVerMsk.Size = new Size(88, 27);
            btnVerMsk.TabIndex = 8;
            btnVerMsk.Text = "Visualizar";
            btnVerMsk.UseVisualStyleBackColor = true;
            btnVerMsk.Click += btnVerMsk_Click;
            // 
            // ControlesBasicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 703);
            Controls.Add(btnVerMsk);
            Controls.Add(btnVerNmr);
            Controls.Add(mskEjemplo);
            Controls.Add(label9);
            Controls.Add(nmrEjemplo);
            Controls.Add(label8);
            Controls.Add(btnVerDtp);
            Controls.Add(btnVerChlb);
            Controls.Add(btnVerCmb);
            Controls.Add(btnVerLst);
            Controls.Add(btnVerRdb);
            Controls.Add(btnVerChk);
            Controls.Add(btnVerTxt);
            Controls.Add(dtpFechaEjemplo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(chlbEjemplo);
            Controls.Add(cmbEjemplo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lstEjemplo);
            Controls.Add(grpEjemplo);
            Controls.Add(chkEjemplo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEjemplo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ControlesBasicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplos de Controles";
            grpEjemplo.ResumeLayout(false);
            grpEjemplo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrEjemplo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEjemplo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEjemplo;
        private System.Windows.Forms.GroupBox grpEjemplo;
        private System.Windows.Forms.RadioButton rdbEjemplo3;
        private System.Windows.Forms.RadioButton rdbEjemplo2;
        private System.Windows.Forms.RadioButton rdbEjemplo1;
        private System.Windows.Forms.ListBox lstEjemplo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEjemplo;
        private System.Windows.Forms.CheckedListBox chlbEjemplo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaEjemplo;
        private System.Windows.Forms.Button btnVerTxt;
        private System.Windows.Forms.Button btnVerChk;
        private System.Windows.Forms.Button btnVerRdb;
        private System.Windows.Forms.Button btnVerLst;
        private System.Windows.Forms.Button btnVerCmb;
        private System.Windows.Forms.Button btnVerChlb;
        private System.Windows.Forms.Button btnVerDtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmrEjemplo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskEjemplo;
        private System.Windows.Forms.Button btnVerNmr;
        private System.Windows.Forms.Button btnVerMsk;
    }
}
