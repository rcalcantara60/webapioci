using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFull.Controllers
{
    public class Cidade
    {
        public int Cod_Cidade { get; set; }
        public string Nome_Cidade { get; set; }
        public int Populacao { get; set; }
        public string Ambiente { get; set; }
    }
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Cidade> Get()
        {
            //Demo: Unmanaged ODP.NET application that connects to Oracle Autonomous DB

            //Enter user id and password, such as ADMIN user	
            //string conString = "User Id=POC_ARQUITETURA;Password=poc_arquiteturahml04;" +

            ////Enter net service name for data source value
            //"Data Source=bi_high;";

            //using (OracleConnection con = new OracleConnection(conString))
            //{
            //    using (OracleCommand cmd = con.CreateCommand())
            //    {

            //        //Connect descriptor and net service name entry settings are located 
            //        // in tnsnames.ora. Enter the database machine port, hostname/IP, service 
            //        // name, and distinguished name there.
            //        //Wallet settings are located in the sqlnet.ora and can be entered there.

            //        con.Open();

            //        Console.WriteLine("Successfully connected to Oracle Autonomous Database");

            //        //Retrieve database version info
            //        cmd.CommandText = "SELECT * FROM cidade";
            //        OracleDataReader reader = cmd.ExecuteReader();
            //        reader.Read();
            //        Console.WriteLine("Connected to " + reader.GetString(0));

            //    }
            //}
            var env = ConfigurationManager.AppSettings["ambiente"];
            List<Cidade> retorno = new List<Cidade> { new Cidade { Cod_Cidade = 1, Nome_Cidade = "BH", Populacao = 12345, Ambiente = env } };
            //using (var connection = new OracleConnection("DATA SOURCE=;PASSWORD=poc_arquiteturahml04;USER ID=POC_ARQUITETURA"))
            //{
            //    retorno = connection.Query<Cidade>("Select * from cidade").ToList();                
            //}

            return retorno;
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
