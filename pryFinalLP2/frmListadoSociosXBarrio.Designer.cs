
namespace pryFinalLP2
{
    partial class frmListadoSociosXBarrio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoSociosXBarrio));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblMenorDeudor = new System.Windows.Forms.Label();
            this.lblMayorDeudor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(30, 739);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(164, 39);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Enabled = false;
            this.btnReporte.Location = new System.Drawing.Point(231, 739);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(164, 39);
            this.btnReporte.TabIndex = 15;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Location = new System.Drawing.Point(433, 739);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(164, 39);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrilla.Location = new System.Drawing.Point(30, 91);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 45;
            this.dgvGrilla.Size = new System.Drawing.Size(567, 468);
            this.dgvGrilla.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Socio N°";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Deuda";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(122, 38);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(460, 28);
            this.cmbBarrio.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Barrio:";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Location = new System.Drawing.Point(372, 687);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(210, 29);
            this.lblTotalDeuda.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 691);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total de deuda:";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(372, 652);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(210, 29);
            this.lblPromedioDeuda.TabIndex = 28;
            // 
            // lblMenorDeudor
            // 
            this.lblMenorDeudor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenorDeudor.Location = new System.Drawing.Point(372, 618);
            this.lblMenorDeudor.Name = "lblMenorDeudor";
            this.lblMenorDeudor.Size = new System.Drawing.Size(210, 29);
            this.lblMenorDeudor.TabIndex = 27;
            // 
            // lblMayorDeudor
            // 
            this.lblMayorDeudor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayorDeudor.Location = new System.Drawing.Point(372, 583);
            this.lblMayorDeudor.Name = "lblMayorDeudor";
            this.lblMayorDeudor.Size = new System.Drawing.Size(210, 29);
            this.lblMayorDeudor.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 655);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Promedio de deuda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Menor Deudor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mayor Deudor:";
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // frmListadoSociosXBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 790);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPromedioDeuda);
            this.Controls.Add(this.lblMenorDeudor);
            this.Controls.Add(this.lblMayorDeudor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListadoSociosXBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de socios por barrio";
            this.Load += new System.EventHandler(this.frmListadoSociosXBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblMenorDeudor;
        private System.Windows.Forms.Label lblMayorDeudor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument prtDocumento;
        private System.Windows.Forms.PrintDialog prtVentana;
    }
}