using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class FormReferences : Form
    {
        string viewTable;
        string columnID;
        string viewColumn;
        string selectedID;
        string viewCondition;
        public FormReferences(string formName, string table, string columns,string condition=null)
        {
            InitializeComponent();
            viewTable = table;
            columnID = columns.Split(',')[0];
            viewColumn = columns.Split(',')[1];
            viewCondition = condition;
            //columns = $"[ID]={columns.Split(',')[0]},[Наименование]={columns.Split(',')[1]}";
            LoadTable(table, $"[ID]={columns.Split(',')[0]},[Наименование]={columns.Split(',')[1]}", condition);
            dataGridView.Columns[0].Visible=false;
            buttonAdd.Enabled=false;
            buttonRename.Enabled=false;
            buttonDelete.Enabled=false;
            this.Text = formName;
        }

        void LoadTable(string table, string columns, string condition)
        {
            Connector connector = new Connector();
            condition += " ORDER BY Наименование";
            dataGridView.DataSource = connector.LoadColumnFromTable(columns, table, condition);
            buttonsEnabled();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelSelectedItem.Text=dataGridView.CurrentCell.FormattedValue.ToString();
            selectedID = dataGridView.CurrentRow.Cells[0].Value.ToString();
            buttonsEnabled();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonsEnabled();
        }
        private void buttonsEnabled()
        {
            if (textBoxNewItem.Text.Length > 0)
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
            if (labelSelectedItem.Text.Length > 0)
            {
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonDelete.Enabled = false;
            }
            if ((textBoxNewItem.Text.Length > 0) && (labelSelectedItem.Text.Length > 0))
            {
                buttonAdd.Enabled = false;
                buttonRename.Enabled = true;
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonRename.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            connector.InsertDataToBase(viewTable, viewColumn, $"'{textBoxNewItem.Text}'");
            textBoxNewItem.Text = "";
            LoadTable(viewTable, $"[ID]={columnID},[Наименование]={viewColumn}", viewCondition);
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            Connector connector = new Connector();
            string condition = $"{columnID}={selectedID}";
            connector.UpdateDataInBase(viewTable,viewColumn, $"'{textBoxNewItem.Text}'", condition);
            textBoxNewItem.Text = "";
            labelSelectedItem.Text = "";
            LoadTable(viewTable, $"[ID]={columnID},[Наименование]={viewColumn}", viewCondition);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Connector connector= new Connector();
            connector.RemoveDataToBase(viewTable, $"{columnID}={selectedID}");
            labelSelectedItem.Text = "";
            LoadTable(viewTable, $"[ID]={columnID},[Наименование]={viewColumn}", viewCondition);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
