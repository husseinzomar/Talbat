﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.DAL.Entities;

namespace Talabat.BLL.Specifications
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productParams)
            : base(P =>
                    (string.IsNullOrEmpty(productParams.Search) || P.Name.ToLower().Contains(productParams.Search)) &&
                     (!productParams.BrandId.HasValue || P.ProductBrandId == productParams.BrandId.Value) &&
                     (!productParams.TypeId.HasValue || P.ProductTypeId == productParams.TypeId.Value))
        {
        }
    }
}