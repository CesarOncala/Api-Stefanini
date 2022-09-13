using Example.Application.Common;
using Example.Domain.CidadeAggregate;

namespace Example.Application.CidadeService.Service
{
    public class GetAllCidadeResponse : BaseResponse
    {
        public ICollection<Cidade> Cidades { get; set; }
    }
}