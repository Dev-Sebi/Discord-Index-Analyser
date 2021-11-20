namespace D_Cleaner
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcome_user = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.RichTextBox();
            this.scan_index = new System.Windows.Forms.Button();
            this.copy_index = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete_webhook = new System.Windows.Forms.Button();
            this.webhook_delete = new System.Windows.Forms.TextBox();
            this.scan_webhooks = new System.Windows.Forms.Button();
            this.kill_discord = new System.Windows.Forms.Button();
            this.delete_discord = new System.Windows.Forms.Button();
            this.liveupdate = new System.Windows.Forms.CheckBox();
            this.webhooks_found = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_webhooks = new System.Windows.Forms.Button();
            this.copy_webhooks = new System.Windows.Forms.Button();
            this.install_discord = new System.Windows.Forms.Button();
            this.open_index_path = new System.Windows.Forms.Button();
            this.open_file_path = new System.Windows.Forms.Button();
            this.open_virustotal = new System.Windows.Forms.Button();
            this.open_GitHub = new System.Windows.Forms.Button();
            this.open_youtube = new System.Windows.Forms.Button();
            this.quicklinks = new System.Windows.Forms.Label();
            this.clear_downloads_folder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_user
            // 
            this.welcome_user.AutoSize = true;
            this.welcome_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_user.Location = new System.Drawing.Point(12, 9);
            this.welcome_user.Name = "welcome_user";
            this.welcome_user.Size = new System.Drawing.Size(134, 24);
            this.welcome_user.TabIndex = 0;
            this.welcome_user.Text = "welcome_user";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.info.Location = new System.Drawing.Point(1229, 9);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(23, 23);
            this.info.TabIndex = 1;
            this.info.Text = "i";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 74);
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(871, 290);
            this.tb1.TabIndex = 2;
            this.tb1.Text = "";
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // scan_index
            // 
            this.scan_index.Enabled = false;
            this.scan_index.Location = new System.Drawing.Point(12, 45);
            this.scan_index.Name = "scan_index";
            this.scan_index.Size = new System.Drawing.Size(121, 23);
            this.scan_index.TabIndex = 3;
            this.scan_index.Text = "Get Discord Index.js";
            this.scan_index.UseVisualStyleBackColor = true;
            this.scan_index.Click += new System.EventHandler(this.scan_index_Click);
            // 
            // copy_index
            // 
            this.copy_index.Enabled = false;
            this.copy_index.Location = new System.Drawing.Point(689, 45);
            this.copy_index.Name = "copy_index";
            this.copy_index.Size = new System.Drawing.Size(75, 23);
            this.copy_index.TabIndex = 4;
            this.copy_index.Text = "Copy All";
            this.copy_index.UseVisualStyleBackColor = true;
            this.copy_index.Click += new System.EventHandler(this.copy_Click);
            // 
            // clear
            // 
            this.clear.Enabled = false;
            this.clear.Location = new System.Drawing.Point(608, 45);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear All";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete_webhook
            // 
            this.delete_webhook.Enabled = false;
            this.delete_webhook.Location = new System.Drawing.Point(12, 370);
            this.delete_webhook.Name = "delete_webhook";
            this.delete_webhook.Size = new System.Drawing.Size(121, 23);
            this.delete_webhook.TabIndex = 6;
            this.delete_webhook.Text = "Delete Webhook";
            this.delete_webhook.UseVisualStyleBackColor = true;
            this.delete_webhook.Click += new System.EventHandler(this.delete_webhook_Click);
            // 
            // webhook_delete
            // 
            this.webhook_delete.Location = new System.Drawing.Point(139, 372);
            this.webhook_delete.Name = "webhook_delete";
            this.webhook_delete.Size = new System.Drawing.Size(744, 20);
            this.webhook_delete.TabIndex = 7;
            this.webhook_delete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // scan_webhooks
            // 
            this.scan_webhooks.Enabled = false;
            this.scan_webhooks.Location = new System.Drawing.Point(139, 45);
            this.scan_webhooks.Name = "scan_webhooks";
            this.scan_webhooks.Size = new System.Drawing.Size(121, 23);
            this.scan_webhooks.TabIndex = 8;
            this.scan_webhooks.Text = "Scan for Webhooks";
            this.scan_webhooks.UseVisualStyleBackColor = true;
            this.scan_webhooks.Click += new System.EventHandler(this.scan_webhooks_Click);
            // 
            // kill_discord
            // 
            this.kill_discord.Enabled = false;
            this.kill_discord.Location = new System.Drawing.Point(266, 45);
            this.kill_discord.Name = "kill_discord";
            this.kill_discord.Size = new System.Drawing.Size(120, 23);
            this.kill_discord.TabIndex = 9;
            this.kill_discord.Text = "Kill Discord Processes";
            this.kill_discord.UseVisualStyleBackColor = true;
            this.kill_discord.Click += new System.EventHandler(this.kill_discord_Click);
            // 
            // delete_discord
            // 
            this.delete_discord.Enabled = false;
            this.delete_discord.Location = new System.Drawing.Point(392, 45);
            this.delete_discord.Name = "delete_discord";
            this.delete_discord.Size = new System.Drawing.Size(102, 23);
            this.delete_discord.TabIndex = 10;
            this.delete_discord.Text = "Uninstall Discord";
            this.delete_discord.UseVisualStyleBackColor = true;
            this.delete_discord.Click += new System.EventHandler(this.delete_discord_Click);
            // 
            // liveupdate
            // 
            this.liveupdate.AutoSize = true;
            this.liveupdate.Checked = true;
            this.liveupdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.liveupdate.Location = new System.Drawing.Point(770, 49);
            this.liveupdate.Name = "liveupdate";
            this.liveupdate.Size = new System.Drawing.Size(113, 17);
            this.liveupdate.TabIndex = 11;
            this.liveupdate.Text = "Live Index Update";
            this.liveupdate.UseVisualStyleBackColor = true;
            this.liveupdate.CheckedChanged += new System.EventHandler(this.liveupdate_CheckedChanged);
            // 
            // webhooks_found
            // 
            this.webhooks_found.Location = new System.Drawing.Point(6, 44);
            this.webhooks_found.Name = "webhooks_found";
            this.webhooks_found.ReadOnly = true;
            this.webhooks_found.Size = new System.Drawing.Size(332, 323);
            this.webhooks_found.TabIndex = 13;
            this.webhooks_found.Text = "";
            this.webhooks_found.TextChanged += new System.EventHandler(this.webhooks_found_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_webhooks);
            this.groupBox1.Controls.Add(this.copy_webhooks);
            this.groupBox1.Controls.Add(this.webhooks_found);
            this.groupBox1.Location = new System.Drawing.Point(908, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 373);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Webhooks Found:";
            // 
            // clear_webhooks
            // 
            this.clear_webhooks.Enabled = false;
            this.clear_webhooks.Location = new System.Drawing.Point(183, 15);
            this.clear_webhooks.Name = "clear_webhooks";
            this.clear_webhooks.Size = new System.Drawing.Size(75, 23);
            this.clear_webhooks.TabIndex = 15;
            this.clear_webhooks.Text = "Clear All";
            this.clear_webhooks.UseVisualStyleBackColor = true;
            this.clear_webhooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // copy_webhooks
            // 
            this.copy_webhooks.Enabled = false;
            this.copy_webhooks.Location = new System.Drawing.Point(264, 15);
            this.copy_webhooks.Name = "copy_webhooks";
            this.copy_webhooks.Size = new System.Drawing.Size(74, 23);
            this.copy_webhooks.TabIndex = 15;
            this.copy_webhooks.Text = "Copy All";
            this.copy_webhooks.UseVisualStyleBackColor = true;
            this.copy_webhooks.Click += new System.EventHandler(this.copy_webhooks_Click);
            // 
            // install_discord
            // 
            this.install_discord.Location = new System.Drawing.Point(500, 45);
            this.install_discord.Name = "install_discord";
            this.install_discord.Size = new System.Drawing.Size(102, 23);
            this.install_discord.TabIndex = 15;
            this.install_discord.Text = "Install Discord";
            this.install_discord.UseVisualStyleBackColor = true;
            this.install_discord.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // open_index_path
            // 
            this.open_index_path.Enabled = false;
            this.open_index_path.Location = new System.Drawing.Point(12, 399);
            this.open_index_path.Name = "open_index_path";
            this.open_index_path.Size = new System.Drawing.Size(121, 23);
            this.open_index_path.TabIndex = 16;
            this.open_index_path.Text = "Open Index Path";
            this.open_index_path.UseVisualStyleBackColor = true;
            this.open_index_path.Click += new System.EventHandler(this.open_index_path_Click);
            // 
            // open_file_path
            // 
            this.open_file_path.Enabled = false;
            this.open_file_path.Location = new System.Drawing.Point(139, 399);
            this.open_file_path.Name = "open_file_path";
            this.open_file_path.Size = new System.Drawing.Size(121, 23);
            this.open_file_path.TabIndex = 17;
            this.open_file_path.Text = "Open File Path";
            this.open_file_path.UseVisualStyleBackColor = true;
            this.open_file_path.Click += new System.EventHandler(this.open_file_path_Click);
            // 
            // open_virustotal
            // 
            this.open_virustotal.Location = new System.Drawing.Point(781, 399);
            this.open_virustotal.Name = "open_virustotal";
            this.open_virustotal.Size = new System.Drawing.Size(102, 23);
            this.open_virustotal.TabIndex = 18;
            this.open_virustotal.Text = "VirusTotal";
            this.open_virustotal.UseVisualStyleBackColor = true;
            this.open_virustotal.Click += new System.EventHandler(this.open_virustotal_Click);
            // 
            // open_GitHub
            // 
            this.open_GitHub.Location = new System.Drawing.Point(673, 399);
            this.open_GitHub.Name = "open_GitHub";
            this.open_GitHub.Size = new System.Drawing.Size(102, 23);
            this.open_GitHub.TabIndex = 19;
            this.open_GitHub.Text = "GitHub";
            this.open_GitHub.UseVisualStyleBackColor = true;
            this.open_GitHub.Click += new System.EventHandler(this.open_GitHub_Click);
            // 
            // open_youtube
            // 
            this.open_youtube.Location = new System.Drawing.Point(565, 399);
            this.open_youtube.Name = "open_youtube";
            this.open_youtube.Size = new System.Drawing.Size(102, 23);
            this.open_youtube.TabIndex = 20;
            this.open_youtube.Text = "YouTube";
            this.open_youtube.UseVisualStyleBackColor = true;
            this.open_youtube.Click += new System.EventHandler(this.open_youtube_Click);
            // 
            // quicklinks
            // 
            this.quicklinks.AutoSize = true;
            this.quicklinks.Location = new System.Drawing.Point(493, 403);
            this.quicklinks.Name = "quicklinks";
            this.quicklinks.Size = new System.Drawing.Size(66, 13);
            this.quicklinks.TabIndex = 21;
            this.quicklinks.Text = "Quick Links:";
            // 
            // clear_downloads_folder
            // 
            this.clear_downloads_folder.Location = new System.Drawing.Point(266, 399);
            this.clear_downloads_folder.Name = "clear_downloads_folder";
            this.clear_downloads_folder.Size = new System.Drawing.Size(143, 23);
            this.clear_downloads_folder.TabIndex = 22;
            this.clear_downloads_folder.Text = "Clear Downloads Folder";
            this.clear_downloads_folder.UseVisualStyleBackColor = true;
            this.clear_downloads_folder.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 430);
            this.Controls.Add(this.clear_downloads_folder);
            this.Controls.Add(this.quicklinks);
            this.Controls.Add(this.open_youtube);
            this.Controls.Add(this.open_GitHub);
            this.Controls.Add(this.open_virustotal);
            this.Controls.Add(this.open_file_path);
            this.Controls.Add(this.open_index_path);
            this.Controls.Add(this.install_discord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.liveupdate);
            this.Controls.Add(this.delete_discord);
            this.Controls.Add(this.kill_discord);
            this.Controls.Add(this.scan_webhooks);
            this.Controls.Add(this.webhook_delete);
            this.Controls.Add(this.delete_webhook);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.copy_index);
            this.Controls.Add(this.scan_index);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.welcome_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1284, 473);
            this.MinimumSize = new System.Drawing.Size(1284, 473);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D-Cleaner - by Sebi";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_user;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.RichTextBox tb1;
        private System.Windows.Forms.Button scan_index;
        private System.Windows.Forms.Button copy_index;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete_webhook;
        private System.Windows.Forms.TextBox webhook_delete;
        private System.Windows.Forms.Button scan_webhooks;
        private System.Windows.Forms.Button kill_discord;
        private System.Windows.Forms.Button delete_discord;
        private System.Windows.Forms.CheckBox liveupdate;
        private System.Windows.Forms.RichTextBox webhooks_found;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear_webhooks;
        private System.Windows.Forms.Button copy_webhooks;
        private System.Windows.Forms.Button install_discord;
        private System.Windows.Forms.Button open_index_path;
        private System.Windows.Forms.Button open_file_path;
        private System.Windows.Forms.Button open_virustotal;
        private System.Windows.Forms.Button open_GitHub;
        private System.Windows.Forms.Button open_youtube;
        private System.Windows.Forms.Label quicklinks;
        private System.Windows.Forms.Button clear_downloads_folder;
    }
}

