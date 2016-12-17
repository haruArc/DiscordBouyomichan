using System;
using System.Linq;
using System.Windows.Forms;
using Discord;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace DiscordBouyomichan
{
    public partial class MainForm : Form
    {
        delegate void SetDiscordServers_Delegate(IEnumerable<Server> obj);
        delegate void ConnectionFailed_Delegate();
        delegate void MessageEvent_Delegate(MessageEventArgs e);

        private DiscordClient client = new DiscordClient();
        private BouyomichanClient bcc = new BouyomichanClient();

        public MainForm()
        {
            InitializeComponent();
            client.Log.Message += (s, e) => Console.WriteLine($"[{e.Severity}] {e.Source}: {e.Message}");
            client.MessageReceived += Client_MessageReceived;
            tbMailAddr.Text = Properties.Settings.Default.mail;
            tbPassword.Text = Properties.Settings.Default.password;
            chkBot.Checked = Properties.Settings.Default.isBot;
            chkOwn.Checked = Properties.Settings.Default.isOwn;
            chkRestrictChannel.Checked = Properties.Settings.Default.restrictChannel;
            tbChatFormat.Text = Properties.Settings.Default.chatFormat;
        }

        private void button1_Click(object sender, EventArgs ea)
        {
            string login = tbMailAddr.Text;
            string password = tbPassword.Text;

            gbAccount.Enabled = false;

            try
            {
                //棒読みちゃん接続確認
                int dammy = bcc.TalkTaskCount;
                statusStrip.Items[1].Text = "棒読みちゃん接続済";
            }
            catch
            {
                statusStrip.Items[1].Text = "棒読みちゃん未接続";
            }

            Task.Run(async () => {
                try
                {
                    await client.Connect(login, password);
                }
                catch {

                }

                if(client.State == ConnectionState.Connected)
                {
                    Invoke(new SetDiscordServers_Delegate(SetDiscordServers), new object[] { client.Servers });
                }
                else
                {
                    Invoke(new ConnectionFailed_Delegate(ConnectionFailed), null);
                }
            });
        }

        private void ConnectionFailed()
        {
            gbAccount.Enabled = true;
            statusStrip.Items[0].Text = "Discord接続失敗";

        }

        private void SetDiscordServers(IEnumerable<Server> servers)
        {
            gbChannelRestrict.Enabled = true;
            chkOwn.Enabled = true;
            chkBot.Enabled = true;
            tbChatFormat.Enabled = true;

            cbTargetServer.Items.Clear();
            foreach(var server in servers)
            {
                cbTargetServer.Items.Add(server);
            }

            for(int i = 0; i < cbTargetServer.Items.Count;i++)
            {
                Server srv = (Server)cbTargetServer.Items[i];
                if (srv.Id == Properties.Settings.Default.targetServer)
                {
                    cbTargetServer.SelectedIndex = i;
                    for (int j = 0; j < lbTargetChannel.Items.Count; j++)
                    {
                        Channel chn = (Channel)lbTargetChannel.Items[j];
                        if(chn.Id == Properties.Settings.Default.targetChannel)
                        {
                            lbTargetChannel.SelectedIndex = j;
                        }
                    }
                }
            }

            statusStrip.Items[0].Text = "Discord接続済";
        }

        private void Client_MessageReceived(object sender, MessageEventArgs e)
        {
            Invoke(new MessageEvent_Delegate(TalkTask), new object[] { e });
        }

        private void TalkTask(MessageEventArgs e)
        {
            if (!chkBot.Checked && e.Message.User.IsBot)
            {
                return;
            }

            if (!chkOwn.Checked && e.Message.IsAuthor)
            {
                return;
            }

            if(chkRestrictChannel.Checked && cbTargetServer.SelectedIndex != -1)
            {
                if(e.Server.Id != ((Server)cbTargetServer.SelectedItem).Id)
                {
                    return;
                }
            }

            if (chkRestrictChannel.Checked && lbTargetChannel.SelectedIndex != -1)
            {
                if (e.Channel.Id != ((Channel)lbTargetChannel.SelectedItem).Id)
                {
                    return;
                }
            }

            try
            {
                bcc.AddTalkTask(String.Format(tbChatFormat.Text, e.Message.User.Name , e.Message.Text, e.Message.Server.Name, e.Message.Channel.Name));
                statusStrip.Items[1].Text = "棒読みちゃん接続済";
            }
            catch
            {
                statusStrip.Items[1].Text = "棒読みちゃん未接続";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            Server srv = (Server)cmb.SelectedItem;

            lbTargetChannel.Items.Clear();
            foreach (var channel in srv.TextChannels)
            {
                lbTargetChannel.Items.Add(channel);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.mail = tbMailAddr.Text;
            Properties.Settings.Default.password = tbPassword.Text;
            Properties.Settings.Default.restrictChannel = chkRestrictChannel.Checked;
            Properties.Settings.Default.isBot = chkBot.Checked;
            Properties.Settings.Default.isOwn = chkOwn.Checked;
            Properties.Settings.Default.chatFormat = tbChatFormat.Text;

            if (lbTargetChannel.SelectedItem != null)
                Properties.Settings.Default.targetServer = ((Channel)lbTargetChannel.SelectedItem).Id;
            if(cbTargetServer.SelectedItem != null)
                Properties.Settings.Default.targetChannel = ((Server)cbTargetServer.SelectedItem).Id;
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
    }
}
