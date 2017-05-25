using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iFun.DTO;
using BL = iFun.BusinessLayer;
using iFun.Utilities;

namespace iFunGameStation
{
    public partial class ExpenseTransactionfrm : Form
    {
        public ExpenseTransactionfrm()
        {
            InitializeComponent();
        }

        private void ExpenseTransactionfrm_Load(object sender, EventArgs e)
        {
            LoadDefaultValues();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                var expense = (ComboboxItem)ddlExpenseName.SelectedItem;
                var Amount = txtAmount.Text;
                var Comments = txtComments.Text;

                ExpenseTransactionDTO expenseTransactionDTO = new ExpenseTransactionDTO();
                expenseTransactionDTO.ExpenseID = Convert.ToInt32(expense.Value);
                expenseTransactionDTO.Comments = Comments;
                expenseTransactionDTO.Amount = Convert.ToInt32(Amount);
                
                BL.ExpenseTransactionBL obj = new BL.ExpenseTransactionBL();
                var result = obj.AddExpenseTransaction(expenseTransactionDTO);

                if (result)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                var expense = (ComboboxItem)ddlExpenseName.SelectedItem;
                var Amount = txtAmount.Text;
                var Comments = txtComments.Text;

                ExpenseTransactionDTO expenseTransactionDTO = new ExpenseTransactionDTO();
                expenseTransactionDTO.ExpenseTransactionID = Convert.ToInt32(dgExpenseTransactionView.CurrentRow.Cells["ExpenseTransactionID"].Value.ToString());
                expenseTransactionDTO.ExpenseID = Convert.ToInt32(expense.Value);
                expenseTransactionDTO.Comments = Comments;
                expenseTransactionDTO.Amount = Convert.ToInt32(Amount);
                
                BL.ExpenseTransactionBL obj = new BL.ExpenseTransactionBL();
                var result = obj.UpdateExpenseTransaction(expenseTransactionDTO);
                if (result)
                {
                    MessageBox.Show("Updated");
                    btnAdd.Text = "ADD";
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            clear();
            LoadDefaultValues();
        }

        private void clear()
        {
            ddlExpenseName.SelectedIndex = -1;
            txtComments.Text = "";
            txtAmount.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtAmount.Text = dgExpenseTransactionView.CurrentRow.Cells["Amount"].Value.ToString();
            txtComments.Text = dgExpenseTransactionView.CurrentRow.Cells["Comments"].Value.ToString();
            btnAdd.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var ID = dgExpenseTransactionView.CurrentRow.Cells["ExpenseTransactionID"].Value.ToString();
            BL.ExpenseTransactionBL obj = new BL.ExpenseTransactionBL();
            var result = obj.DeleteExpenseTransaction(Convert.ToInt32(ID));
            if (result)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadDefaultValues();
        }

        private void LoadDefaultValues()
        {
            //Load Default Game System Names
            BL.ExpensesBL expenseBL = new BL.ExpensesBL();
            ddlExpenseName.Items.Clear();
            var expenseList = expenseBL.GetExpenses();

            foreach (var expenses in expenseList)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = expenses.Description;
                item.Value = expenses.ExpenseID;
                ddlExpenseName.Items.Add(item);


            }

            BL.ExpenseTransactionBL expenseTran = new BL.ExpenseTransactionBL();
            var expenseTranList = expenseTran.GetExpenseTransaction();

            var lst = (from expTran in expenseTranList
                       join exp in expenseList
                       on expTran.ExpenseID equals exp.ExpenseID
                       select new
                       {
                           expTran.ExpenseTransactionID,
                           expTran.ExpenseID,
                           exp.Description,
                           expTran.Comments,
                           expTran.Amount,
                           expTran.CreatedDate,
                        }
                                 ).ToList();
            dgExpenseTransactionView.DataSource = lst;

        }
    }
}
