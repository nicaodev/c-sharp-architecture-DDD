using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.DTOs.User
{
    public class UserDtoCreate
    {

        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "E-mail não está válido.")]
        public string Email { get; set; }
    }
}