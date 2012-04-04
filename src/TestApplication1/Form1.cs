using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(new Class1().SomeControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string AnotherMethod(object y)
        {
            string some = string.Empty;
            if (null != y )
            {
                some = y.ToString();
            }

            int x = 1;
            x++;

            some = some.Replace("x", "b");
            return some;
        }
    }
}
