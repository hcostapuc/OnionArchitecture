using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domain.Entities
{
    public class ProductEntity: BaseEntity
    {
        public string Name { get; set; }
        public virtual ProductDetailEntity ProductDetail { get; set; }
    }
}
