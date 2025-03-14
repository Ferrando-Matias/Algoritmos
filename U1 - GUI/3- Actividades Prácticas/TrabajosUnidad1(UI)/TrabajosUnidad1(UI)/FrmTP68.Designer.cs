namespace TrabajosUnidad1_UI_
{
    partial class FrmTP68
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
            this.btnVotoA = new System.Windows.Forms.Button();
            this.btnVotoB = new System.Windows.Forms.Button();
            this.btnVotoC = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVotoA
            // 
            this.btnVotoA.Location = new System.Drawing.Point(12, 12);
            this.btnVotoA.Name = "btnVotoA";
            this.btnVotoA.Size = new System.Drawing.Size(75, 23);
            this.btnVotoA.TabIndex = 0;
            this.btnVotoA.Text = "Voto A";
            this.btnVotoA.UseVisualStyleBackColor = true;
            this.btnVotoA.Click += new System.EventHandler(this.btnVotoA_Click);
            // 
            // btnVotoB
            // 
            this.btnVotoB.Location = new System.Drawing.Point(93, 12);
            this.btnVotoB.Name = "btnVotoB";
            this.btnVotoB.Size = new System.Drawing.Size(75, 23);
            this.btnVotoB.TabIndex = 0;
            this.btnVotoB.Text = "Voto B";
            this.btnVotoB.UseVisualStyleBackColor = true;
            this.btnVotoB.Click += new System.EventHandler(this.btnVotoB_Click);
            // 
            // btnVotoC
            // 
            this.btnVotoC.Location = new System.Drawing.Point(174, 12);
            this.btnVotoC.Name = "btnVotoC";
            this.btnVotoC.Size = new System.Drawing.Size(75, 23);
            this.btnVotoC.TabIndex = 0;
            this.btnVotoC.Text = "Voto C";
            this.btnVotoC.UseVisualStyleBackColor = true;
            this.btnVotoC.Click += new System.EventHandler(this.btnVotoC_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(48, 56);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 1;
            // 
            // FrmTP68
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 91);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVotoC);
            this.Controls.Add(this.btnVotoB);
            this.Controls.Add(this.btnVotoA);
            this.Name = "FrmTP68";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejercicio 68";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVotoA;
        private System.Windows.Forms.Button btnVotoB;
        private System.Windows.Forms.Button btnVotoC;
        private System.Windows.Forms.Label lblResultado;
    }
}