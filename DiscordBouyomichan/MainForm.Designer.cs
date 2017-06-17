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
            this.btnLogin = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslBouyomiConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbBotClientId = new System.Windows.Forms.TextBox();
            this.lMail = new System.Windows.Forms.Label();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tbBotToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msHelp = new System.Windows.Forms.MenuStrip();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tbChatFormat = new System.Windows.Forms.TextBox();
            this.lChatFormat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.msHelp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(57, 92);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "ログイン";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslBouyomiConnection});
            this.statusStrip.Location = new System.Drawing.Point(0, 325);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslBouyomiConnection
            // 
            this.tsslBouyomiConnection.AutoSize = false;
            this.tsslBouyomiConnection.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslBouyomiConnection.Name = "tsslBouyomiConnection";
            this.tsslBouyomiConnection.Size = new System.Drawing.Size(155, 19);
            this.tsslBouyomiConnection.Text = "棒読みちゃん未接続";
            // 
            // tbBotClientId
            // 
            this.tbBotClientId.Location = new System.Drawing.Point(57, 42);
            this.tbBotClientId.Name = "tbBotClientId";
            this.tbBotClientId.Size = new System.Drawing.Size(400, 19);
            this.tbBotClientId.TabIndex = 5;
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Location = new System.Drawing.Point(6, 45);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(50, 12);
            this.lMail.TabIndex = 7;
            this.lMail.Text = "Client ID";
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.button4);
            this.gbAccount.Controls.Add(this.tbBotToken);
            this.gbAccount.Controls.Add(this.btnLogin);
            this.gbAccount.Controls.Add(this.label1);
            this.gbAccount.Controls.Add(this.tbBotClientId);
            this.gbAccount.Controls.Add(this.lMail);
            this.gbAccount.Location = new System.Drawing.Point(12, 27);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(467, 124);
            this.gbAccount.TabIndex = 15;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Discord Bot アカウント";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "BOT作成";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbBotToken
            // 
            this.tbBotToken.Location = new System.Drawing.Point(57, 67);
            this.tbBotToken.Name = "tbBotToken";
            this.tbBotToken.PasswordChar = '*';
            this.tbBotToken.Size = new System.Drawing.Size(400, 19);
            this.tbBotToken.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Token";
            // 
            // msHelp
            // 
            this.msHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpHToolStripMenuItem});
            this.msHelp.Location = new System.Drawing.Point(0, 0);
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(484, 24);
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
            // tsmiWebsite
            // 
            this.tsmiWebsite.Name = "tsmiWebsite";
            this.tsmiWebsite.Size = new System.Drawing.Size(232, 22);
            this.tsmiWebsite.Text = "DiscordBouyomichan Website";
            this.tsmiWebsite.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // tsmiAck
            // 
            this.tsmiAck.Name = "tsmiAck";
            this.tsmiAck.Size = new System.Drawing.Size(232, 22);
            this.tsmiAck.Text = "Acknowledgements && Credits";
            this.tsmiAck.Click += new System.EventHandler(this.acknowledgementsToolStripMenuItem_Click);
            // 
            // tsmiLicense
            // 
            this.tsmiLicense.Name = "tsmiLicense";
            this.tsmiLicense.Size = new System.Drawing.Size(232, 22);
            this.tsmiLicense.Text = "License(&L)";
            this.tsmiLicense.Click += new System.EventHandler(this.licenseLToolStripMenuItem_Click);
            // 
            // tbChatFormat
            // 
            this.tbChatFormat.Enabled = false;
            this.tbChatFormat.Location = new System.Drawing.Point(289, 293);
            this.tbChatFormat.Name = "tbChatFormat";
            this.tbChatFormat.Size = new System.Drawing.Size(180, 19);
            this.tbChatFormat.TabIndex = 17;
            this.tbChatFormat.Text = "{0} {1}";
            // 
            // lChatFormat
            // 
            this.lChatFormat.AutoSize = true;
            this.lChatFormat.Location = new System.Drawing.Point(181, 296);
            this.lChatFormat.Name = "lChatFormat";
            this.lChatFormat.Size = new System.Drawing.Size(100, 12);
            this.lChatFormat.TabIndex = 12;
            this.lChatFormat.Text = "読み上げフォーマット";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "接続先ギルド一覧取得";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Botを新しいギルドに追加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(8, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 64);
            this.listBox1.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "選択したギルドからBotを削除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "Botが接続しているギルド一覧";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 117);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接続先ギルド制御";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lChatFormat);
            this.Controls.Add(this.tbChatFormat);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.msHelp.ResumeLayout(false);
            this.msHelp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox tbBotClientId;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.ToolStripStatusLabel tsslBouyomiConnection;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.MenuStrip msHelp;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmiAck;
        private System.Windows.Forms.ToolStripMenuItem tsmiWebsite;
        private System.Windows.Forms.TextBox tbChatFormat;
        private System.Windows.Forms.Label lChatFormat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbBotToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
    }
}

