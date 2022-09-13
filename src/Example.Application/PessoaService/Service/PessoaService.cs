using Example.Application.Common;
using Example.Domain.PessoaAggregate;
using Example.Infra.Data;
using Microsoft.EntityFrameworkCore;
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


        public async Task<CreatePessoaResponse> CreateAsync(CreatePessoaRequest request)
        {
            if (request is null) throw new ArgumentNullException("Request Empty");

            var pessoa = Pessoa.Create(request.Nome, request.CPF, request.Idade, request.Id_Cidade);

            await this._db.AddAsync(pessoa);
            await this._db.SaveChangesAsync();

            return new CreatePessoaResponse() { Nome = pessoa.Nome, Id = pessoa.Id };
        }

        public async Task<DeletePessoaResponse> DeleteAsync(int id)
        {
            var entity = await this._db.Pessoa.FindAsync(id);

            if (entity is not null)
            {
                this._db.Pessoa.Remove(entity);
                await this._db.SaveChangesAsync();
            }

            return new DeletePessoaResponse() { };
        }

        public async Task<GetAllPessoaResponse> GetAllAsync()
        {
            var listaPessoas = await this._db.Pessoa.ToListAsync();

            return new GetAllPessoaResponse { Pessoas = listaPessoas };
        }

        public async Task<GetByIdPessoaResponse> GetByIdAsync(int id)
        {
            var q = this._db.Pessoa.Include(o => o.Cidade);

            var entity = await q.FirstOrDefaultAsync(o=> o.Id == id);

            return entity is not null ? new GetByIdPessoaResponse { Pessoa = entity } : null!;

        }

        public async Task<UpdatePessoaResponse> UpdateAsync(int id, UpdatePessoaRequest request)
        {
            var pessoa = await this._db.Pessoa.FindAsync(id);

            if (pessoa is not null)
            {
                pessoa.Update(request.Nome, request.CPF, request.Idade, request.Id_Cidade);
                await this._db.SaveChangesAsync();
                return new UpdatePessoaResponse { Pessoa = pessoa };

            }

            return new UpdatePessoaResponse();
        }
    }
}
