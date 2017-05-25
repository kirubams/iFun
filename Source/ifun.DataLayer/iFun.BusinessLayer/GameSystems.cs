using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ifun.DataLayer;
using iFun.DTO;

namespace iFun.BusinessLayer
{
    public class GameSystems
    {
        public List<Gamesystem> GetGameSystems()
        {
            var lstGameSystems = new List<Gamesystem>();
            using (var entities = new iFunEntities())
            {
                lstGameSystems = entities.Gamesystems.ToList();
            }

            return lstGameSystems;
        }

        public bool AddGameSystems(GameSystemsDTO gameSystemDTO)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var gamesystem = new Gamesystem()
                    {
                        Description = gameSystemDTO.Name,
                        ModelNo = gameSystemDTO.ModelNo,
                        CreatedDate = System.DateTime.Now,
                        Createdby = 1
                    };
                    entities.Gamesystems.Add(gamesystem);
                    entities.SaveChanges();
                    flag = true;
                }
            }
            catch(Exception ex)
            {
                flag = false;
                throw ex;
            }

            return flag;
               
        }

        public bool DeleteGameSystems(int gameSystemID)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    entities.Gamesystems.Remove(entities.Gamesystems.Where(g => g.GameSystemID == gameSystemID).FirstOrDefault());
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

        public bool UpdateGameSystems(GameSystemsDTO gameSystemDTO)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var Gamesys = entities.Gamesystems.Where(g => g.GameSystemID == gameSystemDTO.GameSystemID).FirstOrDefault();
                    Gamesys.Description = gameSystemDTO.Name;
                    Gamesys.ModelNo = gameSystemDTO.ModelNo;
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
