
namespace RentApplication
{
    partial class DueItemList
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
            this.dgv_Duelist = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Duelist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Duelist
            // 
            this.dgv_Duelist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Duelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Duelist.Location = new System.Drawing.Point(12, 130);
            this.dgv_Duelist.Name = "dgv_Duelist";
            this.dgv_Duelist.Size = new System.Drawing.Size(983, 365);
            this.dgv_Duelist.TabIndex = 0;
            this.dgv_Duelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Duelist_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Search ";
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(83, 76);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(386, 20);
            this.Txt_Search.TabIndex = 24;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // DueItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 539);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.dgv_Duelist);
            this.Name = "DueItemList";
            this.Text = "DueItemList";
            this.Load += new System.EventHandler(this.DueItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Duelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Duelist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Search;
    }
}