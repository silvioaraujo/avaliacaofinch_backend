using System.Collections.Generic;
using System.Web.Http;
using Finch.CumpridoresTerceirizados.Models;
using Infraestrutura;

namespace Finch.CumpridoresTerceirizados.Controllers
{
    public class ServicoController : ApiController
    {
        // GET: api/Servico
        public IEnumerable<Servico> Get()
        {
            return ServicosRepository.GetServicos();
        }

        // POST: api/Servico
        public void Post([FromBody] Servico servico)
        {
            if (servico.Status_Servico.Equals("Aguardando Atendimento"))
                servico.Status_Servico = "Em Andamento";
            else
                servico.Status_Servico = "Concluído";
            ServicosRepository.SetServico(servico);
        }
    }
}
