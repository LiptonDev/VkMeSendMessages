using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace VkMeSendMessages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chatTypeBox.SelectedIndex = 0;
        }

        Dictionary<int, string> chatTypes = new Dictionary<int, string>
        {
            [0] = "user_id",
            [1] = "peer_id",
            [2] = "peer_id"
        };

        const string VkApi = "https://api.vk.com/method/messages.send?{0}={1}&message={2}&expire_ttl={3}&random_id=0&v=5.103&access_token={4}";

        private async void sendMessageButton_Click(object sender, EventArgs e)
        {
            sendMessageButton.Enabled = false;

            var type = chatTypes[chatTypeBox.SelectedIndex];
            var id = chatIdField.Value;

            if (chatTypeBox.SelectedIndex == 1)
                id += 2_000_000_000;

            var query = string.Format(VkApi, type, id, messageBox.Text, timeField.Value, tokenBox.Text);

            var request = WebRequest.Create(query);
            var response = await request.GetResponseAsync();
            using (var responseText = new StreamReader(response.GetResponseStream()))
            {
                logBox.Clear();
                logBox.AppendText(responseText.ReadToEnd());
            }

            sendMessageButton.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/id99551920");
        }
    }
}
