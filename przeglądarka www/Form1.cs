using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przeglądarka_www
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor programu: Paula Gajewska, grupa K23. Program powstał w roku: 2018. Wersja 1.0");

        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount>0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate(textBox1.Text);
                //tabControl1.SelectedTab.Text = aktywny.DocumentTitle.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate("https://www.google.pl/?gws_rd=ssl");
            }
            //webBrowser1.Navigate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.GoBack();
            }
            //webBrowser1.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.GoForward();
            }
            //webBrowser1.GoForward();
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate("https://www.facebook.pl");
                tabControl1.SelectedTab.Text = "FaceBook";
            }
            //webBrowser1.Navigate("https://www.facebook.pl");
        }

        private void filmwebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate("https://filmweb.pl");
                tabControl1.SelectedTab.Text = "FilmWeb";
            }
            //webBrowser1.Navigate("https://filmweb.pl");
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate("https://tumblr.com");
                tabControl1.SelectedTab.Text = "Tumblr";
            }
            //webBrowser1.Navigate("https://tumblr.com");
        }

        private void butyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate("https://deezee.pl");
                tabControl1.SelectedTab.Text = "Deezee";
            }
            //webBrowser1.Navigate("https://deezee.pl");
        }

        private void urodzinyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate("https://ikea.pl");
                tabControl1.SelectedTab.Text = "Ikea";
            }
            //webBrowser1.Navigate("https://ikea.pl");
        }

        private void spotifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate("https://spotify.pl");
                tabControl1.SelectedTab.Text = "Spotify";
            }
            //webBrowser1.Navigate("https://spotify.pl");
        }

        private void lastfmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate("https://lastfm.pl");
                tabControl1.SelectedTab.Text = "LastFm";
            }
            //webBrowser1.Navigate("https://lastfm.pl");
        }

        private void biletyNaKoncertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.Navigate("http://www.eventim.pl/");
                tabControl1.SelectedTab.Text = "Eventim";
            }
            //webBrowser1.Navigate("http://www.eventim.pl/");
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.ShowSaveAsDialog();
            }
            //webBrowser1.ShowSaveAsDialog();
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.ShowPrintDialog();
            }
            //webBrowser1.ShowPrintDialog();
        }

        private void właściwościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                aktywny.ShowPropertiesDialog();
            }
            //webBrowser1.ShowPropertiesDialog();
        }

        private void NowaKartaBtn_Click(object sender, EventArgs e)
        {
            NowaKarta();
        }

        
        private void NowaKarta(string link = "")
        {
            TabPage tp = new TabPage("TabPage" + (tabControl1.TabCount).ToString());
            tp.Text = "Nowa karta";
            tabControl1.TabPages.Add(tp);
            WebBrowser web = new WebBrowser();
            web.Dock = DockStyle.Fill;
            web.Name = tp.Name + "Web";
            web.DocumentTitleChanged += new EventHandler(webpage_DocumentTitleChanged);
            web.ProgressChanged += new WebBrowserProgressChangedEventHandler(webpage_ProgressChanged);
            web.StatusTextChanged += new EventHandler(webpage_StatusTextChanged);
            web.Navigated += new WebBrowserNavigatedEventHandler(webpage_Navigated);
            tp.Controls.Add(web);
            tabControl1.SelectedTab = tp;
            if (link!="")
            {
                web.Navigate(link);
            }
        }

        private void ZamknijKarteBtn_Click(object sender, EventArgs e)
        {
            TabPage tp = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(tp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NowaKarta("www.google.com");
        }

        
        #region WebBrowser Events

        private void webpage_DocumentTitleChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                tabControl1.SelectedTab.Text = aktywny.DocumentTitle.ToString();
            }
        }

        private void webpage_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            StatusBarProgress.Visible = true;
            StatusBarProgress.Maximum = (int)e.MaximumProgress;
            StatusBarProgress.Value = ((int)e.CurrentProgress < 0 || (int)e.MaximumProgress < (int)e.CurrentProgress) ? (int)e.MaximumProgress : (int)e.CurrentProgress;
            StatusBarProgress.Visible = false;
        }

        private void webpage_StatusTextChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                StatusBarLabel.Text = aktywny.StatusText;
            }
        }

        private void webpage_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                WebBrowser aktywny = tabControl1.SelectedTab.Controls.OfType<WebBrowser>().First();
                StatusBarLink.Text = aktywny.Url.ToString(); ;
            }
        }


        #endregion
        // Enter - naciśnięcie, przejście na stronę
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button3.PerformClick();
            }
        }
    }
}
