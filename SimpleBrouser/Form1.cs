using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrouser
{
    public partial class Form1 : Form
    {
        string mainSite = "google.com.ua";
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Navigate(mainSite);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            webBrowser.GoSearch();
        }
    }
}
