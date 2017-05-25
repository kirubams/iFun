using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFun.DTO;
using ifun.DataLayer;

namespace iFun.BusinessLayer
{
    public class GetReportBL
    {
        ///////
        //public List<IncomeTransactionDTO> GetDailyIncomeReport(DateTime ReportDate)
        //{
        //    try
        //    {
        //        List<IncomeTransactionDTO> lstIncomeTran = new List<IncomeTransactionDTO>();
        //        using (var entities = new iFunEntities())
        //        {
        //            var results = entities.GenerateDailyReport_SP(ReportDate);

        //            foreach (var result in results)
        //            {
        //                IncomeTransactionDTO obj = new IncomeTransactionDTO();
        //                obj.noOfPlayers = result.NoofPlayers?? 0;
        //                obj.isManual = 

                        
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
