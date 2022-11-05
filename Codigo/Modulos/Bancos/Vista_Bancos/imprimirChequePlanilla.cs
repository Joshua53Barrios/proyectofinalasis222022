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
    public partial class imprimirChequePlanilla : Form
    {
        public imprimirChequePlanilla()
        {
            InitializeComponent();
        }

        private void imprimirChequePlanilla_Load(object sender, EventArgs e)
        {

        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsCheque.DataTable1' Puede moverla o quitarla según sea necesario.
            int valor;
            valor = Convert.ToInt32(txtConsulta.Text);
            this.DataTable1TableAdapter.Fill(this.DsCheque.DataTable1,valor);

            this.reportViewer1.RefreshReport();
        }
    }
}
