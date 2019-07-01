using System.Collections.Generic;

namespace Importer
{
    /// <summary>
    /// Class BulkInsertBuilder.
    /// </summary>
    internal class BulkInsertBuilder
    {
        /// <summary>
        /// Builds a SQL script with all the INSERT statements to be executed in the database
        /// </summary>
        /// <param name="lines">the lines contained in the csv input file</param>
        /// <param name="fields">A List containing all the fields in the database table</param>
        /// <param name="dataTypes">Dictionary collection containing parameters (key) and dataTypes (value)</param>
        /// <param name="table">The table.</param>
        /// <returns>a List collection containing all the query strings</returns>
        public static List<string> BuildQueries(List<string> lines, List<string> fields, Dictionary<string, string> dataTypes, string table)
        {
            var queries = new List<string>();
            var insertBuilder = new InsertBuilder();
            foreach (var line in lines)
            {
                insertBuilder.Table = table;
                foreach (var field in fields)
                    insertBuilder.AddField(field);

                var paramList = line.Split('\t');
                var debug = " ";
                var panicBreak = false;
                for (var index = 0; index < paramList.Length; index++)
                {
                    try
                    {
                        var type = string.Empty;
                        debug = paramList[index];
                        dataTypes.TryGetValue(fields[index], out type);
                        if (type == null || type.Equals("NULL"))
                        {
                            insertBuilder.AddParameter("NULL", "NULL");
                            continue;
                        }
                        insertBuilder.AddParameter(paramList[index], type);
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        System.Windows.Forms.MessageBox.Show("More arguments in query than fields in table, check your csv file near: " + debug);
                        panicBreak = true;
                        break;
                    }
                    if (panicBreak)
                        break;
                }
                if (panicBreak)
                {
                    queries.Clear();
                    break;
                }
                queries.Add(insertBuilder.InsertStatement.Replace("'NULL'", "NULL"));
                insertBuilder.ResetStatement();
            }
            return queries;
        }
    }
}