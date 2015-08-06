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
    public partial class Ayuda : Form
    {
        private static Ayuda instance;
        private Ayuda()
        {
            InitializeComponent();
        }

        public static Ayuda GetInstance()
        {
            if (instance == null) instance = new Ayuda();
            return instance;
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {

        }

        private void Ayuda_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true; 
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
