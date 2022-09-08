using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Usuario
    {
        public Usuario(string? nome, long cNPJ)
        {
            Nome = nome;
            CNPJ = cNPJ;
        }

        public Usuario()
        {
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório!")]
        public long CNPJ { get; set; }
    }
}