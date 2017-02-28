namespace Bibliotheca_Management_System
{
    partial class SearchM
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
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
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
            this.dgMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMembers.Location = new System.Drawing.Point(0, 0);
            this.dgMembers.Name = "dgMembers";
            this.dgMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMembers.Size = new System.Drawing.Size(467, 326);
            this.dgMembers.TabIndex = 2;
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
            // SearchM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 326);
            this.Controls.Add(this.dgMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchM";
            this.Text = "SearchM";
            ((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMemfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMem_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMem_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMemPassword;
    }
}