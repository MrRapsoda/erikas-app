using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErikasApi.Models
{
    public class Trajes2
    {
        [Key]
        public int idTraje { get; set; }
        public string CodigoT { get; set; }
        public string Nombre { get; set; }
        public string Tela { get; set; }
        public string Ajuste { get; set; }
        public int Talla { get; set; }
        public double Precio { get; set; }
     
    }
}
