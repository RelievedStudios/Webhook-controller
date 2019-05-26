using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace web_hook_controll
{
    public partial class WebhookController : Form
    {

        public WebhookController()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SendTestMessageWebhook1_Click(object sender, EventArgs e)
        {
            send_web_hook.sendWebHook(WebHookURL.Text, "Test message");
        }

        private void SendTextBoxMessage_Click(object sender, EventArgs e)
        {
            textBox2.Text = send_web_hook.sendWebHook(WebHookURL.Text, textBox1.Text);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = send_web_hook.sendEmbedWebHook(WebHookURL.Text, CustomJSON.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = send_web_hook.sendImageWebHook(WebHookURL.Text, ImageURL.Text, ImageTitle.Text);
        }
        public string current_bot_Idiots = "";
        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "Announcements channel bot";
            current_bot_Idiots = "https://discordapp.com/api/webhooks/534917659943370784/yChMrPdHRiIrGEQc4Lv5Dqr3ZT5XFHFlbYqAsGEnMvg9NOf0Xkd_2tceHf1pB0VAJv6b";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            current_bot_Idiots = "https://discordapp.com/api/webhooks/537862161226006538/VriaRFgp0YCeW_Vxxjj-98w_1sWXvVbsmKKacffXyZw9nEhhN4FDsI6yIsVu0XQNQgIj";
            textBox5.Text = "Server News bots";
        }
    }
}
