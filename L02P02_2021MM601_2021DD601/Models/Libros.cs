using System.ComponentModel.DataAnnotations;

namespace L02P02_2021MM601_2021DD601.Models
{
    public class Libros
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "nombre del libro")]
        public string nombre { get; set; }
        [Display(Name = "descripcion")]
        public string descripcion { get; set; }
        [Display(Name = "url_imagen")]
        public string url_imagen { get; set; }
        [Display(Name = "id_autor")]
        public int id_autor { get; set; }
        [Display(Name = "id_categoria")]
        public int id_categoria { get; set; }
        [Display(Name = "precio")]
        public decimal precio { get; set; }
        [Display(Name = "estado")]
        public string estado { get; set; }
    }
}
