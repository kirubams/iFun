using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFun.DTO;
using ifun.DataLayer;

namespace iFun.BusinessLayer
{
    public class GamePricingBL
    {
        public List<GamePriceDTO> GetGamePrice()
        {
            var lstGamePrices = new List<GamePriceDTO>();
            using (var entities = new iFunEntities())
            {
                foreach (var ent in entities.GamePrices)
                {
                    var gamepriceDTO = new GamePriceDTO();
                    gamepriceDTO.PriceID = ent.PriceID;
                    gamepriceDTO.Game_SystemID = ent.Game_SystemID ?? 1;
                    gamepriceDTO.PlayerNo = ent.PlayerNo ?? 1;
                    gamepriceDTO.Price = ent.Price ?? 0;
                    gamepriceDTO.Minutes = ent.Minutes ?? 30;
                    gamepriceDTO.IndividualPrice = ent.IndividualPrice ?? 0;
                    lstGamePrices.Add(gamepriceDTO);
                }
            }

            return lstGamePrices;
        }

        public bool AddGamePrice(GamePriceDTO gamePriceDTO)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var gamePrice = new GamePrice()
                    {
                        Game_SystemID = gamePriceDTO.Game_SystemID,
                        PlayerNo = gamePriceDTO.PlayerNo,
                        Price = gamePriceDTO.Price,
                        Minutes = gamePriceDTO.Minutes,
                        IndividualPrice = gamePriceDTO.IndividualPrice,
                        CreatedDate = System.DateTime.Now,
                        Createdby = 1
                    };
                    entities.GamePrices.Add(gamePrice);
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

        public bool UpdateGamePrice(GamePriceDTO gamePriceDTO)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var gamePrice = entities.GamePrices.FirstOrDefault(g => g.PriceID == gamePriceDTO.PriceID);

                    gamePrice.Game_SystemID = gamePriceDTO.Game_SystemID;
                    gamePrice.PlayerNo = gamePriceDTO.PlayerNo;
                    gamePrice.Price = gamePriceDTO.Price;
                    gamePrice.Minutes = gamePriceDTO.Minutes;
                    gamePrice.IndividualPrice = gamePriceDTO.IndividualPrice;
                    gamePrice.Modifiedby = 1;
                    gamePrice.ModifiedDate = System.DateTime.Now;
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

        public bool DeleteGamePrice(int priceID)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var gamePrice = entities.GamePrices.FirstOrDefault(g => g.PriceID == priceID);

                    entities.GamePrices.Remove(gamePrice);
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
