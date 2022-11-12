
namespace Vista_Bancos
{
    partial class Polizas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarPólizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPólizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptoPolizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPólizasToolStripMenuItem,
            this.consultarPólizasToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.conceptoPolizasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarPólizasToolStripMenuItem
            // 
            this.agregarPólizasToolStripMenuItem.Name = "agregarPólizasToolStripMenuItem";
            this.agregarPólizasToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.agregarPólizasToolStripMenuItem.Text = "Agregar pólizas";
            this.agregarPólizasToolStripMenuItem.Click += new System.EventHandler(this.agregarPólizasToolStripMenuItem_Click);
            // 
            // consultarPólizasToolStripMenuItem
            // 
            this.consultarPólizasToolStripMenuItem.Name = "consultarPólizasToolStripMenuItem";
            this.consultarPólizasToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.consultarPólizasToolStripMenuItem.Text = "Consultar pólizas";
            this.consultarPólizasToolStripMenuItem.Click += new System.EventHandler(this.consultarPólizasToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir ";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // conceptoPolizasToolStripMenuItem
            // 
            this.conceptoPolizasToolStripMenuItem.Name = "conceptoPolizasToolStripMenuItem";
            this.conceptoPolizasToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.conceptoPolizasToolStripMenuItem.Text = "Concepto polizas";
            this.conceptoPolizasToolStripMenuItem.Click += new System.EventHandler(this.conceptoPolizasToolStripMenuItem_Click);
            // 
            // Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 219);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Polizas";
            this.Text = "Polizas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarPólizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPólizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptoPolizasToolStripMenuItem;
    }
}