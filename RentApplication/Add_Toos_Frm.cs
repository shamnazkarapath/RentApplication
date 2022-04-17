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
    public partial class Add_Toos_Frm : Form
    {
       SqlConnection con=new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Rental_db;Integrated Security=True");
        int index,pid=0;
        public Add_Toos_Frm()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_Itemname.Text != "" && txt_Numberofitem.Text != "" && Txt_SlNo.Text != "" && txt_Sellingrate.Text != "" && txt_Purchaserate1.Text != "")
                {
                    con.Open();

                    //dgv_add_Rent.Rows.Add(Txt_SlNo.Text, comboBox_Itemname.Text, txt_Numberofitem.Text, txt_Customername.Text, dateTimePicker_Startingdate.Text, dateTimePicker_Duedate.Text, txt_Phonenumber.Text, txt_Rentrate.Text, txt_Discount.Text, txt_Address.Text);
                    // int Rrate =int.Parse(txt_Sellingrate.Text),Prate=int.Parse(txt_Purchaserate1.Text);
                    SqlCommand cmd = new SqlCommand("Add_Tool_Ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", SqlDbType.Int).Value = pid;
                    cmd.Parameters.AddWithValue("@ToolName", SqlDbType.VarChar).Value = txt_Itemname.Text;
                    cmd.Parameters.AddWithValue("@NumberofItem", SqlDbType.Int).Value = int.Parse(txt_Numberofitem.Text);
                    cmd.Parameters.AddWithValue("@PurchaseRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_Purchaserate1.Text);
                    cmd.Parameters.AddWithValue("@RentingRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_Sellingrate.Text);
                    cmd.Parameters.AddWithValue("@BuyDate", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                    cmd.Parameters.AddWithValue("@SlNo", SqlDbType.VarChar).Value = Txt_SlNo.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    /* if (cmd.Connection.State == ConnectionState.Open)
                     {
                         cmd.Connection.Close();
                     }*/
                    if (pid == 0)
                    {
                        MessageBox.Show("Added New Tool Item");
                    }
                    else
                    {
                        MessageBox.Show("Updated Tool Item");
                    }

                    BtnClr();
                    DgView();

                }
                else
                {
                    MessageBox.Show("please fill in the blanks", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error in Add tool");
            }
            
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            BtnClr();
            DgView();
        }
        public void BtnClr()
        {
            txt_Itemname.Text = "";
            txt_Numberofitem.Text = "";
            Txt_SlNo.Text = "";
            txt_Sellingrate.Text = "";
            Txt_Search.Text = "";
            txt_Purchaserate1.Text = "";
            
        }

        private void Add_Toos_Frm_Load(object sender, EventArgs e)
        {
            DgView();


        }
        public void DgView()
        {
            try
            {

                con.Open();
                SqlCommand myCmd = new SqlCommand("Tools_Select", con);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_add_purchase_items.DataSource = dt;
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("error build from  Dgview Tools select");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to delete?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Tools_Delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", SqlDbType.Int).Value = pid;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                /* if (cmd.Connection.State == ConnectionState.Open)
                 {
                     cmd.Connection.Close();
                 }*/
                MessageBox.Show("Delete succefull!!");
                BtnClr();
                DgView();
            }
            catch(Exception)
            {
                MessageBox.Show("error from Delete operation");
            }

        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            /* BindingSource bs = new BindingSource();
             bs.DataSource = dgv_add_purchase_items.DataSource;
             bs.Filter = Colu + " like '%" + Txt_Search.Text + "%'";
             dataGridView1.DataSource = bs;*/
            try
            {
                (dgv_add_purchase_items.DataSource as DataTable).DefaultView.RowFilter = string.Format("ItemName like '{0}%'", Txt_Search.Text);

            }
            catch(Exception)
            {
                MessageBox.Show("error from search txtbox");
            }
            }

        private void dgv_add_purchase_items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                index = e.RowIndex;
                DataGridViewRow row = dgv_add_purchase_items.Rows[index];
                pid = int.Parse(row.Cells[0].Value.ToString());
                txt_Itemname.Text = row.Cells[1].Value.ToString();
                txt_Numberofitem.Text = row.Cells[2].Value.ToString();
                txt_Purchaserate1.Text = row.Cells[3].Value.ToString();
                txt_Sellingrate.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Text = row.Cells[5].Value.ToString();
                Txt_SlNo.Text = row.Cells[6].Value.ToString();

                btn_Save.Enabled = true;
                btn_Clear.Enabled = true;
                btn_Delete.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("error from dgv purchase");
            }
        }
    }
}
