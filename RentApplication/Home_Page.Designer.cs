
namespace RentApplication
{
    partial class Home_Page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Listrentitems = new System.Windows.Forms.Button();
            this.btn_Rent = new System.Windows.Forms.Button();
            this.btn_Addtool = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Listrentitems);
            this.panel1.Controls.Add(this.btn_Rent);
            this.panel1.Controls.Add(this.btn_Addtool);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 651);
            this.panel1.TabIndex = 3;
            // 
            // btn_Listrentitems
            // 
            this.btn_Listrentitems.BackColor = System.Drawing.Color.Black;
            this.btn_Listrentitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listrentitems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Listrentitems.Location = new System.Drawing.Point(32, 245);
            this.btn_Listrentitems.Name = "btn_Listrentitems";
            this.btn_Listrentitems.Size = new System.Drawing.Size(138, 46);
            this.btn_Listrentitems.TabIndex = 5;
            this.btn_Listrentitems.Text = "LIST RENT ITEMS";
            this.btn_Listrentitems.UseVisualStyleBackColor = false;
            this.btn_Listrentitems.Click += new System.EventHandler(this.btn_Listrentitems_Click);
            // 
            // btn_Rent
            // 
            this.btn_Rent.BackColor = System.Drawing.Color.Black;
            this.btn_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Rent.Location = new System.Drawing.Point(32, 91);
            this.btn_Rent.Name = "btn_Rent";
            this.btn_Rent.Size = new System.Drawing.Size(138, 46);
            this.btn_Rent.TabIndex = 3;
            this.btn_Rent.Text = "ADD RENT";
            this.btn_Rent.UseVisualStyleBackColor = false;
            this.btn_Rent.Click += new System.EventHandler(this.btn_Rent_Click);
            // 
            // btn_Addtool
            // 
            this.btn_Addtool.BackColor = System.Drawing.Color.Black;
            this.btn_Addtool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addtool.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Addtool.Location = new System.Drawing.Point(32, 166);
            this.btn_Addtool.Name = "btn_Addtool";
            this.btn_Addtool.Size = new System.Drawing.Size(138, 46);
            this.btn_Addtool.TabIndex = 4;
            this.btn_Addtool.Text = "ADD TOOLS";
            this.btn_Addtool.UseVisualStyleBackColor = false;
            this.btn_Addtool.Click += new System.EventHandler(this.btn_Addtool_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 98);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home";
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(195, 98);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1175, 651);
            this.panel_main.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 96);
            this.panel3.TabIndex = 0;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Home_Page";
            this.Text = "Home_Page";
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Listrentitems;
        private System.Windows.Forms.Button btn_Rent;
        private System.Windows.Forms.Button btn_Addtool;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel3;
    }
}