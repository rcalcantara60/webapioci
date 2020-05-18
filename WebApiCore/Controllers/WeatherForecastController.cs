using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiCore.Controllers
{
    public class TipoIndicador
    {
        public int Cod_Tipo_Indicador { get; set; }
        public string Nom_Tipo_Indicador { get; set; }
    }
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Hosts Get()
        {
            var rng = new Random();
            Hosts hosts = new Hosts();

            hosts.WeatherForecasts = new List<WeatherForecast>();

            hosts.WeatherForecasts.AddRange(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray());

            hosts.Hostid = "ABC";

            return hosts;
            //List<TipoIndicador> retorno;
            //using (var connection = new Oracle.ManagedDataAccess.Client.OracleConnection("DATA SOURCE=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS =(PROTOCOL = TCP)(Host = 172.30.8.18)(Port = 1521)))(CONNECT_DATA = (SID = hml02)));PASSWORD=usu_arquivo_transparenciahml02;PERSIST SECURITY INFO=True;POOLING=False;USER ID=usu_arquivo_transparencia"))
            //{
            //    retorno = connection.Query<TipoIndicador>("Select * from tipo_indicador").ToList();
            //}

            //return retorno;
        }
    }
}
