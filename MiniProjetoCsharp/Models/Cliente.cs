using System.ComponentModel.DataAnnotations;

namespace MiniProjetoCsharp.Models
{
    public class Cliente
    {

        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
