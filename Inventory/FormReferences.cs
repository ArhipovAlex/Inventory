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
        public FormReferences(string table, string columns,string condition=null)
        {
            InitializeComponent();
            viewTable = table;
            LoadTable(table, columns, condition);
            dataGridView.Columns[0].Visible=false;
            buttonAdd.Enabled=false;
            buttonRename.Enabled=false;
            buttonDelete.Enabled=false; 
        }

        void LoadTable(string table, string columns, string condition)
        {
            Connector connector = new Connector();
            condition += " ORDER BY Наименование";
            dataGridView.DataSource = connector.LoadColumnFromTable(columns, table, condition);
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelSelectedItem.Text=dataGridView.CurrentCell.FormattedValue.ToString();
            buttonsEnabled();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buttonsEnabled();
        }
        private void buttonsEnabled()
        {
            if (textBox1.Text.Length > 0)
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
            if ((textBox1.Text.Length > 0) && (labelSelectedItem.Text.Length > 0))
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
    }
}
