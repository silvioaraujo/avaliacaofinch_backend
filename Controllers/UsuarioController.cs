using Finch.CumpridoresTerceirizados.Infraestrutura;
using Finch.CumpridoresTerceirizados.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Finch.CumpridoresTerceirizados.Controllers
{
    public class UsuarioController : ApiController
    {
        // POST: api/Usuario/Logar
        [HttpPost]
        [Route("api/Usuario/Logar")]
        public IEnumerable<Usuario> Logar([FromBody]Usuario usuario)
        {
            return UsuariosRepository.Logar(usuario);
        }

        // PUT: api/Usuario/Cadastrar
        [HttpPost]
        [Route("api/Usuario/Cadastrar")]
        public void Cadastrar([FromBody]Usuario usuario)
        {
            UsuariosRepository.Cadastrar(usuario);
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
