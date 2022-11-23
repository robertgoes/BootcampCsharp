using EstudoAPI.Context;
using EstudoAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EstudoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        
        [HttpPost()]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();

            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));

            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null)
            {
                return NotFound();
            }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Numero = contato.Numero;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contaBanco = _context.Contatos.Find(id);

            if (contaBanco == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contaBanco);
            _context.SaveChanges();

            return NoContent();
        }
    }
}