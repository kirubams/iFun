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


namespace iFunGameStation
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (btnAdd.Text == "ADD")
                {
                    ExpensesDTO expenseDTO = new ExpensesDTO();
                    expenseDTO.Description = txtDescription.Text;
                    expenseDTO.Amount = Convert.ToInt32(txtAmount.Text);

                    BL.ExpensesBL expen = new BL.ExpensesBL();
                    var result = expen.AddExpenses(expenseDTO);
                    LoadExpenses();

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
                    ExpensesDTO expenseDTO = new ExpensesDTO();
                    expenseDTO.Description = txtDescription.Text;
                    expenseDTO.Amount = Convert.ToInt32(txtAmount.Text);
                    expenseDTO.ExpenseID = Convert.ToInt32(dgGameSystems.CurrentRow.Cells["ExpenseID"].Value);
                    BL.ExpensesBL exp = new BL.ExpensesBL();
                    var result = exp.UpdateExpenses(expenseDTO);
                    btnAdd.Text = "ADD";

                }
                clear();
                LoadExpenses();
            }
            else
            {
                MessageBox.Show("Name or Model No cannot be Empty");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedName = dgGameSystems.CurrentRow.Cells["Description"].Value.ToString();

            var selectedAmount = dgGameSystems.CurrentRow.Cells["Amount"].Value.ToString();

            txtDescription.Text = selectedName;
            txtAmount.Text = selectedAmount;
            btnAdd.Text = "Update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var expenseID = dgGameSystems.CurrentRow.Cells["ExpenseID"].Value.ToString();
            BL.ExpensesBL expen = new BL.ExpensesBL();
            var result = expen.DeleteExpenses(Convert.ToInt32(expenseID));
            if (result)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
            clear();
            LoadExpenses();

        }
        private void LoadExpenses()
        {
            BL.ExpensesBL expenseBL = new BL.ExpensesBL();

            dgGameSystems.DataSource = expenseBL.GetExpenses().Select(o => new
            { ExpenseID = o.ExpenseID, Description = o.Description, Amount = o.Amount }).ToList();

            if (dgGameSystems.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        private void clear()
        {
            txtDescription.Text = "";
            txtAmount.Text = "";
        }

        private bool validate()
        {
            var flag = true;
            if (txtDescription.Text == string.Empty || txtAmount.Text == string.Empty)
            {
                flag = false;
            }
            return flag;
        }

       
    }
}
