namespace Bibliotheca_Management_System
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBkTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBkAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYrPubl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dgBookTaken = new System.Windows.Forms.DataGridView();
            this.clmIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookTaken)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 92);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Book\'s Title or Author";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(325, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(672, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 46);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.InitialImage")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(236, 93);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Controls.Add(this.dgBookTaken);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.username);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 368);
            this.panel3.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(92, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(50, 21);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "name";
            // 
            // dgBookTaken
            // 
            this.dgBookTaken.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBookTaken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookTaken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIn,
            this.clmIssue,
            this.clmBookname,
            this.clmDue});
            this.dgBookTaken.Location = new System.Drawing.Point(0, 69);
            this.dgBookTaken.Name = "dgBookTaken";
            this.dgBookTaken.Size = new System.Drawing.Size(233, 130);
            this.dgBookTaken.TabIndex = 3;
            // 
            // clmIn
            // 
            this.clmIn.DataPropertyName = "IncomingID";
            this.clmIn.HeaderText = "Incoming";
            this.clmIn.Name = "clmIn";
            this.clmIn.Visible = false;
            // 
            // clmIssue
            // 
            this.clmIssue.DataPropertyName = "issue_id";
            this.clmIssue.HeaderText = "Issue";
            this.clmIssue.Name = "clmIssue";
            this.clmIssue.Visible = false;
            // 
            // clmBookname
            // 
            this.clmBookname.DataPropertyName = "book_name";
            this.clmBookname.HeaderText = "Book Title";
            this.clmBookname.Name = "clmBookname";
            // 
            // clmDue
            // 
            this.clmDue.DataPropertyName = "due_date";
            this.clmDue.HeaderText = "Due Date";
            this.clmDue.Name = "clmDue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(148, 35);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(53, 21);
            this.username.TabIndex = 1;
            this.username.Text = "label2";
            this.username.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(236, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 460);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Member";
            this.Text = "Member";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Member_FormClosed);
            this.Load += new System.EventHandler(this.Member_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookTaken)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBkTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBkAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYrPubl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookCat;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgBookTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDue;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}