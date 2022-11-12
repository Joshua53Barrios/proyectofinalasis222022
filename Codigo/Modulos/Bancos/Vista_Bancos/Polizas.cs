using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_Bancos
{
    public partial class Polizas : Form
    {
        public Polizas()
        {
            InitializeComponent();
        }

        private void agregarPólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaPoliza nuv = new NuevaPoliza();
           // nuv.MdiParent = this;
            nuv.Show();
        }

        private void consultarPólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaPoliza nuv = new consultaPoliza();
            // nuv.MdiParent = this;
            nuv.Show();
        }

        private void conceptoPolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConceptoPoliza conpol = new ConceptoPoliza();
            // nuv.MdiParent = this;
            ReportePoliza conpol = new ReportePoliza();
            conpol.Show();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir frm_im = new Imprimir();
            frm_im.Show();
        }
    }
}
