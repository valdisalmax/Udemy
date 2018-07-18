namespace RadioButtons
{
    partial class FrmRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRadio));
            this.RdoHappy = new System.Windows.Forms.RadioButton();
            this.RdoSad = new System.Windows.Forms.RadioButton();
            this.GrpMood = new System.Windows.Forms.GroupBox();
            this.PicHappy = new System.Windows.Forms.PictureBox();
            this.PicSad = new System.Windows.Forms.PictureBox();
            this.GrpMood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSad)).BeginInit();
            this.SuspendLayout();
            // 
            // RdoHappy
            // 
            this.RdoHappy.AutoSize = true;
            this.RdoHappy.Location = new System.Drawing.Point(22, 24);
            this.RdoHappy.Name = "RdoHappy";
            this.RdoHappy.Size = new System.Drawing.Size(56, 17);
            this.RdoHappy.TabIndex = 0;
            this.RdoHappy.TabStop = true;
            this.RdoHappy.Text = "Happy";
            this.RdoHappy.UseVisualStyleBackColor = true;
            this.RdoHappy.CheckedChanged += new System.EventHandler(this.RdoHappy_CheckedChanged);
            // 
            // RdoSad
            // 
            this.RdoSad.AutoSize = true;
            this.RdoSad.Location = new System.Drawing.Point(22, 64);
            this.RdoSad.Name = "RdoSad";
            this.RdoSad.Size = new System.Drawing.Size(44, 17);
            this.RdoSad.TabIndex = 1;
            this.RdoSad.TabStop = true;
            this.RdoSad.Text = "Sad";
            this.RdoSad.UseVisualStyleBackColor = true;
            this.RdoSad.CheckedChanged += new System.EventHandler(this.RdoSad_CheckedChanged);
            // 
            // GrpMood
            // 
            this.GrpMood.Controls.Add(this.RdoSad);
            this.GrpMood.Controls.Add(this.RdoHappy);
            this.GrpMood.Location = new System.Drawing.Point(25, 25);
            this.GrpMood.Name = "GrpMood";
            this.GrpMood.Size = new System.Drawing.Size(200, 100);
            this.GrpMood.TabIndex = 4;
            this.GrpMood.TabStop = false;
            this.GrpMood.Text = "Mood";
            // 
            // PicHappy
            // 
            this.PicHappy.Image = ((System.Drawing.Image)(resources.GetObject("PicHappy.Image")));
            this.PicHappy.Location = new System.Drawing.Point(254, 13);
            this.PicHappy.Name = "PicHappy";
            this.PicHappy.Size = new System.Drawing.Size(68, 52);
            this.PicHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicHappy.TabIndex = 6;
            this.PicHappy.TabStop = false;
            this.PicHappy.Visible = false;
            // 
            // PicSad
            // 
            this.PicSad.Image = ((System.Drawing.Image)(resources.GetObject("PicSad.Image")));
            this.PicSad.Location = new System.Drawing.Point(254, 73);
            this.PicSad.Name = "PicSad";
            this.PicSad.Size = new System.Drawing.Size(68, 52);
            this.PicSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSad.TabIndex = 7;
            this.PicSad.TabStop = false;
            this.PicSad.Visible = false;
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 140);
            this.Controls.Add(this.PicSad);
            this.Controls.Add(this.PicHappy);
            this.Controls.Add(this.GrpMood);
            this.Name = "FrmRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Button Example";
            this.GrpMood.ResumeLayout(false);
            this.GrpMood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RdoHappy;
        private System.Windows.Forms.RadioButton RdoSad;
        private System.Windows.Forms.GroupBox GrpMood;
        private System.Windows.Forms.PictureBox PicHappy;
        private System.Windows.Forms.PictureBox PicSad;
    }
}

