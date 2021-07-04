namespace WindowsFormsApp2
{
    partial class ChartMatrix
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
            this.chartForMatrix = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartForMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // chartForMatrix
            // 
            chartArea1.Name = "ChartArea1";
            this.chartForMatrix.ChartAreas.Add(chartArea1);
            this.chartForMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartForMatrix.Legends.Add(legend1);
            this.chartForMatrix.Location = new System.Drawing.Point(0, 0);
            this.chartForMatrix.Name = "chartForMatrix";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartForMatrix.Series.Add(series1);
            this.chartForMatrix.Size = new System.Drawing.Size(800, 450);
            this.chartForMatrix.TabIndex = 0;
            this.chartForMatrix.Click += new System.EventHandler(this.chartForMatrix_Click);
            // 
            // ChartMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartForMatrix);
            this.Name = "ChartMatrix";
            this.Text = "Matrix Chart";
            this.Load += new System.EventHandler(this.ChartMatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartForMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartForMatrix;
    }
}