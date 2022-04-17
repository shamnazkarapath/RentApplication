
namespace RentApplication
{
    partial class Add_Rent_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker_Duedate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Startingdate = new System.Windows.Forms.DateTimePicker();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Rentrate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Phonenumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Additem = new System.Windows.Forms.Button();
            this.comboBox_Itemname = new System.Windows.Forms.ComboBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DueItem = new System.Windows.Forms.Button();
            this.BlnsNumItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.dgv_add_Rent = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Customername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Numberofitem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_SlNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_add_Rent)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Duedate
            // 
            this.dateTimePicker_Duedate.Location = new System.Drawing.Point(117, 222);
            this.dateTimePicker_Duedate.Name = "dateTimePicker_Duedate";
            this.dateTimePicker_Duedate.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker_Duedate.TabIndex = 6;
            this.dateTimePicker_Duedate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_Duedate_KeyDown);
            // 
            // dateTimePicker_Startingdate
            // 
            this.dateTimePicker_Startingdate.Location = new System.Drawing.Point(118, 182);
            this.dateTimePicker_Startingdate.Name = "dateTimePicker_Startingdate";
            this.dateTimePicker_Startingdate.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker_Startingdate.TabIndex = 5;
            this.dateTimePicker_Startingdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_Startingdate_KeyDown);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(119, 421);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(192, 34);
            this.txt_Address.TabIndex = 10;
            this.txt_Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Address_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 435);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Address";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(119, 343);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(189, 20);
            this.txt_Discount.TabIndex = 9;
            this.txt_Discount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Discount_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Discount %";
            // 
            // txt_Rentrate
            // 
            this.txt_Rentrate.Location = new System.Drawing.Point(119, 303);
            this.txt_Rentrate.Name = "txt_Rentrate";
            this.txt_Rentrate.Size = new System.Drawing.Size(189, 20);
            this.txt_Rentrate.TabIndex = 8;
            this.txt_Rentrate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Rentrate_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Rent Rate";
            // 
            // txt_Phonenumber
            // 
            this.txt_Phonenumber.Location = new System.Drawing.Point(118, 263);
            this.txt_Phonenumber.Name = "txt_Phonenumber";
            this.txt_Phonenumber.Size = new System.Drawing.Size(190, 20);
            this.txt_Phonenumber.TabIndex = 7;
            this.txt_Phonenumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Phonenumber_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Phone Number";
            // 
            // btn_Additem
            // 
            this.btn_Additem.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Additem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Additem.ForeColor = System.Drawing.Color.White;
            this.btn_Additem.Location = new System.Drawing.Point(112, 6);
            this.btn_Additem.Name = "btn_Additem";
            this.btn_Additem.Size = new System.Drawing.Size(195, 43);
            this.btn_Additem.TabIndex = 11;
            this.btn_Additem.Text = "Save Item";
            this.btn_Additem.UseVisualStyleBackColor = false;
            this.btn_Additem.Click += new System.EventHandler(this.btn_Additem_Click);
            // 
            // comboBox_Itemname
            // 
            this.comboBox_Itemname.FormattingEnabled = true;
            this.comboBox_Itemname.ItemHeight = 13;
            this.comboBox_Itemname.Location = new System.Drawing.Point(119, 58);
            this.comboBox_Itemname.Name = "comboBox_Itemname";
            this.comboBox_Itemname.Size = new System.Drawing.Size(189, 21);
            this.comboBox_Itemname.TabIndex = 2;
            this.comboBox_Itemname.SelectedIndexChanged += new System.EventHandler(this.comboBox_Itemname_SelectedIndexChanged);
            this.comboBox_Itemname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_Itemname_KeyDown);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.Crimson;
            this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.Location = new System.Drawing.Point(568, 8);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(164, 38);
            this.Btn_Clear.TabIndex = 16;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_DueItem);
            this.panel1.Controls.Add(this.BlnsNumItem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.dateTimePicker_Duedate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePicker_Startingdate);
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_Discount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_Rentrate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_Phonenumber);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox_Itemname);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Txt_Search);
            this.panel1.Controls.Add(this.dgv_add_Rent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Customername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Numberofitem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_SlNo);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 534);
            this.panel1.TabIndex = 4;
            // 
            // btn_DueItem
            // 
            this.btn_DueItem.BackColor = System.Drawing.Color.Navy;
            this.btn_DueItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DueItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DueItem.Location = new System.Drawing.Point(375, 9);
            this.btn_DueItem.Name = "btn_DueItem";
            this.btn_DueItem.Size = new System.Drawing.Size(174, 41);
            this.btn_DueItem.TabIndex = 50;
            this.btn_DueItem.Text = "Due Item";
            this.btn_DueItem.UseVisualStyleBackColor = false;
            this.btn_DueItem.Click += new System.EventHandler(this.btn_DueItem_Click);
            // 
            // BlnsNumItem
            // 
            this.BlnsNumItem.Location = new System.Drawing.Point(231, 98);
            this.BlnsNumItem.Name = "BlnsNumItem";
            this.BlnsNumItem.Size = new System.Drawing.Size(77, 20);
            this.BlnsNumItem.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(119, 380);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(189, 20);
            this.txtTotal.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Additem);
            this.panel2.Controls.Add(this.Btn_Clear);
            this.panel2.Controls.Add(this.Btn_Delete);
            this.panel2.Location = new System.Drawing.Point(3, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 59);
            this.panel2.TabIndex = 5;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Purple;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(355, 8);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(177, 38);
            this.Btn_Delete.TabIndex = 14;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(318, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Search ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Due Date";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(375, 64);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(386, 20);
            this.Txt_Search.TabIndex = 20;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // dgv_add_Rent
            // 
            this.dgv_add_Rent.AllowUserToAddRows = false;
            this.dgv_add_Rent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_add_Rent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_add_Rent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_add_Rent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_add_Rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_add_Rent.Location = new System.Drawing.Point(321, 112);
            this.dgv_add_Rent.Name = "dgv_add_Rent";
            this.dgv_add_Rent.ReadOnly = true;
            this.dgv_add_Rent.RowHeadersVisible = false;
            this.dgv_add_Rent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_add_Rent.Size = new System.Drawing.Size(773, 343);
            this.dgv_add_Rent.TabIndex = 35;
            this.dgv_add_Rent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_add_Rent_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Starting Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Name";
            // 
            // txt_Customername
            // 
            this.txt_Customername.Location = new System.Drawing.Point(116, 140);
            this.txt_Customername.Name = "txt_Customername";
            this.txt_Customername.Size = new System.Drawing.Size(192, 20);
            this.txt_Customername.TabIndex = 4;
            this.txt_Customername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Customername_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Item";
            // 
            // txt_Numberofitem
            // 
            this.txt_Numberofitem.Location = new System.Drawing.Point(119, 98);
            this.txt_Numberofitem.Name = "txt_Numberofitem";
            this.txt_Numberofitem.Size = new System.Drawing.Size(106, 20);
            this.txt_Numberofitem.TabIndex = 3;
            this.txt_Numberofitem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Numberofitem_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tool Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SlNo";
            // 
            // Txt_SlNo
            // 
            this.Txt_SlNo.Location = new System.Drawing.Point(119, 20);
            this.Txt_SlNo.Name = "Txt_SlNo";
            this.Txt_SlNo.Size = new System.Drawing.Size(189, 20);
            this.Txt_SlNo.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(461, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 31);
            this.label13.TabIndex = 5;
            this.label13.Text = "Rent Item Form";
            // 
            // Add_Rent_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1205, 749);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Rent_Frm";
            this.Text = "Rent Item Form";
            this.Load += new System.EventHandler(this.Add_Rent_Frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_add_Rent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Duedate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Startingdate;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Rentrate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Phonenumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Additem;
        private System.Windows.Forms.ComboBox comboBox_Itemname;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.DataGridView dgv_add_Rent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Customername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Numberofitem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_SlNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BlnsNumItem;
        private System.Windows.Forms.Button btn_DueItem;
        private System.Windows.Forms.Label label13;
    }
}