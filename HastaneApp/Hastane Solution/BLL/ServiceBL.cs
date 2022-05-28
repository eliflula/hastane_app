using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using SametFırın.DAL;

namespace BLL
{
    public class ServiceBL : IBusiness<Service>
    {
        Helper _hlp = Helper.HlpInstance();

        public DataTable List()
        {

            try
            {

                return _hlp.List("POLIKLINIK_List");


            }
            catch (Exception e)
            {
                throw;
            }




        }

        public bool Add(Service instance)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ADI",instance.ADI),
                    new SqlParameter("@ADRES",instance.ADRES), 
                };

                if (_hlp.ExecuteNonQuery("POLI_Add",p))
                {
                    return true;
                }


            }
            catch (Exception e)
            {
              
                throw;
            }

            return false;
        }

        public bool Delete(Service instance)
        {
            throw new NotImplementedException();
        }

        public bool Update(Service instance)
        {
            throw new NotImplementedException();
        }

        public List<Service> getList()
        {
            throw new NotImplementedException();
        }
    }
}
