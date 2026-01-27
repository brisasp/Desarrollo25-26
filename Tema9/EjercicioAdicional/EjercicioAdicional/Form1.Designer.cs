namespace EjercicioAdicional
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tamañpoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGrande = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMediano = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPequeño = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.salirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamañpoToolStripMenuItem,
            this.textoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tamañpoToolStripMenuItem
            // 
            this.tamañpoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGrande,
            this.MenuMediano,
            this.MenuPequeño,
            this.salirToolStripMenuItem,
            this.salirMenu});
            this.tamañpoToolStripMenuItem.Name = "tamañpoToolStripMenuItem";
            this.tamañpoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tamañpoToolStripMenuItem.Text = "Tamaño";
            // 
            // MenuGrande
            // 
            this.MenuGrande.Name = "MenuGrande";
            this.MenuGrande.Size = new System.Drawing.Size(180, 22);
            this.MenuGrande.Text = "Grande";
            this.MenuGrande.Click += new System.EventHandler(this.MenuGrande_Click);
            // 
            // MenuMediano
            // 
            this.MenuMediano.Name = "MenuMediano";
            this.MenuMediano.Size = new System.Drawing.Size(180, 22);
            this.MenuMediano.Text = "Mediano";
            this.MenuMediano.Click += new System.EventHandler(this.MenuMediano_Click);
            // 
            // MenuPequeño
            // 
            this.MenuPequeño.Name = "MenuPequeño";
            this.MenuPequeño.Size = new System.Drawing.Size(180, 22);
            this.MenuPequeño.Text = "Pequeño";
            this.MenuPequeño.Click += new System.EventHandler(this.MenuPequeño_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // salirMenu
            // 
            this.salirMenu.Name = "salirMenu";
            this.salirMenu.Size = new System.Drawing.Size(180, 22);
            this.salirMenu.Text = "Salir";
            this.salirMenu.Click += new System.EventHandler(this.salirMenu_Click);
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azulToolStripMenuItem,
            this.verdeMenu,
            this.rojoMenu});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.textoToolStripMenuItem.Text = "Texto";
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // verdeMenu
            // 
            this.verdeMenu.Name = "verdeMenu";
            this.verdeMenu.Size = new System.Drawing.Size(180, 22);
            this.verdeMenu.Text = "Verde";
            this.verdeMenu.Click += new System.EventHandler(this.verdeMenu_Click);
            // 
            // rojoMenu
            // 
            this.rojoMenu.Name = "rojoMenu";
            this.rojoMenu.Size = new System.Drawing.Size(180, 22);
            this.rojoMenu.Text = "Rojo";
            this.rojoMenu.Click += new System.EventHandler(this.rojoMenu_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(0, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(800, 426);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "IES COMERCIO";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombre);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tamañpoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuGrande;
        private System.Windows.Forms.ToolStripMenuItem MenuMediano;
        private System.Windows.Forms.ToolStripMenuItem MenuPequeño;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeMenu;
        private System.Windows.Forms.ToolStripMenuItem rojoMenu;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripSeparator salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenu;
    }
}

