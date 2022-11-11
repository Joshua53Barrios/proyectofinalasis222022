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
    public partial class Reporte_Conciliacion : Form
    {
        CsControlador cn = new CsControlador();
        public Reporte_Conciliacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarReporteConciliacion generadorReportecon = new GenerarReporteConciliacion();
            generadorReportecon.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.llenartablaa(dataGridView1.Tag.ToString(), dataGridView1);
        }
    }
}
