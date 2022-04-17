
namespace RentApplication
{
    partial class Rent_List_Frm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_DueItem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_DueItem
            // 
            this.btn_DueItem.BackColor = System.Drawing.Color.Navy;
            this.btn_DueItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DueItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DueItem.Location = new System.Drawing.Point(12, 104);
            this.btn_DueItem.Name = "btn_DueItem";
            this.btn_DueItem.Size = new System.Drawing.Size(174, 41);
            this.btn_DueItem.TabIndex = 1;
            this.btn_DueItem.Text = "Due Item";
            this.btn_DueItem.UseVisualStyleBackColor = false;
            this.btn_DueItem.Click += new System.EventHandler(this.btn_DueItem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(449, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 31);
            this.label13.TabIndex = 45;
            this.label13.Text = "List Rent Items";
            // 
            // Rent_List_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1012, 541);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_DueItem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rent_List_Frm";
            this.Text = "Rent_List_Frm";
            this.Load += new System.EventHandler(this.Rent_List_Frm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_DueItem;
        private System.Windows.Forms.Label label13;
    }
}