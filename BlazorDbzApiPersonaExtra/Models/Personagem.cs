using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorDbzApiPersonaExtra.Models
{
    public class Personagem
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }
        [JsonPropertyName("race")]
        public string Raca { get; set; }
        [JsonPropertyName("image")]
        public string Img { get; set; }
    }
}