using Example.Application.Common;
using Example.Infra.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.PessoaService.Service
{
    public class PessoaService : BaseService<PessoaService>, IPessoaService
    {

        private readonly ExampleContext _db;

        public PessoaService(ILogger<PessoaService> logger, Infra.Data.ExampleContext db) : base(logger)
        {
            _db = db;
        }


        public Task<CreatePessoaResponse> CreateAsync(CreatePessoaRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeletePessoaResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GetAllPessoaResponse> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdPessoaResponse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UpdatePessoaResponse> UpdateAsync(int id, UpdatePessoaRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
