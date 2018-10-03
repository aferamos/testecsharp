using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matamata.Models
{
    public class Final
    {
        [Key]
        public int IdSelecao { get; set; }


        [Display(Name = "Seleção A")]
        [Required(ErrorMessage = "Informar {0}.")]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string NomeA { get; set; }

    }
}