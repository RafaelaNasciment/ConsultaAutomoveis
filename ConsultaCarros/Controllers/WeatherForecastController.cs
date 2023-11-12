using Microsoft.AspNetCore.Mvc;

namespace ConsultaCarros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ParallelumRepository parallelumRepository = new ParallelumRepository();

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

       // [HttpGet(Name = "GetMarca")]
        [HttpGet("GetMarca")]
        public async Task<List<ParallelumDto>> Get()
        {
            var marcas = await parallelumRepository.ConsultaMarca();

            return marcas;
        }


       // [HttpGet(Name = "GetModel")]
        [HttpGet("GetModel")]
        public async Task<ParallelumModelos> GetModelo(string codigoMarca)
        {
            var marcas = await parallelumRepository.ConsultaModelos(codigoMarca);

            return marcas;
        }
    }
}   