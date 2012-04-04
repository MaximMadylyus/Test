using System;
using System.Windows.Forms;

namespace TestApplication1.Fold
{
    public partial class UserControl1 : UserControl
    {
        private string _messageText;

        public string MessageText
        {
            get { return _messageText; }
            set { _messageText = value; }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void MainBtnClick(object sender, EventArgs e)
        {
            helloRichTextBox.Text += _messageText + "\n";
        }

        private void ClearBtnClick(object sender, EventArgs e)
        {
            helloRichTextBox.Text = "";
        }

        public static string DoThis(object a)
        {
            string x = string.Empty;
            if(a != null)
            {
                x = a.ToString();
            }

            x = x.Replace("x", "b");
            return x;
        }
    }
}
