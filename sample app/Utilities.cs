using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_app
{
    class Utils
    {
        /// <summary>
        /// Authenticates a user based on a username and password.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// True, if authentication is successful, otherwise False.
        /// </returns>
        /// <remarks>
        /// For use with local systems
        /// </remarks>
        public static void PopulateListBox(ListBox listbox, DataTable _list)
        {
            List<string> list = MakeList(_list, false);
            listbox.DataSource = list;
        }

        public static List<string> MakeList(DataTable data, bool useIdField = false)
        {
            // Makes a list from a dataTable by concatenating all the rows.
            // Useful for first_name last_name situations.
            // Can be refactored for other uses
            List<string> newList = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                int start_index;
                if (useIdField)
                {
                    start_index = 0;
                }
                else
                {
                    start_index = 1;
                }

                string msg = "";
                for (int i = start_index; i < data.Columns.Count; i++)
                {
                    DataColumn col = data.Columns[i];
                    msg += row[col] + " ";
                }
                newList.Add(msg);
            }
            return newList;
        }

        public static List<int> StoreIdField(DataTable data, int IdFieldIndex=0)
        {
            List<int> IdList = new List<int>();
            foreach (DataRow row in data.Rows)
            {
                for (int i = 0; i < 1; i++)
                    IdList.Add(Convert.ToInt32(row[0].ToString()));
            }
            return IdList;
        }
    }
}
