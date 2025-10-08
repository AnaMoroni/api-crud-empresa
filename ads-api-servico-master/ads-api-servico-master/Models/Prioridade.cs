using System.ComponentModel.DataAnnotations.Schema;

namespace ApiServico.Models
{
    [Table("prioridade")]
    public class Prioridade
    {
        [Column("id_pri")]
        public int Id { get; set; }

        [Column("nome_pri")]
        public string? Nome { get; set; }
    }
}

