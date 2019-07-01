using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Importer
{
    /// <summary>
    /// Class Main.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Main : Form
    {
        /// <summary>
        /// The data types
        /// </summary>
        private readonly Dictionary<string, string> _dataTypes = new Dictionary<string, string>();

        /// <summary>
        /// The fail count
        /// </summary>
        private int _failCount;

        /// <summary>
        /// The failed queries
        /// </summary>
        private readonly List<string> _failedQueries = new List<string>();

        /// <summary>
        /// The fields
        /// </summary>
        private readonly List<string> _fields = new List<string>();

        /// <summary>
        /// The lineas
        /// </summary>
        private readonly List<string> _lineas = new List<string>();

        /// <summary>
        /// The querys
        /// </summary>
        private List<string> _querys = new List<string>();

        /// <summary>
        /// The succes count
        /// </summary>
        private int _succesCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileTextbox.Text = OpenFileDialog.FileName;
            }
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            ToolbarStatusLabel.Text = "Opening document...";
            var threadStart = new ThreadStart(Gather);
            var thread = new Thread(threadStart);
            thread.Start();
        }

        /// <summary>
        /// Gathers this instance.
        /// </summary>
        public void Gather()
        {
            try
            {
                var path = string.Empty;
                Invoke((MethodInvoker) delegate { path = FileTextbox.Text; });
                using (TextReader textReader = new StreamReader(path))
                {
                    var linea = string.Empty;
                    var tuplas = 0;
                    while ((linea = textReader.ReadLine()) != null)
                    {
                        tuplas++;
                        _lineas.Add(FixLine(linea));
                    }

                    Invoke((MethodInvoker) delegate
                                           {
                                               FoundText.Text = tuplas.ToString();
                                               ToolbarStatusLabel.Text = "ready";
                                           });
                }
            }
            catch (Exception exe)
            {
                Invoke((MethodInvoker) delegate { ErrorText.Text = exe.Message; });
            }
        }

        /// <summary>
        /// Fixes the line.
        /// </summary>
        /// <param name="line">The line.</param>
        /// <returns>System.String.</returns>
        private static string FixLine(string line)
        {
            var insertCoordinates = new List<int>();
            if (line.StartsWith("\t"))
            {
                var temp = "NULL" + line;
                line = temp;
            }

            if (line.EndsWith("\t"))
            {
                var temp = line + "NULL";
                line = temp;
            }

            for (var i = 1; i < line.Length; i++)
            {
                line = line.Replace("\t\t", "\tNULL\t");
            }

            return line;
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            TablesDropdown.Items.Clear();
            var threadStart = new ThreadStart(GetTable);
            var tableThread = new Thread(threadStart);
            tableThread.Start();
            ToolbarStatusLabel.Text = "Getting tables...";
        }

        /// <summary>
        /// Gets the table.
        /// </summary>
        private void GetTable()
        {
            try
            {
                const string select = "SELECT table_name AS Name FROM INFORMATION_SCHEMA.Tables where TABLE_TYPE = 'BASE TABLE'";
                var sqlConnection = new SqlConnection(txtConn.Text);
                sqlConnection.Open();
                var sqlCommand = new SqlCommand(select, sqlConnection);
                var sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Invoke((MethodInvoker) delegate { TablesDropdown.Items.Add(sqlDataReader["Name"].ToString()); });
                }

                sqlConnection.Close();
            }
            catch (Exception exe)
            {
                Invoke((MethodInvoker) delegate { ErrorText.Text = exe.Message; });
            }

            Invoke((MethodInvoker) delegate { ToolbarStatusLabel.Text = "ready"; });
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <param name="column">The column.</param>
        private void GetType(string column)
        {
            try
            {
                var select = $@"SELECT DATA_TYPE FROM INFORMATION_SCHEMA.Columns WHERE TABLE_NAME = '{TablesDropdown.Text}' AND COLUMN_NAME = '{column}'";
                var sqlConnection = new SqlConnection(txtConn.Text);
                sqlConnection.Open();
                var sqlCommand = new SqlCommand(select, sqlConnection);
                var sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    _dataTypes.Add(column, sqlDataReader["DATA_TYPE"].ToString());
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                ErrorText.Text = ex.Message;
            }
        }

        /// <summary>
        /// Gets the row names.
        /// </summary>
        private void GetRowNames()
        {
            var selectAll = string.Empty;
            Invoke((MethodInvoker) delegate { selectAll = $@"SELECT TOP 1 * FROM {TablesDropdown.Text}"; });
            try
            {
                var sqlConnection = new SqlConnection(txtConn.Text);
                sqlConnection.Open();
                var sqlCommand = new SqlCommand(selectAll, sqlConnection);
                var sqlDataReader = sqlCommand.ExecuteReader();
                var count = sqlDataReader.FieldCount;
                Invoke((MethodInvoker) delegate
                                       {
                                           for (var i = 0; i < count; i++)
                                           {
                                               ColumnsList.Items.Add(sqlDataReader.GetName(i));
                                               GetType(sqlDataReader.GetName(i));
                                           }
                                       });
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker) delegate { ErrorText.Text += ex.Message; });
            }

            Invoke((MethodInvoker) delegate { ToolbarStatusLabel.Text = "ready"; });
        }

        /// <summary>
        /// Handles the Click event of the button4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            ColumnsList.Items.Clear();
            _dataTypes.Clear();
            var threadStart = new ThreadStart(GetRowNames);
            var rows = new Thread(threadStart);
            rows.Start();
            ToolbarStatusLabel.Text = "Getting columns...";
        }

        /// <summary>
        /// Handles the Click event of the button5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var value = string.Empty;
                _dataTypes.TryGetValue(ColumnsList.SelectedItem.ToString(), out value);
                Console.WriteLine(value);
                QueryFieldsList.Items.Add(ColumnsList.SelectedItem);
                ColumnsList.Items.Remove(ColumnsList.SelectedItem);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Handles the Click event of the button6 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var o in ColumnsList.Items)
            {
                QueryFieldsList.Items.Add(o);
            }

            ColumnsList.Items.Clear();
        }

        /// <summary>
        /// Handles the Click event of the button7 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var o in QueryFieldsList.Items)
            {
                ColumnsList.Items.Add(o);
            }

            QueryFieldsList.Items.Clear();
        }

        /// <summary>
        /// Handles the Click event of the button8 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ColumnsList.Items.Add(QueryFieldsList.SelectedItem);
                QueryFieldsList.Items.Remove(QueryFieldsList.SelectedItem);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Handles the Click event of the button9 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button9_Click(object sender, EventArgs e)
        {
            ColumnsList.Items.Clear();
            QueryFieldsList.Items.Clear();
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            InstructionsText.Text = global::Importer.Properties.Resources.Instructions;
        }

        /// <summary>
        /// Handles the MouseEnter event of the pictureBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            GoPictureBoxButton.Image = global::Importer.Properties.Resources.Go2;
        }

        /// <summary>
        /// Handles the MouseLeave event of the pictureBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            GoPictureBoxButton.Image = global::Importer.Properties.Resources._1291923764_Perspective_Button___Go;
        }

        /// <summary>
        /// Handles the Click event of the pictureBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var o in QueryFieldsList.Items)
                {
                    _fields.Add(o.ToString());
                }

                var threadStart = new ThreadStart(GenerateSqlScript);
                var thread = new Thread(threadStart);
                thread.Start();
                ToolbarStatusLabel.Text = "Generating Script...";
                GatherButton.Enabled = false;
                GetTablesButton.Enabled = false;
                GetFieldsButton.Enabled = false;
                txtConn.ReadOnly = true;
                GoPictureBoxButton.Enabled = false;
            }
            catch (Exception ex)
            {
                ErrorText.Text += ex.Message + Environment.NewLine;
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Generates the SQL script.
        /// </summary>
        public void GenerateSqlScript()
        {
            try
            {
                Invoke((MethodInvoker) delegate { _querys = BulkInsertBuilder.BuildQueries(_lineas, _fields, _dataTypes, TablesDropdown.Text); });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Invoke((MethodInvoker) delegate { ToolbarStatusLabel.Text = "Executing script..."; });
            var sqlConnection = new SqlConnection(txtConn.Text);
            sqlConnection.Open();
            foreach (var query in _querys)
            {
                Invoke((MethodInvoker) delegate { NowExecutingText.Text = query; });
                try
                {
                    var sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    _succesCount++;
                    Invoke((MethodInvoker) delegate { SuccessfulText.Text = _succesCount.ToString(); });
                }
                catch (Exception exe)
                {
                    _failCount++;
                    Invoke((MethodInvoker) delegate
                                           {
                                               FailText.Text = _failCount.ToString();
                                               ErrorText.Text += exe.Message;
                                               _failedQueries.Add(NowExecutingText.Text);
                                           });
                }
            }

            sqlConnection.Close();
            Invoke((MethodInvoker) delegate
                                   {
                                       //Clean memory :D
                                       ToolbarStatusLabel.Text = "ready";
                                       GatherButton.Enabled = true;
                                       GetTablesButton.Enabled = true;
                                       GetFieldsButton.Enabled = true;
                                       txtConn.ReadOnly = false;
                                       GoPictureBoxButton.Enabled = true;
                                       _lineas.Clear();
                                       _querys.Clear();
                                       _fields.Clear();
                                       _dataTypes.Clear();
                                       _succesCount = 0;
                                       _failCount = 0;
                                   });
        }

        /// <summary>
        /// Handles the Click event of the saveFailedQueriesToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveFailedQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (TextWriter textWriter = new StreamWriter(SaveFileDialog.FileName))
                {
                    foreach (var query in _failedQueries)
                    {
                        textWriter.Write(query + Environment.NewLine);
                    }

                    textWriter.Close();
                }

                // Clean failed querys.
                _failedQueries.Clear();
            }
        }

        /// <summary>
        /// Handles the Click event of the saveErrorLogToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveErrorLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TextWriter textWriter = new StreamWriter(SaveFileDialog.FileName))
            {
                textWriter.Write(ErrorText.Text);
                textWriter.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InstructionsText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}