using System;
using System.Collections.Generic;
using EX08.Entities;

namespace EX08.Services
{
     class ProductService 
    {
        public double FilteredSum(List<Product> list, Func<Product, bool> criteria) {
            double sum = 0.0;
            foreach (Product p in list) {
                if (criteria.Invoke(p)) {
                    sum += p.Price;
                }
            }
            return sum;
        }
    }
}