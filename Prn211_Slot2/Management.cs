using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prn211_Slot2
{
    public partial class Management : Form
    {
        List<Student> students = new List<Student>();
        BankAccountServices _bankAccountService = new BankAccountServices();
        UserServices _userService = new UserServices();
        AccountTypeServices _accountTypeServices = new AccountTypeServices();

        public Management()
        {
            InitializeComponent();

            Random random = new Random();

            var ListBankAccount = _bankAccountService.GetAll();
            var ListUser = _userService.GetAll();
            cmbType.DataSource = _accountTypeServices.GetAll(); // _accountTypes là danh sách các AccountTypes
            cmbType.DisplayMember = "TypeName"; // Thiết lập trường hiển thị trong ComboBox là "TypeName"
            cmbType.ValueMember = "TypeId"; // Thiết lập trường giá trị tương ứng với mỗi mục là "TypeId"
            cmbType.SelectedItem = null;

            cmbUpdateType.DataSource = _accountTypeServices.GetAll(); // _accountTypes là danh sách các AccountTypes
            cmbUpdateType.DisplayMember = "TypeName"; // Thiết lập trường hiển thị trong ComboBox là "TypeName"
            cmbUpdateType.ValueMember = "TypeId"; // Thiết lập trường giá trị tương ứng với mỗi mục là "TypeId"
            cmbUpdateType.SelectedItem = null;


            dgvBankAccount.DataSource = new BindingSource { DataSource = ListBankAccount };
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any input fields are empty
                if (string.IsNullOrEmpty(txtAccountID.Text) ||
                    string.IsNullOrEmpty(txAccountName.Text) ||
                    string.IsNullOrEmpty(txtOpenDate.Text) ||
                    string.IsNullOrEmpty(txtBranchName.Text))
                {
                    MessageBox.Show("Please fill in all the fields.", "Warning", MessageBoxButtons.OK);
                    return;
                }

                // Check if the Bank Account with the given ID already exists
                BankAccount existBankAccount = _bankAccountService.GetAll().FirstOrDefault(BankAccount => BankAccount.AccountId == txtAccountID.Text);
                if (existBankAccount != null)
                {
                    MessageBox.Show("Account ID Duplicated!!! Please try another Account ID.");
                    return;
                }

                // Create a new student
                var bankAccount = new BankAccount();
                bankAccount.AccountId = txtAccountID.Text;
                bankAccount.AccountName = txAccountName.Text;

                // Validate openDate
                if (!DateTime.TryParse(txtOpenDate.Text, out DateTime openDate) || openDate.Year < 2000 || openDate.Year > 2022)
                {
                    MessageBox.Show("Invalid open date. Please enter a valid date in the format (yyyy/MM/dd) between 2000 and 2022.");
                    return;
                }

                bankAccount.OpenDate = openDate;

                // Validate branchName
                if (!IsBranchNameValid(txtBranchName.Text))
                {
                    MessageBox.Show("Invalid Branch name. Please enter a Branch Name more than 5 characters and each word of the Brach name must be begin with the capital letter ");
                    return;
                }

                bankAccount.BranchName = txtBranchName.Text;

                var selectedType = (AccountType)cmbType.SelectedItem;
                bankAccount.TypeId = selectedType.TypeId;

                // Add the new Bank Account to the list or database
                _bankAccountService.Create(bankAccount);

                // Refresh the DataGridView to reflect the changes
                dgvBankAccount.DataSource = new BindingSource() { DataSource = _bankAccountService.GetAll() };
                MessageBox.Show("Add successfully", "Warning", MessageBoxButtons.OK);

                // Clear the text fields
                txtAccountID.Text = string.Empty;
                txAccountName.Text = string.Empty;
                txtOpenDate.Text = string.Empty;
                txtBranchName.Text = string.Empty;
                cmbType.SelectedItem = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Input Invalid. Please Try Again", "Warning", MessageBoxButtons.OK);
            }
        }

        private void dgvBankAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvBankAccount.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvBankAccount.Rows[e.RowIndex];
                var bankAccount = selectedRow.DataBoundItem as BankAccount;

                if (bankAccount != null)
                {
                    txtUpdate_AccountId.Text = bankAccount.AccountId;
                    txtUpdate_AccountName.Text = bankAccount.AccountName;

                    if (bankAccount.OpenDate.HasValue)
                    {
                        txtUpdate_OpenDate.Text = bankAccount.OpenDate.Value.ToString("yyyy/MM/dd");
                    }
                    else
                    {
                        txtUpdate_OpenDate.Text = string.Empty;
                    }

                    txtUpdate_BranchName.Text = bankAccount.BranchName;
                    cmbUpdateType.SelectedValue = bankAccount.TypeId;
                }
                else
                {
                    MessageBox.Show("Invalid row data selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid row index selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any input fields are empty
                if (string.IsNullOrEmpty(txtUpdate_AccountId.Text) ||
                    string.IsNullOrEmpty(txtUpdate_AccountName.Text) ||
                    string.IsNullOrEmpty(txtUpdate_OpenDate.Text) ||
                    string.IsNullOrEmpty(txtUpdate_BranchName.Text))
                {
                    MessageBox.Show("Please fill in all the fields.", "Warning", MessageBoxButtons.OK);
                    return;
                }

                // Check if the student with the given ID already exists
                BankAccount existBankAccount = _bankAccountService.GetAll().FirstOrDefault(BankAccount => BankAccount.AccountId == txtUpdate_AccountId.Text);


                if (existBankAccount != null)
                {
                    existBankAccount.AccountName = txtUpdate_AccountName.Text;

                    // Validate openDate
                    if (!DateTime.TryParse(txtUpdate_OpenDate.Text, out DateTime openDate) || openDate.Year < 2000 || openDate.Year > 2022)
                    {
                        MessageBox.Show("Invalid open date. Please enter a valid date in the format (yyyy/MM/dd) between 2000 and 2022.");
                        return;
                    }

                    existBankAccount.OpenDate = openDate;


                    // Validate branchName
                    if (!IsBranchNameValid(txtUpdate_BranchName.Text))
                    {
                        MessageBox.Show("Invalid Branch name. Please enter a Branch Name more than 5 characters and each word of the Brach name must be begin with the capital letter");
                        return;
                    }
                    existBankAccount.BranchName = txtUpdate_BranchName.Text;

                    var selectedType = (AccountType)cmbUpdateType.SelectedItem;
                    existBankAccount.TypeId = selectedType.TypeId;

                    // Add the new Bank Account to the list or database
                    _bankAccountService.update(existBankAccount);

                    // Refresh the DataGridView to reflect the changes
                    dgvBankAccount.DataSource = new BindingSource() { DataSource = _bankAccountService.GetAll() };
                    MessageBox.Show("Add successfully", "Warning", MessageBoxButtons.OK);

                    // Clear the text fields
                    txtAccountID.Text = string.Empty;
                    txAccountName.Text = string.Empty;
                    txtOpenDate.Text = string.Empty;
                    txtBranchName.Text = string.Empty;

                    // Refresh the DataGridView to reflect the changes
                    dgvBankAccount.Refresh();

                    MessageBox.Show("Update successfully", "Warning", MessageBoxButtons.OK);

                    // Clear the text fields
                    txtUpdate_AccountId.Text = string.Empty;
                    txtUpdate_AccountName.Text = string.Empty;
                    txtUpdate_OpenDate.Text = string.Empty;
                    txtUpdate_BranchName.Text = string.Empty;
                    cmbUpdateType.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("ID Not Found! Please Try Again", "Warning", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input Invalid. Please Try Again", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn một dòng dữ liệu trong DataGridView chưa
            if (dgvBankAccount.SelectedCells.Count > 0)
            {
                // Lấy chỉ số của dòng dữ liệu được chọn
                int selectedIndex = dgvBankAccount.SelectedCells[0].RowIndex;

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Bank Account?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Lấy thông tin BankAccount từ dòng dữ liệu được chọn
                    BankAccount selectedBankAccount = dgvBankAccount.Rows[selectedIndex].DataBoundItem as BankAccount;

                    // Xóa BankAccount từ dịch vụ _bankAccountService
                    bool deleteResult = _bankAccountService.Delete(selectedBankAccount);


                    if (deleteResult)
                    {
                        // Cập nhật lại DataGridView
                        dgvBankAccount.DataSource = null;
                        dgvBankAccount.DataSource = _bankAccountService.GetAll();

                        MessageBox.Show("Delete successfully", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Bank Account.", "Error", MessageBoxButtons.OK);
                    }


                    MessageBox.Show("Delete successfully", "Warning", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show("Please select a Bank Account to delete.", "Warning", MessageBoxButtons.OK);
            }
        }


        private bool IsBranchNameValid(string branchName)
        {
            string[] words = branchName.Split(' ');
            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word) || !char.IsUpper(word[0]))
                {
                    return false;
                }
            }
            return branchName.Length > 5;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string branchName = txtSearchBranchName.Text;

            // Kiểm tra xem đã nhập tên chi nhánh để tìm kiếm hay chưa
            if (string.IsNullOrEmpty(branchName))
            {
                MessageBox.Show("Please enter a branch name to search.", "Warning", MessageBoxButtons.OK);
                return;
            }

            // Gọi phương thức GetAll từ BankAccountServices
            List<BankAccount> bankAccounts = _bankAccountService.GetAll();

            // Lọc các tài khoản theo tên chi nhánh
            List<BankAccount> searchResults = bankAccounts.Where(account => account.BranchName.Contains(branchName)).ToList();

            // Kiểm tra xem có kết quả tìm kiếm hay không
            if (searchResults.Count == 0)
            {
                MessageBox.Show("No accounts found for the specified branch name.", "Information", MessageBoxButtons.OK);
            }
            else
            {
                // Hiển thị kết quả tìm kiếm trong DataGridView
                dgvBankAccount.DataSource = new BindingSource() { DataSource = searchResults };
            }
        }
    }
}
