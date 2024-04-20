using System.ComponentModel.DataAnnotations;

namespace L02P02_2021MM601_2021DD601.Models
{
    public class Autores
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Nombre del autor")]
        public string autor {  get; set; }
    }
}
