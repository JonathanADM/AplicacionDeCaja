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
    public partial class AbrirCaja : Form
    {
        public AbrirCaja()
        {
            InitializeComponent();
        }

        private void AbrirCaja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appCajaDBDataSet.tblUsuarios' table. You can move, or remove it, as needed.
            this.tblUsuariosTableAdapter.Fill(this.appCajaDBDataSet.tblUsuarios);
            lblFecha.Text = DateTime.Now.ToString();
            Font size = new Font("Microsoft Sans Serif", 12);
            lblFecha.Font = size;

        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            AppCaja.mdiobj.clienteToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void tblUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appCajaDBDataSet);

        }
    }
}
