using OA.Domain.Entities;
using OA.Repository.Interfaces;
using OA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OA.Service
{
    public class ProductService : IProductService
    {
        private readonly IRepository<ProductEntity> productRepository;

        public ProductService(IRepository<ProductEntity> productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            return await productRepository.GetAllAsync();
        }

        public async Task<ProductEntity> GetAsync(Guid id)
        {
            return await productRepository.GetAsync(id);
        }
    }
}
