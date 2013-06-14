namespace Zadatak02
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
            this.lblBrojKlikova = new System.Windows.Forms.Label();
            this.txtBrojKlikova = new System.Windows.Forms.TextBox();
            this.btnBrojKlikova = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrojKlikova
            // 
            this.lblBrojKlikova.AutoSize = true;
            this.lblBrojKlikova.Location = new System.Drawing.Point(12, 76);
            this.lblBrojKlikova.Name = "lblBrojKlikova";
            this.lblBrojKlikova.Size = new System.Drawing.Size(68, 17);
            this.lblBrojKlikova.TabIndex = 0;
            this.lblBrojKlikova.Text = "X klikova:";
            this.lblBrojKlikova.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBrojKlikova
            // 
            this.txtBrojKlikova.Location = new System.Drawing.Point(96, 76);
            this.txtBrojKlikova.Name = "txtBrojKlikova";
            this.txtBrojKlikova.Size = new System.Drawing.Size(100, 22);
            this.txtBrojKlikova.TabIndex = 1;
            this.txtBrojKlikova.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBrojKlikova
            // 
            this.btnBrojKlikova.Location = new System.Drawing.Point(96, 117);
            this.btnBrojKlikova.Name = "btnBrojKlikova";
            this.btnBrojKlikova.Size = new System.Drawing.Size(75, 23);
            this.btnBrojKlikova.TabIndex = 2;
            this.btnBrojKlikova.Text = "Klik";
            this.btnBrojKlikova.UseVisualStyleBackColor = true;
            this.btnBrojKlikova.Click += new System.EventHandler(this.btnBrojKlikova_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 195);
            this.Controls.Add(this.btnBrojKlikova);
            this.Controls.Add(this.txtBrojKlikova);
            this.Controls.Add(this.lblBrojKlikova);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojKlikova;
        private System.Windows.Forms.TextBox txtBrojKlikova;
        private System.Windows.Forms.Button btnBrojKlikova;
    }
}

