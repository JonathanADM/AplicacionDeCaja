using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDeCaja
{
    public partial class AppCaja : Form
    {
        public static AppCaja mdiobj;
        public AppCaja()
        {
            InitializeComponent();

        }

        private void AppCaja_Load(object sender, EventArgs e)
        {
            #region * Color Fondo del Mdi
            MdiClient oMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    oMDI = (MdiClient)ctl;
                    oMDI.BackColor = Color.CadetBlue;
                }
                catch (InvalidCastException exc)
                {
                }
            }
            #endregion

            clienteToolStripMenuItem.Enabled = false;
            mdiobj = this;
        }

        private void AppCaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(Inicio inicio = new Inicio())
            {
                inicio.ShowDialog();
            }
           
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente FormCliente = new Cliente();
            FormCliente.MdiParent = this;
            FormCliente.Show();
        }

        private void abrirCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCaja FormAbrirCaja = new AbrirCaja();
            FormAbrirCaja.MdiParent = this;
            FormAbrirCaja.Show();
        }
    }
}
