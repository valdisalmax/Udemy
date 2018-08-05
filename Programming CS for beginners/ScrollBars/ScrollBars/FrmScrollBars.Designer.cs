namespace ScrollBars
{
    partial class FrmScrollBars
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
            this.HsbDemo = new System.Windows.Forms.HScrollBar();
            this.LblDemo = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // HsbDemo
            // 
            this.HsbDemo.LargeChange = 1;
            this.HsbDemo.Location = new System.Drawing.Point(63, 76);
            this.HsbDemo.Maximum = 50;
            this.HsbDemo.Name = "HsbDemo";
            this.HsbDemo.Size = new System.Drawing.Size(361, 31);
            this.HsbDemo.TabIndex = 0;
            this.HsbDemo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbDemo_Scroll);
            // 
            // LblDemo
            // 
            this.LblDemo.AutoSize = true;
            this.LblDemo.Location = new System.Drawing.Point(212, 186);
            this.LblDemo.Name = "LblDemo";
            this.LblDemo.Size = new System.Drawing.Size(35, 13);
            this.LblDemo.TabIndex = 1;
            this.LblDemo.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(102, 276);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(258, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // FrmScrollBars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 419);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.LblDemo);
            this.Controls.Add(this.HsbDemo);
            this.Name = "FrmScrollBars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scroll Bars";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar HsbDemo;
        private System.Windows.Forms.Label LblDemo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

