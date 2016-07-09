﻿using org.company.sales.domain.contracts.repository;
using org.company.sales.entities;
using org.company.sales.repository.generic;
using System.Data.Entity;

namespace org.company.sales.repository
{
    public class ProductTypeRepository : GenericRepository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(DbContext context) : base(context) { }
    }
}
