namespace Twitter_Image
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Box_Pin = new System.Windows.Forms.TextBox();
            this.Btn_Verify = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Label_Verified = new System.Windows.Forms.Label();
            this.Btn_Pin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Box_Pin
            // 
            this.Box_Pin.Enabled = false;
            this.Box_Pin.Location = new System.Drawing.Point(12, 38);
            this.Box_Pin.Name = "Box_Pin";
            this.Box_Pin.Size = new System.Drawing.Size(234, 19);
            this.Box_Pin.TabIndex = 0;
            // 
            // Btn_Verify
            // 
            this.Btn_Verify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Verify.Enabled = false;
            this.Btn_Verify.Location = new System.Drawing.Point(252, 36);
            this.Btn_Verify.Name = "Btn_Verify";
            this.Btn_Verify.Size = new System.Drawing.Size(100, 23);
            this.Btn_Verify.TabIndex = 1;
            this.Btn_Verify.Text = "認証";
            this.Btn_Verify.UseVisualStyleBackColor = true;
            this.Btn_Verify.Click += new System.EventHandler(this.Btn_Verify_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Close.Location = new System.Drawing.Point(298, 80);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "閉じる";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Label_Verified
            // 
            this.Label_Verified.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label_Verified.AutoSize = true;
            this.Label_Verified.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Verified.Location = new System.Drawing.Point(23, 87);
            this.Label_Verified.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Label_Verified.Name = "Label_Verified";
            this.Label_Verified.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Verified.Size = new System.Drawing.Size(56, 16);
            this.Label_Verified.TabIndex = 3;
            this.Label_Verified.Text = "未認証";
            this.Label_Verified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Pin
            // 
            this.Btn_Pin.Location = new System.Drawing.Point(12, 9);
            this.Btn_Pin.Name = "Btn_Pin";
            this.Btn_Pin.Size = new System.Drawing.Size(75, 23);
            this.Btn_Pin.TabIndex = 4;
            this.Btn_Pin.Text = "ログイン";
            this.Btn_Pin.UseVisualStyleBackColor = true;
            this.Btn_Pin.Click += new System.EventHandler(this.Btn_Pin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 106);
            this.Controls.Add(this.Btn_Pin);
            this.Controls.Add(this.Label_Verified);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Verify);
            this.Controls.Add(this.Box_Pin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box_Pin;
        private System.Windows.Forms.Button Btn_Verify;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Label_Verified;
        private System.Windows.Forms.Button Btn_Pin;
    }
}