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
    public partial class DueItemList : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Rental_db;Integrated Security=True");
        string Duedate, Todaydate=DateTime.Now.ToString();
        public DueItemList()
        {
            InitializeComponent();
        }
        public void FtechDuedate()
        {
          
            con.Open();
            string query = "select DueDate from Rent_tb";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                Duedate = sdr[0].ToString();
            }
        }

        private void dgv_Duelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            (dgv_Duelist.DataSource as DataTable).DefaultView.RowFilter = string.Format("CustomerName like '%" + Txt_Search.Text + "%'");

        }

        private void DueItemList_Load(object sender, EventArgs e)
        {
            try
         {
             

                con.Open();
                SqlCommand myCmd = new SqlCommand("RentDueDate_Select", con);
                myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.AddWithValue("@Todaydate", SqlDbType.DateTime).Value = DateTime.Parse( Todaydate);
            myCmd.ExecuteNonQuery();
            // SqlDataAdapter da = new SqlDataAdapter("select * from Rent_tb where SlNo=BLD2020 ", con);
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Duelist.DataSource = dt;
                con.Close();
          }
            catch (Exception)
            {
               MessageBox.Show("error occured");
            }
        }
    }
}
