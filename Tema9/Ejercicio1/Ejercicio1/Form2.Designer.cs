namespace Ejercicio1
{
    partial class Form2
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
            this.btnCerrarFormu = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrarFormu
            // 
            this.btnCerrarFormu.Location = new System.Drawing.Point(276, 147);
            this.btnCerrarFormu.Name = "btnCerrarFormu";
            this.btnCerrarFormu.Size = new System.Drawing.Size(137, 23);
            this.btnCerrarFormu.TabIndex = 0;
            this.btnCerrarFormu.Text = "Cerrar formulario";
            this.btnCerrarFormu.UseVisualStyleBackColor = true;
            this.btnCerrarFormu.Click += new System.EventHandler(this.btnCerrarFormu_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(276, 251);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(137, 23);
            this.btnTerminar.TabIndex = 1;
            this.btnTerminar.Text = "Terminar aplicacion";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnCerrarFormu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarFormu;
        private System.Windows.Forms.Button btnTerminar;
    }
}