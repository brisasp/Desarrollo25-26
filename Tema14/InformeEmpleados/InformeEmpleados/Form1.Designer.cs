namespace InformeEmpleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.InformeEmplleados1 = new InformeEmpleados.InformeEmplleados();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informePedidosAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informePedidosManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 24);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 426);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informePedidosAutoToolStripMenuItem,
            this.informePedidosManualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informePedidosAutoToolStripMenuItem
            // 
            this.informePedidosAutoToolStripMenuItem.Name = "informePedidosAutoToolStripMenuItem";
            this.informePedidosAutoToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.informePedidosAutoToolStripMenuItem.Text = "Informe Pedidos Auto";
            this.informePedidosAutoToolStripMenuItem.Click += new System.EventHandler(this.informePedidosAutoToolStripMenuItem_Click);
            // 
            // informePedidosManualToolStripMenuItem
            // 
            this.informePedidosManualToolStripMenuItem.Name = "informePedidosManualToolStripMenuItem";
            this.informePedidosManualToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.informePedidosManualToolStripMenuItem.Text = "Informe Pedidos manual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private InformeEmplleados InformeEmplleados1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informePedidosAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informePedidosManualToolStripMenuItem;
    }
}

