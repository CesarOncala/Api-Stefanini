using Example.Application.Common;
using Example.Domain.CidadeAggregate;
using Example.Infra.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<CreateCidadeResponse> CreateAsync(CreateCidadeRequest request)
        {
            if(request is null) throw new ArgumentException("Request Empty!");

            var cidade = Cidade.Create(request.Nome, request.UF);

            await this._db.Cidade.AddAsync(cidade);

            await this._db.SaveChangesAsync();

            return new CreateCidadeResponse { Id = cidade.Id, Nome = cidade.Nome };
        }

        public async Task<DeleteCidadeResponse> DeleteAsync(int id)
        {
            var cidade = await this._db.Cidade.FindAsync(id);

            if (cidade is not null)
            {
                this._db.Cidade.Remove(cidade);
                await this._db.SaveChangesAsync();
            }

            return new DeleteCidadeResponse { };
        }

        public async Task<GetAllCidadeResponse> GetAllAsync()
        {
            var cidades = await this._db.Cidade.ToListAsync();

            return new GetAllCidadeResponse { Cidades = cidades };
        }

        public async Task<GetByIdCidadeResponse> GetByIdAsync(int id)
        {
            var q = this._db.Cidade.Include(o => o.Pessoas);

            var cidade = await q.FirstOrDefaultAsync(o=> o.Id == id);


            return new GetByIdCidadeResponse { Cidade = cidade };

        }

        public async Task<UpdateCidadeResponse> UpdateAsync(int id, UpdateCidadeRequest request)
        {
            if(request is null ) throw new ArgumentException("Request Empty!");

            var cidade =  await this._db.Cidade.FindAsync(id);

            cidade.Update(request.Nome, request.UF);

            await this._db.SaveChangesAsync();

            return new UpdateCidadeResponse { };
        }
    }
}
