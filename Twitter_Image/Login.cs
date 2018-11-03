using CoreTweet;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter_Image
{

    public partial class Login : Form
    {
        public Main form1;

        public OAuth.OAuthSession session;
        public Tokens tokens;

        public Login()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Btn_Verify_Click(object sender, EventArgs e)
        {
            var pin = Box_Pin.Text;
            if (pin != null)
            {
                 var task = Task.Run(() =>
                 {
                    try {
                        tokens = OAuth.GetTokens(session, pin.ToString());
                        Label_Verified.Text = "@"+tokens.ScreenName+"でログイン中";
                        form1.Token = tokens;
                        form1.ScreenName = tokens.ScreenName;
                        Btn_Verify.Enabled = false;
                        Box_Pin.Enabled = false;
                        
                    }
                    catch {
                        MessageBox.Show("ログインできませんでした\nやり直してください");
                    }
                 });
            }else MessageBox.Show("Pinコードを入力してください");
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Pin_Click(object sender, EventArgs e)
        {
            Btn_Verify.Enabled = true;
            Box_Pin.Enabled = true;
            var task = Task.Run(() =>
            {
                session = OAuth.Authorize("ydvfSAdpXtw68Zox4AZCzxf1r", "bFHIGBINRylbpPGQMyorqYMhYVoGq07o2qM88fcOlXpDR7wrM6");
                var token_url = session.AuthorizeUri.ToString();
                System.Diagnostics.Process.Start(token_url);     // launch the default browser
            });
        }

        private void Login_Load(object sender, EventArgs e)
        {
            form1 = new Main();
            if(form1.ScreenName != null)
            { 
            Label_Verified.Text =string.Format("@{0}でログイン中",form1.ScreenName);
                if (form1.Streaming)  Btn_Pin.Enabled = false;
            }
        }
    }
}
