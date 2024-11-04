using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWeb.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; } //Primary Key de mi modelo/clase Provider

        [Required]
        [DisplayName("Provider Name")]
        public string ProviderName { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public int Telefono { get; set; }
    }
}
