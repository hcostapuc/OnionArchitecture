using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service.Interfaces
{
    interface IProductDetailService
    {
        Task<ProductDetailEntity> GetAsync(Guid id);
    }
}
