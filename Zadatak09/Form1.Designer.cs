namespace Zadatak09
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
            this.lblKoordinate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKoordinate
            // 
            this.lblKoordinate.AutoSize = true;
            this.lblKoordinate.Location = new System.Drawing.Point(267, 201);
            this.lblKoordinate.Name = "lblKoordinate";
            this.lblKoordinate.Size = new System.Drawing.Size(46, 17);
            this.lblKoordinate.TabIndex = 0;
            this.lblKoordinate.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 511);
            this.Controls.Add(this.lblKoordinate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CursorChanged += new System.EventHandler(this.Form1_MouseMove);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKoordinate;
    }
}

