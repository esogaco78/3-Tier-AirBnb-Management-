using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BEL;
using BAL;
using DAL;
using System.Data.SqlClient;




namespace ThreeTierStructure
{
    public partial class MDEmployee : MetroForm
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();
        public Dbconnection db = new Dbconnection();
        public SqlConnection con = new SqlConnection("Data Source=EYUPCAN\\SQLEXPRESS;Initial Catalog=EmpData;Integrated Security=True");

        string gender;
        DataTable dt = new DataTable();
        public MDEmployee()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           
            info.cname = tbCname.Text;
            info.date = (metroDateTime1.Value.ToShortDateString());
            info.date2 = (metroDateTime2.Value.ToShortDateString());
            info.tckimlik = tbTc.Text;
            info.evlistesi = cbEv.Text;
            if (rbMale.Checked == true)
                gender = "Erkek";
            if (rbFemale.Checked == true)
                gender = "Kadın";
            info.gender = gender;
            int row = opr.insertHotel(info);
       
        }

        private void MDEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDataDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.empDataDataSet.Customer);
            // TODO: This line of code loads data into the 'empDataDataSet1.Customer' table. You can move, or remove it, as needed.
            //  this.customerTableAdapter1.Fill(this.empDataDataSet1.Customer);
            // TODO: This line of code loads data into the 'empDataDataSet.Customer' table. You can move, or remove it, as needed.
            //   this.customerTableAdapter.Fill(this.empDataDataSet.Customer);

        }

        private void btGüncelle_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.Columns.Clear();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
        }
    }
}
