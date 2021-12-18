using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErikasApi.Models
{
    public class VQuinceanos
    {
        [Key]
        public int idQuinceanos { get; set; }
        public string codigoQ { get; set; }
        public string Nombre { get; set; }
        public string color { get; set; }
        public string ajuste { get; set; }
        public string tela { get; set; }
        public int talla { get; set; }
        public double precio { get; set; }

    }
}
