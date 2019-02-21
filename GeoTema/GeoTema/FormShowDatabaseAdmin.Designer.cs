namespace GeoTema
{
    partial class FormShowDatabaseAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.geoTemaDataSet = new GeoTema.GeoTemaDataSet();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new GeoTema.GeoTemaDataSetTableAdapters.CountryTableAdapter();
            this.ranksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ranksTableAdapter = new GeoTema.GeoTemaDataSetTableAdapters.RanksTableAdapter();
            this.geoTemaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Admin_login = new System.Windows.Forms.Button();
            this.Super_login = new System.Windows.Forms.Button();
            this.Standed_login = new System.Windows.Forms.Button();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxPassw0rd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fKRanksID117F9D94BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDiagram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoTemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoTemaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRanksID117F9D94BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // geoTemaDataSet
            // 
            this.geoTemaDataSet.DataSetName = "GeoTemaDataSet";
            this.geoTemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.geoTemaDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // ranksBindingSource
            // 
            this.ranksBindingSource.DataMember = "Ranks";
            this.ranksBindingSource.DataSource = this.geoTemaDataSet;
            // 
            // ranksTableAdapter
            // 
            this.ranksTableAdapter.ClearBeforeFill = true;
            // 
            // geoTemaDataSetBindingSource
            // 
            this.geoTemaDataSetBindingSource.DataSource = this.geoTemaDataSet;
            this.geoTemaDataSetBindingSource.Position = 0;
            // 
            // Admin_login
            // 
            this.Admin_login.Enabled = false;
            this.Admin_login.Location = new System.Drawing.Point(647, 161);
            this.Admin_login.Name = "Admin_login";
            this.Admin_login.Size = new System.Drawing.Size(100, 23);
            this.Admin_login.TabIndex = 1;
            this.Admin_login.Text = "Admin Login";
            this.Admin_login.UseVisualStyleBackColor = true;
            this.Admin_login.Click += new System.EventHandler(this.Admin_login_Click);
            // 
            // Super_login
            // 
            this.Super_login.Enabled = false;
            this.Super_login.Location = new System.Drawing.Point(647, 190);
            this.Super_login.Name = "Super_login";
            this.Super_login.Size = new System.Drawing.Size(100, 23);
            this.Super_login.TabIndex = 2;
            this.Super_login.Text = "Super Login";
            this.Super_login.UseVisualStyleBackColor = true;
            this.Super_login.Click += new System.EventHandler(this.Super_login_Click);
            // 
            // Standed_login
            // 
            this.Standed_login.Enabled = false;
            this.Standed_login.Location = new System.Drawing.Point(647, 219);
            this.Standed_login.Name = "Standed_login";
            this.Standed_login.Size = new System.Drawing.Size(100, 23);
            this.Standed_login.TabIndex = 3;
            this.Standed_login.Text = "Standed Login";
            this.Standed_login.UseVisualStyleBackColor = true;
            this.Standed_login.Click += new System.EventHandler(this.Standed_login_Click);
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(647, 93);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserID.TabIndex = 4;
            this.textBoxUserID.TextChanged += new System.EventHandler(this.textBoxUserID_TextChanged);
            // 
            // textBoxPassw0rd
            // 
            this.textBoxPassw0rd.Location = new System.Drawing.Point(647, 119);
            this.textBoxPassw0rd.Name = "textBoxPassw0rd";
            this.textBoxPassw0rd.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassw0rd.TabIndex = 5;
            this.textBoxPassw0rd.TextChanged += new System.EventHandler(this.textBoxPassw0rd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // fKRanksID117F9D94BindingSource
            // 
            this.fKRanksID117F9D94BindingSource.DataMember = "FK__Ranks__ID__117F9D94";
            this.fKRanksID117F9D94BindingSource.DataSource = this.countryBindingSource;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Enabled = false;
            this.textBoxSearch.Location = new System.Drawing.Point(12, 278);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "For search data you need to gain acces";
            // 
            // buttonDiagram
            // 
            this.buttonDiagram.Enabled = false;
            this.buttonDiagram.Location = new System.Drawing.Point(23, 304);
            this.buttonDiagram.Name = "buttonDiagram";
            this.buttonDiagram.Size = new System.Drawing.Size(80, 35);
            this.buttonDiagram.TabIndex = 10;
            this.buttonDiagram.Text = "Open Diagram";
            this.buttonDiagram.UseVisualStyleBackColor = true;
            this.buttonDiagram.Click += new System.EventHandler(this.buttonDiagram_Click);
            // 
            // FormShowDatabaseAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDiagram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassw0rd);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.Standed_login);
            this.Controls.Add(this.Super_login);
            this.Controls.Add(this.Admin_login);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormShowDatabaseAdmin";
            this.Text = "FormShowDatabaseAdmin";
            this.Load += new System.EventHandler(this.FormShowDatabaseAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoTemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geoTemaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRanksID117F9D94BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GeoTemaDataSet geoTemaDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private GeoTemaDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource ranksBindingSource;
        private GeoTemaDataSetTableAdapters.RanksTableAdapter ranksTableAdapter;
        private System.Windows.Forms.BindingSource geoTemaDataSetBindingSource;
        private System.Windows.Forms.BindingSource fKRanksID117F9D94BindingSource;
        private System.Windows.Forms.Button Admin_login;
        private System.Windows.Forms.Button Super_login;
        private System.Windows.Forms.Button Standed_login;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxPassw0rd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDiagram;
    }
}