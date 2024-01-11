using Microsoft.OpenApi.Models;
using System.ComponentModel.DataAnnotations;

namespace traveland_api.Models
{
    public class Compra
    {
        [Key]
        public int id_compra { get; set; }
        public string data_compra { get; set; }
        public decimal total_compra { get; set; }
        public int UsuarioId { get; set; }
        public Usuarios Usuario { get; set; }
        public int DestinoId { get; set; }
        public Destinos Destino { get; set; }
    }
}
