namespace Inventory
{
    partial class FormMainObject
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFactoryNumber = new System.Windows.Forms.Label();
            this.textBoxFactoryNumber = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.dateTimePickerRelease = new System.Windows.Forms.DateTimePicker();
            this.labelReleaseCountry = new System.Windows.Forms.Label();
            this.comboBoxReleaseCountry = new System.Windows.Forms.ComboBox();
            this.labelDateAccounting = new System.Windows.Forms.Label();
            this.dateTimePickerAccounting = new System.Windows.Forms.DateTimePicker();
            this.labelOffice = new System.Windows.Forms.Label();
            this.comboBoxOffice = new System.Windows.Forms.ComboBox();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.buttonAddModel = new System.Windows.Forms.Button();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.buttonAddOffice = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.29977F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.70023F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.Controls.Add(this.labelFactoryNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFactoryNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBrand, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBrand, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelModel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxModel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelReleaseDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerRelease, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelReleaseCountry, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxReleaseCountry, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelDateAccounting, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerAccounting, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelOffice, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxOffice, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddType, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddBrand, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddModel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddCountry, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddOffice, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 249);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelFactoryNumber
            // 
            this.labelFactoryNumber.AutoSize = true;
            this.labelFactoryNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFactoryNumber.Location = new System.Drawing.Point(3, 0);
            this.labelFactoryNumber.Name = "labelFactoryNumber";
            this.labelFactoryNumber.Size = new System.Drawing.Size(149, 31);
            this.labelFactoryNumber.TabIndex = 0;
            this.labelFactoryNumber.Text = "Factory/Serial Number";
            this.labelFactoryNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFactoryNumber
            // 
            this.textBoxFactoryNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFactoryNumber.Location = new System.Drawing.Point(158, 3);
            this.textBoxFactoryNumber.Name = "textBoxFactoryNumber";
            this.textBoxFactoryNumber.Size = new System.Drawing.Size(256, 22);
            this.textBoxFactoryNumber.TabIndex = 1;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelType.Location = new System.Drawing.Point(3, 31);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(149, 31);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type of Object";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(158, 34);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(256, 24);
            this.comboBoxType.TabIndex = 3;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBrand.Location = new System.Drawing.Point(3, 62);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(149, 31);
            this.labelBrand.TabIndex = 4;
            this.labelBrand.Text = "Brand";
            this.labelBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(158, 65);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(256, 24);
            this.comboBoxBrand.TabIndex = 5;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelModel.Location = new System.Drawing.Point(3, 93);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(149, 31);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "Model";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(158, 96);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(256, 24);
            this.comboBoxModel.TabIndex = 7;
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReleaseDate.Location = new System.Drawing.Point(3, 124);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(149, 31);
            this.labelReleaseDate.TabIndex = 8;
            this.labelReleaseDate.Text = "Date of Release";
            this.labelReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerRelease
            // 
            this.dateTimePickerRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerRelease.Location = new System.Drawing.Point(158, 127);
            this.dateTimePickerRelease.Name = "dateTimePickerRelease";
            this.dateTimePickerRelease.Size = new System.Drawing.Size(256, 22);
            this.dateTimePickerRelease.TabIndex = 9;
            // 
            // labelReleaseCountry
            // 
            this.labelReleaseCountry.AutoSize = true;
            this.labelReleaseCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReleaseCountry.Location = new System.Drawing.Point(3, 155);
            this.labelReleaseCountry.Name = "labelReleaseCountry";
            this.labelReleaseCountry.Size = new System.Drawing.Size(149, 31);
            this.labelReleaseCountry.TabIndex = 10;
            this.labelReleaseCountry.Text = "Manufactured Country";
            this.labelReleaseCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxReleaseCountry
            // 
            this.comboBoxReleaseCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReleaseCountry.FormattingEnabled = true;
            this.comboBoxReleaseCountry.Location = new System.Drawing.Point(158, 158);
            this.comboBoxReleaseCountry.Name = "comboBoxReleaseCountry";
            this.comboBoxReleaseCountry.Size = new System.Drawing.Size(256, 24);
            this.comboBoxReleaseCountry.TabIndex = 11;
            // 
            // labelDateAccounting
            // 
            this.labelDateAccounting.AutoSize = true;
            this.labelDateAccounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDateAccounting.Location = new System.Drawing.Point(3, 186);
            this.labelDateAccounting.Name = "labelDateAccounting";
            this.labelDateAccounting.Size = new System.Drawing.Size(149, 31);
            this.labelDateAccounting.TabIndex = 12;
            this.labelDateAccounting.Text = "Date of Enter Accounting";
            this.labelDateAccounting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerAccounting
            // 
            this.dateTimePickerAccounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerAccounting.Location = new System.Drawing.Point(158, 189);
            this.dateTimePickerAccounting.Name = "dateTimePickerAccounting";
            this.dateTimePickerAccounting.Size = new System.Drawing.Size(256, 22);
            this.dateTimePickerAccounting.TabIndex = 13;
            // 
            // labelOffice
            // 
            this.labelOffice.AutoSize = true;
            this.labelOffice.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelOffice.Location = new System.Drawing.Point(81, 217);
            this.labelOffice.Name = "labelOffice";
            this.labelOffice.Size = new System.Drawing.Size(71, 32);
            this.labelOffice.TabIndex = 14;
            this.labelOffice.Text = "Placement";
            this.labelOffice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxOffice
            // 
            this.comboBoxOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxOffice.FormattingEnabled = true;
            this.comboBoxOffice.Location = new System.Drawing.Point(158, 220);
            this.comboBoxOffice.Name = "comboBoxOffice";
            this.comboBoxOffice.Size = new System.Drawing.Size(256, 24);
            this.comboBoxOffice.TabIndex = 15;
            // 
            // buttonAddType
            // 
            this.buttonAddType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddType.Location = new System.Drawing.Point(420, 34);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(172, 25);
            this.buttonAddType.TabIndex = 16;
            this.buttonAddType.Text = "Add New Type";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddBrand.Location = new System.Drawing.Point(420, 65);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(172, 25);
            this.buttonAddBrand.TabIndex = 17;
            this.buttonAddBrand.Text = "Add New Brand";
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // buttonAddModel
            // 
            this.buttonAddModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddModel.Location = new System.Drawing.Point(420, 96);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.Size = new System.Drawing.Size(172, 25);
            this.buttonAddModel.TabIndex = 18;
            this.buttonAddModel.Text = "Add New Model";
            this.buttonAddModel.UseVisualStyleBackColor = true;
            this.buttonAddModel.Click += new System.EventHandler(this.buttonAddModel_Click);
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddCountry.Location = new System.Drawing.Point(420, 158);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(172, 25);
            this.buttonAddCountry.TabIndex = 19;
            this.buttonAddCountry.Text = "Add New Country";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // buttonAddOffice
            // 
            this.buttonAddOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddOffice.Location = new System.Drawing.Point(420, 220);
            this.buttonAddOffice.Name = "buttonAddOffice";
            this.buttonAddOffice.Size = new System.Drawing.Size(172, 26);
            this.buttonAddOffice.TabIndex = 20;
            this.buttonAddOffice.Text = "Add New Placement";
            this.buttonAddOffice.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(19, 293);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(152, 31);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(447, 293);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(152, 31);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormMainObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 336);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMainObject";
            this.Text = "MainObject";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelFactoryNumber;
        private System.Windows.Forms.TextBox textBoxFactoryNumber;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRelease;
        private System.Windows.Forms.Label labelReleaseCountry;
        private System.Windows.Forms.ComboBox comboBoxReleaseCountry;
        private System.Windows.Forms.Label labelDateAccounting;
        private System.Windows.Forms.DateTimePicker dateTimePickerAccounting;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.ComboBox comboBoxOffice;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.Button buttonAddModel;
        private System.Windows.Forms.Button buttonAddCountry;
        private System.Windows.Forms.Button buttonAddOffice;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}