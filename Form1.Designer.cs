namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.ButtonApplyChanges = new System.Windows.Forms.Button();
            this.ButtonLoadElements = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButtonShowChart = new System.Windows.Forms.Button();
            this.buttonWriteToFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatrix.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(41, 64);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(541, 325);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // ButtonApplyChanges
            // 
            this.ButtonApplyChanges.Enabled = false;
            this.ButtonApplyChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonApplyChanges.Location = new System.Drawing.Point(624, 164);
            this.ButtonApplyChanges.Name = "ButtonApplyChanges";
            this.ButtonApplyChanges.Size = new System.Drawing.Size(135, 51);
            this.ButtonApplyChanges.TabIndex = 3;
            this.ButtonApplyChanges.Text = "Apply Changes";
            this.ButtonApplyChanges.UseVisualStyleBackColor = true;
            this.ButtonApplyChanges.Click += new System.EventHandler(this.buttonApplyChanges_Click);
            // 
            // ButtonLoadElements
            // 
            this.ButtonLoadElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLoadElements.Location = new System.Drawing.Point(624, 94);
            this.ButtonLoadElements.Name = "ButtonLoadElements";
            this.ButtonLoadElements.Size = new System.Drawing.Size(135, 51);
            this.ButtonLoadElements.TabIndex = 4;
            this.ButtonLoadElements.Text = "Load Elements";
            this.ButtonLoadElements.UseVisualStyleBackColor = true;
            this.ButtonLoadElements.Click += new System.EventHandler(this.buttonLoadElements_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ButtonShowChart
            // 
            this.ButtonShowChart.Enabled = false;
            this.ButtonShowChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShowChart.Location = new System.Drawing.Point(624, 314);
            this.ButtonShowChart.Name = "ButtonShowChart";
            this.ButtonShowChart.Size = new System.Drawing.Size(135, 51);
            this.ButtonShowChart.TabIndex = 5;
            this.ButtonShowChart.Text = "Show Chart";
            this.ButtonShowChart.UseVisualStyleBackColor = true;
            this.ButtonShowChart.Click += new System.EventHandler(this.buttonShowChart_Click);
            // 
            // buttonWriteToFile
            // 
            this.buttonWriteToFile.Enabled = false;
            this.buttonWriteToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWriteToFile.Location = new System.Drawing.Point(624, 243);
            this.buttonWriteToFile.Name = "buttonWriteToFile";
            this.buttonWriteToFile.Size = new System.Drawing.Size(135, 51);
            this.buttonWriteToFile.TabIndex = 6;
            this.buttonWriteToFile.Text = "Write into File";
            this.buttonWriteToFile.UseVisualStyleBackColor = true;
            this.buttonWriteToFile.Click += new System.EventHandler(this.buttonWriteToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWriteToFile);
            this.Controls.Add(this.ButtonShowChart);
            this.Controls.Add(this.ButtonLoadElements);
            this.Controls.Add(this.ButtonApplyChanges);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Name = "Form1";
            this.Text = "Matrix from file";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button ButtonApplyChanges;
        private System.Windows.Forms.Button ButtonLoadElements;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button ButtonShowChart;
        private System.Windows.Forms.Button buttonWriteToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

