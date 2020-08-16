using OA.Domain.Entities;
using OA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class ProductDetailService : IProductDetailService
    {
        public Task<ProductDetailEntity> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
