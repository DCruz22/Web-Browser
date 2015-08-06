using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class FrmWeb : Form
    {
        public FrmWeb()
        {
            InitializeComponent();
        }

        private WebBrowser web;
        int i = 0;

        public void Iniciar()
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.ProgressChanged += web_ProgressChanged;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("Google");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            TxtDireccion.Text = "https://google.com.do";
            i += 1;
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("www.google.com.do", false);
        }

        void web_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStrip1.Visible = true;
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                if (toolStripProgressBar1.Value >= Convert.ToInt32(e.MaximumProgress))
                {
                    toolStrip1.Visible = false;
                }
            }
            catch
            {

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Iniciar();
        }

        void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        protected bool IsText(string text)
        {
            return text.Trim() != "";
        }

        protected void GoToUrl()
        {
            if (IsText(TxtDireccion.Text))
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(TxtDireccion.Text, false);
                if (!TxtDireccion.Items.Contains(TxtDireccion.Text))
                {
                    TxtDireccion.Items.Add(TxtDireccion.Text);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected void GoHome()
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("www.google.com.do", false);
        }

        private void irToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToUrl();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();  
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count - 1 > 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItm2_Click(object sender, EventArgs e)
        {
            if (((WebBrowser)tabControl1.SelectedTab.Controls[0]).CanGoForward)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (((WebBrowser)tabControl1.SelectedTab.Controls[0]).CanGoBack)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
            }
        }

        private void TxtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                GoToUrl();
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
