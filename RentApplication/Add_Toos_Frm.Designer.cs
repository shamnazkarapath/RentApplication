
namespace RentApplication
{
    partial class Add_Toos_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_Purchaserate1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.dgv_add_purchase_items = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_Sellingrate = new System.Windows.Forms.TextBox();
            this.txt_Itemname = new System.Windows.Forms.TextBox();
            this.Txt_SlNo = new System.Windows.Forms.TextBox();
            this.txt_Numberofitem = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_add_purchase_items)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Purchaserate1
            // 
            this.txt_Purchaserate1.Location = new System.Drawing.Point(190, 128);
            this.txt_Purchaserate1.Name = "txt_Purchaserate1";
            this.txt_Purchaserate1.Size = new System.Drawing.Size(100, 20);
            this.txt_Purchaserate1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Search ";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(486, 68);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(319, 20);
            this.Txt_Search.TabIndex = 41;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // dgv_add_purchase_items
            // 
            this.dgv_add_purchase_items.AllowUserToAddRows = false;
            this.dgv_add_purchase_items.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_add_purchase_items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_add_purchase_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_add_purchase_items.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_add_purchase_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_add_purchase_items.Location = new System.Drawing.Point(430, 112);
            this.dgv_add_purchase_items.Name = "dgv_add_purchase_items";
            this.dgv_add_purchase_items.ReadOnly = true;
            this.dgv_add_purchase_items.RowHeadersVisible = false;
            this.dgv_add_purchase_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_add_purchase_items.Size = new System.Drawing.Size(622, 340);
            this.dgv_add_purchase_items.TabIndex = 43;
            this.dgv_add_purchase_items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_add_purchase_items_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "SlNo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Buying date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selling Rent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Purchase Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Item";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(284, 9);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 40);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_Sellingrate
            // 
            this.txt_Sellingrate.Location = new System.Drawing.Point(190, 172);
            this.txt_Sellingrate.Name = "txt_Sellingrate";
            this.txt_Sellingrate.Size = new System.Drawing.Size(100, 20);
            this.txt_Sellingrate.TabIndex = 4;
            // 
            // txt_Itemname
            // 
            this.txt_Itemname.Location = new System.Drawing.Point(189, 40);
            this.txt_Itemname.Name = "txt_Itemname";
            this.txt_Itemname.Size = new System.Drawing.Size(100, 20);
            this.txt_Itemname.TabIndex = 1;
            // 
            // Txt_SlNo
            // 
            this.Txt_SlNo.Location = new System.Drawing.Point(190, 264);
            this.Txt_SlNo.Name = "Txt_SlNo";
            this.Txt_SlNo.Size = new System.Drawing.Size(100, 20);
            this.Txt_SlNo.TabIndex = 6;
            // 
            // txt_Numberofitem
            // 
            this.txt_Numberofitem.Location = new System.Drawing.Point(190, 85);
            this.txt_Numberofitem.Name = "txt_Numberofitem";
            this.txt_Numberofitem.Size = new System.Drawing.Size(100, 20);
            this.txt_Numberofitem.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(20, 8);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(114, 40);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(161, 8);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(93, 40);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Location = new System.Drawing.Point(13, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 59);
            this.panel2.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Purchaserate1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Sellingrate);
            this.panel1.Controls.Add(this.txt_Itemname);
            this.panel1.Controls.Add(this.Txt_SlNo);
            this.panel1.Controls.Add(this.txt_Numberofitem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 319);
            this.panel1.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(480, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 31);
            this.label13.TabIndex = 44;
            this.label13.Text = "Add Tool";
            // 
            // Add_Toos_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1215, 724);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.dgv_add_purchase_items);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Toos_Frm";
            this.Text = "Add_Toos_Frm";
            this.Load += new System.EventHandler(this.Add_Toos_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_add_purchase_items)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Purchaserate1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.DataGridView dgv_add_purchase_items;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_Sellingrate;
        private System.Windows.Forms.TextBox txt_Itemname;
        private System.Windows.Forms.TextBox Txt_SlNo;
        private System.Windows.Forms.TextBox txt_Numberofitem;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
    }
}