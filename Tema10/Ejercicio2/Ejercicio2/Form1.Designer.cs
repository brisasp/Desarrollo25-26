namespace Ejercicio2
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
            this.tabEjemplo = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstElementos = new System.Windows.Forms.ListView();
            this.lblElemento = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.btnSeleccionado = new System.Windows.Forms.Button();
            this.txtSeleccionado = new System.Windows.Forms.TextBox();
            this.btnTeminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEjemplo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEjemplo
            // 
            this.tabEjemplo.Controls.Add(this.tabPage2);
            this.tabEjemplo.Controls.Add(this.tabPage1);
            this.tabEjemplo.Controls.Add(this.tabPage3);
            this.tabEjemplo.Location = new System.Drawing.Point(25, 13);
            this.tabEjemplo.Name = "tabEjemplo";
            this.tabEjemplo.SelectedIndex = 0;
            this.tabEjemplo.Size = new System.Drawing.Size(539, 293);
            this.tabEjemplo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtSeleccionado);
            this.tabPage2.Controls.Add(this.btnSeleccionado);
            this.tabPage2.Controls.Add(this.lblSeleccionado);
            this.tabPage2.Controls.Add(this.btnAñadir);
            this.tabPage2.Controls.Add(this.txtElemento);
            this.tabPage2.Controls.Add(this.lblElemento);
            this.tabPage2.Controls.Add(this.lstElementos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(531, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ejemplo con cuadros de lista";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(531, 267);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Cuadros con check";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(531, 267);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Cuadros combinados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstElementos
            // 
            this.lstElementos.HideSelection = false;
            this.lstElementos.Location = new System.Drawing.Point(31, 29);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(219, 202);
            this.lstElementos.TabIndex = 0;
            this.lstElementos.UseCompatibleStateImageBehavior = false;
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(340, 29);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(51, 13);
            this.lblElemento.TabIndex = 1;
            this.lblElemento.Text = "Elemento";
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(344, 46);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(136, 20);
            this.txtElemento.TabIndex = 2;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(343, 81);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(136, 20);
            this.btnAñadir.TabIndex = 3;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(343, 125);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(72, 13);
            this.lblSeleccionado.TabIndex = 4;
            this.lblSeleccionado.Text = "Seleccionado";
            // 
            // btnSeleccionado
            // 
            this.btnSeleccionado.Location = new System.Drawing.Point(343, 176);
            this.btnSeleccionado.Name = "btnSeleccionado";
            this.btnSeleccionado.Size = new System.Drawing.Size(137, 23);
            this.btnSeleccionado.TabIndex = 5;
            this.btnSeleccionado.Text = "Borrar seleccionado";
            this.btnSeleccionado.UseVisualStyleBackColor = true;
            // 
            // txtSeleccionado
            // 
            this.txtSeleccionado.Location = new System.Drawing.Point(343, 141);
            this.txtSeleccionado.Name = "txtSeleccionado";
            this.txtSeleccionado.Size = new System.Drawing.Size(136, 20);
            this.txtSeleccionado.TabIndex = 6;
            // 
            // btnTeminar
            // 
            this.btnTeminar.Location = new System.Drawing.Point(485, 331);
            this.btnTeminar.Name = "btnTeminar";
            this.btnTeminar.Size = new System.Drawing.Size(75, 23);
            this.btnTeminar.TabIndex = 1;
            this.btnTeminar.Text = "Terminar";
            this.btnTeminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero total de elementos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 376);
            this.Controls.Add(this.btnTeminar);
            this.Controls.Add(this.tabEjemplo);
            this.Name = "Form1";
            this.Text = "Ejercicio Control TabControl";
            this.tabEjemplo.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEjemplo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSeleccionado;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.ListView lstElementos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeleccionado;
        private System.Windows.Forms.Button btnTeminar;
    }
}

