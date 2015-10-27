using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormToBrowser.Properties;
using FormToBrowser.Properties;
//using mshtml;

namespace FormToBrowser
    {
    public partial class FormToBrowser : Form
        {
        public FormToBrowser()
            {
            InitializeComponent();

            BrowserInterface browserInterface = new BrowserInterface();
            browserInterface.ContentPushed += browserInterface_ContentPushed;
            webBrowser1.ObjectForScripting = browserInterface;

            PopulateBaseHTML();
            PopulateData();
            NavigateToBase();

            // Determine browser and compatibility version
            //webBrowser1.Navigate("http://www.whatismybrowser.com/");
            }


        private void PopulateBaseHTML()
            {
            String baseHTML = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "base.html");
            txtBaseHTML.Text = File.ReadAllText(baseHTML);
            }

        private void PopulateData()
            {
            String data = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "data.txt");
            txtContentIn.Text = File.ReadAllText(data);
            }

        private void NavigateToBase()
            {
            webBrowser1.DocumentText = txtBaseHTML.Text;
            }

        private void btnNavToBase_Click(object sender, EventArgs e)
            {
            NavigateToBase();
            }

        private void btnInject_Click(object sender, EventArgs e)
            {
            HtmlDocument doc = webBrowser1.Document;

            HtmlElement content1Element = doc.GetElementById("content");
            content1Element.InnerHtml = txtContentIn.Text;
            }

        private void btnExtract_Click(object sender, EventArgs e)
            {
            HtmlDocument doc = webBrowser1.Document;

            HtmlElement content1Element = doc.GetElementById("content");
            txtContentOut.Text = content1Element.InnerHtml;
            }

        void browserInterface_ContentPushed(object sender, BrowserInterfaceEventArgs e)
            {
            txtContentOut.Text = e.Content;
            }

        }
    }
