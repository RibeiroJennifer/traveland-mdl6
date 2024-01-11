using Microsoft.OpenApi.Models;
using System.ComponentModel.DataAnnotations;

namespace traveland_api.Models
{
    public class Contato
    { 
        [Key]
        public int id_contato { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string mensagem { get; set; }

    }
}
