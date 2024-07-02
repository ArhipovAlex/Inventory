namespace Inventory
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.locationOfObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referencesTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelViewObjects = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewMainObjects = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewOffices = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxVisibleOutOperation = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFiltres = new System.Windows.Forms.Label();
            this.labelBuildings = new System.Windows.Forms.Label();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxBuildings = new System.Windows.Forms.ComboBox();
            this.labelTypes = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPageStorage = new System.Windows.Forms.TabPage();
            this.dataGridViewStorage = new System.Windows.Forms.DataGridView();
            this.panelStorageFiltres = new System.Windows.Forms.Panel();
            this.buttonAddNewObject = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainObjects)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPageStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorage)).BeginInit();
            this.panelStorageFiltres.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationOfObjectsToolStripMenuItem,
            this.referencesTablesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // locationOfObjectsToolStripMenuItem
            // 
            this.locationOfObjectsToolStripMenuItem.Name = "locationOfObjectsToolStripMenuItem";
            this.locationOfObjectsToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.locationOfObjectsToolStripMenuItem.Text = "File";
            // 
            // referencesTablesToolStripMenuItem
            // 
            this.referencesTablesToolStripMenuItem.Name = "referencesTablesToolStripMenuItem";
            this.referencesTablesToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.referencesTablesToolStripMenuItem.Text = "References Tables";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelViewObjects});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelViewObjects
            // 
            this.toolStripStatusLabelViewObjects.Name = "toolStripStatusLabelViewObjects";
            this.toolStripStatusLabelViewObjects.Size = new System.Drawing.Size(225, 20);
            this.toolStripStatusLabelViewObjects.Text = "toolStripStatusLabelViewObjects";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageStorage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 396);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.splitter2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Objects in Operation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewMainObjects);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(586, 258);
            this.panel3.TabIndex = 3;
            // 
            // dataGridViewMainObjects
            // 
            this.dataGridViewMainObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMainObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMainObjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMainObjects.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMainObjects.MultiSelect = false;
            this.dataGridViewMainObjects.Name = "dataGridViewMainObjects";
            this.dataGridViewMainObjects.ReadOnly = true;
            this.dataGridViewMainObjects.RowHeadersWidth = 51;
            this.dataGridViewMainObjects.RowTemplate.Height = 24;
            this.dataGridViewMainObjects.Size = new System.Drawing.Size(586, 258);
            this.dataGridViewMainObjects.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(203, 103);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(586, 3);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewOffices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(203, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 100);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewOffices
            // 
            this.dataGridViewOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOffices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOffices.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOffices.MultiSelect = false;
            this.dataGridViewOffices.Name = "dataGridViewOffices";
            this.dataGridViewOffices.ReadOnly = true;
            this.dataGridViewOffices.RowHeadersWidth = 51;
            this.dataGridViewOffices.RowTemplate.Height = 24;
            this.dataGridViewOffices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOffices.Size = new System.Drawing.Size(586, 100);
            this.dataGridViewOffices.TabIndex = 0;
            this.dataGridViewOffices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOffices_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 361);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBoxVisibleOutOperation);
            this.panel4.Controls.Add(this.dateTimePickerDateIn);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.labelFiltres);
            this.panel4.Controls.Add(this.labelBuildings);
            this.panel4.Controls.Add(this.comboBoxTypes);
            this.panel4.Controls.Add(this.comboBoxBuildings);
            this.panel4.Controls.Add(this.labelTypes);
            this.panel4.Location = new System.Drawing.Point(7, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 189);
            this.panel4.TabIndex = 6;
            // 
            // checkBoxVisibleOutOperation
            // 
            this.checkBoxVisibleOutOperation.AutoSize = true;
            this.checkBoxVisibleOutOperation.Checked = true;
            this.checkBoxVisibleOutOperation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVisibleOutOperation.Location = new System.Drawing.Point(6, 164);
            this.checkBoxVisibleOutOperation.Name = "checkBoxVisibleOutOperation";
            this.checkBoxVisibleOutOperation.Size = new System.Drawing.Size(155, 20);
            this.checkBoxVisibleOutOperation.TabIndex = 8;
            this.checkBoxVisibleOutOperation.Text = "Visible Out Operation";
            this.checkBoxVisibleOutOperation.UseVisualStyleBackColor = true;
            this.checkBoxVisibleOutOperation.CheckedChanged += new System.EventHandler(this.checkBoxVisibleOutOperation_CheckedChanged);
            // 
            // dateTimePickerDateIn
            // 
            this.dateTimePickerDateIn.Location = new System.Drawing.Point(6, 135);
            this.dateTimePickerDateIn.Name = "dateTimePickerDateIn";
            this.dateTimePickerDateIn.Size = new System.Drawing.Size(178, 22);
            this.dateTimePickerDateIn.TabIndex = 7;
            this.dateTimePickerDateIn.ValueChanged += new System.EventHandler(this.dateTimePickerDateIn_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date in Operation";
            // 
            // labelFiltres
            // 
            this.labelFiltres.AutoSize = true;
            this.labelFiltres.Location = new System.Drawing.Point(3, 0);
            this.labelFiltres.Name = "labelFiltres";
            this.labelFiltres.Size = new System.Drawing.Size(43, 16);
            this.labelFiltres.TabIndex = 1;
            this.labelFiltres.Text = "Filtres";
            // 
            // labelBuildings
            // 
            this.labelBuildings.AutoSize = true;
            this.labelBuildings.Location = new System.Drawing.Point(6, 19);
            this.labelBuildings.Name = "labelBuildings";
            this.labelBuildings.Size = new System.Drawing.Size(62, 16);
            this.labelBuildings.TabIndex = 5;
            this.labelBuildings.Text = "Buildings";
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(6, 84);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(178, 24);
            this.comboBoxTypes.Sorted = true;
            this.comboBoxTypes.TabIndex = 2;
            this.comboBoxTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypes_SelectedIndexChanged);
            // 
            // comboBoxBuildings
            // 
            this.comboBoxBuildings.FormattingEnabled = true;
            this.comboBoxBuildings.Location = new System.Drawing.Point(6, 38);
            this.comboBoxBuildings.Name = "comboBoxBuildings";
            this.comboBoxBuildings.Size = new System.Drawing.Size(178, 24);
            this.comboBoxBuildings.Sorted = true;
            this.comboBoxBuildings.TabIndex = 4;
            this.comboBoxBuildings.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuildings_SelectedIndexChanged);
            // 
            // labelTypes
            // 
            this.labelTypes.AutoSize = true;
            this.labelTypes.Location = new System.Drawing.Point(6, 65);
            this.labelTypes.Name = "labelTypes";
            this.labelTypes.Size = new System.Drawing.Size(46, 16);
            this.labelTypes.TabIndex = 3;
            this.labelTypes.Text = "Types";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 361);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // tabPageStorage
            // 
            this.tabPageStorage.Controls.Add(this.dataGridViewStorage);
            this.tabPageStorage.Controls.Add(this.panelStorageFiltres);
            this.tabPageStorage.Location = new System.Drawing.Point(4, 25);
            this.tabPageStorage.Name = "tabPageStorage";
            this.tabPageStorage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStorage.Size = new System.Drawing.Size(792, 367);
            this.tabPageStorage.TabIndex = 2;
            this.tabPageStorage.Text = "Storage";
            this.tabPageStorage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStorage
            // 
            this.dataGridViewStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStorage.Location = new System.Drawing.Point(203, 3);
            this.dataGridViewStorage.MultiSelect = false;
            this.dataGridViewStorage.Name = "dataGridViewStorage";
            this.dataGridViewStorage.ReadOnly = true;
            this.dataGridViewStorage.RowHeadersWidth = 51;
            this.dataGridViewStorage.RowTemplate.Height = 24;
            this.dataGridViewStorage.Size = new System.Drawing.Size(586, 361);
            this.dataGridViewStorage.TabIndex = 1;
            this.dataGridViewStorage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStorage_CellDoubleClick);
            // 
            // panelStorageFiltres
            // 
            this.panelStorageFiltres.Controls.Add(this.buttonAddNewObject);
            this.panelStorageFiltres.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStorageFiltres.Location = new System.Drawing.Point(3, 3);
            this.panelStorageFiltres.Name = "panelStorageFiltres";
            this.panelStorageFiltres.Size = new System.Drawing.Size(200, 361);
            this.panelStorageFiltres.TabIndex = 0;
            // 
            // buttonAddNewObject
            // 
            this.buttonAddNewObject.Location = new System.Drawing.Point(5, 3);
            this.buttonAddNewObject.Name = "buttonAddNewObject";
            this.buttonAddNewObject.Size = new System.Drawing.Size(189, 30);
            this.buttonAddNewObject.TabIndex = 0;
            this.buttonAddNewObject.Text = "Add New Object";
            this.buttonAddNewObject.UseVisualStyleBackColor = true;
            this.buttonAddNewObject.Click += new System.EventHandler(this.buttonAddNewObject_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Inventory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMainObjects)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageStorage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorage)).EndInit();
            this.panelStorageFiltres.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem locationOfObjectsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewMainObjects;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewOffices;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelBuildings;
        private System.Windows.Forms.ComboBox comboBoxBuildings;
        private System.Windows.Forms.Label labelTypes;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Label labelFiltres;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBoxVisibleOutOperation;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem referencesTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelViewObjects;
        private System.Windows.Forms.TabPage tabPageStorage;
        private System.Windows.Forms.Panel panelStorageFiltres;
        private System.Windows.Forms.DataGridView dataGridViewStorage;
        private System.Windows.Forms.Button buttonAddNewObject;
    }
}

