using Example.Application.Common;

namespace Example.Application.CidadeService.Service
{
    public class CreateCidadeResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}