using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Matamata.Models
{
    public class Quarta
    {
        [Key]        
        public int IdSelecao { get; set; }

        
        [Display(Name = "Seleção A")]
        [Required(ErrorMessage = "Informar {0}.")]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string NomeA { get; set; }

        [Display(Name = "Seleção B ")]
        [Required(ErrorMessage = "Informar {0}.")]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string NomeB { get; set; }

        [Display(Name = "Seleção C")]
        [Required(ErrorMessage = "Informar {0}.")]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string NomeC { get; set; }

        [Display(Name = "Seleção D ")]
        [Required(ErrorMessage = "Informar {0}.")]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string NomeD { get; set; }
    }
    
}