namespace Prn211_Slot2
{
    partial class Management
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
            dgvBankAccount = new DataGridView();
            Name = new Label();
            lbDate = new Label();
            ID = new Label();
            txtAccountID = new TextBox();
            txAccountName = new TextBox();
            txtOpenDate = new TextBox();
            btnCreate = new Button();
            lbUpdate_AccountId = new Label();
            Update_AccountName = new Label();
            Update_OpenDate = new Label();
            txtUpdate_AccountId = new TextBox();
            txtUpdate_AccountName = new TextBox();
            txtUpdate_OpenDate = new TextBox();
            btnUpdate = new Button();
            Email_Create = new Label();
            Phone_Create = new Label();
            Update_Phone = new Label();
            Update_Email = new Label();
            txtBranchName = new TextBox();
            txtUpdate_BranchName = new TextBox();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbType = new ComboBox();
            cmbUpdateType = new ComboBox();
            label3 = new Label();
            txtSearchBranchName = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvBankAccount
            // 
            dgvBankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAccount.Location = new Point(26, 60);
            dgvBankAccount.Name = "dgvBankAccount";
            dgvBankAccount.ReadOnly = true;
            dgvBankAccount.RowTemplate.Height = 25;
            dgvBankAccount.Size = new Size(1069, 287);
            dgvBankAccount.TabIndex = 1;
            dgvBankAccount.CellDoubleClick += dgvBankAccount_CellDoubleClick;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(26, 426);
            Name.Name = "Name";
            Name.Size = new Size(87, 15);
            Name.TabIndex = 2;
            Name.Text = "Account Name";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(50, 455);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(63, 15);
            lbDate.TabIndex = 3;
            lbDate.Text = "Open Date";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(47, 398);
            ID.Name = "ID";
            ID.Size = new Size(66, 15);
            ID.TabIndex = 4;
            ID.Text = "Account ID";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(128, 395);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(76, 23);
            txtAccountID.TabIndex = 5;
            // 
            // txAccountName
            // 
            txAccountName.Location = new Point(128, 423);
            txAccountName.Name = "txAccountName";
            txAccountName.Size = new Size(280, 23);
            txAccountName.TabIndex = 6;
            // 
            // txtOpenDate
            // 
            txtOpenDate.Location = new Point(128, 452);
            txtOpenDate.Name = "txtOpenDate";
            txtOpenDate.Size = new Size(121, 23);
            txtOpenDate.TabIndex = 7;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(333, 543);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lbUpdate_AccountId
            // 
            lbUpdate_AccountId.AutoSize = true;
            lbUpdate_AccountId.Location = new Point(475, 398);
            lbUpdate_AccountId.Name = "lbUpdate_AccountId";
            lbUpdate_AccountId.Size = new Size(63, 15);
            lbUpdate_AccountId.TabIndex = 9;
            lbUpdate_AccountId.Text = "AccountID";
            // 
            // Update_AccountName
            // 
            Update_AccountName.AutoSize = true;
            Update_AccountName.Location = new Point(451, 426);
            Update_AccountName.Name = "Update_AccountName";
            Update_AccountName.Size = new Size(87, 15);
            Update_AccountName.TabIndex = 10;
            Update_AccountName.Text = "Account Name";
            // 
            // Update_OpenDate
            // 
            Update_OpenDate.AutoSize = true;
            Update_OpenDate.Location = new Point(475, 455);
            Update_OpenDate.Name = "Update_OpenDate";
            Update_OpenDate.Size = new Size(63, 15);
            Update_OpenDate.TabIndex = 11;
            Update_OpenDate.Text = "Open Date";
            // 
            // txtUpdate_AccountId
            // 
            txtUpdate_AccountId.Location = new Point(544, 395);
            txtUpdate_AccountId.Name = "txtUpdate_AccountId";
            txtUpdate_AccountId.ReadOnly = true;
            txtUpdate_AccountId.Size = new Size(80, 23);
            txtUpdate_AccountId.TabIndex = 12;
            // 
            // txtUpdate_AccountName
            // 
            txtUpdate_AccountName.Location = new Point(544, 423);
            txtUpdate_AccountName.Name = "txtUpdate_AccountName";
            txtUpdate_AccountName.Size = new Size(242, 23);
            txtUpdate_AccountName.TabIndex = 13;
            // 
            // txtUpdate_OpenDate
            // 
            txtUpdate_OpenDate.Location = new Point(544, 452);
            txtUpdate_OpenDate.Name = "txtUpdate_OpenDate";
            txtUpdate_OpenDate.Size = new Size(121, 23);
            txtUpdate_OpenDate.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(711, 543);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Email_Create
            // 
            Email_Create.AutoSize = true;
            Email_Create.Location = new Point(35, 486);
            Email_Create.Name = "Email_Create";
            Email_Create.Size = new Size(79, 15);
            Email_Create.TabIndex = 16;
            Email_Create.Text = "Branch Name";
            // 
            // Phone_Create
            // 
            Phone_Create.AutoSize = true;
            Phone_Create.Location = new Point(34, 512);
            Phone_Create.Name = "Phone_Create";
            Phone_Create.Size = new Size(79, 15);
            Phone_Create.TabIndex = 17;
            Phone_Create.Text = "Account Type";
            // 
            // Update_Phone
            // 
            Update_Phone.AutoSize = true;
            Update_Phone.Location = new Point(460, 512);
            Update_Phone.Name = "Update_Phone";
            Update_Phone.Size = new Size(79, 15);
            Update_Phone.TabIndex = 20;
            Update_Phone.Text = "Account Type";
            // 
            // Update_Email
            // 
            Update_Email.AutoSize = true;
            Update_Email.Location = new Point(460, 486);
            Update_Email.Name = "Update_Email";
            Update_Email.Size = new Size(79, 15);
            Update_Email.TabIndex = 19;
            Update_Email.Text = "Branch Name";
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(128, 483);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(280, 23);
            txtBranchName.TabIndex = 22;
            // 
            // txtUpdate_BranchName
            // 
            txtUpdate_BranchName.Location = new Point(544, 483);
            txtUpdate_BranchName.Name = "txtUpdate_BranchName";
            txtUpdate_BranchName.Size = new Size(242, 23);
            txtUpdate_BranchName.TabIndex = 25;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1009, 357);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 353);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 29;
            label1.Text = "CREATE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(544, 353);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 30;
            label2.Text = "UPDATE";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(128, 509);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 31;
            // 
            // cmbUpdateType
            // 
            cmbUpdateType.FormattingEnabled = true;
            cmbUpdateType.Location = new Point(544, 509);
            cmbUpdateType.Name = "cmbUpdateType";
            cmbUpdateType.Size = new Size(121, 23);
            cmbUpdateType.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(738, 35);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 33;
            label3.Text = "Search by Branch";
            // 
            // txtSearchBranchName
            // 
            txtSearchBranchName.Location = new Point(842, 32);
            txtSearchBranchName.Name = "txtSearchBranchName";
            txtSearchBranchName.Size = new Size(187, 23);
            txtSearchBranchName.TabIndex = 34;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1031, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 23);
            btnSearch.TabIndex = 35;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 569);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBranchName);
            Controls.Add(label3);
            Controls.Add(cmbUpdateType);
            Controls.Add(cmbType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(txtUpdate_BranchName);
            Controls.Add(txtBranchName);
            Controls.Add(Update_Phone);
            Controls.Add(Update_Email);
            Controls.Add(Phone_Create);
            Controls.Add(Email_Create);
            Controls.Add(btnUpdate);
            Controls.Add(txtUpdate_OpenDate);
            Controls.Add(txtUpdate_AccountName);
            Controls.Add(txtUpdate_AccountId);
            Controls.Add(Update_OpenDate);
            Controls.Add(Update_AccountName);
            Controls.Add(lbUpdate_AccountId);
            Controls.Add(btnCreate);
            Controls.Add(txtOpenDate);
            Controls.Add(txAccountName);
            Controls.Add(txtAccountID);
            Controls.Add(ID);
            Controls.Add(lbDate);
            Controls.Add(Name);
            Controls.Add(dgvBankAccount);
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBankAccount;
        private Label Name;
        private Label lbDate;
        private Label ID;
        private TextBox txtAccountID;
        private TextBox txAccountName;
        private TextBox txtOpenDate;
        private Button btnCreate;
        private Label lbUpdate_AccountId;
        private Label Update_AccountName;
        private Label Update_OpenDate;
        private TextBox txtUpdate_AccountId;
        private TextBox txtUpdate_AccountName;
        private TextBox txtUpdate_OpenDate;
        private Button btnUpdate;
        private Label Email_Create;
        private Label Phone_Create;
        private Label Update_Phone;
        private Label Update_Email;
        private TextBox txtBranchName;
        private TextBox txtUpdate_BranchName;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private ComboBox cmbType;
        private ComboBox cmbUpdateType;
        private Label label3;
        private TextBox txtSearchBranchName;
        private Button btnSearch;
    }
}