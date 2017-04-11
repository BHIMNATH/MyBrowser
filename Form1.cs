using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s=(ty.Text);
            web.Navigate(s);
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (web.CanGoBack)
                web.GoBack();
        }

        private void front_Click(object sender, EventArgs e)
        {
            if (web.CanGoForward)
                web.GoForward();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
                web.Refresh();
        }

        private void home_Click(object sender, EventArgs e)
        {

        }
    }
}
