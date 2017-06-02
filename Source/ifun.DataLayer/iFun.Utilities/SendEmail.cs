using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace iFun.Utilities
{
    public class SendEmail
    {
        public void send(string senderemail, string receiveremail, string subject, string body, string attachmentpath, string date, string mode )
        {
            //Detailed Method
            try
            {
                MailAddress mailfrom = new MailAddress(senderemail);
                MailAddress mailto = new MailAddress(receiveremail);
                MailMessage newmsg = new MailMessage(mailfrom, mailto);

                newmsg.Subject = subject;
                newmsg.Body = body;

                //For File Attachment, more file can also be attached
                string incomepath = "";
                string expensepath = "";
                if (mode == "DAILY")
                {
                    incomepath = attachmentpath + "\\IncomeTransaction_Daily" + date + ".csv";
                    expensepath = attachmentpath + "\\ExpenseTransaction_Daily" + date + ".csv";
                }
                else if (mode == "MONTHLY")
                {
                    incomepath = attachmentpath + "\\IncomeTransaction_Monthly" + date + ".csv";
                    expensepath = attachmentpath + "\\ExpenseTransaction_Monthly" + date + ".csv";
                }
                else if(mode == "YEARLY")
                {
                    incomepath = attachmentpath + "\\IncomeTransaction_Yearly" + date + ".csv";
                    expensepath = attachmentpath + "\\ExpenseTransaction_Yearly" + date + ".csv";
                }
                Attachment att1 = new Attachment(incomepath);
                Attachment att2 = new Attachment(expensepath);
                newmsg.Attachments.Add(att1);
                newmsg.Attachments.Add(att2);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(senderemail, "nandhu1984");
                smtp.EnableSsl = true;
                smtp.Send(newmsg);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
