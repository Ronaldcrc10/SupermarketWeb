using System.ComponentModel.DataAnnotations;

namespace SupermarketWeb.Models
{
    public class User
    {
        [Required] //Campo requerido de mi tabla user
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
    }
}
