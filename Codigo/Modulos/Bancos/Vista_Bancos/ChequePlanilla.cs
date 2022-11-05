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
    public partial class ChequePlanilla : Form
    {
        Convertir con = new Convertir();
        CsControlador cn = new CsControlador();
        public ChequePlanilla()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7003";
            TextBox[] Grupotextbox = { txtID, txtIDTrabajadores, txtIDConcepto, txtMonto, txtFechaReg, txtFechaAp, txtMontoLetras, txtIDBanco };
            TextBox[] Idtextbox = { txtID, txtIDTrabajadores };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Tbl_Ctrl_chequesnominas");
        }

        private void btn_covertirMonto_Click(object sender, EventArgs e)
        {
            txtMontoLetras.Text = con.enletras(txtMonto.Text).ToUpper();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDBanco.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtBanosConsulta.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            panelBancos.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBancos.Visible = true;
            cn.llenartablaa(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDTrabajadores.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            txtConsultaTrabajador.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            panelTrabajadores.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelTrabajadores.Visible = true;
            cn.llenartablaa(dataGridView3.Tag.ToString(), dataGridView3);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDConcepto.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            txtConceptoConsulta.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            panelConcepto.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelConcepto.Visible = true;
            cn.llenartablaa(dataGridView4.Tag.ToString(), dataGridView4);
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            imprimirChequePlanilla impChePla = new imprimirChequePlanilla();
            impChePla.Show();
        }
    }
}
