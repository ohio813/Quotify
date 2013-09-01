using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Quotify
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void grabClipboard_Click(object sender, EventArgs e)
        {
            var fragment = SkypeClipboard.GetMessage();
            if (fragment != null)
            {
                author.Text = fragment.Author;
                date.Value = fragment.Time.ToLocalTime();
                message.Text = fragment.Message;
            }
            else
            {
                MessageBox.Show("No quote data is available. Copy a message to the clipboard and try again.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setClipboard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(author.Text))
            {
                MessageBox.Show("Please enter an author.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(message.Text))
            {
                MessageBox.Show("Please enter a message.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fragment = new SkypeMessageFragment()
            {
                Author = author.Text,
                Time = date.Value,
                Message = message.Text
            };
            SkypeClipboard.SetMessage(fragment);
            
            MessageBox.Show("Quote copied to the clipboard.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nowButton_Click(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
        }
    }
}
