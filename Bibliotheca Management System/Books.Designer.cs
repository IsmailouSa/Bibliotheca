namespace Bibliotheca_Management_System
{
    partial class Books
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
            this.dgBooks = new System.Windows.Forms.DataGridView();
            this.gbAddBook = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtAddBkQty = new System.Windows.Forms.TextBox();
            this.txtAddBkYr = new System.Windows.Forms.TextBox();
            this.txtAddBkAuthor = new System.Windows.Forms.TextBox();
            this.txtAddBkTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBkauthor = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.gbDeleteUpdateBk = new System.Windows.Forms.GroupBox();
            this.btnRemoveBk = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.txtEditBkQty = new System.Windows.Forms.TextBox();
            this.txtEditBkYr = new System.Windows.Forms.TextBox();
            this.txtEditBkAuthor = new System.Windows.Forms.TextBox();
            this.txtEditBkTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBkTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBkAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYrPubl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).BeginInit();
            this.gbAddBook.SuspendLayout();
            this.gbDeleteUpdateBk.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBooks
            // 
            this.dgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.clmBkTitle,
            this.clmBkAuthor,
            this.clmYrPubl,
            this.cmlQty,
            this.clmBookCat,
            this.clmBookStatus});
            this.dgBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgBooks.Location = new System.Drawing.Point(0, 210);
            this.dgBooks.Name = "dgBooks";
            this.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBooks.Size = new System.Drawing.Size(710, 181);
            this.dgBooks.TabIndex = 0;
            this.dgBooks.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBooks_CellMouseDoubleClick);
            // 
            // gbAddBook
            // 
            this.gbAddBook.Controls.Add(this.btnAddBook);
            this.gbAddBook.Controls.Add(this.txtAddBkQty);
            this.gbAddBook.Controls.Add(this.txtAddBkYr);
            this.gbAddBook.Controls.Add(this.txtAddBkAuthor);
            this.gbAddBook.Controls.Add(this.txtAddBkTitle);
            this.gbAddBook.Controls.Add(this.label3);
            this.gbAddBook.Controls.Add(this.label2);
            this.gbAddBook.Controls.Add(this.lblBkauthor);
            this.gbAddBook.Controls.Add(this.lblBookTitle);
            this.gbAddBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddBook.Location = new System.Drawing.Point(25, 12);
            this.gbAddBook.Name = "gbAddBook";
            this.gbAddBook.Size = new System.Drawing.Size(319, 192);
            this.gbAddBook.TabIndex = 1;
            this.gbAddBook.TabStop = false;
            this.gbAddBook.Text = "Add New Book";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(186, 147);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(85, 29);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtAddBkQty
            // 
            this.txtAddBkQty.Location = new System.Drawing.Point(119, 111);
            this.txtAddBkQty.Name = "txtAddBkQty";
            this.txtAddBkQty.Size = new System.Drawing.Size(72, 23);
            this.txtAddBkQty.TabIndex = 7;
            // 
            // txtAddBkYr
            // 
            this.txtAddBkYr.Location = new System.Drawing.Point(119, 82);
            this.txtAddBkYr.Name = "txtAddBkYr";
            this.txtAddBkYr.Size = new System.Drawing.Size(150, 23);
            this.txtAddBkYr.TabIndex = 6;
            // 
            // txtAddBkAuthor
            // 
            this.txtAddBkAuthor.Location = new System.Drawing.Point(119, 53);
            this.txtAddBkAuthor.Name = "txtAddBkAuthor";
            this.txtAddBkAuthor.Size = new System.Drawing.Size(150, 23);
            this.txtAddBkAuthor.TabIndex = 5;
            // 
            // txtAddBkTitle
            // 
            this.txtAddBkTitle.Location = new System.Drawing.Point(119, 21);
            this.txtAddBkTitle.Name = "txtAddBkTitle";
            this.txtAddBkTitle.Size = new System.Drawing.Size(150, 23);
            this.txtAddBkTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year of Publishing";
            // 
            // lblBkauthor
            // 
            this.lblBkauthor.AutoSize = true;
            this.lblBkauthor.Location = new System.Drawing.Point(14, 57);
            this.lblBkauthor.Name = "lblBkauthor";
            this.lblBkauthor.Size = new System.Drawing.Size(74, 15);
            this.lblBkauthor.TabIndex = 1;
            this.lblBkauthor.Text = "Book Author";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(11, 30);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(60, 15);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Book Title";
            // 
            // gbDeleteUpdateBk
            // 
            this.gbDeleteUpdateBk.Controls.Add(this.btnRemoveBk);
            this.gbDeleteUpdateBk.Controls.Add(this.btnUpdateBook);
            this.gbDeleteUpdateBk.Controls.Add(this.txtEditBkQty);
            this.gbDeleteUpdateBk.Controls.Add(this.txtEditBkYr);
            this.gbDeleteUpdateBk.Controls.Add(this.txtEditBkAuthor);
            this.gbDeleteUpdateBk.Controls.Add(this.txtEditBkTitle);
            this.gbDeleteUpdateBk.Controls.Add(this.label4);
            this.gbDeleteUpdateBk.Controls.Add(this.label5);
            this.gbDeleteUpdateBk.Controls.Add(this.label6);
            this.gbDeleteUpdateBk.Controls.Add(this.label7);
            this.gbDeleteUpdateBk.Enabled = false;
            this.gbDeleteUpdateBk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeleteUpdateBk.Location = new System.Drawing.Point(368, 12);
            this.gbDeleteUpdateBk.Name = "gbDeleteUpdateBk";
            this.gbDeleteUpdateBk.Size = new System.Drawing.Size(321, 192);
            this.gbDeleteUpdateBk.TabIndex = 2;
            this.gbDeleteUpdateBk.TabStop = false;
            this.gbDeleteUpdateBk.Text = "Delete/Update Book";
            // 
            // btnRemoveBk
            // 
            this.btnRemoveBk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBk.Location = new System.Drawing.Point(93, 147);
            this.btnRemoveBk.Name = "btnRemoveBk";
            this.btnRemoveBk.Size = new System.Drawing.Size(85, 29);
            this.btnRemoveBk.TabIndex = 18;
            this.btnRemoveBk.Text = "Delete";
            this.btnRemoveBk.UseVisualStyleBackColor = true;
            this.btnRemoveBk.Click += new System.EventHandler(this.btnRemoveBk_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.Location = new System.Drawing.Point(205, 147);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(85, 29);
            this.btnUpdateBook.TabIndex = 17;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // txtEditBkQty
            // 
            this.txtEditBkQty.Location = new System.Drawing.Point(138, 112);
            this.txtEditBkQty.Name = "txtEditBkQty";
            this.txtEditBkQty.Size = new System.Drawing.Size(72, 23);
            this.txtEditBkQty.TabIndex = 16;
            // 
            // txtEditBkYr
            // 
            this.txtEditBkYr.Location = new System.Drawing.Point(138, 83);
            this.txtEditBkYr.Name = "txtEditBkYr";
            this.txtEditBkYr.Size = new System.Drawing.Size(150, 23);
            this.txtEditBkYr.TabIndex = 15;
            // 
            // txtEditBkAuthor
            // 
            this.txtEditBkAuthor.Location = new System.Drawing.Point(138, 54);
            this.txtEditBkAuthor.Name = "txtEditBkAuthor";
            this.txtEditBkAuthor.Size = new System.Drawing.Size(150, 23);
            this.txtEditBkAuthor.TabIndex = 14;
            // 
            // txtEditBkTitle
            // 
            this.txtEditBkTitle.Location = new System.Drawing.Point(138, 22);
            this.txtEditBkTitle.Name = "txtEditBkTitle";
            this.txtEditBkTitle.Size = new System.Drawing.Size(150, 23);
            this.txtEditBkTitle.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Book Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Year of Publishing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Book Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Book Title";
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
            // cmlQty
            // 
            this.cmlQty.DataPropertyName = "Book_Qty";
            this.cmlQty.HeaderText = "Quantity";
            this.cmlQty.Name = "cmlQty";
            // 
            // clmBookCat
            // 
            this.clmBookCat.DataPropertyName = "BookCat_Id";
            this.clmBookCat.HeaderText = "Book Category";
            this.clmBookCat.Name = "clmBookCat";
            this.clmBookCat.Visible = false;
            // 
            // clmBookStatus
            // 
            this.clmBookStatus.DataPropertyName = "status";
            this.clmBookStatus.HeaderText = "Status";
            this.clmBookStatus.Name = "clmBookStatus";
            this.clmBookStatus.Visible = false;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 391);
            this.Controls.Add(this.gbDeleteUpdateBk);
            this.Controls.Add(this.gbAddBook);
            this.Controls.Add(this.dgBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).EndInit();
            this.gbAddBook.ResumeLayout(false);
            this.gbAddBook.PerformLayout();
            this.gbDeleteUpdateBk.ResumeLayout(false);
            this.gbDeleteUpdateBk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBooks;
        private System.Windows.Forms.GroupBox gbAddBook;
        private System.Windows.Forms.GroupBox gbDeleteUpdateBk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBkauthor;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtAddBkQty;
        private System.Windows.Forms.TextBox txtAddBkYr;
        private System.Windows.Forms.TextBox txtAddBkAuthor;
        private System.Windows.Forms.TextBox txtAddBkTitle;
        private System.Windows.Forms.Button btnRemoveBk;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.TextBox txtEditBkQty;
        private System.Windows.Forms.TextBox txtEditBkYr;
        private System.Windows.Forms.TextBox txtEditBkAuthor;
        private System.Windows.Forms.TextBox txtEditBkTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBkTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBkAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYrPubl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookStatus;
    }
}