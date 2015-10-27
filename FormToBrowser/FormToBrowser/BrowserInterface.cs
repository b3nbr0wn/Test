using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormToBrowser
    {
    [ComVisible(true)]
    public class BrowserInterface
        {
        public event EventHandler<BrowserInterfaceEventArgs> ContentPushed;

        public void PushContent(string content)
            {
            if (ContentPushed != null)
                ContentPushed(this, new BrowserInterfaceEventArgs(content));
            }
        }
        
        public class BrowserInterfaceEventArgs : EventArgs
        {
           public string Content { get; private set; }

           public BrowserInterfaceEventArgs(string content)
               : base()
           {
                  this.Content = content;
           }
        }
    }
