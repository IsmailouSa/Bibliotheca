namespace Bibliotheca_Management_System
{
    partial class Members
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
            this.dgMembers = new System.Windows.Forms.DataGridView();
            this.MemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMemfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMem_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMem_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMemPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveMem = new System.Windows.Forms.Button();
            this.btnUpdateMem = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtMemAddress = new System.Windows.Forms.TextBox();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblMemEmail = new System.Windows.Forms.Label();
            this.lblMemName = new System.Windows.Forms.Label();
            this.cmlQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYrPubl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBkAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBkTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAddMember = new System.Windows.Forms.GroupBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.gbDeleteUpdateMem = new System.Windows.Forms.GroupBox();
            this.cbxEditRole = new System.Windows.Forms.ComboBox();
            this.rtbEditAddress = new System.Windows.Forms.RichTextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
            this.gbAddMember.SuspendLayout();
            this.gbDeleteUpdateMem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMembers
            // 
            this.dgMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemID,
            this.clmMemfName,
            this.clmMem_email,
            this.clmMem_address,
            this.clmRole,
            this.clmMemPassword});
            this.dgMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgMembers.Location = new System.Drawing.Point(0, 210);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMembers.Size = new System.Drawing.Size(710, 181);
            this.dgMembers.TabIndex = 1;
            this.dgMembers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgMembers_CellMouseDoubleClick);
            // 
            // MemID
            // 
            this.MemID.DataPropertyName = "Mem_Id";
            this.MemID.HeaderText = "MemberID";
            this.MemID.Name = "MemID";
            this.MemID.Visible = false;
            // 
            // clmMemfName
            // 
            this.clmMemfName.DataPropertyName = "Mem_Name";
            this.clmMemfName.HeaderText = "Full Name";
            this.clmMemfName.Name = "clmMemfName";
            // 
            // clmMem_email
            // 
            this.clmMem_email.DataPropertyName = "Mem_Email";
            this.clmMem_email.HeaderText = "E-mail";
            this.clmMem_email.Name = "clmMem_email";
            // 
            // clmMem_address
            // 
            this.clmMem_address.DataPropertyName = "Mem_Address";
            this.clmMem_address.HeaderText = "Address";
            this.clmMem_address.Name = "clmMem_address";
            // 
            // clmRole
            // 
            this.clmRole.DataPropertyName = "Mem_Role";
            this.clmRole.HeaderText = "Role";
            this.clmRole.Name = "clmRole";
            // 
            // clmMemPassword
            // 
            this.clmMemPassword.DataPropertyName = "Mem_password";
            this.clmMemPassword.HeaderText = "Password";
            this.clmMemPassword.Name = "clmMemPassword";
            this.clmMemPassword.Visible = false;
            // 
            // btnRemoveMem
            // 
            this.btnRemoveMem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMem.Location = new System.Drawing.Point(89, 161);
            this.btnRemoveMem.Name = "btnRemoveMem";
            this.btnRemoveMem.Size = new System.Drawing.Size(85, 25);
            this.btnRemoveMem.TabIndex = 18;
            this.btnRemoveMem.Text = "Delete";
            this.btnRemoveMem.UseVisualStyleBackColor = true;
            this.btnRemoveMem.Click += new System.EventHandler(this.btnRemoveMem_Click);
            // 
            // btnUpdateMem
            // 
            this.btnUpdateMem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMem.Location = new System.Drawing.Point(211, 161);
            this.btnUpdateMem.Name = "btnUpdateMem";
            this.btnUpdateMem.Size = new System.Drawing.Size(85, 25);
            this.btnUpdateMem.TabIndex = 17;
            this.btnUpdateMem.Text = "Update Member";
            this.btnUpdateMem.UseVisualStyleBackColor = true;
            this.btnUpdateMem.Click += new System.EventHandler(this.btnUpdateMem_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(186, 161);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(85, 25);
            this.btnAddMember.TabIndex = 8;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtMemAddress
            // 
            this.txtMemAddress.Location = new System.Drawing.Point(119, 53);
            this.txtMemAddress.Name = "txtMemAddress";
            this.txtMemAddress.Size = new System.Drawing.Size(150, 23);
            this.txtMemAddress.TabIndex = 5;
            // 
            // txtMemName
            // 
            this.txtMemName.Location = new System.Drawing.Point(119, 21);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(150, 23);
            this.txtMemName.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(28, 111);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(49, 15);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Address";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(28, 85);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(30, 15);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // lblMemEmail
            // 
            this.lblMemEmail.AutoSize = true;
            this.lblMemEmail.Location = new System.Drawing.Point(28, 53);
            this.lblMemEmail.Name = "lblMemEmail";
            this.lblMemEmail.Size = new System.Drawing.Size(86, 15);
            this.lblMemEmail.TabIndex = 1;
            this.lblMemEmail.Text = "E-mail Address";
            // 
            // lblMemName
            // 
            this.lblMemName.AutoSize = true;
            this.lblMemName.Location = new System.Drawing.Point(28, 24);
            this.lblMemName.Name = "lblMemName";
            this.lblMemName.Size = new System.Drawing.Size(61, 15);
            this.lblMemName.TabIndex = 0;
            this.lblMemName.Text = "Full Name";
            // 
            // cmlQty
            // 
            this.cmlQty.DataPropertyName = "Book_Qty";
            this.cmlQty.HeaderText = "Quantity";
            this.cmlQty.Name = "cmlQty";
            // 
            // clmYrPubl
            // 
            this.clmYrPubl.DataPropertyName = "yr_of_publ";
            this.clmYrPubl.HeaderText = "Year of Publishing";
            this.clmYrPubl.Name = "clmYrPubl";
            // 
            // clmBkAuthor
            // 
            this.clmBkAuthor.DataPropertyName = "Book_Author";
            this.clmBkAuthor.HeaderText = "Book Author";
            this.clmBkAuthor.Name = "clmBkAuthor";
            // 
            // clmBkTitle
            // 
            this.clmBkTitle.DataPropertyName = "Book_Title";
            this.clmBkTitle.HeaderText = "Book Title";
            this.clmBkTitle.Name = "clmBkTitle";
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "Book_Id";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.Visible = false;
            // 
            // gbAddMember
            // 
            this.gbAddMember.Controls.Add(this.rtbAddress);
            this.gbAddMember.Controls.Add(this.cbxRole);
            this.gbAddMember.Controls.Add(this.btnAddMember);
            this.gbAddMember.Controls.Add(this.txtMemAddress);
            this.gbAddMember.Controls.Add(this.txtMemName);
            this.gbAddMember.Controls.Add(this.lbl);
            this.gbAddMember.Controls.Add(this.lblRole);
            this.gbAddMember.Controls.Add(this.lblMemEmail);
            this.gbAddMember.Controls.Add(this.lblMemName);
            this.gbAddMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddMember.Location = new System.Drawing.Point(27, 12);
            this.gbAddMember.Name = "gbAddMember";
            this.gbAddMember.Size = new System.Drawing.Size(319, 192);
            this.gbAddMember.TabIndex = 3;
            this.gbAddMember.TabStop = false;
            this.gbAddMember.Text = "Add New Member";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(119, 111);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(150, 47);
            this.rtbAddress.TabIndex = 10;
            this.rtbAddress.Text = "";
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
            "Member",
            "Administrator"});
            this.cbxRole.Location = new System.Drawing.Point(119, 80);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(150, 23);
            this.cbxRole.TabIndex = 9;
            // 
            // gbDeleteUpdateMem
            // 
            this.gbDeleteUpdateMem.Controls.Add(this.cbxEditRole);
            this.gbDeleteUpdateMem.Controls.Add(this.rtbEditAddress);
            this.gbDeleteUpdateMem.Controls.Add(this.btnRemoveMem);
            this.gbDeleteUpdateMem.Controls.Add(this.btnUpdateMem);
            this.gbDeleteUpdateMem.Controls.Add(this.txtEditEmail);
            this.gbDeleteUpdateMem.Controls.Add(this.label4);
            this.gbDeleteUpdateMem.Controls.Add(this.txtEditName);
            this.gbDeleteUpdateMem.Controls.Add(this.label3);
            this.gbDeleteUpdateMem.Controls.Add(this.label1);
            this.gbDeleteUpdateMem.Controls.Add(this.label2);
            this.gbDeleteUpdateMem.Enabled = false;
            this.gbDeleteUpdateMem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDeleteUpdateMem.Location = new System.Drawing.Point(364, 12);
            this.gbDeleteUpdateMem.Name = "gbDeleteUpdateMem";
            this.gbDeleteUpdateMem.Size = new System.Drawing.Size(321, 192);
            this.gbDeleteUpdateMem.TabIndex = 4;
            this.gbDeleteUpdateMem.TabStop = false;
            this.gbDeleteUpdateMem.Text = "Delete/Update Member";
            // 
            // cbxEditRole
            // 
            this.cbxEditRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditRole.FormattingEnabled = true;
            this.cbxEditRole.Items.AddRange(new object[] {
            "Member",
            "Administrator"});
            this.cbxEditRole.Location = new System.Drawing.Point(128, 80);
            this.cbxEditRole.Name = "cbxEditRole";
            this.cbxEditRole.Size = new System.Drawing.Size(150, 23);
            this.cbxEditRole.TabIndex = 11;
            // 
            // rtbEditAddress
            // 
            this.rtbEditAddress.Location = new System.Drawing.Point(128, 108);
            this.rtbEditAddress.Name = "rtbEditAddress";
            this.rtbEditAddress.Size = new System.Drawing.Size(150, 47);
            this.rtbEditAddress.TabIndex = 18;
            this.rtbEditAddress.Text = "";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(128, 50);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(150, 23);
            this.txtEditEmail.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Full Name";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(128, 18);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(150, 23);
            this.txtEditName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-mail Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Role";
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 391);
            this.Controls.Add(this.gbAddMember);
            this.Controls.Add(this.gbDeleteUpdateMem);
            this.Controls.Add(this.dgMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Members";
            this.Text = "Members";
            this.Load += new System.EventHandler(this.Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.gbAddMember.ResumeLayout(false);
            this.gbAddMember.PerformLayout();
            this.gbDeleteUpdateMem.ResumeLayout(false);
            this.gbDeleteUpdateMem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.Button btnRemoveMem;
        private System.Windows.Forms.Button btnUpdateMem;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtMemAddress;
        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblMemEmail;
        private System.Windows.Forms.Label lblMemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYrPubl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBkAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBkTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.GroupBox gbAddMember;
        private System.Windows.Forms.GroupBox gbDeleteUpdateMem;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.ComboBox cbxEditRole;
        private System.Windows.Forms.RichTextBox rtbEditAddress;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMemfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMem_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMem_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMemPassword;
    }
}