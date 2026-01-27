namespace Ejercicio1
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
            this.gbFormularios = new System.Windows.Forms.GroupBox();
            this.btnSegundoForm = new System.Windows.Forms.Button();
            this.btnMostrarTercer = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.gbFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFormularios
            // 
            this.gbFormularios.Controls.Add(this.btnMostrarTercer);
            this.gbFormularios.Controls.Add(this.btnSegundoForm);
            this.gbFormularios.Location = new System.Drawing.Point(36, 45);
            this.gbFormularios.Name = "gbFormularios";
            this.gbFormularios.Size = new System.Drawing.Size(527, 191);
            this.gbFormularios.TabIndex = 0;
            this.gbFormularios.TabStop = false;
            this.gbFormularios.Text = "Formularios";
            // 
            // btnSegundoForm
            // 
            this.btnSegundoForm.Location = new System.Drawing.Point(143, 39);
            this.btnSegundoForm.Name = "btnSegundoForm";
            this.btnSegundoForm.Size = new System.Drawing.Size(194, 23);
            this.btnSegundoForm.TabIndex = 0;
            this.btnSegundoForm.Text = "Mostrar Segundo formulario";
            this.btnSegundoForm.UseVisualStyleBackColor = true;
            this.btnSegundoForm.Click += new System.EventHandler(this.btnSegundoForm_Click);
            // 
            // btnMostrarTercer
            // 
            this.btnMostrarTercer.Location = new System.Drawing.Point(143, 111);
            this.btnMostrarTercer.Name = "btnMostrarTercer";
            this.btnMostrarTercer.Size = new System.Drawing.Size(194, 23);
            this.btnMostrarTercer.TabIndex = 1;
            this.btnMostrarTercer.Text = "Mostrar tercer formulario";
            this.btnMostrarTercer.UseVisualStyleBackColor = true;
            this.btnMostrarTercer.Click += new System.EventHandler(this.btnMostrarTercer_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(471, 276);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 1;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 334);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.gbFormularios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbFormularios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFormularios;
        private System.Windows.Forms.Button btnMostrarTercer;
        private System.Windows.Forms.Button btnSegundoForm;
        private System.Windows.Forms.Button btnTerminar;
    }
}

