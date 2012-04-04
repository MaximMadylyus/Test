using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApplication1.Fold;

namespace TestApplication1
{
    public class Class1
    {
        private UserControl1 someControl = new UserControl1();
        
        public UserControl1 SomeControl 
        { 
            get { return someControl; }
        }
        
        public Class1()
        {
             
            someControl.MessageText = "Hello world";
        }



    }
}
