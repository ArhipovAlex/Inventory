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
using System.CodeDom;

namespace Inventory
{
    public partial class MainForm : Form
    {
        string connectionString;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            
            LoadOffices();
            dataGridViewOffices.Rows[0].Cells[0].Selected = true;
            dataGridViewOffices.Columns[0].Visible = false;
            LoadMainObjects();
            this.dataGridViewOffices.Sort(this.dataGridViewOffices.Columns["Здание"], ListSortDirection.Ascending);
            FormDataLoader.LoadDataToComboBox("Buildings", "building_Name", comboBoxBuildings);
            comboBoxBuildings.SelectedIndex = 0;
            FormDataLoader.LoadDataToComboBox("Types", "type_Name", comboBoxTypes);
            comboBoxTypes.SelectedIndex = 0;
            dateTimePickerDateIn.Text="1901-01-01";
            checkBoxVisibleOutOperation.Checked = false;
            LoadStorage();
        }

        void LoadMainObjects(string condition = null)
        {
            string columns = $@"
                [ID]                            = mainObject_ID,
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
";
            string tables = "MainObjects, Brands, Models, Types, ReleaseCountries, Offices, Buildings";
            string relations = @"mainObject_Brand=brand_ID AND 
                                    mainObject_Model=model_ID AND
                                    mainObject_Type=type_ID AND
                                    mainObject_ReleaseCountry=releaseCountry_ID AND
                                    mainObject_Office=office_ID AND
                                    office_Building=building_ID
";
            if(condition!=null)condition=$"{relations} AND {condition}";
            else condition = relations;
            Connector connector=new Connector();
            dataGridViewMainObjects.DataSource = connector.LoadColumnFromTable(columns, tables, condition);
            dataGridViewMainObjects.Columns[0].Visible = false;
            toolStripStatusLabelViewObjects.Text = $"Отображено основных средств {dataGridViewMainObjects.RowCount-1}";
        }

        void LoadOffices(string condition=null)
        {
            string columns = $@"
                    [ID]        = office_ID,
                    [Кабинет]   = office_Name,
                    [Здание]    = building_Name
";
            string tables = $@"Offices, Buildings";
            string relations = $@"office_Building=building_ID";
            if (condition != null) condition = $"{relations} AND {condition}";
            else condition = relations;
            condition += " ORDER BY Здание, Кабинет";
            Connector connector = new Connector();
            dataGridViewOffices.DataSource=connector.LoadColumnFromTable(columns,tables, condition);
        }
        /*
        void LoadDataToComboBox(string table, string column, ComboBox list)
        {
            Connector connector = new Connector();
            connector.LoadColumnFromTable(column, table);
            string[] items = new string[connector.DataTable.Rows.Count];
            for(int i = 0; i < items.Length; i++)
            {
                items[i] = connector.DataTable.Rows[i][0].ToString();
            }
            list.Items.AddRange(items);
        }*/
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
            //change Date in OPERATION-filter
            if (condition != null) condition += " AND ";
            condition += $"mainObject_DateInToOperation >= '{dateTimePickerDateIn.Value.ToString("yyyy-MM-dd")}'";
            //change OFFICE-filter
            if (dataGridViewOffices.CurrentRow != null)
            {
                if (dataGridViewOffices.CurrentRow.Cells[0].FormattedValue.ToString() != "8")
                condition += $" AND office_ID = {dataGridViewOffices.CurrentRow.Cells[0].FormattedValue.ToString()}";
            }
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
        void LoadStorage(string condition = null)
        {
            string columns = $@"
                    [ID]                            = mainObject_ID,
                    [Серийный номер]                = mainObject_FactoryNumber,
                    [Бренд]                         = brand_Name,
                    [Модель]                        = model_Name,
                    [Тип устройства]                = type_Name,
                    [Дата производства]             = mainObject_ReleaseDate,
                    [Страна-изготовитель]           = releaseCountry_Name,
                    [Кабинет]                       = office_Name,
                    [Здание]                        = building_Name,
                    [Дата принятия к учету]         = mainObject_DateAccounting
";
            string tables = $@"MainObjects, Brands, Models, Types, ReleaseCountries, Offices, Buildings";
            string relations = $@"mainObject_Brand=brand_ID AND 
                                    mainObject_Model=model_ID AND
                                    mainObject_Type=type_ID AND
                                    mainObject_ReleaseCountry=releaseCountry_ID AND
                                    mainObject_Office=office_ID AND
                                    office_Building=building_ID
";
            if (condition != null) condition = $"mainObject_DateInToOperation is null AND {relations} AND {condition}";
            else condition = $"mainObject_DateInToOperation is null AND {relations}";
            Connector connector = new Connector();
            dataGridViewStorage.DataSource = connector.LoadColumnFromTable(columns,tables,condition);
            dataGridViewStorage.Columns[0].Visible = false;
        }

        private void buttonAddNewObject_Click(object sender, EventArgs e)
        {
            FormMainObject formMainObject = new FormMainObject();
            DialogResult result= formMainObject.ShowDialog();
            if(result==DialogResult.OK)
            {
                LoadStorage();
            }
        }

        private void dataGridViewOffices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewMainObjects();
        }

        private void dataGridViewStorage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormMainObject form = new FormMainObject();
            int id = Convert.ToInt32(dataGridViewStorage.Rows[0].Cells[0].Value);
            Connector connector = new Connector();
            connector.LoadColumnFromTable("*", "MainObjects", $"mainObject_id={id}");
            FormMainObject formMain = new FormMainObject();
            form.InitForm(connector.DataTable);
            form.ShowDialog();
        }

        private void tableCountriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReferences form = new FormReferences("Release Countries","ReleaseCountries", "releaseCountry_ID,releaseCountry_Name", "releaseCountry_ID>0");
            form.ShowDialog();
        }

        private void tableTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReferences form = new FormReferences("Types","Types", "type_ID,type_Name","type_ID<>4");
            form.ShowDialog();
        }

        private void tableBrandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReferences form = new FormReferences("Brands", "Brands", "brand_ID,brand_Name", "brand_ID>0");
            form.ShowDialog();
        }

        private void tableModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReferences form = new FormReferences("Models", "Models", "model_ID,model_Name", "model_ID>0");
            form.ShowDialog();
        }
    }
}
