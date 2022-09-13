using Example.Application.Common;
using Example.Domain.CidadeAggregate;

namespace Example.Application.CidadeService.Service
{
    public class GetByIdCidadeResponse : BaseResponse
    {
        public Cidade Cidade { get; set; }
    }
}