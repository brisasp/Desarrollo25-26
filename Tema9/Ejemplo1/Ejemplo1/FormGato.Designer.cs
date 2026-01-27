namespace Ejemplo1
{
    partial class FormGato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGato));
            this.btnMostrarFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarFormulario
            // 
            this.btnMostrarFormulario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrarFormulario.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarFormulario.ForeColor = System.Drawing.Color.Olive;
            this.btnMostrarFormulario.Location = new System.Drawing.Point(852, 47);
            this.btnMostrarFormulario.Name = "btnMostrarFormulario";
            this.btnMostrarFormulario.Size = new System.Drawing.Size(212, 72);
            this.btnMostrarFormulario.TabIndex = 0;
            this.btnMostrarFormulario.Text = "Mostrar 2ºFormulario";
            this.btnMostrarFormulario.UseVisualStyleBackColor = false;
            this.btnMostrarFormulario.Click += new System.EventHandler(this.btnMostrarFormulario_Click);
            // 
            // FormGato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejemplo1.Properties.Resources.gatocomuneuropeo_97;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1138, 656);
            this.Controls.Add(this.btnMostrarFormulario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarFormulario;
    }
}

