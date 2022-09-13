using Example.Application.Common;
using Example.Domain.PessoaAggregate;

namespace Example.Application.PessoaService.Service
{
    public class GetAllPessoaResponse : BaseResponse
    {
        public ICollection<Pessoa> Pessoas { get; set; }
    }
}