namespace CsvTablePresenterProject
{
    partial class MainFrame
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
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.GenerateTable = new System.Windows.Forms.Button();
            this.CsvPath = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.PickFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Location = new System.Drawing.Point(93, 8);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(332, 20);
            this.PathTextBox.TabIndex = 0;
            // 
            // GenerateTable
            // 
            this.GenerateTable.Location = new System.Drawing.Point(553, 8);
            this.GenerateTable.Name = "GenerateTable";
            this.GenerateTable.Size = new System.Drawing.Size(119, 23);
            this.GenerateTable.TabIndex = 1;
            this.GenerateTable.Text = "Generate Table";
            this.GenerateTable.UseVisualStyleBackColor = true;
            this.GenerateTable.Click += new System.EventHandler(this.GenerateTable_Click);
            // 
            // CsvPath
            // 
            this.CsvPath.AutoSize = true;
            this.CsvPath.Location = new System.Drawing.Point(3, 11);
            this.CsvPath.Name = "CsvPath";
            this.CsvPath.Size = new System.Drawing.Size(84, 13);
            this.CsvPath.TabIndex = 2;
            this.CsvPath.Text = "Path to CSV file:";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(6, 42);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(666, 415);
            this.DataGridView.TabIndex = 3;
            // 
            // PickFile
            // 
            this.PickFile.Location = new System.Drawing.Point(432, 7);
            this.PickFile.Name = "PickFile";
            this.PickFile.Size = new System.Drawing.Size(115, 23);
            this.PickFile.TabIndex = 4;
            this.PickFile.Text = "Pick File";
            this.PickFile.UseVisualStyleBackColor = true;
            this.PickFile.Click += new System.EventHandler(this.PickFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.PickFile);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.CsvPath);
            this.Controls.Add(this.GenerateTable);
            this.Controls.Add(this.PathTextBox);
            this.Name = "MainForm";
            this.Text = "TEST C#";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button GenerateTable;
        private System.Windows.Forms.Label CsvPath;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button PickFile;
    }
}

