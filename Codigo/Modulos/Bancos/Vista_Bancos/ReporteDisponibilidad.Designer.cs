﻿
namespace Vista_Bancos
{
    partial class ReporteDisponibilidad
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsCheque = new Vista_Bancos.DsCheque();
            this.DataCuentasBancariasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataCuentasBancariasTableAdapter = new Vista_Bancos.DsChequeTableAdapters.DataCuentasBancariasTableAdapter();
            this.DataMiembrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataMiembrosTableAdapter = new Vista_Bancos.DsChequeTableAdapters.DataMiembrosTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new Vista_Bancos.DsChequeTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCuentasBancariasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMiembrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 422);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsCheque
            // 
            this.DsCheque.DataSetName = "DsCheque";
            this.DsCheque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataCuentasBancariasBindingSource
            // 
            this.DataCuentasBancariasBindingSource.DataMember = "DataCuentasBancarias";
            this.DataCuentasBancariasBindingSource.DataSource = this.DsCheque;
            // 
            // DataCuentasBancariasTableAdapter
            // 
            this.DataCuentasBancariasTableAdapter.ClearBeforeFill = true;
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
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DsCheque;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteDisponibilidad";
            this.Text = "ReporteDisponibilidad";
            this.Load += new System.EventHandler(this.ReporteDisponibilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCuentasBancariasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMiembrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DataCuentasBancariasBindingSource;
        private DsCheque DsCheque;
        private DsChequeTableAdapters.DataCuentasBancariasTableAdapter DataCuentasBancariasTableAdapter;
        private System.Windows.Forms.BindingSource DataMiembrosBindingSource;
        private DsChequeTableAdapters.DataMiembrosTableAdapter DataMiembrosTableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DsChequeTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}