using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_Bancos;

namespace Vista_Bancos
{
    public partial class EstadosCuentas : Form
    {
        CsControlador cn = new CsControlador();
        public EstadosCuentas()
        {
            InitializeComponent();
        }

        private void EstadosCuentas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCuentaBancos.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtConsultaNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            panelConsulta.Visible = false;
        }

        private void btnGenerarCuenta_Click(object sender, EventArgs e)
        {
            panelConsulta.Visible = true;
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsCheque.DataCuentaBancos' Puede moverla o quitarla según sea necesario.
            int valor;
            valor = Convert.ToInt32(txtCuentaBancos.Text);
            this.DataCuentaBancosTableAdapter.Fill(this.DsCheque.DataCuentaBancos, valor);
            this.DataMovBancariosTableAdapter.Fill(this.DsCheque.DataMovBancarios, valor);

            this.reportViewer1.RefreshReport();
        }
    }
}
