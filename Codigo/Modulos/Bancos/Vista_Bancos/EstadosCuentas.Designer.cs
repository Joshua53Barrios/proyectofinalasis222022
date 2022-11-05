
namespace Vista_Bancos
{
    partial class EstadosCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtConsultaNombre = new System.Windows.Forms.TextBox();
            this.btnGenerarCuenta = new System.Windows.Forms.Button();
            this.txtCuentaBancos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataCuentaBancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsCheque = new Vista_Bancos.DsCheque();
            this.DataCuentaBancosTableAdapter = new Vista_Bancos.DsChequeTableAdapters.DataCuentaBancosTableAdapter();
            this.DataMovBancariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataMovBancariosTableAdapter = new Vista_Bancos.DsChequeTableAdapters.DataMovBancariosTableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCuentaBancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMovBancariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.txtConsultaNombre);
            this.groupBox1.Controls.Add(this.btnGenerarCuenta);
            this.groupBox1.Controls.Add(this.txtCuentaBancos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(954, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(732, 52);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(203, 41);
            this.btnImprimir.TabIndex = 57;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtConsultaNombre
            // 
            this.txtConsultaNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaNombre.Location = new System.Drawing.Point(508, 53);
            this.txtConsultaNombre.Name = "txtConsultaNombre";
            this.txtConsultaNombre.Size = new System.Drawing.Size(205, 34);
            this.txtConsultaNombre.TabIndex = 56;
            // 
            // btnGenerarCuenta
            // 
            this.btnGenerarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btnGenerarCuenta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCuenta.Location = new System.Drawing.Point(359, 50);
            this.btnGenerarCuenta.Name = "btnGenerarCuenta";
            this.btnGenerarCuenta.Size = new System.Drawing.Size(125, 44);
            this.btnGenerarCuenta.TabIndex = 54;
            this.btnGenerarCuenta.Text = "Generar";
            this.btnGenerarCuenta.UseVisualStyleBackColor = false;
            this.btnGenerarCuenta.Click += new System.EventHandler(this.btnGenerarCuenta_Click);
            // 
            // txtCuentaBancos
            // 
            this.txtCuentaBancos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaBancos.Location = new System.Drawing.Point(242, 53);
            this.txtCuentaBancos.Name = "txtCuentaBancos";
            this.txtCuentaBancos.Size = new System.Drawing.Size(100, 34);
            this.txtCuentaBancos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de cuenta bancos: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(20, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 472);
            this.panel1.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataCuentaBancosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DataMovBancariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista_Bancos.informEstadoCuentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(954, 472);
            this.reportViewer1.TabIndex = 0;
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.dataGridView1);
            this.panelConsulta.Location = new System.Drawing.Point(5, 12);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(368, 206);
            this.panelConsulta.TabIndex = 2;
            this.panelConsulta.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "tbl_cuentasbancos";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataCuentaBancosBindingSource
            // 
            this.DataCuentaBancosBindingSource.DataMember = "DataCuentaBancos";
            this.DataCuentaBancosBindingSource.DataSource = this.DsCheque;
            // 
            // DsCheque
            // 
            this.DsCheque.DataSetName = "DsCheque";
            this.DsCheque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataCuentaBancosTableAdapter
            // 
            this.DataCuentaBancosTableAdapter.ClearBeforeFill = true;
            // 
            // DataMovBancariosBindingSource
            // 
            this.DataMovBancariosBindingSource.DataMember = "DataMovBancarios";
            this.DataMovBancariosBindingSource.DataSource = this.DsCheque;
            // 
            // DataMovBancariosTableAdapter
            // 
            this.DataMovBancariosTableAdapter.ClearBeforeFill = true;
            // 
            // EstadosCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 647);
            this.Controls.Add(this.panelConsulta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EstadosCuentas";
            this.Text = "Estados de Cuentas";
            this.Load += new System.EventHandler(this.EstadosCuentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCuentaBancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMovBancariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtCuentaBancos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarCuenta;
        private System.Windows.Forms.TextBox txtConsultaNombre;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource DataCuentaBancosBindingSource;
        private DsCheque DsCheque;
        private DsChequeTableAdapters.DataCuentaBancosTableAdapter DataCuentaBancosTableAdapter;
        private System.Windows.Forms.BindingSource DataMovBancariosBindingSource;
        private DsChequeTableAdapters.DataMovBancariosTableAdapter DataMovBancariosTableAdapter;
    }
}