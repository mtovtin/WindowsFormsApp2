using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public string fileName = "";
        public string whereToWrite = "";
        public static double[,] matrix;
        bool checker = true;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets elements of matrix from a file and does their validation
        /// </summary>
        /// <param name="fileName">the name of the file with matrix</param>
        /// <returns>tuple with matrix and its validation</returns>
        private (List<string[]>, bool) GetElements(string fileName = "")
        {
            var rows = new List<string[]>();
            bool validation = false;
            openFileDialog.InitialDirectory = @"C:\Users\Lenovo\Desktop";
            openFileDialog.FileName = fileName;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                validation = true;
                using (var reader = new StreamReader(openFileDialog.FileName))
                {

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var row = line.Split(new[] { ' ' });
                        if (rows.Count > 0 && row.Length != rows[0].Length)
                        {
                            MessageBox.Show($"Invalid Data", "Error");
                            validation = false;
                            break;
                        }

                        rows.Add(row);
                    }
                }
            }
            return (rows, validation);
        }

        /// <summary>
        /// Fills data grid with the elements of matrix
        /// </summary>
        /// <param name="rows">rows to put into grid</param>
        /// <param name="grid">grid to be filled</param>
        private void FillGrid(List<string[]> rows, DataGridView grid)
        {
            grid.Rows.Clear();
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.BackColor = Color.White;
            }
            grid.ColumnCount = rows[0].Length;
            foreach (var row in rows)
            {
                grid.Rows.Add(row);
            }

        }
        private void FillMatrix(DataGridView grid)
        {

            matrix = new double[grid.RowCount, grid.ColumnCount];
            checker = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        if (matrix[i, j].ToString() == "")
                            checker = false;
                        matrix[i, j] = Convert.ToDouble(grid[j, i].Value);
                      
                    }
                    catch (Exception)
                    {
                       
                        checker = false;
                       

                    }
                }
            }
        }
    

        private void buttonLoadElements_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select file", "Information", MessageBoxButtons.OK);
            var (rows, validation) = GetElements("matrix.txt");
            fileName = "matrix.txt";
            if (validation && rows.Count > 0)
            {
         
                FillGrid(rows, dataGridViewMatrix);
                FillMatrix(dataGridViewMatrix);

                    ButtonApplyChanges.Enabled = true;
                    ButtonShowChart.Enabled = true;
                    buttonWriteToFile.Enabled = true;
                


                }
            else if (rows.Count == 0)
            {
                MessageBox.Show($"File is empty", "Error");
            }
        }

        private void buttonApplyChanges_Click(object sender, EventArgs e)
        {
            bool flag = true;
            DataGridView grid = dataGridViewMatrix;
            FillMatrix(grid);
            if (checker == true)
            {
                ButtonApplyChanges.Enabled = true;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.Chartreuse;
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    flag = true;
                    for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                    {
                        if ((matrix[i, j - 1] >= matrix[i, j] && matrix[i, j] <= matrix[i, j + 1]) || (matrix[i, j - 1] <= matrix[i, j] && matrix[i, j] >= matrix[i, j + 1]))
                        {

                            flag = false;
                        }

                        if (!flag)
                        {
                            grid.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"Non-numeric data entered! Task cannot be executed.", "Error");
                foreach (DataGridViewRow row in grid.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }

            }
        }

        /// <summary>
        /// Searches for the biggest digit in every row
        /// </summary>
        /// <returns>array with the biggest digit of each row</returns>
     
        private int[] FindTheLongest()
        {
            int[] res = new int[dataGridViewMatrix.RowCount];
            int largest = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                res[i] = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int num = Convert.ToInt32(matrix[i, j]);
                    while ( num != 0)
                    {  
                        int r = num % 10;
                        largest = Math.Max(r, largest);
                        num = num / 10;
                     
                    }
                    res[i] = largest;
           
                }
                largest = 0;
            }
            return res;
        }


        private void buttonShowChart_Click(object sender, EventArgs e)
        {
           var chartForm = new ChartMatrix(FindTheLongest());
            chartForm.Show();
        }
        
        private void buttonWriteToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = @"C:\Users\Lenovo\Desktop";
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.DefaultExt = "txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer=new StreamWriter(saveFileDialog.FileName))
                {
                    foreach(DataGridViewRow row in dataGridViewMatrix.Rows)
                    {
                        foreach(DataGridViewCell cell in row.Cells)
                        {
               
                            {
                                writer.Write(String.IsNullOrEmpty(cell.Value.ToString())? "" + "\t" : cell.Value.ToString() + "\t");
                            }

                        }
                        writer.WriteLine();
                    }
                }
            }
        }

    }
}
