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
            TxtMensaje.Text = "";
            TxtCorreo.Text = "";
            TxtApellido.Text = "";
            TxtNombre.Text = "";
        }

        private void Contactenos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true; 
        }

        public bool IsEmpty(string text)
        {
            return text.Trim() == "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsEmpty(TxtNombre.Text) || IsEmpty(TxtApellido.Text) || IsEmpty(TxtCorreo.Text) || IsEmpty(TxtMensaje.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gracias por escribirnos.", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
