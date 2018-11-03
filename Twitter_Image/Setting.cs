using System;
using System.Windows.Forms;

namespace Twitter_Image
{
    public partial class Setting : Form
    {
        private Main form1;

        public Setting()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Btn_Cf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "画像の保存先フォルダーを選択してください。";
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.Cancel)
            {
                return; 
            }
            // Get folder path
            string fileName = folderBrowserDialog.SelectedPath;
            folderBrowserDialog.Dispose();
            Box_cf.Text = fileName+"\\";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_LoginStatus_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Enabled = false;
            login.FormClosed += new FormClosedEventHandler(f_FormClosed);
        }
        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        private void Btn_Apply_Click(object sender, EventArgs e)
        {
            if (form1.Streaming == false)
            {
                form1.Sample = chkBox_Sample.Checked;
                Properties.Settings.Default.Sample = chkBox_Sample.Checked;
            }
            else  MessageBox.Show("ストリーミングを終了後、設定しなおしてください"); 
            form1.Path= Box_cf.Text;
            form1.Folder_User = chkBox_Folder.Checked;
            Properties.Settings.Default.Folder = chkBox_Folder.Checked;
            if (System.IO.Directory.Exists(Box_cf.Text))    //  Folder exist or not
                Properties.Settings.Default.SaveTo = Box_cf.Text;
            else
            {
                MessageBox.Show("ディレクトリは存在しません");
                return;
            }
            Properties.Settings.Default.Save();
            Close();
        }

    
        private void Setting_Load(object sender, EventArgs e)
        {
            form1 = new Main();
            chkBox_Sample.Checked =  form1.Sample;
            chkBox_Folder.Checked = form1.Folder_User;
            Box_cf.Text = form1.Path;
        }
    }
}
