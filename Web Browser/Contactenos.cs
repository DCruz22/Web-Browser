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
    public partial class Contactenos : Form
    {
        private static Contactenos instance;
        private Contactenos()
        {
            InitializeComponent();
        }

        public static Contactenos GetInstance()
        {
            if (instance == null) instance = new Contactenos();
            return instance;
        }

        private void Contactenos_Load(object sender, EventArgs e)
        {

        }
    }
}
