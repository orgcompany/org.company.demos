﻿using org.company.sales.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.company.sales.application
{
    public interface ISalesService
    {

        void AddProduct(Product product);
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void UpdateProduct(Product product);

    }
}
