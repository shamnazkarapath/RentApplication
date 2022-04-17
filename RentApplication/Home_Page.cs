using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentApplication
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            openchildForm(new Add_Rent_Frm());
            //Add_Rent_Frm AR = new Add_Rent_Frm();
           // AR.Show();
        }

        private void btn_Addtool_Click(object sender, EventArgs e)
        {
            openchildForm(new Add_Toos_Frm());
            // Add_Toos_Frm AT = new Add_Toos_Frm();
            // AT.Show();
        }

        private void btn_Listrentitems_Click(object sender, EventArgs e)
        {
            openchildForm(new Rent_List_Frm());
            //  Rent_List_Frm rf = new Rent_List_Frm();
            // rf.Show();

        }

        private void Home_Page_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openchildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
