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
    public partial class Cheque : Form
    {
        Convertir con = new Convertir();
        CsControlador cn = new CsControlador();
        private static Cheque instancia = null;
        
        public static Cheque ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new Cheque();
                return instancia;
            }
            return instancia;
        }
        public Cheque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMontoLetras.Text = con.enletras(txtMonto.Text).ToUpper();
            Imprimir frm_imp = new Imprimir();
            frm_imp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void navegador2_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7003";
            TextBox[] Grupotextbox = { txtID, txtIDCuentaBancaria, txtIDConcepto, txtMonto, txtFechaReg, txtFechaAp, txtMontoLetras, txtIDBanco };
            TextBox[] Idtextbox = { txtID, txtIDCuentaBancaria };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_ctrl_cheques");
        }

        private void txtIDConcepto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_covertirMonto_Click(object sender, EventArgs e)
        {
            txtMontoLetras.Text = con.enletras(txtMonto.Text).ToUpper();
            panelCtaBancaria.Visible = false;
            panelConcepto.Visible = false;
            panelBancos.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelBancos.Visible = true;
            cn.llenartablaa(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDBanco.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtBanosConsulta.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            panelBancos.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDCuentaBancaria.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            txtCtaBancariaConsulta.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            panelCtaBancaria.Visible = false;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDConcepto.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            txtConceptoConsulta.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            panelConcepto.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCtaBancaria.Visible = true;
            cn.llenartablaa(dataGridView3.Tag.ToString(), dataGridView3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelConcepto.Visible = true;
            cn.llenartablaa(dataGridView4.Tag.ToString(), dataGridView4);
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            imprimirCheque frm_imp = new imprimirCheque();
            frm_imp.Show();
        }
    }
}
