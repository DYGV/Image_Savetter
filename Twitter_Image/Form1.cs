using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;
using CoreTweet.Streaming;
namespace Twitter_Image
{
    public partial class Main : Form
    {
        private static string path;
        private static string sc;
        private static bool sample;
        private static bool folder;
        private static bool streaming;
        private static Tokens tokens;
        private int i = 0;
        private string dir;
        private string Screen_name;
        private string media;
        private IConnectableObservable<StreamingMessage> connectable;
        private IDisposable connection;

        public Tokens Token
        {
            set { tokens = value; Btn_Start.Enabled = true; }
            get { return tokens; }
        }
        public String Path
        {
            set { path = value; }
            get { return path; }
        }

        public String ScreenName
        {
            set { sc = value; }
            get { return sc; }
        }
        public bool Sample
        {
            set { sample = value; }
            get { return sample; }
        }
        public bool Folder_User
        {
            set { folder = value; }
            get { return folder; }
        }
        public bool Streaming
        {
            set { streaming = value; }
            get { return streaming; }
        }
        
        public Main()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Login_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Close_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Detail_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            Enabled = false;
            setting.FormClosed += new FormClosedEventHandler(f_FormClosed);
        }
        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            Enabled = true;
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            bool isFirst = true;
            Action<StatusMessage> Locale_prime = async (message) =>
            {
                Screen_name = message.Status.User.ScreenName;
                media = message.Status.ExtendedEntities.Media.First().MediaUrl;
                Box_Tweet.AppendText(string.Format("@{0} : {1}\n", Screen_name, media));
                Box_Tweet.AppendText(string.Format("---------------------------------------------------------------------------\n"));
         
                List<string> n_user = new List<string>();
                if (folder) // Divide into folder
                {   
                    dir = path + Screen_name + "\\";
                    if (Directory.Exists(dir)) // File exist or not
                    {
                        DirectoryInfo path_user = new DirectoryInfo(dir);
                        foreach (var file in path_user.EnumerateFiles())
                        {
                            var n_name = file.FullName;
                            n_user.Add(n_name);
                        }
                        i = n_user.Count(); // Number of existence file  
                    }
                    else
                    {
                        Directory.CreateDirectory(dir);
                        i = 0;
                    }
                }
                else
                {       
                    dir = path; // path is set by "setting", it is not necessary to check here
                    if (isFirst)
                    {
                        DirectoryInfo paht_user = new DirectoryInfo(dir);
                        foreach (var file in paht_user.EnumerateFiles()) // Enumerate existence file  
                        {
                            var n_name = file.FullName;
                            n_user.Add(n_name);
                        }
                        i = n_user.Count();
                        isFirst = false;        // One time processing
                    }
                }
                    await Task.Run(() =>
                  Download_Image(media, dir + (i++) + ".jpg"));
            };
           
            if (tokens == null)
                MessageBox.Show("設定→詳細設定からログインしてください");
            else if (path.Length == 0)
                MessageBox.Show("設定→詳細設定から保存先を設定してください");
            else
            {
                Box_Tweet.Enabled = true;
                Btn_Start.Enabled = false;
                Btn_Finish.Enabled = true;
                Streaming = true;
                DirectoryInfo dInfo = new DirectoryInfo(Path);

                if (sample) 
                    connectable = tokens.Streaming.SampleAsObservable().Publish();
                 else 
                    connectable = tokens.Streaming.UserAsObservable().Publish();
                
                connectable.OfType<StatusMessage>()
                           .Where(m => m.Status.Entities.Media!=null)
                           .Subscribe(Locale_prime);

                Box_Tweet.AppendText("ストリーミングを開始しました\n");
                connection = connectable.Connect();
            }
        }

        private async void Download_Image(string url, string path)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(
                url,
                HttpCompletionOption.ResponseContentRead);
            using (var fileStream = File.Create(path))
            using (var httpStream = await response.Content.ReadAsStreamAsync())
                httpStream.CopyTo(fileStream);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                Sample = Properties.Settings.Default.Sample;
                Path = Properties.Settings.Default.SaveTo;
                Folder_User = Properties.Settings.Default.Folder;
        }

        private void Btn_Finish_Click(object sender, EventArgs e)
        {
            connection.Dispose();
            Box_Tweet.AppendText("\nストリーミングを終了しました\n");
            Btn_Finish.Enabled = false;
            Btn_Start.Enabled = true;
            Streaming = false;
            
        }
    }
} 
