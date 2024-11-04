using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SupermarketWeb.Models
{
    public class PayMode
    {
        [Key]
        public int Id { get; set; } //Primary Key de mi modelo/clase PayMode

        [Required]
        [DisplayName("Pay Mode")]
        public string PayModeName { get; set; }
        [Required]
        public string Description { get; set; }
        
    }
}
