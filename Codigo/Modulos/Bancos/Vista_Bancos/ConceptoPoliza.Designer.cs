
namespace Vista_Bancos
{
    partial class ConceptoPoliza
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idtipopoli = new System.Windows.Forms.TextBox();
            this.txt_estadopoli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_despoli = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txt_idtipopoli
            // 
            this.txt_idtipopoli.Location = new System.Drawing.Point(61, 194);
            this.txt_idtipopoli.Name = "txt_idtipopoli";
            this.txt_idtipopoli.Size = new System.Drawing.Size(100, 20);
            this.txt_idtipopoli.TabIndex = 3;
            this.txt_idtipopoli.Tag = "Pk_TipoPoliza";
            // 
            // txt_estadopoli
            // 
            this.txt_estadopoli.Location = new System.Drawing.Point(492, 194);
            this.txt_estadopoli.Name = "txt_estadopoli";
            this.txt_estadopoli.Size = new System.Drawing.Size(100, 20);
            this.txt_estadopoli.TabIndex = 4;
            this.txt_estadopoli.Tag = "status_tipoPoliza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción";
            // 
            // txt_despoli
            // 
            this.txt_despoli.Location = new System.Drawing.Point(292, 197);
            this.txt_despoli.Name = "txt_despoli";
            this.txt_despoli.Size = new System.Drawing.Size(100, 20);
            this.txt_despoli.TabIndex = 7;
            this.txt_despoli.Tag = "descripcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 78);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Tag = "tbl_tipopoliza";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(30, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(578, 152);
            this.navegador1.TabIndex = 29;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load_1);
            // 
            // ConceptoPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 360);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_despoli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_estadopoli);
            this.Controls.Add(this.txt_idtipopoli);
            this.Controls.Add(this.label1);
            this.Name = "ConceptoPoliza";
            this.Text = "ConceptoPoliza";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idtipopoli;
        private System.Windows.Forms.TextBox txt_estadopoli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_despoli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NavegadorVista.Navegador navegador1;
    }
}