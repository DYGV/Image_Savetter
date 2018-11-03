namespace Twitter_Image
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Box_Tweet = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Detail_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Label_Sign = new System.Windows.Forms.Label();
            this.Btn_Finish = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box_Tweet
            // 
            this.Box_Tweet.Enabled = false;
            this.Box_Tweet.Location = new System.Drawing.Point(12, 80);
            this.Box_Tweet.Multiline = true;
            this.Box_Tweet.Name = "Box_Tweet";
            this.Box_Tweet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Box_Tweet.Size = new System.Drawing.Size(477, 210);
            this.Box_Tweet.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Detail_ToolStripMenuItem1,
            this.Close_ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // Detail_ToolStripMenuItem1
            // 
            this.Detail_ToolStripMenuItem1.Name = "Detail_ToolStripMenuItem1";
            this.Detail_ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Detail_ToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.Detail_ToolStripMenuItem1.Text = "詳細設定";
            this.Detail_ToolStripMenuItem1.Click += new System.EventHandler(this.Detail_ToolStripMenuItem1_Click);
            // 
            // Close_ToolStripMenuItem
            // 
            this.Close_ToolStripMenuItem.Name = "Close_ToolStripMenuItem";
            this.Close_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Close_ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.Close_ToolStripMenuItem.Text = "終了";
            this.Close_ToolStripMenuItem.Click += new System.EventHandler(this.Close_ToolStripMenuItem_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(13, 41);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 4;
            this.Btn_Start.Text = "開始";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Label_Sign
            // 
            this.Label_Sign.AutoSize = true;
            this.Label_Sign.Location = new System.Drawing.Point(383, 302);
            this.Label_Sign.Name = "Label_Sign";
            this.Label_Sign.Size = new System.Drawing.Size(118, 12);
            this.Label_Sign.TabIndex = 5;
            this.Label_Sign.Text = "GomiPrograms@DYGV";
            // 
            // Btn_Finish
            // 
            this.Btn_Finish.Enabled = false;
            this.Btn_Finish.Location = new System.Drawing.Point(94, 41);
            this.Btn_Finish.Name = "Btn_Finish";
            this.Btn_Finish.Size = new System.Drawing.Size(75, 23);
            this.Btn_Finish.TabIndex = 6;
            this.Btn_Finish.Text = "停止";
            this.Btn_Finish.UseVisualStyleBackColor = true;
            this.Btn_Finish.Click += new System.EventHandler(this.Btn_Finish_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 315);
            this.Controls.Add(this.Btn_Finish);
            this.Controls.Add(this.Label_Sign);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Box_Tweet);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "画像せーぶったー";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Detail_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Close_ToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label Label_Sign;
        private System.Windows.Forms.Button Btn_Finish;
        public System.Windows.Forms.TextBox Box_Tweet;
    }
}

