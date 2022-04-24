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

namespace RentApplication
{
    public partial class Rent_List_Frm : Form
    {
        DBconnect connect = new DBconnect();
      //  SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Rental_db;Integrated Security=True");

        public Rent_List_Frm()
        {
            InitializeComponent();
        }

        private void Rent_List_Frm_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Rent_List_Frm_Load_1(object sender, EventArgs e)
        {
            connect.openConnect();
            SqlCommand myCmd = new SqlCommand("Rent_Select", connect.getconnection);
            myCmd.CommandType = CommandType.StoredProcedure;
                     SqlDataAdapter da = new SqlDataAdapter(myCmd);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.closeConnect();


            

        }

        private void btn_DueItem_Click(object sender, EventArgs e)
        {
            DueItemList dl = new DueItemList();
            dl.Show();
        }
    }
}
