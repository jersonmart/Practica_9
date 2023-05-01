using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Practica_9.Models
{
    public class equipos
    {
        [Key]
        [Display(Name = "ID")]
        public int id_equipos { get; set; }

        [Display(Name = "Nombre")]
        public string? nombre { get; set; }

        [Display(Name = "Descripcion")]
        public string? descripcion { get; set; }

        [Display(Name = "ID")]
        public int? tipo_equipo_id { get; set; }

        [Display(Name = "ID Marcas")]
        public int? marca_id { get; set; }

        [Display(Name = "Modelo")]
        public string? modelo { get; set; }

        [Display(Name = "Año de compra")]
        public int? anio_compra { get; set; }

        [Display(Name = "Costo")]
        public decimal? costo { get; set; }

        [Display(Name = "Vida Util")]
        public int? vida_util { get; set; }

        [Display(Name = "Estado equipo")]
        public int? estados_equipo { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
