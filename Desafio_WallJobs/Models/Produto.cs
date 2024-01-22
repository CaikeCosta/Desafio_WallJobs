using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_WallJobs.Models
{

    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]

        public string Nome { get; set; }

        [Column("Descricao")]
        [Display(Name ="Descricao")]
        public string Descricao { get; set; }

        [Column("Preco")]
        [Display(Name = "Preco")]
        public string Preco { get; set; }
    }
}
