using System.Collections.Generic;

namespace Importer
{
    /// <summary>
    /// Class ParameterTypeDictionary.
    /// </summary>
    internal class ParameterTypeDictionary
    {
        /// <summary>
        /// The type
        /// </summary>
        private List<string[,]> _type = new List<string[,]>();

        /// <summary>
        /// Add a parameter type pair
        /// </summary>
        /// <param name="key">The parameter</param>
        /// <param name="value">The Type</param>
        public void Add(string key, string value)
        {
            string[,] tmp = { { key, value } };
            _type.Add(tmp);
        }

        /// <summary>
        /// Get a value according to it's key
        /// </summary>
        /// <param name="key">The parameter</param>
        /// <returns>The value</returns>
        public string GetValue(string key)
        {
            foreach (var kvset in _type)
            {
                if (kvset[0, 0] == key)
                    return kvset[0, 1];
            }
            return null;
        }

        /// <summary>
        /// Get a key according to its value
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns>The Key</returns>
        public string GetKey(string value)
        {
            foreach (var kvset in _type)
            {
                if (kvset[0, 1] == value)
                    return kvset[0, 0];
            }
            return null;
        }

        /// <summary>
        /// Clears the dictionary
        /// </summary>
        public void Clear()
        {
            _type.Clear();
        }
    }
}