using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}