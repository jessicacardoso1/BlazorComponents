using System.ComponentModel.DataAnnotations;

namespace BlazorComponent.Models
{
    public class Medico
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome deve ser Fornecido")]
        [MinLength(3, ErrorMessage = "Nome deve conter no mínimo 3 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve conter no máximo 50 caracteres")]
        //[Range(3,50, ErrorMessage = "Nome deve conter entre {0} e {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CRM deve ser Fornecido")]
        public string Crm { get; set; }
    }
}
