using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DeityGenerator.Models
{
    public class Deity
    {
        const string ConnectionName = "Default";

        private string _name;
        private string _form;
        private string _role;
        private string _element;
        private string _attribute;
        private string _imagename;

        public string Name
        {
            get{return _name;}
            set{_name = value;}
        }

        public string Form
        {
            get { return _form; }
            set { _form = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public string Element
        {
            get { return _element; }
            set { _element = value; }
        }

        public string Attribute
        {
            get { return _attribute; }
            set { _attribute = value; }
        }

        public string ImageName
        {
            get { return _imagename; }
            set { _imagename = value; }
        }


        public void GenerateDeity()
        {
            Name = ExecuteQuery("dbo.RandomDeityName");
            Form = ExecuteQuery("dbo.RandomDeityForm");
            Element = ExecuteQuery("dbo.RandomDeityElement");
            Attribute = ExecuteQuery("dbo.RandomDeityAttribute");
            ImageName = ExecuteQuery("dbo.RandomDeityImage");
            Role = ExecuteQuery("dbo.RandomDeityRole");
        }

        private string ExecuteQuery(string Query)
        {
            return QueryWithParameters(Query, ConnectionName);            
        }

        private string QueryWithParameters(string query, string Connection)
        {
            DataTable dt = new DataTable();
            string ConnectionString = ConfigurationManager.ConnectionStrings[Connection].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Result";
            param.Direction = ParameterDirection.Output;
            param.Size = 255;
            param.Value = "";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(param);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            conn.Close();
            conn.Dispose();

            if (param.Value != null)
                return param.Value.ToString();
            else
                return "";


        }


    }
}