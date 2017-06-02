using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFun.DTO;
using ifun.DataLayer;

namespace iFun.BusinessLayer
{
    public class IncomeTransactionBL
    {
        public IncomeTransactionDTO GetPrice(IncomeTransactionDTO incomeTranDTO)
        {
            IncomeTransactionDTO flagIncomeTran = new IncomeTransactionDTO();
            try
            {
                using (var entities = new iFunEntities())
                {
                    var noOfSystems = entities.NumberOfSystems.FirstOrDefault(n => n.SystemOrderId == incomeTranDTO.SystemOrderId);
                    int gamesysId = Convert.ToInt32(noOfSystems.Game_SystemID);
                    int it = 0;
                    flagIncomeTran.Game_SystemID = gamesysId;
                    List<GamePrice> lstGamePrice = new List<GamePrice>();
                    for(it= incomeTranDTO.noOfPlayers; it >= 1; it--)
                    {
                        var gamePriceForPl = entities.GamePrices.Where(
                        i => i.Game_SystemID == gamesysId
                        &&
                        i.PlayerNo == it
                        &&
                        i.Minutes == incomeTranDTO.Minutes
                        ).FirstOrDefault();
                        lstGamePrice.Add(gamePriceForPl);
                    }
                    if (incomeTranDTO.isIndividual)
                    {
                        flagIncomeTran.FinalPrice = lstGamePrice.Sum(g => g.IndividualPrice) ?? 00;
                    }
                    else
                    {
                        flagIncomeTran.FinalPrice = lstGamePrice.Sum(g => g.Price) ?? 00;
                    }


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return flagIncomeTran;
        }

        public int GetGameSystemId(int SystemOrderId)
        {
            int gamesysId = 0;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var noOfSystems = entities.NumberOfSystems.FirstOrDefault(n => n.SystemOrderId == SystemOrderId);
                    gamesysId = Convert.ToInt32(noOfSystems.Game_SystemID);
                  
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return gamesysId;

        }

        public bool SavePrice(IncomeTransactionDTO incomeTranDTO)
        {
            var flag = true;
            try
            {
                IncomeTransaction obj = new IncomeTransaction();
                obj.Game_SystemID = incomeTranDTO.Game_SystemID;
                obj.NoofPlayers = incomeTranDTO.noOfPlayers;
                obj.isIndividual = incomeTranDTO.isIndividual;
                obj.isManual = incomeTranDTO.isManual;
                obj.ManualPrice = incomeTranDTO.ManualPrice;
                obj.ReasonForManualPrice = incomeTranDTO.Comments;
                obj.CreatedDate = System.DateTime.Now;
                obj.Createdby = 1;
                obj.FinalPrice = incomeTranDTO.FinalPrice;
                obj.Minutes = incomeTranDTO.Minutes;
                obj.SystemOrderId = incomeTranDTO.SystemOrderId;

                using (var entities = new iFunEntities())
                {
                    entities.IncomeTransactions.Add(obj);
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
