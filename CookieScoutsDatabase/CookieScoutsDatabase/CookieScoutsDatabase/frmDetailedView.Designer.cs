namespace CookieScoutsDatabase
{
    partial class frmDetailedView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zIPLabel;
            this.cookieScoutsDatabaseDataSet1 = new CookieScoutsDatabase.CookieScoutsDatabaseDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new CookieScoutsDatabase.CookieScoutsDatabaseDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new CookieScoutsDatabase.CookieScoutsDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zIPTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zIPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cookieScoutsDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(27, 88);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(27, 114);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(27, 140);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 7;
            streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(27, 166);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(27, 192);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 11;
            stateLabel.Text = "State:";
            // 
            // zIPLabel
            // 
            zIPLabel.AutoSize = true;
            zIPLabel.Location = new System.Drawing.Point(27, 218);
            zIPLabel.Name = "zIPLabel";
            zIPLabel.Size = new System.Drawing.Size(27, 13);
            zIPLabel.TabIndex = 13;
            zIPLabel.Text = "ZIP:";
            // 
            // cookieScoutsDatabaseDataSet1
            // 
            this.cookieScoutsDatabaseDataSet1.DataSetName = "CookieScoutsDatabaseDataSet1";
            this.cookieScoutsDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.cookieScoutsDatabaseDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.tblCustomersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CookieScoutsDatabase.CookieScoutsDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(94, 85);
            this.firstNameTextBox.MaxLength = 20;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(94, 111);
            this.lastNameTextBox.MaxLength = 20;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(94, 137);
            this.streetTextBox.MaxLength = 50;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(165, 20);
            this.streetTextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(94, 163);
            this.cityTextBox.MaxLength = 20;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(165, 20);
            this.cityTextBox.TabIndex = 10;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(94, 189);
            this.stateTextBox.MaxLength = 2;
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(165, 20);
            this.stateTextBox.TabIndex = 12;
            // 
            // zIPTextBox
            // 
            this.zIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "ZIP", true));
            this.zIPTextBox.Location = new System.Drawing.Point(94, 215);
            this.zIPTextBox.MaxLength = 5;
            this.zIPTextBox.Name = "zIPTextBox";
            this.zIPTextBox.Size = new System.Drawing.Size(165, 20);
            this.zIPTextBox.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zIPLabel);
            this.Controls.Add(this.zIPTextBox);
            this.Name = "frmDetailedView";
            this.Text = "Detailed View";
            this.Load += new System.EventHandler(this.frmDetailedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookieScoutsDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CookieScoutsDatabaseDataSet1 cookieScoutsDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private CookieScoutsDatabaseDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private CookieScoutsDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zIPTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}