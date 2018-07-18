namespace FirstApp
{
    partial class FrmFirstApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirstApp));
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.BtnWelcome = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(22, 26);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(241, 19);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Welcome To My Program";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(38, 66);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(197, 20);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.Text = "default";
            // 
            // PicTitle
            // 
            this.PicTitle.Image = ((System.Drawing.Image)(resources.GetObject("PicTitle.Image")));
            this.PicTitle.Location = new System.Drawing.Point(34, 105);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(200, 76);
            this.PicTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTitle.TabIndex = 2;
            this.PicTitle.TabStop = false;
            // 
            // BtnWelcome
            // 
            this.BtnWelcome.Location = new System.Drawing.Point(16, 204);
            this.BtnWelcome.Name = "BtnWelcome";
            this.BtnWelcome.Size = new System.Drawing.Size(84, 32);
            this.BtnWelcome.TabIndex = 3;
            this.BtnWelcome.Text = "Welcome";
            this.BtnWelcome.UseVisualStyleBackColor = true;
            this.BtnWelcome.Click += new System.EventHandler(this.BtnWelcome_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(151, 204);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(84, 32);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnWelcome);
            this.Controls.Add(this.PicTitle);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmFirstApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First App";
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.Button BtnWelcome;
        private System.Windows.Forms.Button BtnExit;
    }
}

