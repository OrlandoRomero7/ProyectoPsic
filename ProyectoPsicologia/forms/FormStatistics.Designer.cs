namespace ProyectoPsicologia.forms
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.chartGraficoBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iconButtonConsultar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficoBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(187, 112);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerDesde.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(673, 117);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerHasta.TabIndex = 4;
            // 
            // chartGraficoBarras
            // 
            this.chartGraficoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartGraficoBarras.BackColor = System.Drawing.Color.Transparent;
            this.chartGraficoBarras.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartGraficoBarras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraficoBarras.Legends.Add(legend1);
            this.chartGraficoBarras.Location = new System.Drawing.Point(250, 269);
            this.chartGraficoBarras.Name = "chartGraficoBarras";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Estudiantes";
            this.chartGraficoBarras.Series.Add(series1);
            this.chartGraficoBarras.Size = new System.Drawing.Size(655, 300);
            this.chartGraficoBarras.TabIndex = 6;
            this.chartGraficoBarras.Text = "chart1";
            // 
            // iconButtonConsultar
            // 
            this.iconButtonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonConsultar.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconButtonConsultar.IconColor = System.Drawing.Color.Black;
            this.iconButtonConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonConsultar.IconSize = 25;
            this.iconButtonConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonConsultar.Location = new System.Drawing.Point(948, 112);
            this.iconButtonConsultar.Name = "iconButtonConsultar";
            this.iconButtonConsultar.Size = new System.Drawing.Size(150, 41);
            this.iconButtonConsultar.TabIndex = 7;
            this.iconButtonConsultar.Text = "Consultar";
            this.iconButtonConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonConsultar.UseVisualStyleBackColor = true;
            this.iconButtonConsultar.Click += new System.EventHandler(this.iconButtonConsultar_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(210)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1164, 650);
            this.Controls.Add(this.iconButtonConsultar);
            this.Controls.Add(this.chartGraficoBarras);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDesde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficoBarras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraficoBarras;
        private FontAwesome.Sharp.IconButton iconButtonConsultar;
    }
}