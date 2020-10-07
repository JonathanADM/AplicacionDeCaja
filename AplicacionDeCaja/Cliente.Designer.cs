namespace AplicacionDeCaja
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label noCuentaLabel;
            System.Windows.Forms.Label noDocumentoLabel;
            System.Windows.Forms.Label tipoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarDoc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nombresLabel1 = new System.Windows.Forms.Label();
            this.apellidosLabel1 = new System.Windows.Forms.Label();
            this.celularLabel1 = new System.Windows.Forms.Label();
            this.correoElectronicoLabel1 = new System.Windows.Forms.Label();
            this.balanceLabel1 = new System.Windows.Forms.Label();
            this.noCuentaComboBox = new System.Windows.Forms.ComboBox();
            this.noDocumentoLabel1 = new System.Windows.Forms.Label();
            this.tipoLabel1 = new System.Windows.Forms.Label();
            this.tblCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appCajaDBDataSet = new AplicacionDeCaja.AppCajaDBDataSet();
            this.tblClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClientesTableAdapter = new AplicacionDeCaja.AppCajaDBDataSetTableAdapters.tblClientesTableAdapter();
            this.tableAdapterManager = new AplicacionDeCaja.AppCajaDBDataSetTableAdapters.TableAdapterManager();
            this.tblCuentasTableAdapter = new AplicacionDeCaja.AppCajaDBDataSetTableAdapters.tblCuentasTableAdapter();
            this.tblCuentasConClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCCAdapter = new AplicacionDeCaja.AppCajaDBDataSetTableAdapters.tblCCAdapter();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            noCuentaLabel = new System.Windows.Forms.Label();
            noDocumentoLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appCajaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCuentasConClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Documento:";
            // 
            // txtBuscarDoc
            // 
            this.txtBuscarDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDoc.Location = new System.Drawing.Point(186, 9);
            this.txtBuscarDoc.Name = "txtBuscarDoc";
            this.txtBuscarDoc.Size = new System.Drawing.Size(146, 27);
            this.txtBuscarDoc.TabIndex = 1;
            this.txtBuscarDoc.TextChanged += new System.EventHandler(this.txtBuscarDoc_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(celularLabel);
            this.panel1.Controls.Add(this.celularLabel1);
            this.panel1.Controls.Add(nombresLabel);
            this.panel1.Controls.Add(this.nombresLabel1);
            this.panel1.Controls.Add(correoElectronicoLabel);
            this.panel1.Controls.Add(this.correoElectronicoLabel1);
            this.panel1.Controls.Add(this.apellidosLabel1);
            this.panel1.Controls.Add(apellidosLabel);
            this.panel1.Controls.Add(noDocumentoLabel);
            this.panel1.Controls.Add(this.noDocumentoLabel1);
            this.panel1.Location = new System.Drawing.Point(17, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 116);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(balanceLabel);
            this.panel2.Controls.Add(this.balanceLabel1);
            this.panel2.Controls.Add(noCuentaLabel);
            this.panel2.Controls.Add(this.noCuentaComboBox);
            this.panel2.Controls.Add(tipoLabel);
            this.panel2.Controls.Add(this.tipoLabel1);
            this.panel2.Location = new System.Drawing.Point(17, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 91);
            this.panel2.TabIndex = 16;
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombresLabel.Location = new System.Drawing.Point(19, 17);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(97, 25);
            nombresLabel.TabIndex = 16;
            nombresLabel.Text = "Nombres:";
            // 
            // nombresLabel1
            // 
            this.nombresLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombresLabel1.Location = new System.Drawing.Point(123, 17);
            this.nombresLabel1.Name = "nombresLabel1";
            this.nombresLabel1.Size = new System.Drawing.Size(279, 23);
            this.nombresLabel1.TabIndex = 17;
            this.nombresLabel1.Click += new System.EventHandler(this.nombresLabel1_Click);
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel.Location = new System.Drawing.Point(19, 61);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(98, 25);
            apellidosLabel.TabIndex = 18;
            apellidosLabel.Text = "Apellidos:";
            // 
            // apellidosLabel1
            // 
            this.apellidosLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosLabel1.Location = new System.Drawing.Point(123, 63);
            this.apellidosLabel1.Name = "apellidosLabel1";
            this.apellidosLabel1.Size = new System.Drawing.Size(279, 23);
            this.apellidosLabel1.TabIndex = 19;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celularLabel.Location = new System.Drawing.Point(835, 15);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(80, 25);
            celularLabel.TabIndex = 20;
            celularLabel.Text = "Celular:";
            // 
            // celularLabel1
            // 
            this.celularLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularLabel1.Location = new System.Drawing.Point(921, 15);
            this.celularLabel1.Name = "celularLabel1";
            this.celularLabel1.Size = new System.Drawing.Size(189, 23);
            this.celularLabel1.TabIndex = 21;
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoElectronicoLabel.Location = new System.Drawing.Point(441, 63);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(179, 25);
            correoElectronicoLabel.TabIndex = 22;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // correoElectronicoLabel1
            // 
            this.correoElectronicoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoElectronicoLabel1.Location = new System.Drawing.Point(626, 61);
            this.correoElectronicoLabel1.Name = "correoElectronicoLabel1";
            this.correoElectronicoLabel1.Size = new System.Drawing.Size(453, 33);
            this.correoElectronicoLabel1.TabIndex = 23;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            balanceLabel.Location = new System.Drawing.Point(768, 32);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(89, 25);
            balanceLabel.TabIndex = 24;
            balanceLabel.Text = "Balance:";
            // 
            // balanceLabel1
            // 
            this.balanceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel1.Location = new System.Drawing.Point(863, 32);
            this.balanceLabel1.Name = "balanceLabel1";
            this.balanceLabel1.Size = new System.Drawing.Size(247, 23);
            this.balanceLabel1.TabIndex = 25;
            // 
            // noCuentaLabel
            // 
            noCuentaLabel.AutoSize = true;
            noCuentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noCuentaLabel.Location = new System.Drawing.Point(19, 30);
            noCuentaLabel.Name = "noCuentaLabel";
            noCuentaLabel.Size = new System.Drawing.Size(112, 25);
            noCuentaLabel.TabIndex = 26;
            noCuentaLabel.Text = "No Cuenta:";
            // 
            // noCuentaComboBox
            // 
            this.noCuentaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noCuentaComboBox.FormattingEnabled = true;
            this.noCuentaComboBox.Location = new System.Drawing.Point(154, 27);
            this.noCuentaComboBox.Name = "noCuentaComboBox";
            this.noCuentaComboBox.Size = new System.Drawing.Size(270, 33);
            this.noCuentaComboBox.TabIndex = 27;
            // 
            // noDocumentoLabel
            // 
            noDocumentoLabel.AutoSize = true;
            noDocumentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noDocumentoLabel.Location = new System.Drawing.Point(442, 17);
            noDocumentoLabel.Name = "noDocumentoLabel";
            noDocumentoLabel.Size = new System.Drawing.Size(148, 25);
            noDocumentoLabel.TabIndex = 28;
            noDocumentoLabel.Text = "No Documento:";
            // 
            // noDocumentoLabel1
            // 
            this.noDocumentoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDocumentoLabel1.Location = new System.Drawing.Point(596, 17);
            this.noDocumentoLabel1.Name = "noDocumentoLabel1";
            this.noDocumentoLabel1.Size = new System.Drawing.Size(201, 23);
            this.noDocumentoLabel1.TabIndex = 29;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.Location = new System.Drawing.Point(452, 30);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(57, 25);
            tipoLabel.TabIndex = 32;
            tipoLabel.Text = "Tipo:";
            // 
            // tipoLabel1
            // 
            this.tipoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoLabel1.Location = new System.Drawing.Point(515, 32);
            this.tipoLabel1.Name = "tipoLabel1";
            this.tipoLabel1.Size = new System.Drawing.Size(217, 23);
            this.tipoLabel1.TabIndex = 33;
            // 
            // tblCuentasBindingSource
            // 
            this.tblCuentasBindingSource.DataMember = "tblCuentas";
            this.tblCuentasBindingSource.DataSource = this.appCajaDBDataSet;
            // 
            // appCajaDBDataSet
            // 
            this.appCajaDBDataSet.DataSetName = "AppCajaDBDataSet";
            this.appCajaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClientesBindingSource
            // 
            this.tblClientesBindingSource.DataMember = "tblClientes";
            this.tblClientesBindingSource.DataSource = this.appCajaDBDataSet;
            // 
            // tblClientesTableAdapter
            // 
            this.tblClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblClientesTableAdapter = this.tblClientesTableAdapter;
            this.tableAdapterManager.tblCuentasTableAdapter = null;
            this.tableAdapterManager.tblRetirosDepositosTableAdapter = null;
            this.tableAdapterManager.tblUsuariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplicacionDeCaja.AppCajaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCuentasTableAdapter
            // 
            this.tblCuentasTableAdapter.ClearBeforeFill = true;
            // 
            // tblCuentasConClientesBindingSource
            // 
            this.tblCuentasConClientesBindingSource.DataMember = "tblCuentasConClientes";
            this.tblCuentasConClientesBindingSource.DataSource = this.appCajaDBDataSet;
            // 
            // tblCCAdapter
            // 
            this.tblCCAdapter.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1172, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscarDoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appCajaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCuentasConClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarDoc;
        private System.Windows.Forms.Button button1;
        private AppCajaDBDataSet appCajaDBDataSet;
        private System.Windows.Forms.BindingSource tblClientesBindingSource;
        private AppCajaDBDataSetTableAdapters.tblClientesTableAdapter tblClientesTableAdapter;
        private AppCajaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource tblCuentasBindingSource;
        private AppCajaDBDataSetTableAdapters.tblCuentasTableAdapter tblCuentasTableAdapter;
        private System.Windows.Forms.BindingSource tblCuentasConClientesBindingSource;
        private AppCajaDBDataSetTableAdapters.tblCCAdapter tblCCAdapter;
        private System.Windows.Forms.Label nombresLabel1;
        private System.Windows.Forms.Label apellidosLabel1;
        private System.Windows.Forms.Label celularLabel1;
        private System.Windows.Forms.Label correoElectronicoLabel1;
        private System.Windows.Forms.Label balanceLabel1;
        private System.Windows.Forms.ComboBox noCuentaComboBox;
        private System.Windows.Forms.Label noDocumentoLabel1;
        private System.Windows.Forms.Label tipoLabel1;
    }
}