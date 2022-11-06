using System.ComponentModel.DataAnnotations;

   namespace APIMysql.Models
{

    public class Cliente
    {
        [Key]
        public int Id_cliente { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "informe o nome")]
        [StringLength(50, MinimumLength = 3)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(50, MinimumLength = 3)]
        public string email { get; set; }

        [Required(ErrorMessage = "informe o nome")]
        [StringLength(15, MinimumLength = 8)]
        public string senha { get; set; }

    }
}
