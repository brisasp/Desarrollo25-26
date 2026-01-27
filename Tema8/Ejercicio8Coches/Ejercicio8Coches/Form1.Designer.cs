namespace Ejercicio8Coches
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("NUM.CUOTA");
            this.lblFinanciacion = new System.Windows.Forms.Label();
            this.lstCantidades = new System.Windows.Forms.ListView();
            this.lvCuotas = new System.Windows.Forms.ListView();
            this.lblImporteFinanciar = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoFinanciamiento = new System.Windows.Forms.Label();
            this.cmbTipoFinanciamiento = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblFinanciacion
            // 
            this.lblFinanciacion.AutoSize = true;
            this.lblFinanciacion.Location = new System.Drawing.Point(28, 23);
            this.lblFinanciacion.Name = "lblFinanciacion";
            this.lblFinanciacion.Size = new System.Drawing.Size(230, 13);
            this.lblFinanciacion.TabIndex = 0;
            this.lblFinanciacion.Text = "FINANCIACION DE VEHICULO - SIMULADOR";
            // 
            // lstCantidades
            // 
            this.lstCantidades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstCantidades.HideSelection = false;
            this.lstCantidades.Location = new System.Drawing.Point(32, 123);
            this.lstCantidades.Name = "lstCantidades";
            this.lstCantidades.Size = new System.Drawing.Size(564, 97);
            this.lstCantidades.TabIndex = 1;
            this.lstCantidades.UseCompatibleStateImageBehavior = false;
            this.lstCantidades.View = System.Windows.Forms.View.Details;
            // 
            // lvCuotas
            // 
            this.lvCuotas.HideSelection = false;
            this.lvCuotas.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvCuotas.Location = new System.Drawing.Point(34, 286);
            this.lvCuotas.Name = "lvCuotas";
            this.lvCuotas.Size = new System.Drawing.Size(394, 97);
            this.lvCuotas.TabIndex = 2;
            this.lvCuotas.UseCompatibleStateImageBehavior = false;
            // 
            // lblImporteFinanciar
            // 
            this.lblImporteFinanciar.AutoSize = true;
            this.lblImporteFinanciar.Location = new System.Drawing.Point(28, 55);
            this.lblImporteFinanciar.Name = "lblImporteFinanciar";
            this.lblImporteFinanciar.Size = new System.Drawing.Size(126, 13);
            this.lblImporteFinanciar.TabIndex = 3;
            this.lblImporteFinanciar.Text = "IMPORTE A FINANCIAR";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(160, 52);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(119, 20);
            this.txtImporte.TabIndex = 4;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(331, 55);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 5;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(468, 55);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CANTIDADES SEGUN TIPO DE FINANCIAMIENTO";
            // 
            // lblTipoFinanciamiento
            // 
            this.lblTipoFinanciamiento.AutoSize = true;
            this.lblTipoFinanciamiento.Location = new System.Drawing.Point(28, 270);
            this.lblTipoFinanciamiento.Name = "lblTipoFinanciamiento";
            this.lblTipoFinanciamiento.Size = new System.Drawing.Size(144, 13);
            this.lblTipoFinanciamiento.TabIndex = 8;
            this.lblTipoFinanciamiento.Text = "TIPO DE FINANCIAMIENTO";
            // 
            // cmbTipoFinanciamiento
            // 
            this.cmbTipoFinanciamiento.FormattingEnabled = true;
            this.cmbTipoFinanciamiento.Items.AddRange(new object[] {
            "Personal",
            "Banco",
            "Fondo Colectivo"});
            this.cmbTipoFinanciamiento.Location = new System.Drawing.Point(178, 259);
            this.cmbTipoFinanciamiento.Name = "cmbTipoFinanciamiento";
            this.cmbTipoFinanciamiento.Size = new System.Drawing.Size(138, 21);
            this.cmbTipoFinanciamiento.TabIndex = 9;
            this.cmbTipoFinanciamiento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFinanciamiento_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(468, 326);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TIPO DE FINANCIACION";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "INTERES TOTALES";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CUOTA SOCIAL";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NUM.LETRAS";
            this.columnHeader4.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 471);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbTipoFinanciamiento);
            this.Controls.Add(this.lblTipoFinanciamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporteFinanciar);
            this.Controls.Add(this.lvCuotas);
            this.Controls.Add(this.lstCantidades);
            this.Controls.Add(this.lblFinanciacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinanciacion;
        private System.Windows.Forms.ListView lstCantidades;
        private System.Windows.Forms.ListView lvCuotas;
        private System.Windows.Forms.Label lblImporteFinanciar;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoFinanciamiento;
        private System.Windows.Forms.ComboBox cmbTipoFinanciamiento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

