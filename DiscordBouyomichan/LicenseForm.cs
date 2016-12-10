using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DiscordBouyomichan
{
    public partial class LicenseForm : Form
    {
        public LicenseForm(String path)
        {
            InitializeComponent();

            StreamReader sr = new StreamReader(path, Encoding.GetEncoding("Shift_JIS"));
            webBrowser1.DocumentText = sr.ReadToEnd();
            sr.Close();
        }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.ToString() != "about:blank")
            {
                e.Cancel = true;
                System.Diagnostics.Process.Start(e.Url.ToString());
            }
        }
    }
}
