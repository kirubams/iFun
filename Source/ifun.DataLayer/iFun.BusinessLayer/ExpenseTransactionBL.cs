using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFun.DTO;
using ifun.DataLayer;

namespace iFun.BusinessLayer
{
    public class ExpenseTransactionBL
    {
        public List<ExpenseTransactionDTO> GetExpenseTransaction()
        {
            var lstExpenseTransaction = new List<ExpenseTransactionDTO>();
            using (var entities = new iFunEntities())
            {
                foreach (var ent in entities.ExpenseTransactions)
                {
                    var expenseTransactionDTO = new ExpenseTransactionDTO();
                    expenseTransactionDTO.ExpenseTransactionID = ent.ExpenseTransactionID;
                    expenseTransactionDTO.ExpenseID = ent.ExpenseID ?? 0;
                    expenseTransactionDTO.Comments = ent.Comments;
                    expenseTransactionDTO.Amount = ent.Amount ?? 0;
                    lstExpenseTransaction.Add(expenseTransactionDTO);
                }
            }

            return lstExpenseTransaction;
        }

        public List<ExpenseTransactionDTO> GetDailyExpenseTransaction(DateTime reportDate)
        {
            var lstExpenseTransaction = new List<ExpenseTransactionDTO>();
            using (var entities = new iFunEntities())
            {
                var results = entities.GetDailyExpenseTransaction_SP(reportDate);
                foreach (var ent in results)
                {
                    var expenseTransactionDTO = new ExpenseTransactionDTO();
                    expenseTransactionDTO.ExpenseTransactionID = ent.ExpenseTransactionID;
                    expenseTransactionDTO.ExpenseID = ent.ExpenseID ?? 0;
                    expenseTransactionDTO.Comments = ent.Comments;
                    expenseTransactionDTO.Amount = ent.Amount ?? 0;
                    expenseTransactionDTO.ExpenseDescription = ent.Description;
                    expenseTransactionDTO.CreatedDate = ent.CreatedDate ?? DateTime.Now;
                    lstExpenseTransaction.Add(expenseTransactionDTO);
                }
            }

            return lstExpenseTransaction;
        }

        public bool AddExpenseTransaction(ExpenseTransactionDTO expenseTransactionDTO)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var expenseTransaction = new ExpenseTransaction()
                    {
                        ExpenseID = expenseTransactionDTO.ExpenseID,
                        Comments = expenseTransactionDTO.Comments,
                        Amount = expenseTransactionDTO.Amount,
                        CreatedDate = System.DateTime.Now,
                        Createdby = 1
                    };
                    entities.ExpenseTransactions.Add(expenseTransaction);
                    entities.SaveChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                throw ex;
            }

            return flag;

        }

        public bool UpdateExpenseTransaction(ExpenseTransactionDTO expenseTransactionDTO)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var expenseTran = entities.ExpenseTransactions.FirstOrDefault(g => g.ExpenseTransactionID == expenseTransactionDTO.ExpenseTransactionID);

                    expenseTran.ExpenseTransactionID = expenseTransactionDTO.ExpenseTransactionID;
                    expenseTran.Comments = expenseTransactionDTO.Comments;
                    expenseTran.Amount = expenseTransactionDTO.Amount;
                    expenseTran.Modifiedby = 1;
                    expenseTran.ModifiedDate = System.DateTime.Now;
                    entities.SaveChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                throw ex;
            }

            return flag;

        }

        public bool DeleteExpenseTransaction(int expenseTransactionID)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var expenseTran = entities.ExpenseTransactions.FirstOrDefault(g => g.ExpenseTransactionID == expenseTransactionID);

                    entities.ExpenseTransactions.Remove(expenseTran);
                    entities.SaveChanges();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                throw ex;
            }

            return flag;

        }
    }
}
