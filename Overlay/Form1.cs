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
        bool InMainScreen = true;
        bool UnavailableEmbed = false;

        Point MouseDownPoint = Point.Empty;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            FormSize = new Size(720, 76);

            CheckForIllegalCrossThreadCalls = false;
            //WB.DocumentText = "<html><body style='background-color:#646464;'></html></body>";
            WB.DocumentCompleted += WB_DocumentCompleted;

            t.Interval = 20;
            t.Tick += t_Tick;
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (ExpandForm)
            {
                this.Size = new Size(FormSize.Width += 16, FormSize.Height += 9);
                drag_panel.Size = new Size(FormSize.Width, 30);
                exit_program.Location = new Point(FormSize.Width - 30, 0);
                WB.Size = new Size(FormSize.Width, FormSize.Height - 30);
            }
            if (ContractForm)
            {
                if (exit_program.Location.X > contract.Location.X + 30)
                {
                    this.Size = new Size(FormSize.Width -= 16, FormSize.Height -= 9);
                    drag_panel.Size = new Size(FormSize.Width, 30);
                    exit_program.Location = new Point(FormSize.Width - 30, 0);
                    WB.Size = new Size(FormSize.Width, FormSize.Height - 30);
                }
            }


            if (WB.Document != null)
            {
                try
                {
                    var links = WB.Document.GetElementsByTagName("a");
                    foreach (HtmlElement link in links)
                    {
                        if (link.GetAttribute("className") == "ytp-error-content-wrap")
                        {
                            MessageBox.Show("");
                        }
                    }
                    //textBox1.Text = WB.Document.GetElementById("player").Children[0]
                }
                catch { }

                //textBox1.Text = WB.Document.GetElementById("player").FirstChild.InnerHtml;//WB.Document.ActiveElement.InnerHtml;//WB.Document.GetElementsByTagName("full-frame").GetElementsByName("ytp-error html5-stop-propagation").Count.ToString();

                //textBox1.Text = WB.Document.GetElementsByTagName("full-frame").Count.ToString();
                //textBox1.Text = WB.Document.GetElementById("ytp-error-content").InnerText;
                if (WB.DocumentText.Contains("ytp-error html5-stop-propagation"))
                {
                    MessageBox.Show("");
                    //ytp-error html5-stop-propagation
                    //ytp-tv-static
                    //ytp-error-content
                    //ytp-error-content-wrap
                    //This video contains content from VEVO. It is restricted from playback on certain sites.
                    UnavailableEmbed = true;
                    //WB.GoBack();
                    //MessageBox.Show("");
                }
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
                label2.Text = "Now playing: " + WB.Document.Title.Replace(" - YouTube", "");
                if (WB.Url.ToString().Contains("youtube.com/watch?v="))
                {
                    if (!UnavailableEmbed)
                    {
                        LoadSearch(WB.Url.ToString(), false);
                    }
                }
            }
        }
        void LoadSearch(string Search, bool BackMainScreen)
        {
            web_panel.Hide();
            web_address_background.Hide();
            submit_web_search.Hide();
            web_search.Hide();

            if (Search.Contains("youtube.com/watch?v="))
            {
                if (BackMainScreen)
                {
                    InMainScreen = false;
                }
                string[] VideoString = Search.Split(new string[] { "youtube.com/watch?v=" }, StringSplitOptions.None);
                Search = "https://www.youtube.com/embed/" + VideoString[1] + "?feature=player_embedded&autoplay=1&controls=1&cc_load_policy=0&iv_load_policy=3&vq=hd1080&modestbranding=1&rel=0&showinfo=1";
                WB.Navigate(Search);
            }
            else if (Search.Contains("youtube.com/v/"))
            {
                if (BackMainScreen)
                {
                    InMainScreen = false;
                }
                string[] VideoString = Search.Split(new string[] { "youtube.com/v/" }, StringSplitOptions.None);
                Search = "https://www.youtube.com/embed/" + VideoString[1] + "?feature=player_embedded&autoplay=1&controls=1&cc_load_policy=0&iv_load_policy=3&vq=hd1080&modestbranding=1&rel=0&showinfo=1";
                WB.Navigate(Search);
            }
            else
            {
                WB.ScrollBarsEnabled = true;
                //WB.Navigate("https://www.google.com/?gws_rd=ssl#q=" + web_search.Text.Replace(" ", "+"));
                WB.Navigate("https://www.youtube.com/embed/e-ORhEE9VVg?feature=player_embedded&autoplay=1"); //Testing blocked videos
               // WB.Navigate("https://www.youtube.com/results?search_query=" + web_search.Text.Replace(" ", "+"));
            }
        }

        #region Drag Panel Mouse Control
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

        #region Controls
        private void webpage_back_Click(object sender, EventArgs e)
        {
            if (!InMainScreen)
            {
                WB.DocumentText = "<html><body style='background-color:#646464;'></html></body>";
                InMainScreen = true;
                web_panel.Show();
                web_search.Show();
                web_address_background.Show();
                submit_web_search.Show();

                this.Size = new Size(720, 76);
                FormSize = this.Size;
                drag_panel.Size = new Size(FormSize.Width, 30);
                exit_program.Location = new Point(FormSize.Width - 30, 0);
                WB.Size = new Size(720, 405);
            }
            else
            {
                WB.GoBack();
                WB.GoBack();
            }
        }
        private void exit_program_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #endregion

        private void submit_web_search_Click(object sender, EventArgs e)
        {
            this.Size = new Size(720, 435);
            FormSize = this.Size;
            LoadSearch(web_search.Text, true);
        }
        private void web_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Size = new Size(720, 435);
                FormSize = this.Size;
                LoadSearch(web_search.Text, true);
            }
        }
    }
}
