using System.ComponentModel.DataAnnotations;

namespace CadastroPalestra.Models
{
    public class Participante
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        public string Email { get; set; } = null!;
        [StringLength(11)]
        public string Contato { get; set; } = null!;
        [StringLength(50)]
        public string Instituicao { get; set; } = null!;
    }
}
