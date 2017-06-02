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

        public List<IncomeTransactionDTO> GetIncomeReport(DateTime ReportDate, string mode)
        {
            try
            {
                List<IncomeTransactionDTO> lstIncomeTran = new List<IncomeTransactionDTO>();
                using (var entities = new iFunEntities())
                {
                    //System.Data.Entity.Core.Objects.ObjectResult<GenerateDailyReport_SP1_Result> results = null;
                    if (mode == "DAILY")
                    { 
                         var results = entities.GenerateDailyReport_SP1(ReportDate);
                        foreach (var result in results)
                        {
                            IncomeTransactionDTO obj = new IncomeTransactionDTO();
                            obj.noOfPlayers = result.NoofPlayers ?? 0;
                            obj.isManual = result.isManual ?? false;
                            obj.ManualPrice = result.ManualPrice ?? 0;
                            obj.Comments = result.ReasonForManualPrice;
                            obj.CreatedDate = result.CreatedDate ?? System.DateTime.Now;
                            obj.FinalPrice = result.FinalPrice ?? 0;
                            obj.Game_SystemID = result.Game_SystemID ?? 0;
                            obj.GameSystemDescription = result.Description;
                            obj.SystemOrderId = result.SystemOrderId ?? 0;
                            obj.Minutes = result.Minutes ?? 0;
                            lstIncomeTran.Add(obj);
                        }
                    }
                    else if(mode == "MONTHLY")
                    {
                        var results = entities.GenerateMonthlyReport_SP(ReportDate);
                        foreach (var result in results)
                        {
                            IncomeTransactionDTO obj = new IncomeTransactionDTO();
                            obj.noOfPlayers = result.NoofPlayers ?? 0;
                            obj.isManual = result.isManual ?? false;
                            obj.ManualPrice = result.ManualPrice ?? 0;
                            obj.Comments = result.ReasonForManualPrice;
                            obj.CreatedDate = result.CreatedDate ?? System.DateTime.Now;
                            obj.FinalPrice = result.FinalPrice ?? 0;
                            obj.Game_SystemID = result.Game_SystemID ?? 0;
                            obj.GameSystemDescription = result.Description;
                            obj.SystemOrderId = result.SystemOrderId ?? 0;
                            obj.Minutes = result.Minutes ?? 0;
                            lstIncomeTran.Add(obj);
                        }
                    }
                    else if(mode == "YEARLY")
                    {
                        var results = entities.GenerateYearlyReport_SP(ReportDate);
                        foreach (var result in results)
                        {
                            IncomeTransactionDTO obj = new IncomeTransactionDTO();
                            obj.noOfPlayers = result.NoofPlayers ?? 0;
                            obj.isManual = result.isManual ?? false;
                            obj.ManualPrice = result.ManualPrice ?? 0;
                            obj.Comments = result.ReasonForManualPrice;
                            obj.CreatedDate = result.CreatedDate ?? System.DateTime.Now;
                            obj.FinalPrice = result.FinalPrice ?? 0;
                            obj.Game_SystemID = result.Game_SystemID ?? 0;
                            obj.GameSystemDescription = result.Description;
                            obj.SystemOrderId = result.SystemOrderId ?? 0;
                            obj.Minutes = result.Minutes ?? 0;
                            lstIncomeTran.Add(obj);
                        }

                    }
                    
                    return lstIncomeTran;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
