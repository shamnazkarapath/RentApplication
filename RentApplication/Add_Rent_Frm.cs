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
    public partial class Add_Rent_Frm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Rental_db;Integrated Security=True");

        int tid, index,NumofItem,Avlbitem,BlnsItemLb,Rid=0,dfrns1,dfrns2,Ntid;
        string Todaydate = DateTime.Now.ToString();


        public Add_Rent_Frm()
        {
            InitializeComponent();
        }

        private void btn_Additem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Customername.Text != "" && txt_Discount.Text != "" && txt_Numberofitem.Text != "" && txt_Phonenumber.Text != "" && txt_Rentrate.Text != "" && Txt_SlNo.Text != "" && comboBox_Itemname.Text != "" && dateTimePicker_Startingdate.Value.Date<dateTimePicker_Duedate.Value.Date)
                {
                    AvailableItem();

                    // dgv_add_Rent.Rows.Add(Txt_SlNo.Text, comboBox_Itemname.Text, txt_Numberofitem.Text, txt_Customername.Text, dateTimePicker_Startingdate.Text, dateTimePicker_Duedate.Text, txt_Phonenumber.Text, txt_Rentrate.Text, txt_Discount.Text, txt_Address.Text, txtTotal.Text,tid,Avlbitem);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Add_Rent_Ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", SqlDbType.Int).Value = Rid;
                    cmd.Parameters.AddWithValue("@SlNo", SqlDbType.Int).Value = Txt_SlNo.Text;
                    cmd.Parameters.AddWithValue("@ToolName", SqlDbType.VarChar).Value = comboBox_Itemname.Text;
                    cmd.Parameters.AddWithValue("@NumberofItem", SqlDbType.Int).Value = int.Parse(txt_Numberofitem.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", SqlDbType.VarChar).Value = txt_Customername.Text;
                    cmd.Parameters.AddWithValue("@StartingDate", SqlDbType.DateTime).Value = dateTimePicker_Startingdate.Text;
                    cmd.Parameters.AddWithValue("@DueDate", SqlDbType.DateTime).Value = dateTimePicker_Duedate.Text;
                    cmd.Parameters.AddWithValue("@PhoneNumber", SqlDbType.VarChar).Value = txt_Phonenumber.Text;
                    cmd.Parameters.AddWithValue("@RentRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_Rentrate.Text);
                    cmd.Parameters.AddWithValue("@Discount", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_Discount.Text);
                    cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = txt_Address.Text;
                    cmd.Parameters.AddWithValue("@Total", SqlDbType.Decimal).Value = txtTotal.Text;
                    cmd.Parameters.AddWithValue("@TId", SqlDbType.Int).Value = tid;
                    cmd.Parameters.AddWithValue("@AvbItem", SqlDbType.Int).Value = Avlbitem;

                    cmd.ExecuteNonQuery();
                   /*SqlCommand myCmd = new SqlCommand("Rent_Select", con);
                    myCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(myCmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_add_Rent.DataSource = dt;*/
                    con.Close();
                DisplayRent();
                    BtnClr();
                }
                else
                {
                    MessageBox.Show("please fill in the blanks", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }


            /*dgv_add_Rent.Rows[0].Cells["SlNo"].Value = Txt_SlNo.Text;
        dgv_add_Rent.Rows[0].Cells["ToolName"].Value = comboBox_Itemname.Text;
        dgv_add_Rent.Rows[0].Cells["NumberOfItem"].Value = txt_Numberofitem.Text;
        dgv_add_Rent.Rows[0].Cells["CustomerName"].Value = txt_Customername.Text;
        dgv_add_Rent.Rows[0].Cells["StartingDate"].Value = dateTimePicker_Startingdate.Text;
        dgv_add_Rent.Rows[0].Cells["DueDate"].Value = dateTimePicker_Startingdate.Text;
        dgv_add_Rent.Rows[0].Cells["PhoneNumber"].Value = txt_Phonenumber.Text;
        dgv_add_Rent.Rows[0].Cells["RentRate"].Value = txt_Rentrate.Text;
        dgv_add_Rent.Rows[0].Cells["Discount"].Value = txt_Discount.Text;
        dgv_add_Rent.Rows[0].Cells["Address"].Value = txt_Address.Text;*/

        }
        public void BtnClr()
        {
            txt_Address.Text = "";
           // txt_Customername.Text = "";
           
            txt_Numberofitem.Text = "";
            txt_Phonenumber.Text = "";
            txt_Rentrate.Text = "";
            Txt_Search.Text = "";
            Txt_SlNo.Text = "";
            comboBox_Itemname.Text = "";
            dateTimePicker_Duedate.Text = "";
            dateTimePicker_Startingdate.Text = "";
            Txt_SlNo.Enabled = false;
            txtTotal.Enabled = false;
            txt_Discount.Text = "";
            txtTotal.Text = "";
            BlnsNumItem.Text = "";
            btn_Additem.Enabled = true;
            comboBox_Itemname.Focus();
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            BtnClr();
            txt_Customername.Text = "";
            Datafetchdrop();
            DisplayRent();
            Txt_SlNo.Enabled = false;

        }
        public void Datafetchdrop()
        {
            try
            {
                con.Open();
                string query = "select distinct(ItemName) from AddTools_tb ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBox_Itemname.Items.Add(sdr.GetValue(0).ToString());
                }
                sdr.Close();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
        }
        private void dgv_add_Rent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            string ttd,tid1;
            index = e.RowIndex;
            DataGridViewRow row = dgv_add_Rent.Rows[index];
            
            Txt_SlNo.Text = row.Cells[1].Value.ToString();
            comboBox_Itemname.Text = row.Cells[2].Value.ToString();
            txt_Numberofitem.Text = row.Cells[3].Value.ToString();
            txt_Customername.Text = row.Cells[4].Value.ToString();
            dateTimePicker_Startingdate.Text = row.Cells[5].Value.ToString();
            dateTimePicker_Duedate.Text = row.Cells[6].Value.ToString();
            txt_Phonenumber.Text = row.Cells[7].Value.ToString();
            txt_Rentrate.Text = row.Cells[8].Value.ToString();
            txt_Discount.Text = row.Cells[9].Value.ToString();
            txt_Address.Text = row.Cells[10].Value.ToString();
            txtTotal.Text= row.Cells[11].Value.ToString();
                tid1 = row.Cells[12].Value.ToString();
                Ntid = Int32.Parse(tid1.ToString());
                BlnsNumItem.Text = row.Cells[13].Value.ToString();
                BlnsItemLb = Int32.Parse(BlnsNumItem.Text);
            ttd = row.Cells[0].Value.ToString();
            Rid = Int32.Parse(ttd);
                 dfrns1 =Int32.Parse( txt_Numberofitem.Text);
            Btn_Clear.Enabled = true;
            Btn_Delete.Enabled = true;
            btn_Additem.Enabled = true;
            txtTotal.Enabled = false;
            }
            catch(Exception)
            {
              MessageBox.Show("error occured");
            }

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
           /* SqlCommand cmd = new SqlCommand("Add_Rent_Ins", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SlNo", SqlDbType.Int).Value = Txt_SlNo.Text;
            cmd.Parameters.AddWithValue("@ToolName", SqlDbType.VarChar).Value = comboBox_Itemname.Text;
            cmd.Parameters.AddWithValue("@NumberofItem", SqlDbType.Int).Value = int.Parse(txt_Numberofitem.Text);
            cmd.Parameters.AddWithValue("@CustomerName", SqlDbType.VarChar).Value = txt_Customername.Text;
            cmd.Parameters.AddWithValue("@StartingDate", SqlDbType.DateTime).Value = dateTimePicker_Startingdate.Text;
            cmd.Parameters.AddWithValue("@DueDate", SqlDbType.DateTime).Value = dateTimePicker_Duedate.Text;
            cmd.Parameters.AddWithValue("@PhoneNumber", SqlDbType.VarChar).Value = txt_Phonenumber.Text;
            cmd.Parameters.AddWithValue("@RentRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_Rentrate.Text);
            cmd.Parameters.AddWithValue("@Discount", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_Discount.Text);
            cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = txt_Address.Text;
            cmd.Parameters.AddWithValue("@Total", SqlDbType.Decimal).Value = txtTotal.Text;
            cmd.Parameters.AddWithValue("@TId", SqlDbType.Int).Value = tid;
            cmd.Parameters.AddWithValue("@AvbItem", SqlDbType.Int).Value = Avlbitem;

            cmd.ExecuteNonQuery();
            SqlCommand myCmd = new SqlCommand("Rent_Select", con);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_add_Rent.DataSource = dt;
            con.Close();
            BtnClr();*/



            //try
            // {
            //
            /*
                 DataGridViewRow newdata = dgv_add_Rent.Rows[index];
                 newdata.Cells[0].Value = Txt_SlNo.Text;
                 newdata.Cells[1].Value = comboBox_Itemname.Text;
                 newdata.Cells[2].Value = txt_Numberofitem.Text;
                 newdata.Cells[3].Value = txt_Customername.Text;
                 newdata.Cells[4].Value = dateTimePicker_Startingdate.Text;
                 newdata.Cells[5].Value = dateTimePicker_Duedate.Text;
                 newdata.Cells[6].Value = txt_Phonenumber.Text;
                 newdata.Cells[7].Value = txt_Rentrate.Text;
                 newdata.Cells[8].Value = txt_Discount.Text;
                 newdata.Cells[9].Value = txt_Address.Text;
                 BtnClr();

                 Btn_Clear.Enabled = true;
                 Btn_Delete.Enabled = true;
                 btn_Additem.Enabled = true;
            */
            /*
             *  foreach (DataGridViewRow row in dgv_add_Rent.Rows)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Add_Rent_Ins", con);
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Flag", SqlDbType.Int).Value = N_Id;
                if (row.IsNewRow) continue;
                cmd.Parameters.AddWithValue("@SlNo", row.Cells[0].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ToolName", row.Cells[1].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NumberofItem", row.Cells[2].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CustomerName", row.Cells[3].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@StartingDate", row.Cells[4].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DueDate", row.Cells[5].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PhoneNumber", row.Cells[6].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RentRate", row.Cells[7].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Discount", row.Cells[8].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", row.Cells[9].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Total", row.Cells[10].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TId", row.Cells[11].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AvbItem", row.Cells[12].Value ?? DBNull.Value);

                cmd.ExecuteNonQuery();
                con.Close();
            */
            //}
            //catch(Exception)
            //{
            //  MessageBox.Show("error occured");
            //}
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
          try
            {
                int blnsItem = Int32.Parse(BlnsNumItem.Text);
                Avlbitem = blnsItem + dfrns1;
                if (MessageBox.Show("Are you sure want to delete?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    /* index = dgv_add_Rent.CurrentCell.RowIndex;
                     dgv_add_Rent.Rows.RemoveAt(index);*/
                    con.Open();


                    SqlCommand cmd = new SqlCommand("Rent_Delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", SqlDbType.Int).Value = Rid;
                    cmd.Parameters.AddWithValue("@avlbitem", SqlDbType.Int).Value = Avlbitem;
                    cmd.Parameters.AddWithValue("@Ntid", SqlDbType.Int).Value = Ntid;
                    cmd.ExecuteNonQuery();
                    
                    con.Close();
                    DisplayRent();
                }
            
            /* if (cmd.Connection.State == ConnectionState.Open)
             {
                 cmd.Connection.Close();
             }*/
            MessageBox.Show("Delete succefull!!");
                BtnClr();
            }
            catch(Exception)
            {
               MessageBox.Show("error occured");
            }
           

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            { 
            foreach (DataGridViewRow row in dgv_add_Rent.Rows)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Add_Rent_Ins", con);
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@Flag", SqlDbType.Int).Value = N_Id;
                if (row.IsNewRow) continue;
                cmd.Parameters.AddWithValue("@SlNo", row.Cells[0].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ToolName", row.Cells[1].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@NumberofItem", row.Cells[2].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CustomerName", row.Cells[3].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@StartingDate", row.Cells[4].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DueDate", row.Cells[5].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PhoneNumber", row.Cells[6].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RentRate", row.Cells[7].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Discount", row.Cells[8].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", row.Cells[9].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Total", row.Cells[10].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TId", row.Cells[11].Value ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AvbItem", row.Cells[12].Value ?? DBNull.Value);

                cmd.ExecuteNonQuery();
                con.Close();

            }
            MessageBox.Show("Added New Rent Items");
            BtnClr();

            }
            catch(Exception)
            {
                MessageBox.Show("error occured");

            }

        }
        public void Total()
        { try
            {
                DateTime d1 = dateTimePicker_Startingdate.Value.Date;
                DateTime d2 = dateTimePicker_Duedate.Value.Date;
                int dateiff = ((TimeSpan)(d2 - d1)).Days;
                decimal percent, Rrate, total, Disc;
                Rrate = Convert.ToDecimal(txt_Rentrate.Text);
                NumofItem = Int32.Parse(txt_Numberofitem.Text);
                Disc = Convert.ToDecimal(txt_Discount.Text);

                percent = ((Rrate * NumofItem) * Disc) / 100;
                total = ((Rrate * NumofItem) - percent)*dateiff;
                txtTotal.Text = total.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("error occured");
            }
            }
       public void DisplayRent()
        {
            try
            {


                con.Open();
                SqlCommand myCmd = new SqlCommand("Rent_Select", con);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_add_Rent.DataSource = dt;
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("error occured");
            }
        }
        private void Add_Rent_Frm_Load(object sender, EventArgs e)
        {
            Datafetchdrop();
            DisplayRent();
            Txt_SlNo.Enabled = false;
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            (dgv_add_Rent.DataSource as DataTable).DefaultView.RowFilter = string.Format("CustomerName like '%" + Txt_Search.Text+ "%'");
           
        }


      
        private void txt_Customername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
               dateTimePicker_Startingdate.Focus();

            }
        }

        private void dateTimePicker_Startingdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                dateTimePicker_Duedate.Focus();

            }
        }

        private void dateTimePicker_Duedate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(dateTimePicker_Startingdate.Value.Date<dateTimePicker_Duedate.Value.Date)
                {
                    txt_Phonenumber.Focus();
                }
               else
                {
                    MessageBox.Show("please change the due date greater than starting date");
                }

            }
        }

        private void btn_DueItem_Click(object sender, EventArgs e)
        {

            try
            {


                con.Open();
                SqlCommand myCmd = new SqlCommand("RentDueDate_Select", con);
                myCmd.CommandType = CommandType.StoredProcedure;
                myCmd.Parameters.AddWithValue("@Todaydate", SqlDbType.DateTime).Value = DateTime.Parse(Todaydate);
                myCmd.ExecuteNonQuery();
                // SqlDataAdapter da = new SqlDataAdapter("select * from Rent_tb where SlNo=BLD2020 ", con);
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_add_Rent.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("error occured");
            }
        }

        private void txt_Phonenumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

               txt_Rentrate.Focus();

            }
        }

        private void txt_Rentrate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                /*if (txt_Discount.Text == "")
                {
                    MessageBox.Show("Rent Item Added Succesfully !");

                }
                else
                {
                    Total();
                }*/
            txt_Discount.Focus();

            }
        }

        private void comboBox_Itemname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txt_Numberofitem.Focus();

            }
        }

        private void txt_Address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btn_Additem.Focus();

            }
        }

        private void txt_Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Total();
                AvailableItem();
                txt_Address.Focus();

            }
        }

        private void txt_Numberofitem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                 dfrns2 =Int32.Parse( txt_Numberofitem.Text);
                    BlnsItemLb = Int32.Parse(BlnsNumItem.Text);
                    NumofItem = Int32.Parse(txt_Numberofitem.Text);
                    if (BlnsItemLb >= NumofItem)
                    {
                        AvailableItem();
                        txt_Customername.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Entered Item is not Available", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        txt_Numberofitem.Focus();
                    }


                }
            }
            catch(Exception)
            {
                MessageBox.Show("error occured");
            }
        }

        public void AvailableItem()
        {
            try
            { 
             if(dfrns1<=dfrns2)
                {
                    int blnsItem = Int32.Parse(BlnsNumItem.Text);
                    Avlbitem = blnsItem -(NumofItem-dfrns1);
                }
             else
                {
                    int blnsItem = Int32.Parse(BlnsNumItem.Text);
                    Avlbitem = blnsItem + (dfrns1- NumofItem);
                }
           
            }
            catch(Exception)
            {
                MessageBox.Show("error occured");
            }


        }

        private void comboBox_Itemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string query = "select NumberofItem,RentingRate,SlNo,TId from AddTools_tb where ItemName='" + comboBox_Itemname.Text + "'"; SqlCommand cmd = new SqlCommand();
                SqlCommand cmd1 = new SqlCommand(query, con);
                SqlDataReader sdr = cmd1.ExecuteReader();
                while (sdr.Read())
                {
                    BlnsNumItem.Text = sdr[0].ToString();
                    txt_Rentrate.Text = sdr[1].ToString();
                    Txt_SlNo.Text = sdr[2].ToString();
                    tid = Int32.Parse(sdr[3].ToString());
                }

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("error occured");
            }

        }

    }
}
