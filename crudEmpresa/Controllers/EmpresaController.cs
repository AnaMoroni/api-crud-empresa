using crudEmpresa.DataContexts;
using crudEmpresa.Models;
using crudEmpresa.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;


namespace crudEmpresa.Controllers
{
    [Route("/empresas")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {

        private readonly AppDbContext _context;

        public EmpresaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos([FromQuery] string? search, [FromQuery] string? razaoSocial, [FromQuery] string? nomeFantasia, [FromQuery] string? cnpj)
        {
            var query = _context.Empresas.AsQueryable();

            if (search is not null)
            {
                query = query.Where(x => x.nomeFantasia.Contains(search));
            }

            if (razaoSocial is not null)
            {
                query = query.Where(x => x.razaoSocial.Equals(razaoSocial));
            }

            if (nomeFantasia is not null)
            {
                query = query.Where(x => x.nomeFantasia.Equals(nomeFantasia));
            }
            if (cnpj is not null)
            {
                query = query.Where(x => x.cnpj.Equals(cnpj));
            }
       
            var empresas = await query.ToListAsync();
            return Ok(empresas);
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] EmpresaDto novaEmpresa)
        {
            var empresa = new Empresa()
            {
                razaoSocial = novaEmpresa.razaoSocial,
                nomeFantasia = novaEmpresa.nomeFantasia,
                cnpj = novaEmpresa.cnpj,
                incricaoEstadual = novaEmpresa.incricaoEstadual,
                telefone = novaEmpresa.telefone,
                email = novaEmpresa.email,
                cidade = novaEmpresa.cidade,
                estadoUf = novaEmpresa.estadoUf,
                cep = novaEmpresa.cep,
                dataCadastro = novaEmpresa.dataCadastro
            };

            await _context.Empresas.AddAsync(empresa);
            await _context.SaveChangesAsync();
            return Created("", empresa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] EmpresaDto atualizacaoEmpresa)
        {
            var empresa = await _context.Empresas.FirstOrDefaultAsync(x => x.id == id);

            if (empresa is null)
            {
                return NotFound();
            }
            empresa.razaoSocial = atualizacaoEmpresa.razaoSocial;
            empresa.nomeFantasia = atualizacaoEmpresa.nomeFantasia;
            empresa.cnpj = atualizacaoEmpresa.cnpj;
            empresa.incricaoEstadual = atualizacaoEmpresa.incricaoEstadual;
            empresa.telefone = atualizacaoEmpresa.telefone;
            empresa.email = atualizacaoEmpresa.email;
            empresa.cidade = atualizacaoEmpresa.cidade;
            empresa.estadoUf = atualizacaoEmpresa.estadoUf;
            empresa.cep = atualizacaoEmpresa.cep;
            empresa.dataCadastro = atualizacaoEmpresa.dataCadastro;
            
            _context.Empresas.Update(empresa);
            await _context.SaveChangesAsync();
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            return NoContent();
        }

    }
}
