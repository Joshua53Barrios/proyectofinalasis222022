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
    public partial class ReporteCuentasBancarias : Form
    {
        CsControlador cn = new CsControlador();
        public ReporteCuentasBancarias()
        {
            InitializeComponent();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            pnImpGeneral.Visible = true;
            panelPersonalizado.Visible = false;
        }

        private void ReporteCuentasBancarias_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'DsCheque.DataCuentasBancarias' Puede moverla o quitarla según sea necesario.
            this.DataCuentasBancariasTableAdapter.Fill(this.DsCheque.DataCuentasBancarias);

            this.reportViewer1.RefreshReport();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBancos.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtConsultaBancos.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            panelConsultaBancos.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMoneda.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtConsultaMoneda.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            panelConsultaMoneda.Visible = false;
        }

        private void btnGenerarBanco_Click(object sender, EventArgs e)
        {
            panelConsultaBancos.Visible = true;
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
        }

        private void btnGenerarMoneda_Click(object sender, EventArgs e)
        {
            panelConsultaMoneda.Visible = true;
            cn.llenartablaa(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            pnImpGeneral.Visible = false;
            panelPersonalizado.Visible = true;
            // TODO: esta línea de código carga datos en la tabla 'DsCheque.DataMiembros' Puede moverla o quitarla según sea necesario.
            int estado, banco, moneda;
            estado = Convert.ToInt32(txtEstado.Text);
            banco = Convert.ToInt32(txtBancos.Text);
            moneda = Convert.ToInt32(txtMoneda.Text);
            this.DataMiembrosTableAdapter.Fill(this.DsCheque.DataMiembros,moneda,banco,estado);

            this.reportViewer2.RefreshReport();
        }
    }
}
