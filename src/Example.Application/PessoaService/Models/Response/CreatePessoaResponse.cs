using Example.Application.Common;

namespace Example.Application.PessoaService.Service
{
    public class CreatePessoaResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}