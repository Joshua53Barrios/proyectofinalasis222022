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
    public partial class NuevaPoliza : Form
    {
        CsControlador con = new CsControlador();

        public NuevaPoliza()
        {
            InitializeComponent();
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7003";
            TextBox[] Grupotextbox = { txt_nopoli, txt_fechapoli, txt_ctapoli, txt_elepoli, txt_debe, txt_haber, txt_descpoli };
            TextBox[] Idtextbox = { txt_nopoli, txt_fechapoli };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_polizasbancarias");
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            txt_fechapoli.Text = fecha_poli.Value.ToString("yyyy-MM-dd");
            txt_ctapoli.Text = cmb_cta.Text;
            txt_elepoli.Text = cmb_ele.Text;
            txt_descpoli.Text = cmb_descpoli.Text;
            this.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
            textBox4.Text= txt_debe.Text;
            textBox5.Text = txt_haber.Text;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7003";
            TextBox[] Grupotextbox = { txt_nopoli, txt_fechapoli, txt_ctapoli, txt_elepoli, txt_debe, txt_haber, txt_descpoli };
            TextBox[] Idtextbox = { txt_nopoli, txt_fechapoli };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_polizasbancarias");
        }
    }
}
