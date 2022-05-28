using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using SametFırın.DAL;

namespace BLL
{
    public class PatientBL : IBusiness<PatientInfo>
    {

        private Helper _hlp = Helper.HlpInstance();
        public bool Add(PatientInfo instance)
        {
            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@ADI",instance.Name),
                    new SqlParameter("@SOYADI",instance.LastName),
                    new SqlParameter("@YAS",instance.Age),
                    new SqlParameter("@CINSIYET",instance.Gender),
                    new SqlParameter("@TC",instance.TC),
                    new SqlParameter("@POLID",instance.PolID),
                    new SqlParameter("@DOKTORID",instance.DoktorID),
                    new SqlParameter("@DURUM",instance.Durum)

                };

                if (_hlp.ExecuteNonQuery("HASTA_Add", p, CommandType.StoredProcedure))
                {
                    return true;
                }



            }
            catch (Exception e)
            {


            }



            return false;

        }

        public bool Delete(PatientInfo instance)
        {
            try
            {

                SqlParameter[] p =
                {
                    new SqlParameter("@TC",instance.TC),
                };

                if (_hlp.ExecuteNonQuery("HASTA_Delete", p))
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

        public bool Update(PatientInfo instance)
        {
            throw new NotImplementedException();
        }

        public List<PatientInfo> getList()
        {


            throw new NotImplementedException();
        }

        public DataTable getPatientInfo(string TCno)
        {

            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@TC",TCno),
                };

                return _hlp.List("HASTA_ByID", p);


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public DataTable getAllPatient()
        {
            DataTable dt = null;
            try
            {
                dt = _hlp.List("HASTA_List");



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return dt;
        }

        public bool HastaIlacEkle( int hastaId, int ilacId, int adet)
        {

            try
            {
                SqlParameter[] p =
                {
                    new SqlParameter("@HASTAID",hastaId),
                    new SqlParameter("ILACID",ilacId),
                    new SqlParameter("@ADET",adet), 
                };
                if (_hlp.ExecuteNonQuery("HASTAILAC_Add",p))
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
    }
}
