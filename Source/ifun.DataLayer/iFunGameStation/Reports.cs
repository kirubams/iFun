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
            var incomeTranlist = obj.GetIncomeReport(Convert.ToDateTime(datePicker.Text), "DAILY");
            lblDailyIncome.Text = incomeTranlist.Sum(x => x.FinalPrice).ToString();
            ExpenseTransactionBL expenTran = new ExpenseTransactionBL();
            var expenseTranList = expenTran.GetExpenseTransaction(Convert.ToDateTime(datePicker.Text), "DAILY");
            lblDailyExpense.Text = expenseTranList.Sum(et => et.Amount).ToString();
        }

        private void btnDownloadDaily_Click(object sender, EventArgs e)
        {
            GetReportBL obj = new GetReportBL();
            var incomeTranlist = obj.GetIncomeReport(Convert.ToDateTime(datePicker.Text), "DAILY");
            ExpenseTransactionBL expenTran = new ExpenseTransactionBL();
            var expenseTranList = expenTran.GetExpenseTransaction(Convert.ToDateTime(datePicker.Text), "DAILY");

            string ReportDownloadPath = ConfigurationManager.AppSettings["ReportDailyDownload"];
            string IncomeTranDownloadPath = ReportDownloadPath + "\\IncomeTransaction_Daily" + Convert.ToDateTime(datePicker.Text).ToLongDateString()+".csv";
            using (var textWriter = File.CreateText(IncomeTranDownloadPath))
            {
                
                string header = "IncomeTransactionID,SystemOrderId,Minutes,Game_SystemID,noOfPlayers,isIndividual,isManual,ManualPrice,Comments,FinalPrice,Createdby,GameSystemDescription,CreatedDate";
                textWriter.WriteLine(header);
                foreach (var line in TOCSV.ToCsv(incomeTranlist))
                {
                    textWriter.WriteLine(line);
                    
                }
            }
            string ExpenseTranDownloadPath = ReportDownloadPath + "\\ExpenseTransaction_Daily" + Convert.ToDateTime(datePicker.Text).ToLongDateString() + ".csv";
            using (var textWriter = File.CreateText(ExpenseTranDownloadPath))
            {
                string header = "ExpenseTransactionID,ExpenseID,Comments,Amount,CreatedDate,CreatedBy,ExpenseDescription";
                textWriter.WriteLine(header);
                foreach (var line in TOCSV.ToCsv(expenseTranList))
                {
                    textWriter.WriteLine(line);
                }
            }
            MessageBox.Show("Reports Downloaded to" + ReportDownloadPath);

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string ReportDownloadPath = ConfigurationManager.AppSettings["ReportDailyDownload"];
            SendEmail email = new SendEmail();
            string senderEmail = ConfigurationManager.AppSettings["SenderEmail"];
            string receiverEmail = ConfigurationManager.AppSettings["ReceiverEmail"];
            string Body = ConfigurationManager.AppSettings["BodyForDaily"] + Convert.ToDateTime(datePicker.Text).ToLongDateString();
            string Subject = ConfigurationManager.AppSettings["SubjectForDaily"]+ Convert.ToDateTime(datePicker.Text).ToLongDateString();
            email.send(senderEmail, receiverEmail, Subject, Body, ReportDownloadPath, Convert.ToDateTime(datePicker.Text).ToLongDateString(), "DAILY");
            MessageBox.Show("Email Sent to " + receiverEmail);

        }

        private void btnGetMonthlyIncome_Click(object sender, EventArgs e)
        {
            GetReportBL obj = new GetReportBL();
            var incomeTranlist = obj.GetIncomeReport(Convert.ToDateTime(datePickerMonthly.Text), "MONTHLY");
            lblIncomeMonthly.Text = incomeTranlist.Sum(x => x.FinalPrice).ToString();
            ExpenseTransactionBL expenTran = new ExpenseTransactionBL();
            var expenseTranList = expenTran.GetExpenseTransaction(Convert.ToDateTime(datePickerMonthly.Text), "MONTHLY");
            lblExpenseMonthly.Text = expenseTranList.Sum(et => et.Amount).ToString();
        }

        private void btnDownloadMonthly_Click(object sender, EventArgs e)
        {
            GetReportBL obj = new GetReportBL();
            var incomeTranlist = obj.GetIncomeReport(Convert.ToDateTime(datePickerMonthly.Text), "MONTHLY");
            ExpenseTransactionBL expenTran = new ExpenseTransactionBL();
            var expenseTranList = expenTran.GetExpenseTransaction(Convert.ToDateTime(datePickerMonthly.Text), "MONTHLY");

            string ReportDownloadPath = ConfigurationManager.AppSettings["ReportDailyDownload"];
            string IncomeTranDownloadPath = ReportDownloadPath + "\\IncomeTransaction_Monthly" + Convert.ToDateTime(datePickerMonthly.Text).ToLongDateString() + ".csv";
            using (var textWriter = File.CreateText(IncomeTranDownloadPath))
            {

                string header = "IncomeTransactionID,SystemOrderId,Minutes,Game_SystemID,noOfPlayers,isIndividual,isManual,ManualPrice,Comments,FinalPrice,Createdby,GameSystemDescription,CreatedDate";
                textWriter.WriteLine(header);
                foreach (var line in TOCSV.ToCsv(incomeTranlist))
                {
                    textWriter.WriteLine(line);

                }
            }
            string ExpenseTranDownloadPath = ReportDownloadPath + "\\ExpenseTransaction_Monthly" + Convert.ToDateTime(datePickerMonthly.Text).ToLongDateString() + ".csv";
            using (var textWriter = File.CreateText(ExpenseTranDownloadPath))
            {
                string header = "ExpenseTransactionID,ExpenseID,Comments,Amount,CreatedDate,CreatedBy,ExpenseDescription";
                textWriter.WriteLine(header);
                foreach (var line in TOCSV.ToCsv(expenseTranList))
                {
                    textWriter.WriteLine(line);
                }
            }
            MessageBox.Show("Reports Downloaded to" + ReportDownloadPath);

        }

        private void btnReportMonthly_Click(object sender, EventArgs e)
        {
            string ReportDownloadPath = ConfigurationManager.AppSettings["ReportDailyDownload"];
            SendEmail email = new SendEmail();
            string senderEmail = ConfigurationManager.AppSettings["SenderEmail"];
            string receiverEmail = ConfigurationManager.AppSettings["ReceiverEmail"];
            string Body = ConfigurationManager.AppSettings["BodyForMonthly"] + Convert.ToDateTime(datePickerMonthly.Text).ToLongDateString();
            string Subject = ConfigurationManager.AppSettings["SubjectForMonthly"] + Convert.ToDateTime(datePickerMonthly.Text).ToLongDateString();
            email.send(senderEmail, receiverEmail, Subject, Body, ReportDownloadPath, Convert.ToDateTime(datePickerMonthly.Text).ToLongDateString(), "MONTHLY");
            MessageBox.Show("Email Sent to " + receiverEmail);
        }

        private void btnGetYearlyIncome_Click(object sender, EventArgs e)
        {
            GetReportBL obj = new GetReportBL();
            var incomeTranlist = obj.GetIncomeReport(Convert.ToDateTime(datePickerYearly.Text), "YEARLY");
            lblIncomeYearly.Text = incomeTranlist.Sum(x => x.FinalPrice).ToString();
            ExpenseTransactionBL expenTran = new ExpenseTransactionBL();
            var expenseTranList = expenTran.GetExpenseTransaction(Convert.ToDateTime(datePickerYearly.Text), "YEARLY");
            lblExpenseYearly.Text = expenseTranList.Sum(et => et.Amount).ToString();
        }

        private void btnDownloadYearly_Click(object sender, EventArgs e)
        {
            GetReportBL obj = new GetReportBL();
            var incomeTranlist = obj.GetIncomeReport(Convert.ToDateTime(datePickerYearly.Text), "YEARLY");
            ExpenseTransactionBL expenTran = new ExpenseTransactionBL();
            var expenseTranList = expenTran.GetExpenseTransaction(Convert.ToDateTime(datePickerYearly.Text), "YEARLY");

            string ReportDownloadPath = ConfigurationManager.AppSettings["ReportDailyDownload"];
            string IncomeTranDownloadPath = ReportDownloadPath + "\\IncomeTransaction_Yearly" + Convert.ToDateTime(datePickerYearly.Text).ToLongDateString() + ".csv";
            using (var textWriter = File.CreateText(IncomeTranDownloadPath))
            {

                string header = "IncomeTransactionID,SystemOrderId,Minutes,Game_SystemID,noOfPlayers,isIndividual,isManual,ManualPrice,Comments,FinalPrice,Createdby,GameSystemDescription,CreatedDate";
                textWriter.WriteLine(header);
                foreach (var line in TOCSV.ToCsv(incomeTranlist))
                {
                    textWriter.WriteLine(line);

                }
            }
            string ExpenseTranDownloadPath = ReportDownloadPath + "\\ExpenseTransaction_Yearly" + Convert.ToDateTime(datePickerYearly.Text).ToLongDateString() + ".csv";
            using (var textWriter = File.CreateText(ExpenseTranDownloadPath))
            {
                string header = "ExpenseTransactionID,ExpenseID,Comments,Amount,CreatedDate,CreatedBy,ExpenseDescription";
                textWriter.WriteLine(header);
                foreach (var line in TOCSV.ToCsv(expenseTranList))
                {
                    textWriter.WriteLine(line);
                }
            }
            MessageBox.Show("Reports Downloaded to" + ReportDownloadPath);
        }

        private void btnReportYearly_Click(object sender, EventArgs e)
        {
            string ReportDownloadPath = ConfigurationManager.AppSettings["ReportDailyDownload"];
            SendEmail email = new SendEmail();
            string senderEmail = ConfigurationManager.AppSettings["SenderEmail"];
            string receiverEmail = ConfigurationManager.AppSettings["ReceiverEmail"];
            string Body = ConfigurationManager.AppSettings["BodyForYearly"] + Convert.ToDateTime(datePickerYearly.Text).ToLongDateString();
            string Subject = ConfigurationManager.AppSettings["SubjectForYearly"] + Convert.ToDateTime(datePickerYearly.Text).ToLongDateString();
            email.send(senderEmail, receiverEmail, Subject, Body, ReportDownloadPath, Convert.ToDateTime(datePickerYearly.Text).ToLongDateString(), "YEARLY");
            MessageBox.Show("Email Sent to " + receiverEmail);
        }
    }
}
