using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifun.DataLayer;
using iFun.DTO;
namespace iFun.BusinessLayer
{
    public class ExpensesBL
    {
        public List<ExpensesDTO> GetExpenses()
        {
            var lstExpenses = new List<ExpensesDTO>();
            using (var entities = new iFunEntities())
            {
                foreach (var ent in entities.Expenses)
                {
                    var expenseDTO = new ExpensesDTO();
                    expenseDTO.ExpenseID = ent.ExpenseID;
                    expenseDTO.Description = ent.Description;
                    expenseDTO.Amount = ent.Amount ?? 00;
                    lstExpenses.Add(expenseDTO);
                }
            }

            return lstExpenses;
        }

            public bool AddExpenses(ExpensesDTO expensesDTO)
            {
                var flag = true;
                try
                {
                    using (var entities = new iFunEntities())
                    {
                        var expense = new Expens()
                        {
                            Description = expensesDTO.Description,
                            Amount = expensesDTO.Amount,
                            CreatedDate = System.DateTime.Now,
                            Createdby = 1
                        };
                        entities.Expenses.Add(expense);
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

            public bool DeleteExpenses(int expenseID)
            {
                var flag = true;
                try
                {
                    using (var entities = new iFunEntities())
                    {
                        entities.Expenses.Remove(entities.Expenses.Where(g => g.ExpenseID == expenseID).FirstOrDefault());
                        entities.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    flag = false;
                    throw ex;
                }

                return flag;

            }

            public bool UpdateExpenses(ExpensesDTO expensesDTO)
            {
                var flag = true;
                try
                {
                    using (var entities = new iFunEntities())
                    {
                        var Gamesys = entities.Expenses.Where(g => g.ExpenseID == expensesDTO.ExpenseID).FirstOrDefault();
                        Gamesys.Description = expensesDTO.Description;
                        Gamesys.Amount = expensesDTO.Amount;
                        Gamesys.Modifiedby = 1;
                        Gamesys.ModifiedDate = System.DateTime.Now;
                        entities.SaveChanges();
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
