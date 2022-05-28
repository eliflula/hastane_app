using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace SametFırın.DAL
{
    public class Helper
    {
        
       
        private const string V = "Data Source=localhost;Initial Catalog=HASTANE;Integrated Security=True;";
        private SqlConnection cn;
        private SqlCommand ctx;
        private DataTable dt;
        private SqlDataAdapter sda;
        private SqlDataReader dr;

        private static Helper helper;

        public static Helper HlpInstance()
        {
            if (helper==null)
            {
                helper = new Helper();
            }

            return helper;
        }



        public bool ExecuteNonQuery(string cmd, SqlParameter[] p, CommandType type = CommandType.StoredProcedure)
        {
            try
            {
                using (cn = new SqlConnection(V))
                {

                    using (ctx = new SqlCommand(cmd, cn))
                    {
                        cn.Open();
                        if (p != null)
                        {
                            ctx.Parameters.AddRange(p);
                        }

                        ctx.CommandType = type;


                        if (ctx.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return false;
        }

       
      
        public DataTable List(string cmd, SqlParameter[] p = null, CommandType type = CommandType.StoredProcedure)
        {
            try
            {
                using (cn = new SqlConnection(V))

                {
                    using (ctx = new SqlCommand(cmd, cn))
                    {
                        if (p != null)
                        {
                            ctx.Parameters.AddRange(p);
                        }



                        ctx.CommandType = type;
                        sda = new SqlDataAdapter(ctx);

                        dt = new DataTable();
                        sda.Fill(dt);
                        
                        if (dt.Rows.Count > 0)
                        {
                            return dt;
                        }
                        else
                        {
                            return null;
                        }

                    }




                }

            }
            catch (Exception)
            {

                throw;
            }


        }
       
        public SqlDataReader Reader(string cmd, SqlParameter[] p = null, CommandType type = CommandType.StoredProcedure)

        {
            try
            {
                cn = new SqlConnection(V);
                cn.Open();
                using (ctx = new SqlCommand(cmd, cn))
                {
                    if (p != null)
                    {
                        ctx.Parameters.AddRange(p);
                    }
                    ctx.CommandType = type;

                    return dr = ctx.ExecuteReader(CommandBehavior.CloseConnection);



                }

                cn.Close();


            }
            catch (Exception)
            {

                throw;
            }



        }


    }
}

















