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

    public partial class Banco_Form : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public Banco_Form()
        {
            InitializeComponent();
            HideStart();
            Button[] apps = {CncBancario,btnCheques,btnDepositos,btnDisponibilidad,
            btnMovBanc,btnBitacora,btnIngresosEgresos,btnPolizas,btnReportes,
            btnOrdenes,btnBancos,btnCuentasBanc,btnTipoDeCambio};
            cnseg.deshabilitarApps(apps);

            cnseg.getAccesoApp(7101, apps[0]);
            cnseg.getAccesoApp(7002, apps[1]);
            cnseg.getAccesoApp(7003, apps[2]);
            cnseg.getAccesoApp(7004, apps[3]);
            cnseg.getAccesoApp(7001, apps[4]);
            cnseg.getAccesoApp(7102, apps[5]);
            cnseg.getAccesoApp(7103, apps[6]);
            cnseg.getAccesoApp(7104, apps[7]);
            cnseg.getAccesoApp(7105, apps[8]);
            cnseg.getAccesoApp(7106, apps[9]);
            cnseg.getAccesoApp(7201, apps[10]);
            cnseg.getAccesoApp(7202, apps[11]);
            cnseg.getAccesoApp(7203, apps[12]);

        }
        private void HideStart()
        {
            //Metodo para cubrir los paneles
            panelConceptosBanc.Visible = false;
            panelPartidasCont.Visible = false;
            panelMantenimientos.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelConceptosBanc.Visible == true)
                panelConceptosBanc.Visible = false;
            if (panelPartidasCont.Visible == true)
                panelPartidasCont.Visible = false;
            if (panelMantenimientos.Visible == true)
                panelMantenimientos.Visible = false;
            if(panel1.Visible==true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }
        private void Banco_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMantenimientos);
        }

        private void btnConceptosBanc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConceptosBanc);
        }

        private void btnPartidasCont_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPartidasCont);
        }

        private void btnCheques_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Cheque frm_cheque = new Cheque();
            frm_cheque.MdiParent = this;
            frm_cheque.Show();
            logop.Visible = false;
        }

        private void btnDepositos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChequePlanilla frm_chequePlanilla = new ChequePlanilla();
            frm_chequePlanilla.MdiParent = this;
            frm_chequePlanilla.Show();
            logop.Visible = false;
        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Disponibilidad frm_dispo = new Disponibilidad();
            frm_dispo.MdiParent = this;
            frm_dispo.Show();
            logop.Visible = false;
        }

        private void btnMovBanc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            MovBancos frm_mantbancos = new MovBancos();
            frm_mantbancos.MdiParent = this;
            frm_mantbancos.Show();
            logop.Visible = false;
        }

        private void btnTipoDeCambio_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            tipoCambio frm_tcambio = new tipoCambio();
            frm_tcambio.MdiParent = this;
            frm_tcambio.Show();
            logop.Visible = false;
        }

        private void btnPolizas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //ConceptoPoliza pol = new ConceptoPoliza();
            Polizas pol = new Polizas();
            pol.MdiParent = this;
            pol.Show();
            logop.Visible = false;
        }

        private void btnIngresosEgresos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Reporte_Conciliacion form_conci = new Reporte_Conciliacion();
            form_conci.MdiParent = this;
            form_conci.Show();
            logop.Visible = false;
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Reporte_Orden form_orde = new Reporte_Orden();
            form_orde.MdiParent = this;
            form_orde.Show();
            logop.Visible = false;
        }

        private void btnRepBanc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnBancos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            MantBancos frm_mtbancos = new MantBancos();
            frm_mtbancos.MdiParent = this;
            frm_mtbancos.Show();
            logop.Visible = false;
        }

        private void btnCuentasBanc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            MntCuentas frm_cuentas = new MntCuentas();
            frm_cuentas.MdiParent = this;
            frm_cuentas.Show();
            logop.Visible = false;
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            BitacoraBancos frm_bi = new BitacoraBancos();
            frm_bi.MdiParent = this;
            frm_bi.Show();
            logop.Visible = false;
        }

        private void CncBancario_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ConceptoBancario frm_cb = new ConceptoBancario();
            frm_cb.MdiParent = this;
            frm_cb.Show();
            logop.Visible = false;
        }

        private void btnTipoDeCambio_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            tipoCambio frm_tcambio = new tipoCambio();
            frm_tcambio.MdiParent = this;
            frm_tcambio.Show();
            logop.Visible = false;
        }

        private void btnConcilacionBancaria_Click(object sender, EventArgs e)
        {
  
        }

        private void btnRepCuentasBanc_Click(object sender, EventArgs e)
        {
            ReporteCuentasBancarias form_rptCuenBanc = new ReporteCuentasBancarias();
            form_rptCuenBanc.MdiParent = this;
            form_rptCuenBanc.Show();
            logop.Visible = false;
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ReporteCuentasBancarias form_rptCuenBanc = new ReporteCuentasBancarias();
            form_rptCuenBanc.MdiParent = this;
            form_rptCuenBanc.Show();
            logop.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            EstadosCuentas form_estcta = new EstadosCuentas();
            form_estcta.MdiParent = this;
            form_estcta.Show();
            logop.Visible = false;
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void btnconsultaA_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Capa_VistaConsultas.Busqueda consultar = new Capa_VistaConsultas.Busqueda();
            consultar.MdiParent = this;
            consultar.StartPosition = FormStartPosition.CenterScreen;
            consultar.Show();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
