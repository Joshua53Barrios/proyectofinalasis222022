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
    public partial class ReporteDisponibilidad : Form
    {
        public ReporteDisponibilidad()
        {
            InitializeComponent();
        }

        private void ReporteDisponibilidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsCheque.DataTable2' Puede moverla o quitarla según sea necesario.
            this.DataTable2TableAdapter.Fill(this.DsCheque.DataTable2);

            this.reportViewer1.RefreshReport();
        }
    }
}
