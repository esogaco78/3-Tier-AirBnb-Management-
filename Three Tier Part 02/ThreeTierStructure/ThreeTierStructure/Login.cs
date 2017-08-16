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
using MetroFramework.Forms;

namespace ThreeTierStructure
{
    public partial class Login : MetroForm
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();
        DataTable dt = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            info.username = tbUname.Text;
            info.password = textBox2.Text;
            dt = opr.login(info);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                MDEmployee mde = new MDEmployee();
                mde.Show();
               
            }
            else
            {
                MessageBox.Show("invalid password or username");
                

            }
            
        }
    }
}
