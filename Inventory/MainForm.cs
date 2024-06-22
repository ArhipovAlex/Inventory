using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Inventory
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;
        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            LoadMainObjects();
            
            toolStripStatusLabelAllObjects.Text = $"из {dataGridViewMainObjects.RowCount-1}";
            LoadOffices();
            this.dataGridViewOffices.Sort(this.dataGridViewOffices.Columns["Здание"], ListSortDirection.Ascending);
            LoadDataToComboBox("Buildings", "building_Name", comboBoxBuildings);
            comboBoxBuildings.SelectedIndex = 0;
            LoadDataToComboBox("Types", "type_Name", comboBoxTypes);
            comboBoxTypes.SelectedIndex = 0;
            dateTimePickerDateIn.Text="1901-01-01";
        }

        void LoadMainObjects(string condition = null)
        {
            connection.Open();
            string cmd = $@"
SELECT 
        [Инвентарный номер]             = mainObject_InventarNumber,
        [Серийный номер]                = mainObject_FactoryNumber,
        [Бренд]                         = brand_Name,
        [Модель]                        = model_Name,
        [Тип устройства]                = type_Name,
        [Дата производства]             = mainObject_ReleaseDate,
        [Страна-изготовитель]           = releaseCountry_Name,
        [Кабинет]                       = office_Name,
        [Здание]                        = building_Name,
        [Дата принятия к учету]         = mainObject_DateAccounting,
        [Дата ввода в эксплуатацию]     = mainObject_DateInToOperation,
        [Дата вывода из эксплуатации]   = mainObject_DateOutOfOperation,
        [Причина вывода]                = mainObject_Reason

FROM MainObjects
JOIN Brands ON  (mainObject_Brand=brand_ID)
JOIN Models ON  (mainObject_Model=model_ID)
JOIN Types  ON  (mainObject_Type=type_ID)
JOIN ReleaseCountries   ON  (mainObject_ReleaseCountry=releaseCountry_ID)
JOIN Offices    ON  (mainObject_Office=office_ID)
JOIN Buildings  ON  (office_Building=building_ID)
";
            if (condition != null)
            {
                cmd += $" WHERE {condition}";
            }
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);

            }
            dataGridViewMainObjects.DataSource = table;
            connection.Close();
            toolStripStatusLabelViewObjects.Text = $"Отображено основных средств {dataGridViewMainObjects.RowCount-1}";
        }

        void LoadOffices(string condition=null)
        {
            connection.Open();
            string cmd = $@"
SELECT 
        [Кабинет]   = office_Name,
        [Здание]    = building_Name
FROM Offices
JOIN Buildings  ON  (office_Building=building_ID)
";
            if(condition!=null)
            {
                cmd += $" WHERE {condition}";
            }
            cmd += " ORDER BY Здание, Кабинет";
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);

            }
            dataGridViewOffices.DataSource = table;
            connection.Close();
        }

        void LoadDataToComboBox(string table, string column, ComboBox list)
        {
            string cmd = $"SELECT {column} From {table}";
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            reader = command.ExecuteReader();
            while(reader.Read()) 
            {
                list.Items.Add(reader[0]);
            }
            connection.Close();
        }

        private void comboBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuildings.SelectedItem.ToString() != "All")
                LoadOffices($"building_Name='{comboBoxBuildings.SelectedItem.ToString()}'");
            else
                LoadOffices();
            this.dataGridViewOffices.Sort(this.dataGridViewOffices.Columns["Здание"], ListSortDirection.Ascending);
        }
        void ViewMainObjects()
        {
            //if (comboBoxTypes.SelectedItem.ToString() != "All" && !checkBoxVisibleOutOperation.Checked)
            //{
            //    LoadMainObjects($"(type_Name='{comboBoxTypes.SelectedItem.ToString()}' AND mainObject_DateOutOfOperation is null)");
            //    return;
            //}
            //    if (comboBoxTypes.SelectedItem.ToString() != "All")
            //{
            //    LoadMainObjects($"type_Name='{comboBoxTypes.SelectedItem.ToString()}'");
            //    return;
            //}
            //if (!checkBoxVisibleOutOperation.Checked)
            //{
            //    LoadMainObjects($"mainObject_DateOutOfOperation is null");
            //    return;
            //}
            //LoadMainObjects();

            string condition = null;
            //change TYPE-filter
            if (comboBoxTypes.SelectedItem.ToString() != "All") 
                condition+= $"type_Name='{comboBoxTypes.SelectedItem.ToString()}'";
            //change VISIBLE-filter DEBIT OBJECTS
            if (!checkBoxVisibleOutOperation.Checked)
            {
                if (condition != null) condition += " AND ";
                condition += "mainObject_DateOutOfOperation is null";
            }
            if (condition != null) condition += " AND ";
            condition += $"mainObject_DateInToOperation >= '{dateTimePickerDateIn.Value.ToString("yyyy-MM-dd")}'";
            if (condition !=null) LoadMainObjects(condition);
            else LoadMainObjects();

        }
        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewMainObjects();
        }

        private void checkBoxVisibleOutOperation_CheckedChanged(object sender, EventArgs e)
        {
            ViewMainObjects();
        }

        private void dateTimePickerDateIn_ValueChanged(object sender, EventArgs e)
        {
            ViewMainObjects();
        }
    }
}
