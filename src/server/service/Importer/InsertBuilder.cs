using System.Collections.Generic;

namespace Importer
{
    /// <summary>
    /// Class InsertBuilder.
    /// </summary>
    internal class InsertBuilder
    {
        /// <summary>
        /// The fields
        /// </summary>
        private readonly List<string> _fields = new List<string>();

        //private ListDictionary parameterType = new ListDictionary();
        /// <summary>
        /// The parameters
        /// </summary>
        private readonly List<string> _parameters = new List<string>();

        /// <summary>
        /// The parameter type dictionary
        /// </summary>
        private readonly ParameterTypeDictionary _parameterTypeDictionary = new ParameterTypeDictionary();

        /// <summary>
        /// Variables to build the statement
        /// </summary>
        private string _table;

        /// <summary>
        /// The final Insert statement build, once all the fields and parameters are set.
        /// </summary>
        /// <value>The insert statement.</value>
        public string InsertStatement
        {
            get
            {
                var insert = $@"INSERT INTO {_table} {BuildFieldList()} VALUES {BuildParameterList()}";
                return insert;
            }
        }

        /// <summary>
        /// The table to which the parameters will be inserted
        /// </summary>
        /// <value>The table.</value>
        public string Table
        {
            get => _table;
            set => _table = value;
        }

        /// <summary>
        /// Add a field to the field list to be inserted
        /// </summary>
        /// <param name="field"><b>field: </b> The column name in the database table</param>
        public void AddField(string field)
        {
            if (!_fields.Contains(field))
                _fields.Add(field);
        }

        /// <summary>
        /// Add a parameter value to be inserted in the database
        /// </summary>
        /// <param name="parameter"><b>parameter: </b> the value you want to insert into the database</param>
        /// <param name="type"><b>type: </b> the type of the parameter to be inserted in the database</param>
        public void AddParameter(string parameter, string type)
        {
            _parameters.Add(parameter);
            _parameterTypeDictionary.Add(parameter, type);
        }

        /// <summary>
        /// Builds the final field list.
        /// </summary>
        /// <returns>the field list</returns>
        private string BuildFieldList()
        {
            var fieldList = string.Empty;
            _fields.ForEach(delegate(string field) { fieldList += ", " + field; });
            fieldList = fieldList.TrimEnd(',');
            fieldList = fieldList.TrimStart(',');
            return $@"({fieldList})";
        }

        /// <summary>
        /// Builds the final parameter list
        /// </summary>
        /// <returns>returns the parameter list</returns>
        private string BuildParameterList()
        {
            var parameterList = string.Empty;
            _parameters.ForEach(delegate(string parameter)
            {
                var type = _parameterTypeDictionary.GetValue(parameter);
                if (type.Equals("int") || type.Equals("date") || type.Equals("datetime") || type.Equals("bigint")|| type.Equals("decimal"))
                    parameterList += ", " + parameter;
                if (type.Equals("datetime"))
                    parameterList += ", " + parameter;
                if (type.Equals("text") || type.Equals("char") || type.Equals("varchar") || type.Equals("nchar") || type.Equals("nvarchar"))
                    parameterList += ", '" + parameter.Replace("'", "''") + "'";
                if (type.Contains("NULL"))
                    parameterList += ", NULL";
            });
            parameterList = parameterList.TrimStart(',');
            parameterList = parameterList.TrimEnd(',');
            return $@"({parameterList})";
        }

        /// <summary>
        /// clear all the values and parameters for this statement
        /// </summary>
        public void ResetStatement()
        {
            _parameters.Clear();
            _parameterTypeDictionary.Clear();
            Table = string.Empty;
            _fields.Clear();
        }
    }
}