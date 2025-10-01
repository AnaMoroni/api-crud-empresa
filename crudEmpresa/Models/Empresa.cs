using crudEmpresa.Models.Dtos;
using System.ComponentModel.DataAnnotations.Schema;


namespace crudEmpresa.Models
{
    [Table("dados_empresa")]
    public class Empresa
    {
        [Column("id_empresa")]
        public int id { get; set; }
        [Column("nome_fantasia")]
        public required string nomeFantasia { get; set; }

        [Column("razao_social")]
        public required string razaoSocial { get; set; }

        [Column("cnpj")]
        public required string cnpj {  get; set; }

        [Column("incricao_estadual")]
        public string incricaoEstadual {  get; set; }

        [Column("telefone")]
        public required string telefone { get; set; }

        [Column("email")]
        public required string email { get; set; }

        [Column("cidade")]
        public required string cidade { get; set; }

        [Column("estado_uf")]
        public required string estadoUf { get; set; }

        [Column("cep")]
        public required string cep { get; set; }

        [Column("dataCadastro")]
        public required DateTime dataCadastro { get; set; }
    }
}
