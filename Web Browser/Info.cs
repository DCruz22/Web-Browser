using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Info : Form
    {
        private static Info instance; 
        private Info()
        {
            InitializeComponent();
        }

        public static Info GetInstance()
        {
            if (instance == null) instance = new Info();
            return instance;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
