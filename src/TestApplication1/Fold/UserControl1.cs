using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApplication1.Fold
{
    public partial class UserControl1 : UserControl
    {
        private string messageText;

        public string MessageText
        {
            get { return messageText; }
            set { messageText = value; }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            this.helloRichTextBox.Text += this.messageText + "\n";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.helloRichTextBox.Text = "";
        }
    }
}
