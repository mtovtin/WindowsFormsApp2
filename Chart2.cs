using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class ChartMatrix : Form
    {
        int[] matrix1;

        public ChartMatrix(int[] matrix1)
        {
            this.matrix1 = matrix1;
            InitializeComponent();
        }

        private void ChartMatrix_Load(object sender, EventArgs e)
        {
            chartForMatrix.Series.Clear();
            NewSeries(matrix1, "The biggest digit in row");

        }

        /// <summary>
        /// Fills the chart with appropriate data
        /// </summary>
        /// <param name="matrix">the matrix of the longest element of each column</param>
        /// <param name="name">name of the chart element</param>
        void NewSeries(int[] matrix, string name)
        {
            var series = new Series { ChartType = SeriesChartType.Column, Name = name };
 
            for (int i = 0; i < matrix.Length; i++)
            {

                series.Points.Add(matrix[i]);
            }
            chartForMatrix.Series.Add(series);
        }

        private void chartForMatrix_Click(object sender, EventArgs e)
        {

        }
    }
}
