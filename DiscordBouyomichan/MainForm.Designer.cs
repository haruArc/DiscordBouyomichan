namespace DiscordBouyomichan
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbTargetChannel = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTargetServer = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslDiscordConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBouyomiConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lMail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lServer = new System.Windows.Forms.Label();
            this.lChannel = new System.Windows.Forms.Label();
            this.chkRestrictChannel = new System.Windows.Forms.CheckBox();
            this.chkOwn = new System.Windows.Forms.CheckBox();
            this.gbChannelRestrict = new System.Windows.Forms.GroupBox();
            this.chkBot = new System.Windows.Forms.CheckBox();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.msHelp = new System.Windows.Forms.MenuStrip();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.gbChannelRestrict.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.msHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTargetChannel
            // 
            this.lbTargetChannel.FormattingEnabled = true;
            this.lbTargetChannel.ItemHeight = 12;
            this.lbTargetChannel.Location = new System.Drawing.Point(74, 65);
            this.lbTargetChannel.Name = "lbTargetChannel";
            this.lbTargetChannel.Size = new System.Drawing.Size(188, 64);
            this.lbTargetChannel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ログイン";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTargetServer
            // 
            this.cbTargetServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTargetServer.FormattingEnabled = true;
            this.cbTargetServer.Location = new System.Drawing.Point(74, 39);
            this.cbTargetServer.Name = "cbTargetServer";
            this.cbTargetServer.Size = new System.Drawing.Size(188, 20);
            this.cbTargetServer.TabIndex = 2;
            this.cbTargetServer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDiscordConnection,
            this.tsslBouyomiConnection});
            this.statusStrip.Location = new System.Drawing.Point(0, 332);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(309, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslDiscordConnection
            // 
            this.tsslDiscordConnection.AutoSize = false;
            this.tsslDiscordConnection.Name = "tsslDiscordConnection";
            this.tsslDiscordConnection.Size = new System.Drawing.Size(155, 19);
            this.tsslDiscordConnection.Text = "Discord未接続";
            // 
            // tsslBouyomiConnection
            // 
            this.tsslBouyomiConnection.AutoSize = false;
            this.tsslBouyomiConnection.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslBouyomiConnection.Name = "tsslBouyomiConnection";
            this.tsslBouyomiConnection.Size = new System.Drawing.Size(155, 19);
            this.tsslBouyomiConnection.Text = "棒読みちゃん未接続";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 19);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(180, 19);
            this.textBox2.TabIndex = 6;
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Location = new System.Drawing.Point(6, 23);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(69, 12);
            this.lMail.TabIndex = 7;
            this.lMail.Text = "メールアドレス";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(8, 48);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(52, 12);
            this.lPassword.TabIndex = 8;
            this.lPassword.Text = "パスワード";
            // 
            // lServer
            // 
            this.lServer.AutoSize = true;
            this.lServer.Location = new System.Drawing.Point(6, 42);
            this.lServer.Name = "lServer";
            this.lServer.Size = new System.Drawing.Size(35, 12);
            this.lServer.TabIndex = 9;
            this.lServer.Text = "サーバ";
            // 
            // lChannel
            // 
            this.lChannel.AutoSize = true;
            this.lChannel.Location = new System.Drawing.Point(6, 65);
            this.lChannel.Name = "lChannel";
            this.lChannel.Size = new System.Drawing.Size(51, 12);
            this.lChannel.TabIndex = 10;
            this.lChannel.Text = "チャンネル";
            // 
            // chkRestrictChannel
            // 
            this.chkRestrictChannel.AutoSize = true;
            this.chkRestrictChannel.Location = new System.Drawing.Point(8, 17);
            this.chkRestrictChannel.Name = "chkRestrictChannel";
            this.chkRestrictChannel.Size = new System.Drawing.Size(176, 16);
            this.chkRestrictChannel.TabIndex = 11;
            this.chkRestrictChannel.Text = "読み上げるチャンネルを制限する";
            this.chkRestrictChannel.UseVisualStyleBackColor = true;
            // 
            // chkOwn
            // 
            this.chkOwn.AutoSize = true;
            this.chkOwn.Enabled = false;
            this.chkOwn.Location = new System.Drawing.Point(20, 140);
            this.chkOwn.Name = "chkOwn";
            this.chkOwn.Size = new System.Drawing.Size(177, 16);
            this.chkOwn.TabIndex = 12;
            this.chkOwn.Text = "自分自身のチャットを読み上げる";
            this.chkOwn.UseVisualStyleBackColor = true;
            // 
            // gbChannelRestrict
            // 
            this.gbChannelRestrict.Controls.Add(this.lbTargetChannel);
            this.gbChannelRestrict.Controls.Add(this.cbTargetServer);
            this.gbChannelRestrict.Controls.Add(this.chkRestrictChannel);
            this.gbChannelRestrict.Controls.Add(this.lChannel);
            this.gbChannelRestrict.Controls.Add(this.lServer);
            this.gbChannelRestrict.Enabled = false;
            this.gbChannelRestrict.Location = new System.Drawing.Point(12, 184);
            this.gbChannelRestrict.Name = "gbChannelRestrict";
            this.gbChannelRestrict.Size = new System.Drawing.Size(277, 140);
            this.gbChannelRestrict.TabIndex = 13;
            this.gbChannelRestrict.TabStop = false;
            this.gbChannelRestrict.Text = "チャンネル制限";
            // 
            // chkBot
            // 
            this.chkBot.AutoSize = true;
            this.chkBot.Checked = true;
            this.chkBot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBot.Enabled = false;
            this.chkBot.Location = new System.Drawing.Point(20, 162);
            this.chkBot.Name = "chkBot";
            this.chkBot.Size = new System.Drawing.Size(152, 16);
            this.chkBot.TabIndex = 14;
            this.chkBot.Text = "BOTのチャットを読み上げる";
            this.chkBot.UseVisualStyleBackColor = true;
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.button1);
            this.gbAccount.Controls.Add(this.textBox1);
            this.gbAccount.Controls.Add(this.textBox2);
            this.gbAccount.Controls.Add(this.lPassword);
            this.gbAccount.Controls.Add(this.lMail);
            this.gbAccount.Location = new System.Drawing.Point(12, 27);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(277, 107);
            this.gbAccount.TabIndex = 15;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Discordアカウント";
            // 
            // msHelp
            // 
            this.msHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpHToolStripMenuItem});
            this.msHelp.Location = new System.Drawing.Point(0, 0);
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(309, 24);
            this.msHelp.TabIndex = 16;
            this.msHelp.Text = "menuStrip1";
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWebsite,
            this.tsmiAck,
            this.tsmiLicense});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // tsmiLicense
            // 
            this.tsmiLicense.Name = "tsmiLicense";
            this.tsmiLicense.Size = new System.Drawing.Size(232, 22);
            this.tsmiLicense.Text = "License(&L)";
            this.tsmiLicense.Click += new System.EventHandler(this.licenseLToolStripMenuItem_Click);
            // 
            // tsmiAck
            // 
            this.tsmiAck.Name = "tsmiAck";
            this.tsmiAck.Size = new System.Drawing.Size(232, 22);
            this.tsmiAck.Text = "Acknowledgements && Credits";
            this.tsmiAck.Click += new System.EventHandler(this.acknowledgementsToolStripMenuItem_Click);
            // 
            // tsmiWebsite
            // 
            this.tsmiWebsite.Name = "tsmiWebsite";
            this.tsmiWebsite.Size = new System.Drawing.Size(232, 22);
            this.tsmiWebsite.Text = "DiscordBouyomichan Website";
            this.tsmiWebsite.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 356);
            this.Controls.Add(this.chkBot);
            this.Controls.Add(this.gbChannelRestrict);
            this.Controls.Add(this.chkOwn);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.msHelp);
            this.Controls.Add(this.gbAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msHelp;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DiscordBouyomichan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbChannelRestrict.ResumeLayout(false);
            this.gbChannelRestrict.PerformLayout();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.msHelp.ResumeLayout(false);
            this.msHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTargetChannel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTargetServer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslDiscordConnection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lServer;
        private System.Windows.Forms.Label lChannel;
        private System.Windows.Forms.CheckBox chkRestrictChannel;
        private System.Windows.Forms.CheckBox chkOwn;
        private System.Windows.Forms.GroupBox gbChannelRestrict;
        private System.Windows.Forms.CheckBox chkBot;
        private System.Windows.Forms.ToolStripStatusLabel tsslBouyomiConnection;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.MenuStrip msHelp;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiAck;
        private System.Windows.Forms.ToolStripMenuItem tsmiWebsite;
    }
}

