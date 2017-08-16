namespace ThreeTierStructure
{
    partial class MDEmployee
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
            this.btAdd = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tbTc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbEv = new MetroFramework.Controls.MetroComboBox();
            this.rbFemale = new MetroFramework.Controls.MetroRadioButton();
            this.rbMale = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbCname = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btGüncelle = new MetroFramework.Controls.MetroButton();
            this.empDataDataSet = new ThreeTierStructure.EmpDataDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new ThreeTierStructure.EmpDataDataSetTableAdapters.CustomerTableAdapter();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(651, 239);
            this.btAdd.Name = "btAdd";
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Ekle";
            this.btAdd.UseSelectable = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 53);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(764, 307);
            this.metroTabControl1.TabIndex = 7;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btAdd);
            this.metroTabPage1.Controls.Add(this.tbTc);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.cbEv);
            this.metroTabPage1.Controls.Add(this.rbFemale);
            this.metroTabPage1.Controls.Add(this.rbMale);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroDateTime2);
            this.metroTabPage1.Controls.Add(this.metroDateTime1);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.tbCname);
            this.metroTabPage1.Enabled = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(756, 265);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Müşteri Bilgileri";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Visible = false;
            // 
            // tbTc
            // 
            // 
            // 
            // 
            this.tbTc.CustomButton.Image = null;
            this.tbTc.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.tbTc.CustomButton.Name = "";
            this.tbTc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTc.CustomButton.TabIndex = 1;
            this.tbTc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTc.CustomButton.UseSelectable = true;
            this.tbTc.CustomButton.Visible = false;
            this.tbTc.Lines = new string[0];
            this.tbTc.Location = new System.Drawing.Point(483, 21);
            this.tbTc.MaxLength = 32767;
            this.tbTc.Name = "tbTc";
            this.tbTc.PasswordChar = '\0';
            this.tbTc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTc.SelectedText = "";
            this.tbTc.SelectionLength = 0;
            this.tbTc.SelectionStart = 0;
            this.tbTc.ShortcutsEnabled = true;
            this.tbTc.Size = new System.Drawing.Size(140, 23);
            this.tbTc.TabIndex = 18;
            this.tbTc.UseSelectable = true;
            this.tbTc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(380, 25);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(84, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "TC Kimlik No";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 167);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Ev Listesi";
            // 
            // cbEv
            // 
            this.cbEv.FormattingEnabled = true;
            this.cbEv.ItemHeight = 23;
            this.cbEv.Items.AddRange(new object[] {
            "Siren 1 ",
            "Siren 2 ",
            "Öztuğ"});
            this.cbEv.Location = new System.Drawing.Point(121, 157);
            this.cbEv.Name = "cbEv";
            this.cbEv.Size = new System.Drawing.Size(121, 29);
            this.cbEv.TabIndex = 15;
            this.cbEv.UseSelectable = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(201, 123);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(53, 15);
            this.rbFemale.TabIndex = 14;
            this.rbFemale.Text = "Kadın";
            this.rbFemale.UseSelectable = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(121, 123);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 15);
            this.rbMale.TabIndex = 13;
            this.rbMale.Text = "Erkek";
            this.rbMale.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Cinsiyet";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(348, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Çıkış Tarihi";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Giriş Tarihi";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(423, 63);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 9;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(121, 63);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Adı Soyadı";
            // 
            // tbCname
            // 
            // 
            // 
            // 
            this.tbCname.CustomButton.Image = null;
            this.tbCname.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbCname.CustomButton.Name = "";
            this.tbCname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCname.CustomButton.TabIndex = 1;
            this.tbCname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCname.CustomButton.UseSelectable = true;
            this.tbCname.CustomButton.Visible = false;
            this.tbCname.Lines = new string[0];
            this.tbCname.Location = new System.Drawing.Point(121, 22);
            this.tbCname.MaxLength = 32767;
            this.tbCname.Name = "tbCname";
            this.tbCname.PasswordChar = '\0';
            this.tbCname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCname.SelectedText = "";
            this.tbCname.SelectionLength = 0;
            this.tbCname.SelectionStart = 0;
            this.tbCname.ShortcutsEnabled = true;
            this.tbCname.Size = new System.Drawing.Size(200, 23);
            this.tbCname.TabIndex = 6;
            this.tbCname.UseSelectable = true;
            this.tbCname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dataGridView1);
            this.metroTabPage2.Enabled = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(756, 265);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Rezervasyonlar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Visible = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 266);
            this.dataGridView1.TabIndex = 2;
            // 
            // btGüncelle
            // 
            this.btGüncelle.Location = new System.Drawing.Point(676, 376);
            this.btGüncelle.Name = "btGüncelle";
            this.btGüncelle.TabIndex = 3;
            this.btGüncelle.Text = "Güncelle";
            this.btGüncelle.UseSelectable = true;
            this.btGüncelle.Click += new System.EventHandler(this.btGüncelle_Click);
            // 
            // empDataDataSet
            // 
            this.empDataDataSet.DataSetName = "EmpDataDataSet";
            this.empDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.empDataDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // MDEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 432);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.btGüncelle);
            this.Name = "MDEmployee";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "MDEmployee";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.MDEmployee_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btAdd;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox tbTc;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbEv;
        private MetroFramework.Controls.MetroRadioButton rbFemale;
        private MetroFramework.Controls.MetroRadioButton rbMale;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbCname;
  //      private EmpDataDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private MetroFramework.Controls.MetroButton btGüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmpDataDataSet empDataDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private EmpDataDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}