
namespace pryFinalLP2
{
    partial class frmListadoSocios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoSocios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblMenorDeudor = new System.Windows.Forms.Label();
            this.lblMayorDeudor = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalDeuda);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnGenerarReporte);
            this.groupBox1.Controls.Add(this.lblPromedioDeuda);
            this.groupBox1.Controls.Add(this.lblMenorDeudor);
            this.groupBox1.Controls.Add(this.lblMayorDeudor);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Grilla);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 610);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de todos los socios";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Location = new System.Drawing.Point(277, 489);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(210, 29);
            this.lblTotalDeuda.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total de deuda:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(6, 547);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(150, 49);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporte.Enabled = false;
            this.btnGenerarReporte.Location = new System.Drawing.Point(162, 547);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(185, 49);
            this.btnGenerarReporte.TabIndex = 11;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(277, 454);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(210, 29);
            this.lblPromedioDeuda.TabIndex = 10;
            // 
            // lblMenorDeudor
            // 
            this.lblMenorDeudor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenorDeudor.Location = new System.Drawing.Point(277, 420);
            this.lblMenorDeudor.Name = "lblMenorDeudor";
            this.lblMenorDeudor.Size = new System.Drawing.Size(210, 29);
            this.lblMenorDeudor.TabIndex = 9;
            // 
            // lblMayorDeudor
            // 
            this.lblMayorDeudor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayorDeudor.Location = new System.Drawing.Point(277, 385);
            this.lblMayorDeudor.Name = "lblMayorDeudor";
            this.lblMayorDeudor.Size = new System.Drawing.Size(210, 29);
            this.lblMayorDeudor.TabIndex = 8;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Location = new System.Drawing.Point(353, 547);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(160, 49);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Promedio de deuda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menor Deudor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mayor Deudor:";
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.Grilla.Location = new System.Drawing.Point(6, 42);
            this.Grilla.Name = "Grilla";
            this.Grilla.RowHeadersWidth = 51;
            this.Grilla.RowTemplate.Height = 24;
            this.Grilla.Size = new System.Drawing.Size(507, 320);
            this.Grilla.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Socio N°";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Deuda";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // frmListadoSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 627);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListadoSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de socios";
            this.Load += new System.EventHandler(this.frmListadoSocios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblMenorDeudor;
        private System.Windows.Forms.Label lblMayorDeudor;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument prtDocumento;
        private System.Windows.Forms.PrintDialog prtVentana;
    }
}