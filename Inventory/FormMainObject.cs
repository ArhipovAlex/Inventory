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
        public FormMainObject()
        {
            InitializeComponent();
            FormDataLoader.FilterDataComboBox("Types","type_Name",comboBoxType);
            FormDataLoader.FilterDataComboBox("Brands","brand_Name",comboBoxBrand);
            FormDataLoader.FilterDataComboBox("Models","model_Name",comboBoxModel);
            FormDataLoader.FilterDataComboBox("ReleaseCountries","releaseCountry_Name",comboBoxReleaseCountry);
            FormDataLoader.FilterDataComboBox("Offices","office_Name",comboBoxOffice);
        }
        public void InitForm
            (
            string mainObject_FactoryNumber, string mainObject_Type, string mainObject_Brand, 
            string mainObject_Model, DateTime mainObject_ReleaseDate, string mainObject_ReleaseCountry, 
            DateTime mainObject_DateAccounting, string mainObject_Office
            )
        {
            textBoxFactoryNumber.Text = mainObject_FactoryNumber;
            comboBoxType.SelectedValue = mainObject_Type;
            comboBoxBrand.SelectedValue = mainObject_Brand;
            comboBoxModel.SelectedValue = mainObject_Model;
            dateTimePickerRelease.Value = mainObject_ReleaseDate;
            comboBoxReleaseCountry.SelectedValue = mainObject_ReleaseCountry;
            dateTimePickerAccounting.Value = mainObject_DateAccounting;
            comboBoxOffice.SelectedValue = mainObject_Office;
        }
        public void InitForm(DataTable table)
        {
            DataRow row = table.Rows[0];
            Connector connector = new Connector();
            connector.LoadColumnFromTable("*", "MainObjects", $"mainObject_ID={row["mainObject_ID"]}");
            textBoxFactoryNumber.Text = row["mainObject_FactoryNumber"].ToString();
            comboBoxType.SelectedIndex = comboBoxType.FindStringExact(connector.DataTable.Rows[0]["mainObject_Type"].ToString());
            comboBoxBrand.SelectedValue = row["mainObject_Brand"].ToString();
            comboBoxModel.SelectedValue = row["mainObject_Model"].ToString();
            dateTimePickerRelease.Value = DateTime.Parse(row["mainObject_ReleaseDate"].ToString());
            comboBoxReleaseCountry.SelectedValue = row["mainObject_ReleaseCountry"].ToString();
            dateTimePickerAccounting.Value = DateTime.Parse(row["mainObject_DateAccounting"].ToString());
            comboBoxOffice.SelectedValue = row["mainObject_Office"].ToString();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            connector.InsertDataToBase
                (
                "MainObjects",
                "mainObject_FactoryNumber,mainObject_Type,mainObject_Brand,mainObject_Model,mainObject_ReleaseDate,mainObject_ReleaseCountry,mainObject_DateAccounting,mainObject_Office",
                $"" +
                $"{textBoxFactoryNumber.Text}," +
                $"{connector.GetIDbyValue("Types", "type_ID,type_Name", comboBoxType.SelectedItem.ToString())}" +
                $"{connector.GetIDbyValue("Brands", "brand_ID,brand_Name", comboBoxBrand.SelectedItem.ToString())}" +
                $"{connector.GetIDbyValue("Models", "model_ID,model_Name", comboBoxModel.SelectedItem.ToString())}" +
                $"{dateTimePickerRelease.Value}," +
                $"{connector.GetIDbyValue("ReleaseCountries", "releaseCountry_ID,releaseCountry_Name", comboBoxReleaseCountry.SelectedItem.ToString())}" +
                $"{dateTimePickerAccounting.Value}," +
                $"{connector.GetIDbyValue("Offices", "office_ID,office_Name", comboBoxOffice.SelectedItem.ToString())}"
                );
        }

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
    }
}
