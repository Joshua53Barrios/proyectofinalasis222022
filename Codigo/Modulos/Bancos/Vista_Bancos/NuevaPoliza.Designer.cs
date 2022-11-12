
namespace Vista_Bancos
{
    partial class NuevaPoliza
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.cmb_cta = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_descpoli = new System.Windows.Forms.ComboBox();
            this.fecha_poli = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descpoli = new System.Windows.Forms.TextBox();
            this.txt_nopoli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_haber = new System.Windows.Forms.TextBox();
            this.txt_debe = new System.Windows.Forms.TextBox();
            this.cmb_ele = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_fechapoli = new System.Windows.Forms.TextBox();
            this.txt_ctapoli = new System.Windows.Forms.TextBox();
            this.txt_elepoli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 141);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Tag = "tbl_polizasbancarias";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.Location = new System.Drawing.Point(470, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Generar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmb_cta
            // 
            this.cmb_cta.FormattingEnabled = true;
            this.cmb_cta.Items.AddRange(new object[] {
            "CLIENTES",
            "VENTAS",
            "COMPRAS",
            "CAJA CHICA",
            "BANCOS",
            "IVA POR COBRAR",
            "IVA POR PAGAR"});
            this.cmb_cta.Location = new System.Drawing.Point(7, 31);
            this.cmb_cta.Name = "cmb_cta";
            this.cmb_cta.Size = new System.Drawing.Size(101, 21);
            this.cmb_cta.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_descpoli);
            this.panel1.Location = new System.Drawing.Point(20, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 57);
            this.panel1.TabIndex = 3;
            // 
            // cmb_descpoli
            // 
            this.cmb_descpoli.FormattingEnabled = true;
            this.cmb_descpoli.Items.AddRange(new object[] {
            "Clientes por cobrar",
            "Pago por transferencia",
            "Pago a proveedores",
            "Registrando Venta",
            "Registrando compra",
            "Pago a acreedores",
            "Pago a empleados",
            "Pago de Iva"});
            this.cmb_descpoli.Location = new System.Drawing.Point(223, 31);
            this.cmb_descpoli.Name = "cmb_descpoli";
            this.cmb_descpoli.Size = new System.Drawing.Size(242, 21);
            this.cmb_descpoli.TabIndex = 0;
            // 
            // fecha_poli
            // 
            this.fecha_poli.CustomFormat = "yyyy-MM-dd";
            this.fecha_poli.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_poli.Location = new System.Drawing.Point(135, 199);
            this.fecha_poli.Name = "fecha_poli";
            this.fecha_poli.Size = new System.Drawing.Size(103, 20);
            this.fecha_poli.TabIndex = 9;
            this.fecha_poli.Value = new System.DateTime(2022, 11, 11, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Location = new System.Drawing.Point(491, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. ";
            // 
            // txt_descpoli
            // 
            this.txt_descpoli.Location = new System.Drawing.Point(260, 450);
            this.txt_descpoli.Name = "txt_descpoli";
            this.txt_descpoli.Size = new System.Drawing.Size(72, 20);
            this.txt_descpoli.TabIndex = 3;
            this.txt_descpoli.Tag = "descrip_poli";
            // 
            // txt_nopoli
            // 
            this.txt_nopoli.Location = new System.Drawing.Point(29, 199);
            this.txt_nopoli.Name = "txt_nopoli";
            this.txt_nopoli.Size = new System.Drawing.Size(100, 20);
            this.txt_nopoli.TabIndex = 1;
            this.txt_nopoli.Tag = "Pk_idPoliza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de la póliza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Detalle de la póliza";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_haber);
            this.panel2.Controls.Add(this.txt_debe);
            this.panel2.Controls.Add(this.cmb_ele);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.cmb_cta);
            this.panel2.Location = new System.Drawing.Point(21, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 57);
            this.panel2.TabIndex = 4;
            // 
            // txt_haber
            // 
            this.txt_haber.Location = new System.Drawing.Point(356, 32);
            this.txt_haber.Name = "txt_haber";
            this.txt_haber.Size = new System.Drawing.Size(74, 20);
            this.txt_haber.TabIndex = 14;
            this.txt_haber.Tag = "haber_poli";
            // 
            // txt_debe
            // 
            this.txt_debe.Location = new System.Drawing.Point(261, 32);
            this.txt_debe.Name = "txt_debe";
            this.txt_debe.Size = new System.Drawing.Size(74, 20);
            this.txt_debe.TabIndex = 12;
            this.txt_debe.Tag = "debe_poli";
            // 
            // cmb_ele
            // 
            this.cmb_ele.FormattingEnabled = true;
            this.cmb_ele.Items.AddRange(new object[] {
            "CLIENTES",
            "VENTAS",
            "COMPRAS",
            "CAJA CHICA",
            "BANCOS",
            "IVA POR COBRAR",
            "IVA POR PAGAR"});
            this.cmb_ele.Location = new System.Drawing.Point(127, 31);
            this.cmb_ele.Name = "cmb_ele";
            this.cmb_ele.Size = new System.Drawing.Size(101, 21);
            this.cmb_ele.TabIndex = 13;
            this.cmb_ele.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Haber";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Debe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cuenta II";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cuenta";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(412, 450);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(492, 450);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 22);
            this.textBox5.TabIndex = 10;
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(1, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(572, 157);
            this.navegador1.TabIndex = 11;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txt_fechapoli
            // 
            this.txt_fechapoli.Location = new System.Drawing.Point(20, 450);
            this.txt_fechapoli.Name = "txt_fechapoli";
            this.txt_fechapoli.Size = new System.Drawing.Size(74, 20);
            this.txt_fechapoli.TabIndex = 15;
            this.txt_fechapoli.Tag = "fecha_poli";
            // 
            // txt_ctapoli
            // 
            this.txt_ctapoli.Location = new System.Drawing.Point(100, 450);
            this.txt_ctapoli.Name = "txt_ctapoli";
            this.txt_ctapoli.Size = new System.Drawing.Size(74, 20);
            this.txt_ctapoli.TabIndex = 15;
            this.txt_ctapoli.Tag = "cuentai_poli";
            // 
            // txt_elepoli
            // 
            this.txt_elepoli.Location = new System.Drawing.Point(180, 450);
            this.txt_elepoli.Name = "txt_elepoli";
            this.txt_elepoli.Size = new System.Drawing.Size(74, 20);
            this.txt_elepoli.TabIndex = 15;
            this.txt_elepoli.Tag = "cuentaii_poli";
            // 
            // NuevaPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(585, 477);
            this.Controls.Add(this.txt_elepoli);
            this.Controls.Add(this.txt_ctapoli);
            this.Controls.Add(this.txt_fechapoli);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.fecha_poli);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_descpoli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nopoli);
            this.Controls.Add(this.panel1);
            this.Name = "NuevaPoliza";
            this.Text = "NuevaPoliza";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmb_cta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descpoli;
        private System.Windows.Forms.TextBox txt_nopoli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fecha_poli;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_haber;
        private System.Windows.Forms.TextBox txt_debe;
        private System.Windows.Forms.ComboBox cmb_ele;
        private System.Windows.Forms.TextBox txt_fechapoli;
        private System.Windows.Forms.TextBox txt_ctapoli;
        private System.Windows.Forms.TextBox txt_elepoli;
        private System.Windows.Forms.ComboBox cmb_descpoli;
    }
}