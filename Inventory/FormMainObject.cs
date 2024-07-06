using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class FormMainObject : Form
    {
        int id;
        public FormMainObject()
        {
            InitializeComponent();
            FormDataLoader.FilterDataComboBox("Types","type_Name",comboBoxType);
            FormDataLoader.FilterDataComboBox("Brands","brand_Name",comboBoxBrand);
            FormDataLoader.FilterDataComboBox("Models","model_Name",comboBoxModel);
            FormDataLoader.FilterDataComboBox("ReleaseCountries","releaseCountry_Name",comboBoxReleaseCountry);
            FormDataLoader.FilterDataComboBox("Offices","office_Name",comboBoxOffice);
            id = -1;
        }

        public void InitForm(DataTable table)
        {
            DataRow row = table.Rows[0];
            id = Convert.ToInt32(row["mainObject_ID"].ToString());
            textBoxFactoryNumber.Text = row["mainObject_FactoryNumber"].ToString();
            Connector connectorLoad = new Connector();
            connectorLoad.LoadColumnFromTable("type_Name, brand_Name, model_Name, releaseCountry_Name, office_Name", "Types, Brands, Models, ReleaseCountries, Offices", $"type_ID={row["mainObject_Type"]} AND brand_ID={row["mainObject_Brand"]} AND model_ID={row["mainObject_Model"]} AND releaseCountry_ID={row["mainObject_ReleaseCountry"]} AND office_ID={row["mainObject_Office"]}");
            comboBoxType.SelectedIndex = comboBoxType.FindStringExact(connectorLoad.DataTable.Rows[0]["type_Name"].ToString());
            connectorLoad.LoadColumnFromTable("brand_Name", "Brands", $"brand_ID={table.Rows[0]["mainObject_Brand"]}");
            comboBoxBrand.SelectedIndex = comboBoxBrand.FindStringExact(connectorLoad.DataTable.Rows[0]["brand_Name"].ToString());
            connectorLoad.LoadColumnFromTable("model_Name", "Models", $"model_ID={table.Rows[0]["mainObject_Model"]}");
            comboBoxModel.SelectedIndex = comboBoxModel.FindStringExact(connectorLoad.DataTable.Rows[0]["model_Name"].ToString());
            dateTimePickerRelease.Value = DateTime.Parse(row["mainObject_ReleaseDate"].ToString());
            connectorLoad.LoadColumnFromTable("releaseCountry_Name", "ReleaseCountries", $"releaseCountry_ID={table.Rows[0]["mainObject_ReleaseCountry"]}");
            comboBoxReleaseCountry.SelectedIndex = comboBoxReleaseCountry.FindStringExact(connectorLoad.DataTable.Rows[0]["releaseCountry_Name"].ToString());
            dateTimePickerAccounting.Value = DateTime.Parse(row["mainObject_DateAccounting"].ToString());
            connectorLoad.LoadColumnFromTable("office_Name", "Offices", $"office_ID={table.Rows[0]["mainObject_Office"]}");
            comboBoxOffice.SelectedIndex = comboBoxOffice.FindStringExact(connectorLoad.DataTable.Rows[0]["office_Name"].ToString());
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            string table = "MainObjects";
            string columns = "mainObject_FactoryNumber,mainObject_Type,mainObject_Brand,mainObject_Model,mainObject_ReleaseDate,mainObject_ReleaseCountry,mainObject_DateAccounting,mainObject_Office";
            string values = $"" +
            $"'{textBoxFactoryNumber.Text}'," +
            $"{connector.GetIDbyValue("Types", "type_ID,type_Name", comboBoxType.SelectedItem.ToString())}," +
            $"{connector.GetIDbyValue("Brands", "brand_ID,brand_Name", comboBoxBrand.SelectedItem.ToString())}," +
            $"{connector.GetIDbyValue("Models", "model_ID,model_Name", comboBoxModel.SelectedItem.ToString())}," +
            $"'{dateTimePickerRelease.Value.ToString("MM-dd-yyyy")}'," +
            $"{connector.GetIDbyValue("ReleaseCountries", "releaseCountry_ID,releaseCountry_Name", comboBoxReleaseCountry.SelectedItem.ToString())}," +
            $"'{dateTimePickerAccounting.Value.ToString("MM-dd-yyyy")}'," +
            $"{connector.GetIDbyValue("Offices", "office_ID,office_Name", comboBoxOffice.SelectedItem.ToString())}";
            if (id < 0)
            {
            connector.InsertDataToBase
                    (
                table,
                columns,
                values
                    );
            }
            else
            {
                string condition = $"mainObject_ID={id}";
                connector.UpdateDataInBase
                    (
                table,
                columns,
                values,
                condition
                    );
            }

        }
        /*
        private void comboBoxType_TextChanged(object sender, EventArgs e)
        {
            FormDataLoader.FilterDataComboBox("Types", "type_Name", comboBoxType);
        }

        private void comboBoxBrand_TextChanged(object sender, EventArgs e)
        {
            FormDataLoader.FilterDataComboBox("Brands", "brand_Name", comboBoxBrand);
        }

        private void comboBoxModel_TextChanged(object sender, EventArgs e)
        {
            FormDataLoader.FilterDataComboBox("Models", "model_Name", comboBoxModel);
        }

        private void comboBoxReleaseCountry_TextChanged(object sender, EventArgs e)
        {
            FormDataLoader.FilterDataComboBox("ReleaseCountries", "releaseCountry_Name", comboBoxReleaseCountry);
        }

        private void comboBoxOffice_TextChanged(object sender, EventArgs e)
        {
            FormDataLoader.FilterDataComboBox("Offices", "office_Name", comboBoxOffice);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxType.Text=comboBoxType.SelectedIndex.ToString();
            labelTest.Text = comboBoxType.SelectedItem.ToString();
        }
        */
    }
}
