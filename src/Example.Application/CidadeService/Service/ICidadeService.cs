using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.CidadeService.Service
{
    public interface ICidadeService
    {
        Task<GetAllCidadeResponse> GetAllAsync();
        Task<GetByIdCidadeResponse> GetByIdAsync(int id);
        Task<CreateCidadeResponse> CreateAsync(CreateCidadeRequest request);
        Task<UpdateCidadeResponse> UpdateAsync(int id, UpdateCidadeRequest request);
        Task<DeleteCidadeResponse> DeleteAsync(int id);
    }
}
