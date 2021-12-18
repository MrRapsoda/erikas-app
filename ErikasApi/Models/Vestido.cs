using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErikasApi.Models
{
    public class Vestido
    {
        [Key]
        public int idVestidos { get; set; }
        public string codigoV { get; set; }
        public string Nombre { get; set; }
        public string color { get; set; }
        public string tela { get; set; }
        public string Estilo { get; set; }
        public int talla { get; set; }
        public double precio { get; set; }

    }
}
