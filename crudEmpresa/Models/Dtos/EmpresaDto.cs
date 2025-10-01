using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crudEmpresa.Models.Dtos
{

        public class EmpresaDto
        {
            public int id { get; set; }

            [Required(ErrorMessage = "O Nome Fantasia é obrigatório.")]
            [StringLength(100, ErrorMessage = "O Nome Fantasia deve ter no máximo 100 caracteres.")]
            public required string nomeFantasia { get; set; }

            [Required(ErrorMessage = "A Razão Social é obrigatória.")]
            [StringLength(100, ErrorMessage = "A Razão Social deve ter no máximo 100 caracteres.")]
            public required string razaoSocial { get; set; }

            [Required(ErrorMessage = "O CNPJ é obrigatório.")]
            [RegularExpression(@"^\d{14}$", ErrorMessage = "O CNPJ deve conter exatamente 14 dígitos (somente números).")]
            public required string cnpj { get; set; }

            [Required(ErrorMessage = "A Inscrição Estadual é obrigatória.")]
            [StringLength(20, ErrorMessage = "A Inscrição Estadual deve ter no máximo 20 caracteres.")]
            public string incricaoEstadual { get; set; }

            [Required(ErrorMessage = "O Telefone é obrigatório.")]
            [RegularExpression(@"^\(\d{2}\)\s\d{4,5}-\d{4}$", ErrorMessage = "O Telefone deve estar no formato (XX) 00000-0000.")]
            public required string telefone { get; set; }

            [Required(ErrorMessage = "O E-mail é obrigatório.")]
            [EmailAddress(ErrorMessage = "O E-mail informado não é válido.")]
            public required string email { get; set; }

            [Required(ErrorMessage = "A Cidade é obrigatória.")]
            [StringLength(100, ErrorMessage = "A Cidade deve ter no máximo 100 caracteres.")]
            public required string cidade { get; set; }

            [Required(ErrorMessage = "O Estado (UF) é obrigatório.")]
            [RegularExpression(@"^(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)$",
                ErrorMessage = "O Estado deve ser uma sigla válida (ex: SP, RJ, MG).")]
            public required string estadoUf { get; set; }

            [Required(ErrorMessage = "O CEP é obrigatório.")]
            [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP deve estar no formato 00000-000.")]
            public required string cep { get; set; }

            [Required(ErrorMessage = "A Data de Cadastro é obrigatória.")]
            public required DateTime dataCadastro { get; set; }
        }
    }
