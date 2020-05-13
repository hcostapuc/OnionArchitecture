using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domain.Entities
{
    public class ProductDetailEntity: BaseEntity
    {
        public int StockAvaliable { get; set; }
        public decimal Price { get; set; }
        public  virtual ProductEntity Product { get; set; }
    }
}
