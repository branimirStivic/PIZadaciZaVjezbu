namespace Zadatak03
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
            this.btnUhvati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUhvati
            // 
            this.btnUhvati.Location = new System.Drawing.Point(88, 114);
            this.btnUhvati.Name = "btnUhvati";
            this.btnUhvati.Size = new System.Drawing.Size(103, 58);
            this.btnUhvati.TabIndex = 0;
            this.btnUhvati.Text = "Uhvati me!";
            this.btnUhvati.UseVisualStyleBackColor = true;
            this.btnUhvati.Click += new System.EventHandler(this.btnUhvati_Click);
            this.btnUhvati.MouseEnter += new System.EventHandler(this.btnUhvati_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 263);
            this.Controls.Add(this.btnUhvati);
            this.Name = "Form1";
            this.Text = "bu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUhvati;
    }
}

