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
    public partial class Reporte_Orden : Form
    {
        CsControlador cn = new CsControlador();
        public Reporte_Orden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeneradorReporteOrden generadorReporteOrden = new GeneradorReporteOrden();
            generadorReporteOrden.Show();
        }
    }
}
