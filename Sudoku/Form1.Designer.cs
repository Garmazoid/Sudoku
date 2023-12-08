namespace Sudoku
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TIME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TIME
            // 
            this.TIME.AutoSize = true;
            this.TIME.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TIME.ForeColor = System.Drawing.Color.Black;
            this.TIME.Location = new System.Drawing.Point(-3, -2);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(84, 54);
            this.TIME.TabIndex = 0;
            this.TIME.Text = "0:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(584, 811);
            this.Controls.Add(this.TIME);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TIME;
    }
}