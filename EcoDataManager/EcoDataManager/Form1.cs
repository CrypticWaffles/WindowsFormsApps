using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EcoDataManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Opens file a from the computer
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                txtb_filename.Text = file;
            }
        }

        // Checks filetype and imports to a selected table
        private void btn_import_Click(object sender, EventArgs e)
        {
            string file = txtb_filename.Text;
            string fileExtension = Path.GetExtension(file).ToLower();
            string targetTable = cmb_tableSelect.SelectedItem.ToString();

            // Check that a file and table are both selected
            if (string.IsNullOrEmpty(file) || string.IsNullOrEmpty(targetTable))
            {
                MessageBox.Show("Please selecet a file and target table");
                return;
            }

            DataTable dataTable = null;

            try
            {
                // Checks file extention type and matches to correct import method
                switch (fileExtension)
                {
                    case ".csv":
                        dataTable = getDataFromCSV(file);
                        break;
                    case ".xml":
                        dataTable = getDataFromXML(file);
                        break;
                    case ".json":
                        dataTable = getDataFromJSON(file);
                        break;
                    default:
                        MessageBox.Show("Unsupported filetype.");
                        return;
                }

                // Adds data to database
                if (dataTable != null)
                {
                    InsertDataIntoSQL(dataTable, targetTable);
                    MessageBox.Show("Data imported successfully into " + targetTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Importing: " + ex.Message);
            }
        }

        // retrives data from .csv file as a DataTable
        private static DataTable getDataFromCSV(string file)
        {
            DataTable data = new DataTable();
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(file))
                {
                    csvReader.SetDelimiters(",");
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    // Add Columns
                    foreach (string colField in colFields)
                    {
                        DataColumn datacolumn = new DataColumn(colField);
                        data.Columns.Add(datacolumn);
                    }
                    // Add Rows
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        data.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            return data;
        }

        // retrives data from .xml file as a DataTable
        private static DataTable getDataFromXML(string file)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(file);
            return dataSet.Tables[0];
        }

        // retrives data from .json file as a DataTable
        private static DataTable getDataFromJSON(string file)
        {
            string json = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        // Inserts a DataTable into a selected SQL Table
        private static void InsertDataIntoSQL(DataTable dataTable, string tableName)
        {
            using (SqlConnection dbConnection = new SqlConnection(@"Data Source=BIG-PP-9000\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    s.DestinationTableName = tableName;
                    foreach (var column in dataTable.Columns)
                    {
                        s.ColumnMappings.Add(column.ToString(), column.ToString());
                    }
                    s.WriteToServer(dataTable);
                }
                dbConnection.Close();
            }
        }

        // Sets datagridview with selected table from ComboBox when combobox selection is changed
        private void cmb_tableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cmb_tableSelect.SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedTable))
                return;

            LoadTableDataToGrid(selectedTable);
        }

        // Used to modify datagrid view
        BindingSource bindingSource = new BindingSource();

        // populates datagrid view
        private void LoadTableDataToGrid(string selectedTable)
        {
            string connectionString = @"Data Source=BIG-PP-9000\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True;TrustServerCertificate=True";
            string query = $"SELECT * FROM {selectedTable}";

            using (SqlConnection dbConnection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    bindingSource.DataSource = dataTable;
                    dgv_main.DataSource = bindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
            UpdateColFilterOptions();
        }

        // Dynamically updates column filetr options based on selected table
        private void UpdateColFilterOptions()
        {
            if (bindingSource.DataSource is DataTable dataTable)
            {
                cmb_colFilter.Items.Clear();
                foreach (DataColumn col in dataTable.Columns)
                {
                    cmb_colFilter.Items.Add(col.ColumnName);
                }

                if (cmb_colFilter.Items.Count > 0)
                {
                    cmb_colFilter.SelectedIndex = 0;
                }
            }
        }

        // Applies filter to selected column
        private void btn_apply_Click(object sender, EventArgs e)
        {
            string selectedCol = cmb_colFilter.SelectedItem?.ToString();
            string filterText = txt_filter.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrEmpty(filterText) && !string.IsNullOrEmpty(selectedCol))
            {
                bindingSource.Filter = $"Convert({selectedCol}, 'System.String') LIKE '%{filterText}%'";
            }
            else
            {
                bindingSource.RemoveFilter();
            }
        }

        // Gets the current filter and populates datagridview with matching data
        private DataTable GetCurrentFilteredData()
        {
            return (bindingSource.DataSource as DataTable)?.DefaultView.ToTable();
        }

        // Opens export context menu
        private void btn_export_Click(object sender, EventArgs e)
        {
            ctx_exportMenu.Show(btn_export, new Point(0, btn_export.Height));
        }

        // matches correct filetype to base export method
        private void tsmi_exportAsCSV_Click(object sender, EventArgs e)
        {
            ExportFilteredData("csv");
        }

        private void tsmi_exportAsXML_Click(object sender, EventArgs e)
        {
            ExportFilteredData("xml");
        }

        private void tsmi_exportAsJSON_Click(object sender, EventArgs e)
        {
            ExportFilteredData("json");
        }

        // Exports data as selected file type
        private void ExportFilteredData(string format)
        {
            DataTable dt = GetCurrentFilteredData();
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            switch (format.ToLower())
            {
                case "csv":
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                    break;
                case "xml":
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                    break;
                case "json":
                    saveFileDialog.Filter = "JSON files (*.json)|*.json";
                    break;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (format.ToLower())
                {
                    case "csv":
                        ExportToCSV(dt, saveFileDialog.FileName);
                        break;
                    case "xml":
                        dt.TableName = "ExportedData";
                        dt.WriteXml(saveFileDialog.FileName, XmlWriteMode.WriteSchema);
                        break;
                    case "json":
                        string json = JsonConvert.SerializeObject(dt, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(saveFileDialog.FileName, json);
                        break;
                }

                MessageBox.Show($"Exported to {format.ToUpper()}.");
            }
        }

        // Exports data as CSV file
        private void ExportToCSV(DataTable dt, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // Write header
            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            // Write rows
            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field =>
                    $"\"{field?.ToString()?.Replace("\"", "\"\"")}\"");
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        // Applies filter based on the dates selected
        private void btn_applyDateFilter_Click(object sender, EventArgs e)
        {
            if (!(bindingSource.DataSource is DataTable dt) || dt.Rows.Count == 0)
                return;

            string selectedTable = cmb_tableSelect.SelectedItem?.ToString();
            string dateColumn = "";

            switch (selectedTable)
            {
                case "Observations":
                case "Environment":
                    dateColumn = "Date";
                    break;
                default:
                    MessageBox.Show("Date filtering not applicable for this table.");
                    return;
            }

            string filter = $"[{dateColumn}] >= #{dtp_start.Value:MM/dd/yyyy}# AND [{dateColumn}] <= #{dtp_end.Value:MM/dd/yyyy}#";
            bindingSource.Filter = filter;
        }

        // Exports a filtered summary from the data
        private void btn_exportSummary_Click(object sender, EventArgs e)
        {
            string selectedTable = cmb_tableSelect.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTable))
            {
                MessageBox.Show("Please select a table first.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.FileName = $"{selectedTable}_Summary.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string summary = GenerateSummary(selectedTable);
                File.WriteAllText(saveFileDialog.FileName, summary);
                MessageBox.Show("Summary exported.");
            }
        }

        // Generates a summary of exported data based on each table
        private string GenerateSummary(string tableName)
        {
            string connectionString = @"Data Source=BIG-PP-9000\SQLEXPRESS;Initial Catalog=EcoDataDB;Integrated Security=True;TrustServerCertificate=True";
            StringBuilder sb = new StringBuilder();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (!(bindingSource.DataSource is DataTable dt) || dt.Rows.Count == 0)
                    return "No data available for summary.";

                switch (tableName)
                {
                    case "Observations":
                        sb.AppendLine("Summary: Observations (Filtered)");
                        sb.AppendLine("------------------------");

                        var groupedObs = dt.AsEnumerable()
                            .GroupBy(row => row["SpeciesId"].ToString())
                            .Select(g => new
                            {
                                SpeciesId = g.Key,
                                TotalObservations = g.Count(),
                                TotalQuantity = g.Sum(r => Convert.ToInt32(r["Quantity"]))
                            });

                        foreach (var group in groupedObs)
                        {
                            sb.AppendLine($"Species ID: {group.SpeciesId} | Observations: {group.TotalObservations} | Quantity: {group.TotalQuantity}");
                        }
                        break;

                    case "Environment":
                        sb.AppendLine("Summary: Environment (Filtered)");
                        sb.AppendLine("-------------------------------");

                        var temps = dt.AsEnumerable().Select(r => Convert.ToDouble(r["Temperature"]));
                        var hums = dt.AsEnumerable().Select(r => Convert.ToDouble(r["Humidity"]));
                        var aqis = dt.AsEnumerable().Select(r => Convert.ToDouble(r["AirQualityIndex"]));

                        sb.AppendLine($"Average Temperature: {temps.Average():0.00} °C");
                        sb.AppendLine($"Average Humidity: {hums.Average():0.00} %");
                        sb.AppendLine($"Average Air Quality Index: {aqis.Average():0.00}");
                        break;

                    case "Species":
                        sb.AppendLine("Summary: Species (Filtered)");
                        sb.AppendLine("----------------------------");

                        var groupedSpecies = dt.AsEnumerable()
                            .GroupBy(row => row["Category"].ToString())
                            .Select(g => new
                            {
                                Category = g.Key,
                                Count = g.Count()
                            });

                        foreach (var group in groupedSpecies)
                        {
                            sb.AppendLine($"Category: {group.Category} | Count: {group.Count}");
                        }
                        break;

                    default:
                        sb.AppendLine("No summary available for selected table.");
                        break;
                }

                return sb.ToString();
            }
        }
    }
}
