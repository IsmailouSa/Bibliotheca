namespace Bibliotheca_Management_System
{
    partial class search
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
            this.dgMember = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBkTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBkAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYrPubl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMember
            // 
            this.dgMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.clmBkTitle,
            this.clmBkAuthor,
            this.clmYrPubl,
            this.clmBookStatus,
            this.cmlQty,
            this.clmBookCat});
            this.dgMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMember.Location = new System.Drawing.Point(0, 0);
            this.dgMember.Name = "dgMember";
            this.dgMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMember.Size = new System.Drawing.Size(467, 326);
            this.dgMember.TabIndex = 4;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "Book_Id";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.Visible = false;
            // 
            // clmBkTitle
            // 
            this.clmBkTitle.DataPropertyName = "Book_Title";
            this.clmBkTitle.HeaderText = "Book Title";
            this.clmBkTitle.Name = "clmBkTitle";
            // 
            // clmBkAuthor
            // 
            this.clmBkAuthor.DataPropertyName = "Book_Author";
            this.clmBkAuthor.HeaderText = "Book Author";
            this.clmBkAuthor.Name = "clmBkAuthor";
            // 
            // clmYrPubl
            // 
            this.clmYrPubl.DataPropertyName = "yr_of_publ";
            this.clmYrPubl.HeaderText = "Year of Publishing";
            this.clmYrPubl.Name = "clmYrPubl";
            // 
            // clmBookStatus
            // 
            this.clmBookStatus.DataPropertyName = "status";
            this.clmBookStatus.HeaderText = "Status";
            this.clmBookStatus.Name = "clmBookStatus";
            // 
            // cmlQty
            // 
            this.cmlQty.DataPropertyName = "Book_Qty";
            this.cmlQty.HeaderText = "Quantity";
            this.cmlQty.Name = "cmlQty";
            this.cmlQty.Visible = false;
            // 
            // clmBookCat
            // 
            this.clmBookCat.DataPropertyName = "BookCat_Id";
            this.clmBookCat.HeaderText = "Book Category";
            this.clmBookCat.Name = "clmBookCat";
            this.clmBookCat.Visible = false;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 326);
            this.Controls.Add(this.dgMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "search";
            this.Text = "search";
            ((System.ComponentModel.ISupportInitialize)(this.dgMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBkTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBkAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYrPubl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookCat;
    }
}