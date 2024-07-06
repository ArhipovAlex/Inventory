namespace Inventory
{
    partial class FormReferences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelElements = new System.Windows.Forms.Panel();
            this.labelSelectedItem = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNewItem = new System.Windows.Forms.TextBox();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelElements.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelElements
            // 
            this.panelElements.Controls.Add(this.labelSelectedItem);
            this.panelElements.Controls.Add(this.labelText);
            this.panelElements.Controls.Add(this.buttonDelete);
            this.panelElements.Controls.Add(this.buttonRename);
            this.panelElements.Controls.Add(this.buttonAdd);
            this.panelElements.Controls.Add(this.textBoxNewItem);
            this.panelElements.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelElements.Location = new System.Drawing.Point(0, 0);
            this.panelElements.Name = "panelElements";
            this.panelElements.Size = new System.Drawing.Size(289, 352);
            this.panelElements.TabIndex = 0;
            // 
            // labelSelectedItem
            // 
            this.labelSelectedItem.AutoSize = true;
            this.labelSelectedItem.Location = new System.Drawing.Point(12, 118);
            this.labelSelectedItem.Name = "labelSelectedItem";
            this.labelSelectedItem.Size = new System.Drawing.Size(0, 16);
            this.labelSelectedItem.TabIndex = 5;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(12, 90);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(92, 16);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "Selected Item:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 184);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(270, 32);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete Selected Item";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(12, 146);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(270, 32);
            this.buttonRename.TabIndex = 2;
            this.buttonRename.Text = "Rename Selected Item";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(270, 32);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add New Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNewItem
            // 
            this.textBoxNewItem.Location = new System.Drawing.Point(12, 12);
            this.textBoxNewItem.Name = "textBoxNewItem";
            this.textBoxNewItem.Size = new System.Drawing.Size(270, 22);
            this.textBoxNewItem.TabIndex = 0;
            this.textBoxNewItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dataGridView);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(289, 0);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(356, 352);
            this.panelTable.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(356, 352);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // FormReferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 352);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelElements);
            this.Name = "FormReferences";
            this.Text = "FormReferences";
            this.panelElements.ResumeLayout(false);
            this.panelElements.PerformLayout();
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelElements;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNewItem;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSelectedItem;
        private System.Windows.Forms.Label labelText;
    }
}