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
   public class DoctorBL : IBusiness<Doctor>
    {


        Helper _hlp = Helper.HlpInstance();


        public bool Add(Doctor instance)
        {

            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ADI",instance.Name), 
                    new SqlParameter("SOYADI",instance.Surname), 
                    new SqlParameter("POLID",instance.PolId), 

                };
                if (_hlp.ExecuteNonQuery("DOCTOR_Add",p))
                {
                    return true;
                }
                


            }
            catch (Exception e)
            {
                
            }

            return false;

        }

        public bool Delete(Doctor instance)
        {
            throw new NotImplementedException();
        }

        public bool Update(Doctor instance)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> getList()
        {
            throw new NotImplementedException();
        }
        public DataTable getList(int PolID)
        {
            DataTable dt=new DataTable();
            try
            {

                SqlParameter[] p =
                {
                    new SqlParameter("@POLID",PolID), 
                };

                SqlDataReader rd =_hlp.Reader("DOKTOR_List", p);

                dt.Load(rd);
                return dt;

            }
            catch (Exception e)
            {
                


            }

            return dt;

        }
    }
}
