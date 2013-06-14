namespace PIZadaciZaVjezbu
{
    partial class frmGlavnaForma
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
            this.btnBrojFormi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrojFormi
            // 
            this.btnBrojFormi.Location = new System.Drawing.Point(85, 94);
            this.btnBrojFormi.Name = "btnBrojFormi";
            this.btnBrojFormi.Size = new System.Drawing.Size(81, 40);
            this.btnBrojFormi.TabIndex = 0;
            this.btnBrojFormi.Text = "0";
            this.btnBrojFormi.UseVisualStyleBackColor = true;
            this.btnBrojFormi.Click += new System.EventHandler(this.btnBrojFormi_Click);
            // 
            // frmGlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.btnBrojFormi);
            this.Name = "frmGlavnaForma";
            this.Text = "Zadatak1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrojFormi;
    }
}

