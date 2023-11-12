using Newtonsoft.Json;
using System.Text.Json;

namespace ConsultaCarros
{
    public class ParallelumDto
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }


        [JsonProperty("nome")]
        public string Nome { get; set; }
    }

    public class ParallelumModelos
    {
        [JsonProperty("modelos")]
        public List<ParallelumDto> Modelos { get; set; }

        [JsonProperty("anos")]
        public List<ParallelumDto> Anos { get; set; }

    }
}
