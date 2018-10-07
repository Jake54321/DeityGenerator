using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DeityGenerator.Controllers
{    

    public class DatabaseController : ApiController
    {
        const string ConnectionName = "Default";


        //private DataTable ExecuteQuery(string Query, int Seed)
        //{
        //    SqlParameter[] parameters =
        //    {
        //        new SqlParameter("@Seed", SqlDbType.Int) { Value = Seed}
        //    };

        //    return ExecuteParameterQuery(Query, ConnectionName, parameters);
        //}

        //private DataTable ExecuteParameterQuery(string query, string Connection, SqlParameter[] parameters)
        //{
        //    DataTable dt = new DataTable();
        //    string ConnectionString = ConfigurationManager.ConnectionStrings[Connection].ConnectionString;
        //    SqlConnection conn = new SqlConnection(ConnectionString);
        //    conn.Open();

        //    using (SqlCommand cmd = new SqlCommand(query, conn))
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        for (int i = 0; i < parameters.Length; i++)
        //        {
        //            cmd.Parameters.AddWithValue(parameters[i].ParameterName, parameters[i].Value);
        //        }

        //        try
        //        {
        //            using (SqlDataReader rd = cmd.ExecuteReader())
        //            {
        //                dt.Load(rd);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            //
        //        }
        //    }

        //    conn.Close();
        //    conn.Dispose();

        //    return dt;
        //}
    }

}
