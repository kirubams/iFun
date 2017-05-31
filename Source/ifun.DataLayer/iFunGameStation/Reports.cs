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
using System.Configuration;

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

            string ReportDownloadPath = ConfigurationManager.AppSettings["ReportDailyDownload"];
            string IncomeTranDownloadPath = ReportDownloadPath + "\\IncomeTransaction_" + System.DateTime.Now.ToLongDateString()+".csv";
            using (var textWriter = File.CreateText(IncomeTranDownloadPath))
            {
                foreach (var line in TOCSV.ToCsv(incomeTranlist))
                {
                    textWriter.WriteLine(line);
                    
                }
            }
            string ExpenseTranDownloadPath = ReportDownloadPath + "\\ExpenseTransaction_" + System.DateTime.Now.ToLongDateString() + ".csv";
            using (var textWriter = File.CreateText(ExpenseTranDownloadPath))
            {
                foreach (var line in TOCSV.ToCsv(expenseTranList))
                {
                    textWriter.WriteLine(line);
                }
            }
            MessageBox.Show("Reports Downloaded to" + ReportDownloadPath);

        }

        
    }
}
