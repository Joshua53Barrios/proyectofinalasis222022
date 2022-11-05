
namespace Vista_Bancos
{
    partial class ChequePlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequePlanilla));
            this.navegador1 = new NavegadorVista.Navegador();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.txtConceptoConsulta = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTrabajadorConsulta = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBanosConsulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_covertirMonto = new System.Windows.Forms.Button();
            this.txtMontoLetras = new System.Windows.Forms.TextBox();
            this.txtIDBanco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaAp = new System.Windows.Forms.TextBox();
            this.txtFechaReg = new System.Windows.Forms.TextBox();
            this.txtIDConcepto = new System.Windows.Forms.TextBox();
            this.txtIDTrabajadores = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelConcepto = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.panelTrabajadores = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtConsultaTrabajador = new System.Windows.Forms.TextBox();
            this.panelBancos = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelConcepto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panelTrabajadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panelBancos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(54, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(771, 187);
            this.navegador1.TabIndex = 29;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(809, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btn_Imprimir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_Imprimir.Location = new System.Drawing.Point(447, 508);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(403, 41);
            this.btn_Imprimir.TabIndex = 74;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // txtConceptoConsulta
            // 
            this.txtConceptoConsulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConceptoConsulta.Location = new System.Drawing.Point(463, 419);
            this.txtConceptoConsulta.Name = "txtConceptoConsulta";
            this.txtConceptoConsulta.Size = new System.Drawing.Size(203, 27);
            this.txtConceptoConsulta.TabIndex = 73;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(313, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 44);
            this.button3.TabIndex = 72;
            this.button3.Text = "Generar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTrabajadorConsulta
            // 
            this.txtTrabajadorConsulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabajadorConsulta.Location = new System.Drawing.Point(463, 370);
            this.txtTrabajadorConsulta.Name = "txtTrabajadorConsulta";
            this.txtTrabajadorConsulta.Size = new System.Drawing.Size(203, 27);
            this.txtTrabajadorConsulta.TabIndex = 71;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(313, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 37);
            this.button2.TabIndex = 70;
            this.button2.Text = "Generar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBanosConsulta
            // 
            this.txtBanosConsulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanosConsulta.Location = new System.Drawing.Point(463, 325);
            this.txtBanosConsulta.Name = "txtBanosConsulta";
            this.txtBanosConsulta.Size = new System.Drawing.Size(203, 27);
            this.txtBanosConsulta.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 68;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_covertirMonto
            // 
            this.btn_covertirMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btn_covertirMonto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_covertirMonto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_covertirMonto.Location = new System.Drawing.Point(44, 508);
            this.btn_covertirMonto.Name = "btn_covertirMonto";
            this.btn_covertirMonto.Size = new System.Drawing.Size(394, 41);
            this.btn_covertirMonto.TabIndex = 67;
            this.btn_covertirMonto.Text = "Convertir Monto a Letras";
            this.btn_covertirMonto.UseVisualStyleBackColor = false;
            this.btn_covertirMonto.Click += new System.EventHandler(this.btn_covertirMonto_Click);
            // 
            // txtMontoLetras
            // 
            this.txtMontoLetras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoLetras.Location = new System.Drawing.Point(123, 465);
            this.txtMontoLetras.Name = "txtMontoLetras";
            this.txtMontoLetras.Size = new System.Drawing.Size(727, 27);
            this.txtMontoLetras.TabIndex = 66;
            this.txtMontoLetras.Tag = "MontoLet_chequesN";
            // 
            // txtIDBanco
            // 
            this.txtIDBanco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBanco.Location = new System.Drawing.Point(210, 324);
            this.txtIDBanco.Name = "txtIDBanco";
            this.txtIDBanco.Size = new System.Drawing.Size(86, 27);
            this.txtIDBanco.TabIndex = 65;
            this.txtIDBanco.Tag = "fk_Banco_chequesN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "ID Banco:";
            // 
            // txtFechaAp
            // 
            this.txtFechaAp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAp.Location = new System.Drawing.Point(711, 282);
            this.txtFechaAp.Name = "txtFechaAp";
            this.txtFechaAp.Size = new System.Drawing.Size(139, 27);
            this.txtFechaAp.TabIndex = 63;
            this.txtFechaAp.Tag = "fechaAplicacion_chequesN";
            // 
            // txtFechaReg
            // 
            this.txtFechaReg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaReg.Location = new System.Drawing.Point(339, 279);
            this.txtFechaReg.Name = "txtFechaReg";
            this.txtFechaReg.Size = new System.Drawing.Size(162, 27);
            this.txtFechaReg.TabIndex = 62;
            this.txtFechaReg.Tag = "fechaReg_chequesN";
            // 
            // txtIDConcepto
            // 
            this.txtIDConcepto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDConcepto.Location = new System.Drawing.Point(210, 415);
            this.txtIDConcepto.Name = "txtIDConcepto";
            this.txtIDConcepto.Size = new System.Drawing.Size(86, 27);
            this.txtIDConcepto.TabIndex = 61;
            this.txtIDConcepto.Tag = "fk_id_concepto";
            // 
            // txtIDTrabajadores
            // 
            this.txtIDTrabajadores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTrabajadores.Location = new System.Drawing.Point(210, 370);
            this.txtIDTrabajadores.Name = "txtIDTrabajadores";
            this.txtIDTrabajadores.Size = new System.Drawing.Size(86, 27);
            this.txtIDTrabajadores.TabIndex = 60;
            this.txtIDTrabajadores.Tag = "fk_trabajadornominas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "ID Trabajadores:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(85, 279);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(58, 27);
            this.txtID.TabIndex = 58;
            this.txtID.Tag = "Pk_idControl_chequesN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Suma de: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha de aplicación:";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(688, 422);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(162, 27);
            this.txtMonto.TabIndex = 55;
            this.txtMonto.Tag = "montoNum_chequesN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(721, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Fecha de registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "ID Concepto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 567);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 273);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.Tag = "tbl_ctrl_chequesnominas";
            // 
            // panelConcepto
            // 
            this.panelConcepto.Controls.Add(this.dataGridView4);
            this.panelConcepto.Location = new System.Drawing.Point(22, 3);
            this.panelConcepto.Name = "panelConcepto";
            this.panelConcepto.Size = new System.Drawing.Size(437, 198);
            this.panelConcepto.TabIndex = 79;
            this.panelConcepto.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(21, 26);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(392, 150);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.Tag = "tbl_conceptosbancario";
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // panelTrabajadores
            // 
            this.panelTrabajadores.Controls.Add(this.dataGridView3);
            this.panelTrabajadores.Location = new System.Drawing.Point(3, 12);
            this.panelTrabajadores.Name = "panelTrabajadores";
            this.panelTrabajadores.Size = new System.Drawing.Size(456, 196);
            this.panelTrabajadores.TabIndex = 78;
            this.panelTrabajadores.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(26, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(397, 150);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.Tag = "tbl_trabajador";
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // txtConsultaTrabajador
            // 
            this.txtConsultaTrabajador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaTrabajador.Location = new System.Drawing.Point(452, 369);
            this.txtConsultaTrabajador.Name = "txtConsultaTrabajador";
            this.txtConsultaTrabajador.Size = new System.Drawing.Size(203, 27);
            this.txtConsultaTrabajador.TabIndex = 77;
            // 
            // panelBancos
            // 
            this.panelBancos.Controls.Add(this.dataGridView2);
            this.panelBancos.Location = new System.Drawing.Point(12, 19);
            this.panelBancos.Name = "panelBancos";
            this.panelBancos.Size = new System.Drawing.Size(438, 198);
            this.panelBancos.TabIndex = 76;
            this.panelBancos.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(383, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Tag = "tbl_bancos";
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ChequePlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 866);
            this.Controls.Add(this.panelConcepto);
            this.Controls.Add(this.panelTrabajadores);
            this.Controls.Add(this.txtConsultaTrabajador);
            this.Controls.Add(this.panelBancos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.txtConceptoConsulta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTrabajadorConsulta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBanosConsulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_covertirMonto);
            this.Controls.Add(this.txtMontoLetras);
            this.Controls.Add(this.txtIDBanco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFechaAp);
            this.Controls.Add(this.txtFechaReg);
            this.Controls.Add(this.txtIDConcepto);
            this.Controls.Add(this.txtIDTrabajadores);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.navegador1);
            this.Name = "ChequePlanilla";
            this.Text = "Cheque Planilla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelConcepto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panelTrabajadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panelBancos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.TextBox txtConceptoConsulta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTrabajadorConsulta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBanosConsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_covertirMonto;
        private System.Windows.Forms.TextBox txtMontoLetras;
        private System.Windows.Forms.TextBox txtIDBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaAp;
        private System.Windows.Forms.TextBox txtFechaReg;
        private System.Windows.Forms.TextBox txtIDConcepto;
        private System.Windows.Forms.TextBox txtIDTrabajadores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelConcepto;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel panelTrabajadores;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtConsultaTrabajador;
        private System.Windows.Forms.Panel panelBancos;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}