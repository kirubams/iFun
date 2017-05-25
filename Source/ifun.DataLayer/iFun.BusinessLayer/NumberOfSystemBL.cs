using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iFun.DTO;
using ifun.DataLayer;


namespace iFun.BusinessLayer
{
    public class NumberOfSystemBL
    {
        public List<NumberOfSystemDTO> GetNumberOfSystem()
        {
            var lstNumberofSystem = new List<NumberOfSystemDTO>();
            using (var entities = new iFunEntities())
            {
                foreach (var ent in entities.NumberOfSystems)
                {
                    var numberOfSystemDTO = new NumberOfSystemDTO();
                    numberOfSystemDTO.ID = ent.ID;
                    numberOfSystemDTO.Game_SystemID = ent.Game_SystemID ?? 0;
                    numberOfSystemDTO.SystemOrderId = ent.SystemOrderId ?? 0;
                   lstNumberofSystem.Add(numberOfSystemDTO);
                }
            }

            return lstNumberofSystem;
        }

        public bool AddNumberOfSystem(NumberOfSystemDTO numberOfSystemDTO)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var numberOfSystem = new NumberOfSystem()
                    {
                        Game_SystemID = numberOfSystemDTO.Game_SystemID,
                        SystemOrderId = numberOfSystemDTO.SystemOrderId,
                        CreatedDate = System.DateTime.Now,
                        Createdby = 1
                    };
                    entities.NumberOfSystems.Add(numberOfSystem);
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

        public bool UpdateNumberOfSystems(NumberOfSystemDTO numberOfSystemDTO)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var numberOfSystems = entities.NumberOfSystems.FirstOrDefault(g => g.ID == numberOfSystemDTO.ID);

                    numberOfSystems.Game_SystemID = numberOfSystemDTO.Game_SystemID;
                    numberOfSystems.SystemOrderId = numberOfSystemDTO.SystemOrderId;
                    numberOfSystems.Modifiedby = 1;
                    numberOfSystems.ModifiedDate = System.DateTime.Now;
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

        public bool DeleteNumberOfSystems(int ID)
        {
            var flag = true;
            try
            {
                using (var entities = new iFunEntities())
                {
                    var numberOfSystems = entities.NumberOfSystems.FirstOrDefault(g => g.ID == ID);

                    entities.NumberOfSystems.Remove(numberOfSystems);
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
