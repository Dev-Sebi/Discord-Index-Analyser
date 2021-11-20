using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace D_Cleaner
{
    public partial class main : Form
    {
        bool tmp = false;

        public main()
        {
            InitializeComponent();
            welcome_user.Text = "Welcome " + Environment.UserName + "!";
            string path = Environment.GetEnvironmentVariable("LocalAppData") + "/Discord/";
            AutomaticScanForDirectories();
        }

        async Task<bool> AutomaticScanForDirectories()
        {
            while (!tmp)
            {
                ScanDirectories();
                await Task.Delay(1000); // arbitrary delay
            }
            return false;
        }


        private void ScanDirectories()
        {
            string path = Environment.GetEnvironmentVariable("LocalAppData") + "/Discord/app-1.0.9003/modules/discord_desktop_core-1/discord_desktop_core/index.js";
            if (File.Exists(path))
            {
                scan_index.Enabled = true;
                kill_discord.Enabled = true;
                install_discord.Enabled = false;
                delete_discord.Enabled = true;
                open_index_path.Enabled = true;
                open_file_path.Enabled = true;
                tmp = false;
                if(liveupdate.Checked)
                {
                    string text = File.ReadAllText(@path);
                    tb1.Text = text;
                }
            }
            else
            {
                scan_index.Enabled = false;
                kill_discord.Enabled = false;
                install_discord.Enabled = true;
                delete_discord.Enabled = false;
                scan_webhooks.Enabled = false;
                open_index_path.Enabled = false;
                open_file_path.Enabled = false;
                tmp = true;
                if (liveupdate.Checked)
                { 
                    tb1.Text = "";
                }
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Sebi" + "\n" + "Version: 1.0.0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void scan_index_Click(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("LocalAppData") + "/Discord/app-1.0.9003/modules/discord_desktop_core-1/discord_desktop_core/index.js";

            if (!File.Exists(path))
            {
                MessageBox.Show("No Files Found!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string text = File.ReadAllText(@path);
            tb1.Text = text;
            scan_webhooks.Enabled = true;
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (tb1.Text == "")
            {
                copy_index.Enabled = false;
                clear.Enabled = false;
                scan_webhooks.Enabled = false;
            }
            else
            {
                copy_index.Enabled = true;
                clear.Enabled = true;
                scan_webhooks.Enabled = true;
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb1.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            webhook_delete.Text = "";
        }

        private void delete_webhook_Click(object sender, EventArgs e)
        {
            string url = webhook_delete.Text;
            string pattern = @"https:\/\/discord(?:app)?\.com\/api\/webhooks\/([^\/]+)\/.{1,68}";
            RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase;
            MatchCollection matches = Regex.Matches(webhook_delete.Text, pattern, options);
            if (matches.Count <= 0)
            {
                MessageBox.Show("Invalid Webhook Syntax!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "DELETE";

            try
            {
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
                webhook_delete.Text = "";
                MessageBox.Show("Successfully deleted the Webhook!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        var encoding = ASCIIEncoding.ASCII;
                        using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                        {
                            string responseText = reader.ReadToEnd();
                            MessageBox.Show(responseText, "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {
                        // no http status code available
                    }
                }
                else
                {
                    // no http status code available
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (webhook_delete.Text == "")
            {
                delete_webhook.Enabled = false;
                clear.Enabled = false;
            }
            else
            {
                delete_webhook.Enabled = true;
                clear.Enabled = true;
            }
        }

        private void scan_webhooks_Click(object sender, EventArgs e)
        {
            string pattern = @"https:\/\/discord(?:app)?\.com\/api\/webhooks\/([^\/]+)\/.{1,68}";
            RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase;
            MatchCollection matches = Regex.Matches(tb1.Text, pattern, options);
            if(tb1.Text.Contains("PirateStealer"))
            {
                MessageBox.Show("Suspicious Words Found:\nPirateStealer", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (matches.Count == 0)
            {
                MessageBox.Show("0 Webhooks found!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string hooks = "";
                foreach (Match match in matches)
                {
                    hooks = hooks + match.Value + "\n\n";
                }
                webhooks_found.Text = hooks;
            }
        }

        private void kill_discord_Click(object sender, EventArgs e)
        {
            foreach (var process in System.Diagnostics.Process.GetProcessesByName("Discord"))
            {
                try
                {
                    process.Kill();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An Error Accured: \n\n" + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Killed Discord Processes!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delete_discord_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to Uninstall Discord?", "Are you sure about that?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var process in System.Diagnostics.Process.GetProcessesByName("Discord"))
                {
                    process.Kill();
                }
                string path = Environment.GetEnvironmentVariable("LocalAppData") + "/Discord";
                string path2 = Environment.GetEnvironmentVariable("AppData") + "/Discord";
                string path3 = Environment.GetEnvironmentVariable("AppData") + "/Microsoft/Windows/Start Menu/Programs/Discord inc";
                try
                {
                    Thread.Sleep(2000);
                    Directory.Delete(path, true);
                    Directory.Delete(path2, true);
                    Directory.Delete(path3, true);
                    MessageBox.Show("Successfully Uninstalled Discord!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An Error Accured: \n\n" + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webhooks_found.Text = "";
        }

        private void copy_webhooks_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(webhooks_found.Text);
        }

        private void webhooks_found_TextChanged(object sender, EventArgs e)
        {
            if(webhooks_found.Text == "")
            {
                clear_webhooks.Enabled = false;
                copy_webhooks.Enabled = false;
            }
            else
            {
                clear_webhooks.Enabled = true;
                copy_webhooks.Enabled = true;
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("LocalAppData") + "/Discord/";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Discord is already Installed!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string url = @"https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86";

            using (WebClient webClient = new WebClient())
            {
                install_discord.Enabled = false;
                MessageBox.Show("Starting Download!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    webClient.DownloadFile(url, Environment.GetEnvironmentVariable("TMP") + "/DiscordInstaller.exe");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An Error Accured:\n\n" + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Starting Installation!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start(Environment.GetEnvironmentVariable("TMP") + "/DiscordInstaller.exe");
            tmp = false;
            while (!folderExists())
            {
                await Task.Delay(1000); // arbitrary delay
            }
            AutomaticScanForDirectories();
        }

        private bool folderExists()
        {
            string path = Environment.GetEnvironmentVariable("LocalAppData") + "/Discord/app-1.0.9003/modules/discord_desktop_core-1/discord_desktop_core/index.js";
            if (File.Exists(path))
            {
                Task.Delay(100);
                return true;
            }
            else
            {
                Task.Delay(100);
                return false;
            }
        }

        private void open_index_path_Click(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("LocalAppData") + "/Discord/app-1.0.9003/modules/discord_desktop_core-1/discord_desktop_core";
            System.Diagnostics.Process.Start(path);
        }

        private void open_file_path_Click(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("AppData") + "/Discord";
            System.Diagnostics.Process.Start(path);
        }

        private void liveupdate_CheckedChanged(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("LocalAppData") + "/Discord/app-1.0.9003/modules/discord_desktop_core-1/discord_desktop_core/index.js";
            if(liveupdate.Checked && File.Exists(path))
            {
                tb1.Text = "";
            }
        }

        private void open_virustotal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://virustotal.com/");
        }

        private void open_GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/");
        }

        private void open_youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com/");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to clear your Downloads Folder?", "Are you sure about that?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads";

                DirectoryInfo directory = new DirectoryInfo(path);

                foreach (FileInfo file in directory.GetFiles())
                {
                    file.Delete();
                }

                foreach (DirectoryInfo dir in directory.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
