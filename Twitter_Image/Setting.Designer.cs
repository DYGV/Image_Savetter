namespace Twitter_Image
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.Box_cf = new System.Windows.Forms.TextBox();
            this.Btn_Cf = new System.Windows.Forms.Button();
            this.Label_cf = new System.Windows.Forms.Label();
            this.label_verify = new System.Windows.Forms.Label();
            this.Btn_LoginStatus = new System.Windows.Forms.Button();
            this.chkBox_Sample = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Apply = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.chkBox_Folder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Box_cf
            // 
            this.Box_cf.Location = new System.Drawing.Point(12, 107);
            this.Box_cf.Name = "Box_cf";
            this.Box_cf.Size = new System.Drawing.Size(298, 19);
            this.Box_cf.TabIndex = 0;
            // 
            // Btn_Cf
            // 
            this.Btn_Cf.Location = new System.Drawing.Point(316, 105);
            this.Btn_Cf.Name = "Btn_Cf";
            this.Btn_Cf.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cf.TabIndex = 1;
            this.Btn_Cf.Text = "参照";
            this.Btn_Cf.UseVisualStyleBackColor = true;
            this.Btn_Cf.Click += new System.EventHandler(this.Btn_Cf_Click);
            // 
            // Label_cf
            // 
            this.Label_cf.AutoSize = true;
            this.Label_cf.Location = new System.Drawing.Point(14, 92);
            this.Label_cf.Name = "Label_cf";
            this.Label_cf.Size = new System.Drawing.Size(47, 12);
            this.Label_cf.TabIndex = 2;
            this.Label_cf.Text = "・保存先";
            // 
            // label_verify
            // 
            this.label_verify.AutoSize = true;
            this.label_verify.Location = new System.Drawing.Point(14, 29);
            this.label_verify.Name = "label_verify";
            this.label_verify.Size = new System.Drawing.Size(35, 12);
            this.label_verify.TabIndex = 3;
            this.label_verify.Text = "・認証";
            // 
            // Btn_LoginStatus
            // 
            this.Btn_LoginStatus.Location = new System.Drawing.Point(12, 44);
            this.Btn_LoginStatus.Name = "Btn_LoginStatus";
            this.Btn_LoginStatus.Size = new System.Drawing.Size(75, 23);
            this.Btn_LoginStatus.TabIndex = 4;
            this.Btn_LoginStatus.Text = "ログイン状況";
            this.Btn_LoginStatus.UseVisualStyleBackColor = true;
            this.Btn_LoginStatus.Click += new System.EventHandler(this.Btn_LoginStatus_Click);
            // 
            // chkBox_Sample
            // 
            this.chkBox_Sample.AutoSize = true;
            this.chkBox_Sample.Location = new System.Drawing.Point(16, 176);
            this.chkBox_Sample.Name = "chkBox_Sample";
            this.chkBox_Sample.Size = new System.Drawing.Size(281, 16);
            this.chkBox_Sample.TabIndex = 5;
            this.chkBox_Sample.Text = "サンプルモード (全タイムラインよりランダムに取得します)";
            this.chkBox_Sample.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "・ストリームについて";
            // 
            // Btn_Apply
            // 
            this.Btn_Apply.Location = new System.Drawing.Point(259, 250);
            this.Btn_Apply.Name = "Btn_Apply";
            this.Btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.Btn_Apply.TabIndex = 7;
            this.Btn_Apply.Text = "適用";
            this.Btn_Apply.UseVisualStyleBackColor = true;
            this.Btn_Apply.Click += new System.EventHandler(this.Btn_Apply_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(340, 250);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "キャンセル";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // chkBox_Folder
            // 
            this.chkBox_Folder.AutoSize = true;
            this.chkBox_Folder.Location = new System.Drawing.Point(16, 198);
            this.chkBox_Folder.Name = "chkBox_Folder";
            this.chkBox_Folder.Size = new System.Drawing.Size(171, 16);
            this.chkBox_Folder.TabIndex = 9;
            this.chkBox_Folder.Text = "ユーザー毎にフォルダー分けする";
            this.chkBox_Folder.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 276);
            this.Controls.Add(this.chkBox_Folder);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Apply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBox_Sample);
            this.Controls.Add(this.Btn_LoginStatus);
            this.Controls.Add(this.label_verify);
            this.Controls.Add(this.Label_cf);
            this.Controls.Add(this.Btn_Cf);
            this.Controls.Add(this.Box_cf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box_cf;
        private System.Windows.Forms.Button Btn_Cf;
        private System.Windows.Forms.Label Label_cf;
        private System.Windows.Forms.Label label_verify;
        private System.Windows.Forms.Button Btn_LoginStatus;
        private System.Windows.Forms.CheckBox chkBox_Sample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Apply;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.CheckBox chkBox_Folder;
    }
}