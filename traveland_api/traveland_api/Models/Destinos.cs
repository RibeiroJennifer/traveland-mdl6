using Microsoft.OpenApi.Models;
using System.ComponentModel.DataAnnotations;

namespace traveland_api.Models
{
    public class Destinos
    {
        [Key]
        public int id_destino { get; set; }
        public string nome_destino { get; set; }
        public string pais { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string data_ida{ get; set; }
        public string data_volta { get; set; }
        public decimal preco { get; set; }

    }
}
