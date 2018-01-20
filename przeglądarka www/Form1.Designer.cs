using System.Windows.Forms;

namespace przeglądarka_www
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulubioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmwebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urodzinyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muzykaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastfmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletyNaKoncertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.właściwościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZamknijKarteBtn = new System.Windows.Forms.Button();
            this.NowaKartaBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTabControl = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StatusBar = new System.Windows.Forms.ToolStrip();
            this.StatusBarLink = new System.Windows.Forms.ToolStripLabel();
            this.StatusBarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTabControl.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.ulubioneToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.właściwościToolStripMenuItem,
            this.wyjścieToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // ulubioneToolStripMenuItem
            // 
            this.ulubioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookToolStripMenuItem,
            this.filmwebToolStripMenuItem,
            this.blogToolStripMenuItem,
            this.butyToolStripMenuItem,
            this.urodzinyToolStripMenuItem,
            this.muzykaToolStripMenuItem});
            this.ulubioneToolStripMenuItem.Name = "ulubioneToolStripMenuItem";
            this.ulubioneToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ulubioneToolStripMenuItem.Text = "Ulubione";
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // filmwebToolStripMenuItem
            // 
            this.filmwebToolStripMenuItem.Name = "filmwebToolStripMenuItem";
            this.filmwebToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.filmwebToolStripMenuItem.Text = "Filmweb";
            this.filmwebToolStripMenuItem.Click += new System.EventHandler(this.filmwebToolStripMenuItem_Click);
            // 
            // blogToolStripMenuItem
            // 
            this.blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            this.blogToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.blogToolStripMenuItem.Text = "blog";
            this.blogToolStripMenuItem.Click += new System.EventHandler(this.blogToolStripMenuItem_Click);
            // 
            // butyToolStripMenuItem
            // 
            this.butyToolStripMenuItem.Name = "butyToolStripMenuItem";
            this.butyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.butyToolStripMenuItem.Text = "buty";
            this.butyToolStripMenuItem.Click += new System.EventHandler(this.butyToolStripMenuItem_Click);
            // 
            // urodzinyToolStripMenuItem
            // 
            this.urodzinyToolStripMenuItem.Name = "urodzinyToolStripMenuItem";
            this.urodzinyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.urodzinyToolStripMenuItem.Text = "urodziny";
            this.urodzinyToolStripMenuItem.Click += new System.EventHandler(this.urodzinyToolStripMenuItem_Click);
            // 
            // muzykaToolStripMenuItem
            // 
            this.muzykaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spotifyToolStripMenuItem,
            this.lastfmToolStripMenuItem,
            this.biletyNaKoncertToolStripMenuItem});
            this.muzykaToolStripMenuItem.Name = "muzykaToolStripMenuItem";
            this.muzykaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.muzykaToolStripMenuItem.Text = "muzyka";
            // 
            // spotifyToolStripMenuItem
            // 
            this.spotifyToolStripMenuItem.Name = "spotifyToolStripMenuItem";
            this.spotifyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.spotifyToolStripMenuItem.Text = "Spotify";
            this.spotifyToolStripMenuItem.Click += new System.EventHandler(this.spotifyToolStripMenuItem_Click);
            // 
            // lastfmToolStripMenuItem
            // 
            this.lastfmToolStripMenuItem.Name = "lastfmToolStripMenuItem";
            this.lastfmToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.lastfmToolStripMenuItem.Text = "lastfm";
            this.lastfmToolStripMenuItem.Click += new System.EventHandler(this.lastfmToolStripMenuItem_Click);
            // 
            // biletyNaKoncertToolStripMenuItem
            // 
            this.biletyNaKoncertToolStripMenuItem.Name = "biletyNaKoncertToolStripMenuItem";
            this.biletyNaKoncertToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.biletyNaKoncertToolStripMenuItem.Text = "bilety na koncert";
            this.biletyNaKoncertToolStripMenuItem.Click += new System.EventHandler(this.biletyNaKoncertToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // właściwościToolStripMenuItem
            // 
            this.właściwościToolStripMenuItem.Name = "właściwościToolStripMenuItem";
            this.właściwościToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.właściwościToolStripMenuItem.Text = "Właściwości";
            this.właściwościToolStripMenuItem.Click += new System.EventHandler(this.właściwościToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ZamknijKarteBtn);
            this.panel1.Controls.Add(this.NowaKartaBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 53);
            this.panel1.TabIndex = 1;
            // 
            // ZamknijKarteBtn
            // 
            this.ZamknijKarteBtn.Location = new System.Drawing.Point(988, 12);
            this.ZamknijKarteBtn.Name = "ZamknijKarteBtn";
            this.ZamknijKarteBtn.Size = new System.Drawing.Size(132, 23);
            this.ZamknijKarteBtn.TabIndex = 24;
            this.ZamknijKarteBtn.Text = "Zamknij aktywną kartę";
            this.ZamknijKarteBtn.UseVisualStyleBackColor = true;
            this.ZamknijKarteBtn.Click += new System.EventHandler(this.ZamknijKarteBtn_Click);
            // 
            // NowaKartaBtn
            // 
            this.NowaKartaBtn.Location = new System.Drawing.Point(907, 12);
            this.NowaKartaBtn.Name = "NowaKartaBtn";
            this.NowaKartaBtn.Size = new System.Drawing.Size(75, 23);
            this.NowaKartaBtn.TabIndex = 23;
            this.NowaKartaBtn.Text = "Nowa Karta";
            this.NowaKartaBtn.UseVisualStyleBackColor = true;
            this.NowaKartaBtn.Click += new System.EventHandler(this.NowaKartaBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(564, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(94, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Odśwież";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(745, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Wyszukaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(826, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cofnij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelTabControl
            // 
            this.panelTabControl.Controls.Add(this.tabControl1);
            this.panelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabControl.Location = new System.Drawing.Point(0, 77);
            this.panelTabControl.Name = "panelTabControl";
            this.panelTabControl.Size = new System.Drawing.Size(1193, 467);
            this.panelTabControl.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1193, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // StatusBar
            // 
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLink,
            this.StatusBarProgress,
            this.toolStripSeparator1,
            this.StatusBarLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 544);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1193, 25);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "toolStrip1";
            // 
            // StatusBarLink
            // 
            this.StatusBarLink.Name = "StatusBarLink";
            this.StatusBarLink.Size = new System.Drawing.Size(29, 22);
            this.StatusBarLink.Text = "Link";
            // 
            // StatusBarProgress
            // 
            this.StatusBarProgress.Name = "StatusBarProgress";
            this.StatusBarProgress.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(39, 22);
            this.StatusBarLabel.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 569);
            this.Controls.Add(this.panelTabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StatusBar);
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przeglądarka internetowa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTabControl.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulubioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmwebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urodzinyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muzykaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spotifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastfmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletyNaKoncertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem właściwościToolStripMenuItem;
        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panelTabControl;
        private Button NowaKartaBtn;
        private Button ZamknijKarteBtn;
        private TabControl tabControl1;
        private ToolStrip StatusBar;
        private ToolStripProgressBar StatusBarProgress;
        private ToolStripLabel StatusBarLabel;
        private ToolStripLabel StatusBarLink;
        private ToolStripSeparator toolStripSeparator1;
    }
}

