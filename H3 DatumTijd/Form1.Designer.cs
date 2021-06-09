
namespace H3_1_DatumTijd
{
    partial class Form1
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
            this.btnVandaag = new System.Windows.Forms.Button();
            this.lblDatumTijd = new System.Windows.Forms.Label();
            this.lblJaar = new System.Windows.Forms.Label();
            this.lblMaand = new System.Windows.Forms.Label();
            this.lblDag = new System.Windows.Forms.Label();
            this.lblWeekdag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVandaag
            // 
            this.btnVandaag.Location = new System.Drawing.Point(20, 13);
            this.btnVandaag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVandaag.Name = "btnVandaag";
            this.btnVandaag.Size = new System.Drawing.Size(100, 28);
            this.btnVandaag.TabIndex = 0;
            this.btnVandaag.Text = "Vandaag";
            this.btnVandaag.UseVisualStyleBackColor = true;
            this.btnVandaag.Click += new System.EventHandler(this.btnVandaag_Click);
            // 
            // lblDatumTijd
            // 
            this.lblDatumTijd.AutoSize = true;
            this.lblDatumTijd.Location = new System.Drawing.Point(29, 162);
            this.lblDatumTijd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumTijd.Name = "lblDatumTijd";
            this.lblDatumTijd.Size = new System.Drawing.Size(91, 17);
            this.lblDatumTijd.TabIndex = 1;
            this.lblDatumTijd.Text = "Datum en tijd";
            // 
            // lblJaar
            // 
            this.lblJaar.AutoSize = true;
            this.lblJaar.Location = new System.Drawing.Point(302, 9);
            this.lblJaar.Name = "lblJaar";
            this.lblJaar.Size = new System.Drawing.Size(36, 17);
            this.lblJaar.TabIndex = 2;
            this.lblJaar.Text = "Jaar";
            // 
            // lblMaand
            // 
            this.lblMaand.AutoSize = true;
            this.lblMaand.Location = new System.Drawing.Point(302, 36);
            this.lblMaand.Name = "lblMaand";
            this.lblMaand.Size = new System.Drawing.Size(51, 17);
            this.lblMaand.TabIndex = 3;
            this.lblMaand.Text = "Maand";
            // 
            // lblDag
            // 
            this.lblDag.AutoSize = true;
            this.lblDag.Location = new System.Drawing.Point(302, 65);
            this.lblDag.Name = "lblDag";
            this.lblDag.Size = new System.Drawing.Size(34, 17);
            this.lblDag.TabIndex = 4;
            this.lblDag.Text = "Dag";
            // 
            // lblWeekdag
            // 
            this.lblWeekdag.AutoSize = true;
            this.lblWeekdag.Location = new System.Drawing.Point(302, 96);
            this.lblWeekdag.Name = "lblWeekdag";
            this.lblWeekdag.Size = new System.Drawing.Size(68, 17);
            this.lblWeekdag.TabIndex = 5;
            this.lblWeekdag.Text = "Weekdag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 233);
            this.Controls.Add(this.lblWeekdag);
            this.Controls.Add(this.lblDag);
            this.Controls.Add(this.lblMaand);
            this.Controls.Add(this.lblJaar);
            this.Controls.Add(this.lblDatumTijd);
            this.Controls.Add(this.btnVandaag);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVandaag;
        private System.Windows.Forms.Label lblDatumTijd;
        private System.Windows.Forms.Label lblJaar;
        private System.Windows.Forms.Label lblMaand;
        private System.Windows.Forms.Label lblDag;
        private System.Windows.Forms.Label lblWeekdag;
    }
}

