using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        // Construtor sem critérios
        public ProductsWithTypesAndBrandsSpecification() : base(x => true) 
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        // Construtor com critérios
        public ProductsWithTypesAndBrandsSpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}
