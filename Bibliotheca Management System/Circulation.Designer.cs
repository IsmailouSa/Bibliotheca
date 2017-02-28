namespace Bibliotheca_Management_System
{
    partial class Circulation
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
            this.dgCirculation = new System.Windows.Forms.DataGridView();
            this.gbCheckIn = new System.Windows.Forms.GroupBox();
            this.dtpReturnD = new System.Windows.Forms.DateTimePicker();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCheckOut = new System.Windows.Forms.GroupBox();
            this.dtpAddReturnD = new System.Windows.Forms.DateTimePicker();
            this.txtAddMemName = new System.Windows.Forms.TextBox();
            this.txtAddBookName = new System.Windows.Forms.TextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Member_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBkTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCirculation)).BeginInit();
            this.gbCheckIn.SuspendLayout();
            this.gbCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCirculation
            // 
            this.dgCirculation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCirculation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCirculation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Member_ID,
            this.clmBkTitle,
            this.clmMemName,
            this.clmIssueDate,
            this.clmDueDate});
            this.dgCirculation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCirculation.Location = new System.Drawing.Point(0, 192);
            this.dgCirculation.Name = "dgCirculation";
            this.dgCirculation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCirculation.Size = new System.Drawing.Size(710, 199);
            this.dgCirculation.TabIndex = 2;
            this.dgCirculation.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCirculation_CellMouseDoubleClick);
            // 
            // gbCheckIn
            // 
            this.gbCheckIn.Controls.Add(this.dtpReturnD);
            this.gbCheckIn.Controls.Add(this.txtMemName);
            this.gbCheckIn.Controls.Add(this.label8);
            this.gbCheckIn.Controls.Add(this.btnUpdate);
            this.gbCheckIn.Controls.Add(this.txtBookName);
            this.gbCheckIn.Controls.Add(this.btnReturn);
            this.gbCheckIn.Controls.Add(this.label3);
            this.gbCheckIn.Controls.Add(this.label2);
            this.gbCheckIn.Controls.Add(this.label1);
            this.gbCheckIn.Enabled = false;
            this.gbCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCheckIn.Location = new System.Drawing.Point(370, 12);
            this.gbCheckIn.Name = "gbCheckIn";
            this.gbCheckIn.Size = new System.Drawing.Size(307, 174);
            this.gbCheckIn.TabIndex = 3;
            this.gbCheckIn.TabStop = false;
            this.gbCheckIn.Text = "Book Return/Update";
            // 
            // dtpReturnD
            // 
            this.dtpReturnD.AllowDrop = true;
            this.dtpReturnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnD.Location = new System.Drawing.Point(84, 90);
            this.dtpReturnD.Name = "dtpReturnD";
            this.dtpReturnD.Size = new System.Drawing.Size(184, 20);
            this.dtpReturnD.TabIndex = 10;
            this.dtpReturnD.Value = new System.DateTime(2016, 4, 28, 21, 30, 55, 0);
            // 
            // txtMemName
            // 
            this.txtMemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMemName.Location = new System.Drawing.Point(84, 59);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(184, 23);
            this.txtMemName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Return Date";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(202, 138);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBookName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBookName.Location = new System.Drawing.Point(84, 30);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(184, 23);
            this.txtBookName.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(114, 138);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(66, 30);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "User\'s Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "User\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Title";
            // 
            // gbCheckOut
            // 
            this.gbCheckOut.Controls.Add(this.dtpAddReturnD);
            this.gbCheckOut.Controls.Add(this.txtAddMemName);
            this.gbCheckOut.Controls.Add(this.txtAddBookName);
            this.gbCheckOut.Controls.Add(this.btnIssue);
            this.gbCheckOut.Controls.Add(this.label7);
            this.gbCheckOut.Controls.Add(this.label6);
            this.gbCheckOut.Controls.Add(this.label4);
            this.gbCheckOut.Controls.Add(this.label5);
            this.gbCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCheckOut.Location = new System.Drawing.Point(31, 12);
            this.gbCheckOut.Name = "gbCheckOut";
            this.gbCheckOut.Size = new System.Drawing.Size(307, 174);
            this.gbCheckOut.TabIndex = 4;
            this.gbCheckOut.TabStop = false;
            this.gbCheckOut.Text = "Book Issue";
            // 
            // dtpAddReturnD
            // 
            this.dtpAddReturnD.AllowDrop = true;
            this.dtpAddReturnD.Location = new System.Drawing.Point(84, 91);
            this.dtpAddReturnD.Name = "dtpAddReturnD";
            this.dtpAddReturnD.Size = new System.Drawing.Size(184, 23);
            this.dtpAddReturnD.TabIndex = 8;
            // 
            // txtAddMemName
            // 
            this.txtAddMemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAddMemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAddMemName.Location = new System.Drawing.Point(84, 59);
            this.txtAddMemName.Name = "txtAddMemName";
            this.txtAddMemName.Size = new System.Drawing.Size(184, 23);
            this.txtAddMemName.TabIndex = 7;
            // 
            // txtAddBookName
            // 
            this.txtAddBookName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAddBookName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAddBookName.Location = new System.Drawing.Point(84, 33);
            this.txtAddBookName.Name = "txtAddBookName";
            this.txtAddBookName.Size = new System.Drawing.Size(184, 23);
            this.txtAddBookName.TabIndex = 6;
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(192, 138);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(66, 30);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Return Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 2;
            // 
            // Member_ID
            // 
            this.Member_ID.DataPropertyName = "issue_id";
            this.Member_ID.HeaderText = "Issue_id";
            this.Member_ID.Name = "Member_ID";
            this.Member_ID.Visible = false;
            // 
            // clmBkTitle
            // 
            this.clmBkTitle.DataPropertyName = "book_name";
            this.clmBkTitle.HeaderText = "Book Title";
            this.clmBkTitle.Name = "clmBkTitle";
            // 
            // clmMemName
            // 
            this.clmMemName.DataPropertyName = "Mem_Name";
            this.clmMemName.HeaderText = "Taken By";
            this.clmMemName.Name = "clmMemName";
            // 
            // clmIssueDate
            // 
            this.clmIssueDate.DataPropertyName = "issue_date";
            this.clmIssueDate.HeaderText = "Issue Date";
            this.clmIssueDate.Name = "clmIssueDate";
            // 
            // clmDueDate
            // 
            this.clmDueDate.DataPropertyName = "due_date";
            this.clmDueDate.HeaderText = "Due Date";
            this.clmDueDate.Name = "clmDueDate";
            // 
            // Circulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 391);
            this.Controls.Add(this.gbCheckOut);
            this.Controls.Add(this.gbCheckIn);
            this.Controls.Add(this.dgCirculation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Circulation";
            this.Text = "Circulation";
            this.Load += new System.EventHandler(this.Circulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCirculation)).EndInit();
            this.gbCheckIn.ResumeLayout(false);
            this.gbCheckIn.PerformLayout();
            this.gbCheckOut.ResumeLayout(false);
            this.gbCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCirculation;
        private System.Windows.Forms.GroupBox gbCheckIn;
        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbCheckOut;
        private System.Windows.Forms.DateTimePicker dtpAddReturnD;
        private System.Windows.Forms.TextBox txtAddMemName;
        private System.Windows.Forms.TextBox txtAddBookName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpReturnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBkTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDueDate;
    }
}