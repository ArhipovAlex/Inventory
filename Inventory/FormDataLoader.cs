using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    static class FormDataLoader
    {
        public static void LoadDataToComboBox(string table, string column, ComboBox list, string condition=null)
        {
            list.Items.Clear();
            Connector connector = new Connector();
            connector.LoadColumnFromTable(column, table,condition);
            string[] items = new string[connector.DataTable.Rows.Count];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = connector.DataTable.Rows[i][0].ToString();
            }
            list.Items.AddRange(items);
        }
        public static void FilterDataComboBox(string table, string column, ComboBox list, string condition = null)
        {
            if (list.Text == null)
                FormDataLoader.LoadDataToComboBox($"{table}", $"{column}", list, $"{condition} {column}<>'All' ORDER BY {column}");
            else
                FormDataLoader.LoadDataToComboBox($"{table}", $"{column}", list, $"{condition} {column}<>'All' AND {column} LIKE '{list.Text}%' ORDER BY {column}");
            list.SelectionStart = list.Text.Length;
        }
    }
}
