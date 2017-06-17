using System;
using System.Linq;
using System.Windows.Forms;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace DiscordBouyomichan
{
    public partial class MainForm : Form
    {
        delegate void ConnectionFailed_Delegate();
        delegate void MessageEvent_Delegate(SocketMessage e);
        private DiscordSocketClient client = new DiscordSocketClient();
        private BouyomichanClient bcc = new BouyomichanClient();
        
        public MainForm()
        {
            InitializeComponent();
            client.MessageReceived += Client_MessageReceived;
            tbBotClientId.Text = Properties.Settings.Default.mail;
            tbBotToken.Text = Properties.Settings.Default.password;
            tbChatFormat.Text = Properties.Settings.Default.chatFormat;
        }

        private void button1_Click(object sender, EventArgs ea)
        {
            string login = tbBotToken.Text;

            gbAccount.Enabled = false;
            groupBox1.Enabled = true;
            client.Log += Client_Log;
            try
            {
                //棒読みちゃん接続確認
                int dammy = bcc.TalkTaskCount;
                statusStrip.Items[0].Text = "棒読みちゃん接続済";
            }
            catch
            {
                statusStrip.Items[0].Text = "棒読みちゃん未接続";
            }

            Task.Run(async () =>
            {
                await client.LoginAsync(TokenType.Bot, login);
                await client.StartAsync();
                await Task.Delay(-1);
            });
        }

        private Task Client_Log(LogMessage arg)
        {
            Console.WriteLine(arg.Message);
            return Task.CompletedTask;
        }

        private Task Client_MessageReceived(SocketMessage arg)
        {
            Invoke(new MessageEvent_Delegate(TalkTask), new object[] { arg });
            return Task.CompletedTask;
        }

        private void TalkTask(SocketMessage e)
        {
            try
            {
               // bcc.AddTalkTask(String.Format(tbChatFormat.Text, e.Message.User.Name, e.Message.Text, e.Message.Server.Name, e.Message.Channel.Name));

                bcc.AddTalkTask(String.Format(tbChatFormat.Text, e.Author.Username, e.Content));
                statusStrip.Items[0].Text = "棒読みちゃん接続済";
            }
            catch
            {
                statusStrip.Items[0].Text = "棒読みちゃん未接続";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.mail = tbBotClientId.Text;
            Properties.Settings.Default.chatFormat = tbChatFormat.Text;
            Properties.Settings.Default.password = tbBotToken.Text;

            Properties.Settings.Default.Save();
        }

        private void licenseLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseForm f = new DiscordBouyomichan.LicenseForm("license\\license.html");
            f.ShowDialog();
            f.Dispose();
        }

        private void acknowledgementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseForm f = new DiscordBouyomichan.LicenseForm("license\\acknowledgements.html");
            f.ShowDialog();
            f.Dispose();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.arcenserv.info/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IGuild guild in client.Guilds)
            {
                listBox1.Items.Add(guild.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/oauth2/authorize?scope=bot&client_id=" + tbBotClientId.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < 0 || listBox1.SelectedIndex  >= client.Guilds.Count)
            {
                return;
            }
            client.Guilds.ElementAt(listBox1.SelectedIndex).LeaveAsync();
            listBox1.Items.Clear();
            foreach (IGuild guild in client.Guilds)
            {
                listBox1.Items.Add(guild.Name);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/developers/applications/me/create");
        }
    }
}
