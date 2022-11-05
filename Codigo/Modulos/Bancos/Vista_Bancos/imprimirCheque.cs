using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Vista_Bancos
{
    public partial class imprimirCheque : Form
    {
        public imprimirCheque()
        {
            InitializeComponent();
        }

        private void imprimirCheque_Load(object sender, EventArgs e)
        {

        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsCheque.DataTableCheque' Puede moverla o quitarla según sea necesario.
            int valor;
            valor = Convert.ToInt32(txtConsulta.Text);
            this.DataTableChequeTableAdapter.Fill(this.DsCheque.DataTableCheque,valor);

            this.reportViewer1.RefreshReport();
        }
    }
}
