using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RentApplication
{
    class RentClass
    {
        DBconnect connect = new DBconnect();
        public bool InsertTools(int pid,string ToolName,int Numberofitem,decimal Purchaserate,decimal Rentingrate,DateTime Buydate,string SlNo)
        {
            SqlCommand cmd = new SqlCommand("Add_Tool_Ins", connect.getconnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", SqlDbType.Int).Value = pid;
            cmd.Parameters.AddWithValue("@ToolName", SqlDbType.VarChar).Value = ToolName;
            cmd.Parameters.AddWithValue("@NumberofItem", SqlDbType.Int).Value = Numberofitem;  // int.Parse(txt_Numberofitem.Text);
            cmd.Parameters.AddWithValue("@PurchaseRate", SqlDbType.Decimal).Value = Purchaserate; //Convert.ToDecimal(txt_Purchaserate1.Text);
            cmd.Parameters.AddWithValue("@RentingRate", SqlDbType.Decimal).Value = Rentingrate;//Convert.ToDecimal(txt_Sellingrate.Text);
            cmd.Parameters.AddWithValue("@BuyDate", SqlDbType.DateTime).Value = Buydate;//dateTimePicker1.Text;
            cmd.Parameters.AddWithValue("@SlNo", SqlDbType.VarChar).Value = SlNo; //Txt_SlNo.Text;

            connect.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        public bool InsertRentItem(int Rid,string SlNo,string ToolName,int Numberofitem,string CustomerName,DateTime StartingDate,DateTime DueDate,string PhoneNumber,decimal Rentrate,decimal Disc,string Address,decimal total,int Tid,int Avlbitem)
        { 
        SqlCommand cmd = new SqlCommand("Add_Rent_Ins", connect.getconnection);
        cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@flag", SqlDbType.Int).Value = Rid;
                    cmd.Parameters.AddWithValue("@SlNo", SqlDbType.VarChar).Value = SlNo;
                    cmd.Parameters.AddWithValue("@ToolName", SqlDbType.VarChar).Value = ToolName;
            cmd.Parameters.AddWithValue("@NumberofItem", SqlDbType.Int).Value = Numberofitem;
            cmd.Parameters.AddWithValue("@CustomerName", SqlDbType.VarChar).Value = CustomerName; 
            cmd.Parameters.AddWithValue("@StartingDate", SqlDbType.DateTime).Value = StartingDate;
            cmd.Parameters.AddWithValue("@DueDate", SqlDbType.DateTime).Value = DueDate; ; 
            cmd.Parameters.AddWithValue("@PhoneNumber", SqlDbType.VarChar).Value = PhoneNumber; 
            cmd.Parameters.AddWithValue("@RentRate", SqlDbType.Decimal).Value = Rentrate;
            cmd.Parameters.AddWithValue("@Discount", SqlDbType.Decimal).Value = Disc; 
            cmd.Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value =Address; 
            cmd.Parameters.AddWithValue("@Total", SqlDbType.Decimal).Value = total; 
                    cmd.Parameters.AddWithValue("@TId", SqlDbType.Int).Value = Tid;
                    cmd.Parameters.AddWithValue("@AvbItem", SqlDbType.Int).Value = Avlbitem;
                    connect.openConnect();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        connect.closeConnect();
                return true;

                    }
                    else
                    {
                        connect.closeConnect();
                return false;
                    }
        }
    }
}
