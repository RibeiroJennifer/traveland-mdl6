using Microsoft.OpenApi.Models;
using System.ComponentModel.DataAnnotations;

namespace traveland_api.Models
{
    public class Usuarios
    {
        [Key]
        public int id_usuario { get; set; }
        public string nome_usuario { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

    }
}
