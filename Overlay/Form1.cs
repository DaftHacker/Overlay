using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyState;
using System.Threading;

namespace Overlay
{
    public partial class Form1 : Form
    {
        bool SettingsOpen = false;

        bool FormToggle = false;
        int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        Size FormSize;
        bool ExpandForm = false;
        bool ContractForm = false;


        Point MouseDownPoint = Point.Empty;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            FormSize = new Size(720, 76);

            CheckForIllegalCrossThreadCalls = false;
            WB.DocumentText = "<html><body style='background-color:#646464;'></html></body>";
            WB.DocumentCompleted += WB_DocumentCompleted;

            t.Interval = 20;
            t.Tick += t_Tick;
            t.Start();

            //Thread MonitorKeyPress = new Thread(MonitorKeyPresses);
            //MonitorKeyPress.IsBackground = true;
            //MonitorKeyPress.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (ExpandForm)
            {
                this.Size = new Size(FormSize.Width += 16, FormSize.Height += 9);
                drag_panel.Size = new Size(this.Size.Width, 30);
                exit_program.Location = new Point(drag_panel.Width - 30, 0);
                WB.Size = new Size(this.Size.Width, this.Size.Height - 30);
            }
            if (ContractForm)
            {
                if (exit_program.Location.X > contract.Location.X + 30)
                {
                    this.Size = new Size(FormSize.Width -= 16, FormSize.Height -= 9);
                    drag_panel.Size = new Size(this.Size.Width, 30);
                    exit_program.Location = new Point(drag_panel.Width - 30, 0);
                    WB.Size = new Size(this.Size.Width, this.Size.Height - 30);

                }
            }

            if (WB.Document != null)
            {
                //MessageBox.Show(WB.Document.Title);
                try
                {
                    //MessageBox.Show(WB.Document.GetElementsByTagName("yt-error-content").Count.ToString());
                    //MessageBox.Show(WB.Document.GetElementById("player").InnerHtml);
                    //if (WB.Document.GetElementById("player").InnerText.ToString().Contains("restricted from playback on certain sites."))
                    //{
                    //     //MessageBox.Show("");
                    //}
                }
                catch { }
            }


            if (!FormToggle)
            {
                TopMost = true;
            }
            if (KeyListener.GetActiveKeys().Contains("|Numpad 0|"))
            {
                if (FormToggle)
                {
                    //ShowForm
                    FormToggle = false;
                    WindowState = FormWindowState.Normal;
                    TopMost = true;
                }
                else
                {
                    //HideForm
                    FormToggle = true;
                    WindowState = FormWindowState.Minimized;
                    TopMost = false;
                }
                Thread.Sleep(150);
            }
        }

        void WB_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (WB.Document != null)
            {
                //MessageBox.Show(WB.Document.GetElementsByTagName("yt-error-content").Cast<HtmlElement>().FirstOrDefault().InnerText);
                //MessageBox.Show(WB.DocumentText.ToString());
                //It is restricted from playback on certain sites.
                if (WB.Url.ToString().Contains("www.youtube.com/v/"))
                {
                    //MessageBox.Show(WB.Document.Body.OuterText);
                    //if (WB.)
                }
                if (WB.Url.ToString().Contains("watch?v="))
                {
                    LoadVideo(WB.Url.ToString());
                    return;
                }
                //if (WB.ScrollBarsEnabled)
                //{
                //    WB.Document.Body.Style = "zoom:100%;";
                //}
            }
        }
        void LoadVideo(string VideoURL)
        {
            web_panel.Hide();
            web_address_background.Hide();
            submit_web_address.Hide();
            web_address.Hide();

            if (VideoURL.Contains("watch?v="))
            {
                string[] VideoString = VideoURL.Split(new string[] { "watch?v=" }, StringSplitOptions.None);
                VideoURL = "https://www.youtube.com/v/" + VideoString[1];
                WB.Navigate(VideoURL + "&autoplay=1&controls=1&cc_load_policy=0&iv_load_policy=3&vq=hd1080&modestbranding=1&rel=0&showinfo=1");
            }
            else
            {
                WB.ScrollBarsEnabled = true;
                //WB.ClientSize = new Size(100, 100); Resize window
                //WB.Navigate("https://www.youtube.com/v/e-ORhEE9VVg&autoplay=1");
                WB.Navigate("https://www.youtube.com/results?search_query=" + web_address.Text.Replace(" ", "+"));
            }
        }

        private void VideoSource_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Size = new Size(720, 435);
                FormSize = this.Size;
                LoadVideo(web_address.Text);
            }
        }
        private void SubmitVideo_Click(object sender, EventArgs e)
        {
            this.Size = new Size(720, 435);
            FormSize = this.Size;
            LoadVideo(web_address.Text);
        }

        #region Drag panel mouse control
        private void drag_panel_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownPoint = Point.Empty;
        }
        private void drag_panel_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownPoint = new Point(e.X, e.Y);
        }
        private void drag_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MouseDownPoint.IsEmpty)
            {
                this.Location = new Point(this.Location.X + (e.X - MouseDownPoint.X), this.Location.Y + (e.Y - MouseDownPoint.Y));
            }
        }
        #endregion

        private void exit_program_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void webpage_back_Click(object sender, EventArgs e)
        {
            WB.GoBack();
            WB.GoBack();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            if (!SettingsOpen)
                SettingsOpen = true;
            else
                SettingsOpen = false;
            Thread Animation = new Thread(SettingsAnimation);
            Animation.Start();
        }
        private void SettingsAnimation()
        {
            if (SettingsOpen)
                for (int i = 0; i <= 406; i++)
                    settings_panel.Size = new Size(720, i);
            else
                for (int i = 406; i >= 0; i--)
                    settings_panel.Size = new Size(720, i);
        }

        private void expand_MouseDown(object sender, MouseEventArgs e)
        {
            if (FormSize != new Size(720, 76))
            {
                ExpandForm = true;
            }
        }
        private void expand_MouseUp(object sender, MouseEventArgs e)
        {
            ExpandForm = false;
        }
        private void contract_MouseDown(object sender, MouseEventArgs e)
        {
            if (FormSize != new Size(720, 76))
            {
                ContractForm = true;
            }
        }
        private void contract_MouseUp(object sender, MouseEventArgs e)
        {
            ContractForm = false;
        }
    }
}
