using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductEntity>> GetAllAsync();
        Task<ProductEntity> GetAsync(Guid id);
    }
}
