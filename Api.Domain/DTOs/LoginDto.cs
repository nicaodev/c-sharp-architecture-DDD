using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório.")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
    }
}