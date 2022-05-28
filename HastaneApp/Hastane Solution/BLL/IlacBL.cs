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
    public class IlacBL : IBusiness<Ilac>
    {
        Helper _hlp = Helper.HlpInstance();
        public bool Add(Ilac instance)
        {


            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ADI",instance.ADI),
                    new SqlParameter("@ADET",instance.ADET),
                    new SqlParameter("@SERINO",instance.SERINO)
                };

                if (_hlp.ExecuteNonQuery("ILAC_Add", p))
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

        public bool Delete(Ilac instance)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ID",instance.ID),
                };

                if (_hlp.ExecuteNonQuery("ILAC_Delete", p))
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return false;
        }

        public bool Update(Ilac instance)
        {
            throw new NotImplementedException();
        }

        public List<Ilac> getList()
        {
            throw new NotImplementedException();
        }

        public DataTable getIlacs()
        {
            try
            {

                return _hlp.List("ILAC_List");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }

        public DataTable getIlacByName(string Name)
        {

            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ADI",Name),
                };
                SqlDataReader dr = _hlp.Reader("ILAC_ByAD", p);

                dt.Load(dr);
                return dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }


        public DataTable getIlacsByHasta(int hastaid)
        {

            try
            {

                SqlParameter[] p =
                {
                    new SqlParameter("@HASTAID", hastaid),
                };
                SqlDataReader dr = _hlp.Reader("HASTAILAC_ListByID", p);

                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }



    }
}
