using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace DoAn_2
{
    public partial class Form1 : Form
    {
        public static string usernv = "";
        SqlConnection connect = ClassKetnoi.connect;
        
        public Form1()
        {   
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            usernv = txtuser.Text;
            string querynv = "Select * From nhanvien where usernv ='" +txtuser.Text+"' and passnv='" +txtpass.Text+"' ";
            SqlDataAdapter sqldata = new SqlDataAdapter(querynv, connect);
            DataTable datatb1 = new DataTable();
            sqldata.Fill(datatb1);
            if(datatb1.Rows.Count==1)
            {
                MainControl mainmenu = new MainControl(datatb1.Rows[0][0].ToString(), datatb1.Rows[0][1].ToString(), datatb1.Rows[0][2].ToString());
                this.Hide();
                mainmenu.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
               
            

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
