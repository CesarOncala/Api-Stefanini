using Example.Application.Common;
using Example.Infra.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.CidadeService.Service
{
    public class CidadeService : BaseService<CidadeService>, ICidadeService
    {
        private readonly ExampleContext _db;

        public CidadeService(ILogger<CidadeService> logger, Infra.Data.ExampleContext db) : base(logger)
        {
            _db = db;
        }

        public Task<CreateCidadeResponse> CreateAsync(CreateCidadeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteCidadeResponse> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GetAllCidadeResponse> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCidadeResponse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateCidadeResponse> UpdateAsync(int id, UpdateCidadeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
