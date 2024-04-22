using System.ComponentModel.DataAnnotations;

namespace CadastroPalestra.Models
{
    public class Participante
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "O campo nome não pode passar de 50 Caracteres")]
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Name { get; set; } = null!;
        [StringLength(50, ErrorMessage = "O campo email não pode passar de 50 Caracteres")]
        [Required(ErrorMessage = "O campo email é obrigatório")]
        [EmailAddress(ErrorMessage = "Digite um endereço de e-mail válido")]
        public string Email { get; set; } = null!;
        [StringLength(50, ErrorMessage = "O campo de confirmação do email não pode passar de 50 Caracteres")]
        [Required(ErrorMessage = "O campo de confirmação de email é obrigatório")]
        [Compare("Email", ErrorMessage = "Os campos de e-mail e confirmação de e-mail não correspondem")]
        public string ConfirmacaoEmail { get; set; } = null!;
        [StringLength(11, ErrorMessage = "O campo Telefone não pode passar de 11 Caracteres")]
        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        public string Contato { get; set; } = null!;
        [StringLength(50, ErrorMessage = "O campo instituição não pode passar de 50 Caracteres")]
        [Required(ErrorMessage = "O campo instituição é obrigatório")]
        public string Instituicao { get; set; } = null!;
    }
}
