
namespace Vista_Bancos
{
    partial class Cheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cheque));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDCuentaBancaria = new System.Windows.Forms.TextBox();
            this.txtIDConcepto = new System.Windows.Forms.TextBox();
            this.txtFechaReg = new System.Windows.Forms.TextBox();
            this.txtFechaAp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDBanco = new System.Windows.Forms.TextBox();
            this.txtMontoLetras = new System.Windows.Forms.TextBox();
            this.btn_covertirMonto = new System.Windows.Forms.Button();
            this.panelBancos = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBanosConsulta = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCtaBancariaConsulta = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtConceptoConsulta = new System.Windows.Forms.TextBox();
            this.panelCtaBancaria = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panelConcepto = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBancos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelCtaBancaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panelConcepto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Concepto: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de registro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(752, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(719, 421);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(162, 27);
            this.txtMonto.TabIndex = 6;
            this.txtMonto.Tag = "montoNum_cheques";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de aplicación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Suma de: ";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(96, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(771, 187);
            this.navegador1.TabIndex = 28;
            this.navegador1.Load += new System.EventHandler(this.navegador2_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 554);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 261);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.Tag = "tbl_ctrl_cheques";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(116, 278);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(58, 27);
            this.txtID.TabIndex = 30;
            this.txtID.Tag = "Pk_idControl_cheques";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "ID Cuenta Bancaria:";
            // 
            // txtIDCuentaBancaria
            // 
            this.txtIDCuentaBancaria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCuentaBancaria.Location = new System.Drawing.Point(241, 369);
            this.txtIDCuentaBancaria.Name = "txtIDCuentaBancaria";
            this.txtIDCuentaBancaria.Size = new System.Drawing.Size(86, 27);
            this.txtIDCuentaBancaria.TabIndex = 32;
            this.txtIDCuentaBancaria.Tag = "fk_id_cuentabancaria";
            // 
            // txtIDConcepto
            // 
            this.txtIDConcepto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDConcepto.Location = new System.Drawing.Point(241, 414);
            this.txtIDConcepto.Name = "txtIDConcepto";
            this.txtIDConcepto.Size = new System.Drawing.Size(86, 27);
            this.txtIDConcepto.TabIndex = 33;
            this.txtIDConcepto.Tag = "fk_id_concepto";
            this.txtIDConcepto.TextChanged += new System.EventHandler(this.txtIDConcepto_TextChanged);
            // 
            // txtFechaReg
            // 
            this.txtFechaReg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaReg.Location = new System.Drawing.Point(370, 278);
            this.txtFechaReg.Name = "txtFechaReg";
            this.txtFechaReg.Size = new System.Drawing.Size(162, 27);
            this.txtFechaReg.TabIndex = 34;
            this.txtFechaReg.Tag = "fechaReg_cheques";
            // 
            // txtFechaAp
            // 
            this.txtFechaAp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAp.Location = new System.Drawing.Point(742, 281);
            this.txtFechaAp.Name = "txtFechaAp";
            this.txtFechaAp.Size = new System.Drawing.Size(139, 27);
            this.txtFechaAp.TabIndex = 35;
            this.txtFechaAp.Tag = "fechaAplicacion_cheques";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID Banco:";
            // 
            // txtIDBanco
            // 
            this.txtIDBanco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBanco.Location = new System.Drawing.Point(241, 324);
            this.txtIDBanco.Name = "txtIDBanco";
            this.txtIDBanco.Size = new System.Drawing.Size(86, 27);
            this.txtIDBanco.TabIndex = 37;
            this.txtIDBanco.Tag = "fk_Banco_cheques";
            // 
            // txtMontoLetras
            // 
            this.txtMontoLetras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoLetras.Location = new System.Drawing.Point(154, 464);
            this.txtMontoLetras.Name = "txtMontoLetras";
            this.txtMontoLetras.Size = new System.Drawing.Size(727, 27);
            this.txtMontoLetras.TabIndex = 38;
            this.txtMontoLetras.Tag = "MontoLet_cheques";
            // 
            // btn_covertirMonto
            // 
            this.btn_covertirMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btn_covertirMonto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_covertirMonto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_covertirMonto.Location = new System.Drawing.Point(75, 507);
            this.btn_covertirMonto.Name = "btn_covertirMonto";
            this.btn_covertirMonto.Size = new System.Drawing.Size(394, 41);
            this.btn_covertirMonto.TabIndex = 40;
            this.btn_covertirMonto.Text = "Convertir Monto a Letras";
            this.btn_covertirMonto.UseVisualStyleBackColor = false;
            this.btn_covertirMonto.Click += new System.EventHandler(this.btn_covertirMonto_Click);
            // 
            // panelBancos
            // 
            this.panelBancos.Controls.Add(this.dataGridView2);
            this.panelBancos.Location = new System.Drawing.Point(508, 13);
            this.panelBancos.Name = "panelBancos";
            this.panelBancos.Size = new System.Drawing.Size(438, 198);
            this.panelBancos.TabIndex = 41;
            this.panelBancos.Visible = false;
            this.panelBancos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 42;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtBanosConsulta
            // 
            this.txtBanosConsulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanosConsulta.Location = new System.Drawing.Point(494, 324);
            this.txtBanosConsulta.Name = "txtBanosConsulta";
            this.txtBanosConsulta.Size = new System.Drawing.Size(203, 27);
            this.txtBanosConsulta.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(344, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 39);
            this.button2.TabIndex = 44;
            this.button2.Text = "Generar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCtaBancariaConsulta
            // 
            this.txtCtaBancariaConsulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtaBancariaConsulta.Location = new System.Drawing.Point(494, 369);
            this.txtCtaBancariaConsulta.Name = "txtCtaBancariaConsulta";
            this.txtCtaBancariaConsulta.Size = new System.Drawing.Size(203, 27);
            this.txtCtaBancariaConsulta.TabIndex = 45;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(344, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 44);
            this.button3.TabIndex = 46;
            this.button3.Text = "Generar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtConceptoConsulta
            // 
            this.txtConceptoConsulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConceptoConsulta.Location = new System.Drawing.Point(494, 418);
            this.txtConceptoConsulta.Name = "txtConceptoConsulta";
            this.txtConceptoConsulta.Size = new System.Drawing.Size(203, 27);
            this.txtConceptoConsulta.TabIndex = 47;
            // 
            // panelCtaBancaria
            // 
            this.panelCtaBancaria.Controls.Add(this.dataGridView3);
            this.panelCtaBancaria.Location = new System.Drawing.Point(24, 13);
            this.panelCtaBancaria.Name = "panelCtaBancaria";
            this.panelCtaBancaria.Size = new System.Drawing.Size(456, 196);
            this.panelCtaBancaria.TabIndex = 48;
            this.panelCtaBancaria.Visible = false;
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
            this.dataGridView3.Tag = "tbl_ctabancarias";
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // panelConcepto
            // 
            this.panelConcepto.Controls.Add(this.dataGridView4);
            this.panelConcepto.Location = new System.Drawing.Point(12, 8);
            this.panelConcepto.Name = "panelConcepto";
            this.panelConcepto.Size = new System.Drawing.Size(473, 198);
            this.panelConcepto.TabIndex = 49;
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
            // btn_Imprimir
            // 
            this.btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(203)))), ((int)(((byte)(175)))));
            this.btn_Imprimir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_Imprimir.Location = new System.Drawing.Point(478, 507);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(403, 41);
            this.btn_Imprimir.TabIndex = 50;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(809, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 853);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.panelConcepto);
            this.Controls.Add(this.panelCtaBancaria);
            this.Controls.Add(this.txtConceptoConsulta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCtaBancariaConsulta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBanosConsulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelBancos);
            this.Controls.Add(this.btn_covertirMonto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtMontoLetras);
            this.Controls.Add(this.txtIDBanco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFechaAp);
            this.Controls.Add(this.txtFechaReg);
            this.Controls.Add(this.txtIDConcepto);
            this.Controls.Add(this.txtIDCuentaBancaria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cheque";
            this.Text = "Cheque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBancos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelCtaBancaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panelConcepto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDCuentaBancaria;
        private System.Windows.Forms.TextBox txtIDConcepto;
        private System.Windows.Forms.TextBox txtFechaReg;
        private System.Windows.Forms.TextBox txtFechaAp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDBanco;
        private System.Windows.Forms.TextBox txtMontoLetras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_covertirMonto;
        private System.Windows.Forms.Panel panelBancos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBanosConsulta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCtaBancariaConsulta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtConceptoConsulta;
        private System.Windows.Forms.Panel panelCtaBancaria;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panelConcepto;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btn_Imprimir;
    }
}