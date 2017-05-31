using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iFun.BusinessLayer;
using iFun.DTO;
using System.IO;
using iFun.Utilities;

namespace iFunGameStation
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnGetDailyIncome_Click(object sender, EventArgs e)
        {
            GetReportBL obj = new GetReportBL();
            var incomeTranlist = obj.GetDailyIncomeReport(System.DateTime.Now);
            lblDailyIncome.Text = incomeTranlist.Sum(x => x.FinalPrice).ToString();
            ExpenseTransactionBL expenTran = new ExpenseTransactionBL();
            var expenseTranList = expenTran.GetDailyExpenseTransaction(DateTime.Now);
            lblDailyExpense.Text = expenseTranList.Sum(et => et.Amount).ToString();
        }

        private void btnDownloadDaily_Click(object sender, EventArgs e)
        {
            GetReportBL obj = new GetReportBL();
            var incomeTranlist = obj.GetDailyIncomeReport(System.DateTime.Now);
            ExpenseTransactionBL expenTran = new ExpenseTransactionBL();
            var expenseTranList = expenTran.GetDailyExpenseTransaction(DateTime.Now);

            using (var textWriter = File.CreateText(@"C:\Projects\iFun\Reports\DailyReport\IncomeTransaction.csv"))
            {
                foreach (var line in TOCSV.ToCsv(incomeTranlist))
                {
                    textWriter.WriteLine(line);
                }
            }

            using (var textWriter = File.CreateText(@"C:\Projects\iFun\Reports\DailyReport\ExpenseTransaction.csv"))
            {
                foreach (var line in TOCSV.ToCsv(expenseTranList))
                {
                    textWriter.WriteLine(line);
                }
            }

        }

        
    }
}
