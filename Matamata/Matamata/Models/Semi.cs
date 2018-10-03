using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matamata.Models
{
    public class Semi    {
        [Key]
        //[Index(IsUnique = true)]
        public int IdSemi { get; set; }


        [Display(Name = "Seleção A")]
        [Required(ErrorMessage = "Informar {0}.")]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string NmA { get; set; }

        [Display(Name = "Seleção B ")]
        [Required(ErrorMessage = "Informar {0}.")]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string NmB { get; set; }

    }
}