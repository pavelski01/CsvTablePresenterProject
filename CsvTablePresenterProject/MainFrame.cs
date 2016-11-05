using CsvTablePresenterProject.DataTransferObject;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.String;
using static CsvTablePresenterProject.Utility.UtilityBundle;
using CsvTablePresenterProject.Properties;

namespace CsvTablePresenterProject
{
    public partial class MainFrame : Form
    {
        private DataTable _dt = new DataTable();

        public MainFrame()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource =
                MakeTable(null, true);
        }
        private void GenerateTable_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView.DataSource = MakeTable(PathTextBox.Text, false);
            }
            catch (ArgumentNullException anex)
            {
                MessageBox.Show(anex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DataTable MakeTable(string pathToCsv, bool isResource)
        {
            if (!isResource && IsNullOrEmpty(pathToCsv))
                throw new ArgumentNullException(
                    nameof(pathToCsv), Resources.EmptyPathMessage
                );
            _dt = new DataTable();
            var csvText =
                isResource ?
                Resources.test_file.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries) :
                File.ReadAllLines(pathToCsv);
            var first = true;
            foreach (var line in csvText)
            {
                var columnText = line.Split(';');
                var lineObj = new LineDto
                {
                    Forename = columnText[0],
                    Surname = columnText[1],
                    ElectronicMail = columnText[2]
                };
                if (first)
                {
                    _dt.Columns.Add(
                        Capitalize(lineObj.Forename)
                    );
                    _dt.Columns.Add(
                        Capitalize(lineObj.Surname)
                    );
                    _dt.Columns.Add(
                        Capitalize(lineObj.ElectronicMail)
                    );
                    first = false;
                }
                else
                {
                    _dt.Rows.Add(
                        lineObj.Forename, lineObj.Surname, lineObj.ElectronicMail
                    );
                }
            }
            return _dt;
        }
        private void PickFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PathTextBox.Text = openFileDialog.InitialDirectory + openFileDialog.FileName;
            }
        }
    }
}
