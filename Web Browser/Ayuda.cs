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
    }
}
