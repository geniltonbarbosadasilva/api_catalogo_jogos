using System.ComponentModel.DataAnnotations;

namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo de conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome da produtora de conter entre 1 e 100 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "O preco deve ser no minimo 1 real e no maximo 1000")]
        public double Preco { get; set; }
    }
}