using AplicacionDeCaja.AppCajaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AplicacionDeCaja.AppCajaDBDataSet;

namespace AplicacionDeCaja
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void tblClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblClientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appCajaDBDataSet);

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appCajaDBDataSet.tblCuentasConClientes' table. You can move, or remove it, as needed.
            this.tblCCAdapter.Fill(this.appCajaDBDataSet.tblCuentasConClientes);
            // TODO: This line of code loads data into the 'appCajaDBDataSet.tblCuentas' table. You can move, or remove it, as needed.
            this.tblCuentasTableAdapter.Fill(this.appCajaDBDataSet.tblCuentas);
            // TODO: This line of code loads data into the 'appCajaDBDataSet.tblClientes' table. You can move, or remove it, as needed.
            this.tblClientesTableAdapter.Fill(this.appCajaDBDataSet.tblClientes);
        }

        private void button1_Click(object sender, EventArgs e) //Falta
        {
            try
            {
                tblCCAdapter adapterCC = new tblCCAdapter();

                foreach (tblCuentasConClientesRow item in adapterCC.GetDataByDoc(txtBuscarDoc.Text))
                {
                    nombresLabel1.Text = item.Nombres;
                    apellidosLabel1.Text = item.Apellidos;
                    noDocumentoLabel1.Text = item.NoDocumento;
                    celularLabel1.Text = item.Celular;
                    correoElectronicoLabel1.Text = item.CorreoElectronico;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtBuscarDoc_TextChanged(object sender, EventArgs e)
        {

        }


        private void nombresLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
