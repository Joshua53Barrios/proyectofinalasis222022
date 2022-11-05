
namespace Vista_Bancos
{
    partial class ReporteCuentasBancarias
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
            this.DataCuentasBancariasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsCheque = new Vista_Bancos.DsCheque();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConsultaMoneda = new System.Windows.Forms.TextBox();
            this.txtConsultaBancos = new System.Windows.Forms.TextBox();
            this.btnGenerarMoneda = new System.Windows.Forms.Button();
            this.btnGenerarBanco = new System.Windows.Forms.Button();
            this.btnPersonalizado = new System.Windows.Forms.Button();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBancos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnImpGeneral = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelConsultaBancos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelConsultaMoneda = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DataCuentasBancariasTableAdapter = new Vista_Bancos.DsChequeTableAdapters.DataCuentasBancariasTableAdapter();
            this.panelPersonalizado = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataMiembrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataMiembrosTableAdapter = new Vista_Bancos.DsChequeTableAdapters.DataMiembrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataCuentasBancariasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCheque)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnImpGeneral.SuspendLayout();
            this.panelConsultaBancos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelConsultaMoneda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelPersonalizado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMiembrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataCuentasBancariasBindingSource
            // 
            this.DataCuentasBancariasBindingSource.DataMember = "DataCuentasBancarias";
            this.DataCuentasBancariasBindingSource.DataSource = this.DsCheque;
            // 
            // DsCheque
            // 
            this.DsCheque.DataSetName = "DsCheque";
            this.DsCheque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Imprimir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btn_Imprimir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_Imprimir.Location = new System.Drawing.Point(20, 67);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(278, 41);
            this.btn_Imprimir.TabIndex = 51;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar todas las cuentas bancarias";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConsultaMoneda);
            this.groupBox2.Controls.Add(this.txtConsultaBancos);
            this.groupBox2.Controls.Add(this.btnGenerarMoneda);
            this.groupBox2.Controls.Add(this.btnGenerarBanco);
            this.groupBox2.Controls.Add(this.btnPersonalizado);
            this.groupBox2.Controls.Add(this.txtMoneda);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBancos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(346, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personalizado";
            // 
            // txtConsultaMoneda
            // 
            this.txtConsultaMoneda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaMoneda.Location = new System.Drawing.Point(558, 83);
            this.txtConsultaMoneda.Name = "txtConsultaMoneda";
            this.txtConsultaMoneda.Size = new System.Drawing.Size(163, 30);
            this.txtConsultaMoneda.TabIndex = 56;
            // 
            // txtConsultaBancos
            // 
            this.txtConsultaBancos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaBancos.Location = new System.Drawing.Point(558, 33);
            this.txtConsultaBancos.Name = "txtConsultaBancos";
            this.txtConsultaBancos.Size = new System.Drawing.Size(163, 30);
            this.txtConsultaBancos.TabIndex = 55;
            // 
            // btnGenerarMoneda
            // 
            this.btnGenerarMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btnGenerarMoneda.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarMoneda.ForeColor = System.Drawing.Color.White;
            this.btnGenerarMoneda.Location = new System.Drawing.Point(452, 80);
            this.btnGenerarMoneda.Name = "btnGenerarMoneda";
            this.btnGenerarMoneda.Size = new System.Drawing.Size(100, 38);
            this.btnGenerarMoneda.TabIndex = 54;
            this.btnGenerarMoneda.Text = "Generar";
            this.btnGenerarMoneda.UseVisualStyleBackColor = false;
            this.btnGenerarMoneda.Click += new System.EventHandler(this.btnGenerarMoneda_Click);
            // 
            // btnGenerarBanco
            // 
            this.btnGenerarBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btnGenerarBanco.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarBanco.ForeColor = System.Drawing.Color.White;
            this.btnGenerarBanco.Location = new System.Drawing.Point(452, 33);
            this.btnGenerarBanco.Name = "btnGenerarBanco";
            this.btnGenerarBanco.Size = new System.Drawing.Size(100, 34);
            this.btnGenerarBanco.TabIndex = 53;
            this.btnGenerarBanco.Text = "Generar";
            this.btnGenerarBanco.UseVisualStyleBackColor = false;
            this.btnGenerarBanco.Click += new System.EventHandler(this.btnGenerarBanco_Click);
            // 
            // btnPersonalizado
            // 
            this.btnPersonalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btnPersonalizado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalizado.ForeColor = System.Drawing.Color.White;
            this.btnPersonalizado.Location = new System.Drawing.Point(19, 77);
            this.btnPersonalizado.Name = "btnPersonalizado";
            this.btnPersonalizado.Size = new System.Drawing.Size(248, 41);
            this.btnPersonalizado.TabIndex = 52;
            this.btnPersonalizado.Text = "Imprimir";
            this.btnPersonalizado.UseVisualStyleBackColor = false;
            this.btnPersonalizado.Click += new System.EventHandler(this.btnPersonalizado_Click);
            // 
            // txtMoneda
            // 
            this.txtMoneda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.Location = new System.Drawing.Point(375, 80);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(71, 30);
            this.txtMoneda.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Moneda: ";
            // 
            // txtBancos
            // 
            this.txtBancos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBancos.Location = new System.Drawing.Point(375, 33);
            this.txtBancos.Name = "txtBancos";
            this.txtBancos.Size = new System.Drawing.Size(71, 30);
            this.txtBancos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Banco: ";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(181, 33);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(86, 30);
            this.txtEstado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado de la cuenta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnImpGeneral
            // 
            this.pnImpGeneral.Controls.Add(this.reportViewer1);
            this.pnImpGeneral.Location = new System.Drawing.Point(25, 169);
            this.pnImpGeneral.Name = "pnImpGeneral";
            this.pnImpGeneral.Size = new System.Drawing.Size(1047, 635);
            this.pnImpGeneral.TabIndex = 2;
            this.pnImpGeneral.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataCuentasBancariasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Vista_Bancos.informeGeneralCtaBancarias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1047, 635);
            this.reportViewer1.TabIndex = 0;
            // 
            // panelConsultaBancos
            // 
            this.panelConsultaBancos.Controls.Add(this.dataGridView1);
            this.panelConsultaBancos.Location = new System.Drawing.Point(23, 8);
            this.panelConsultaBancos.Name = "panelConsultaBancos";
            this.panelConsultaBancos.Size = new System.Drawing.Size(332, 155);
            this.panelConsultaBancos.TabIndex = 3;
            this.panelConsultaBancos.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(307, 135);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "tbl_Bancos";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelConsultaMoneda
            // 
            this.panelConsultaMoneda.Controls.Add(this.dataGridView2);
            this.panelConsultaMoneda.Location = new System.Drawing.Point(8, 5);
            this.panelConsultaMoneda.Name = "panelConsultaMoneda";
            this.panelConsultaMoneda.Size = new System.Drawing.Size(344, 155);
            this.panelConsultaMoneda.TabIndex = 4;
            this.panelConsultaMoneda.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 11);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(308, 135);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Tag = "tbl_reg_tipocambio";
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // DataCuentasBancariasTableAdapter
            // 
            this.DataCuentasBancariasTableAdapter.ClearBeforeFill = true;
            // 
            // panelPersonalizado
            // 
            this.panelPersonalizado.Controls.Add(this.reportViewer2);
            this.panelPersonalizado.Location = new System.Drawing.Point(25, 166);
            this.panelPersonalizado.Name = "panelPersonalizado";
            this.panelPersonalizado.Size = new System.Drawing.Size(1047, 638);
            this.panelPersonalizado.TabIndex = 5;
            this.panelPersonalizado.Visible = false;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataMiembrosBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Vista_Bancos.informePersoCuentasBancarias.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1047, 638);
            this.reportViewer2.TabIndex = 0;
            // 
            // DataMiembrosBindingSource
            // 
            this.DataMiembrosBindingSource.DataMember = "DataMiembros";
            this.DataMiembrosBindingSource.DataSource = this.DsCheque;
            // 
            // DataMiembrosTableAdapter
            // 
            this.DataMiembrosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCuentasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 836);
            this.Controls.Add(this.panelPersonalizado);
            this.Controls.Add(this.panelConsultaMoneda);
            this.Controls.Add(this.panelConsultaBancos);
            this.Controls.Add(this.pnImpGeneral);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReporteCuentasBancarias";
            this.Text = "Reportes Cuentas Bancarias";
            this.Load += new System.EventHandler(this.ReporteCuentasBancarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataCuentasBancariasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsCheque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnImpGeneral.ResumeLayout(false);
            this.panelConsultaBancos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelConsultaMoneda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelPersonalizado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMiembrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Panel pnImpGeneral;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataCuentasBancariasBindingSource;
        private DsCheque DsCheque;
        private DsChequeTableAdapters.DataCuentasBancariasTableAdapter DataCuentasBancariasTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBancos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnGenerarMoneda;
        private System.Windows.Forms.Button btnGenerarBanco;
        private System.Windows.Forms.Button btnPersonalizado;
        private System.Windows.Forms.TextBox txtConsultaMoneda;
        private System.Windows.Forms.TextBox txtConsultaBancos;
        private System.Windows.Forms.Panel panelConsultaBancos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelConsultaMoneda;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panelPersonalizado;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource DataMiembrosBindingSource;
        private DsChequeTableAdapters.DataMiembrosTableAdapter DataMiembrosTableAdapter;
    }
}