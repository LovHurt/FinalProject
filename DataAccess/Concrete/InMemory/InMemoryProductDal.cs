﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product { Id = 1, CategoryId = 1, ProductName = "Glass", UnitPrice = 15, UnitInStock = 15 },
                new Product { Id = 2, CategoryId = 2, ProductName = "Camera", UnitPrice = 500, UnitInStock = 3 },
                new Product { Id = 3, CategoryId = 2, ProductName = "Telephone", UnitPrice = 1500, UnitInStock = 2 },
                new Product { Id = 4, CategoryId = 2, ProductName = "Keyboard", UnitPrice = 150, UnitInStock = 65 },
                new Product { Id = 5, CategoryId = 2, ProductName = "Mouse", UnitPrice = 85, UnitInStock = 1 },

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.Id == p.Id)
            //    {
            //        productToDelete = p;
            //    }
            //}

            //LINQ - Language Integrated Query
            //Lambda
            Product productToDelete =
                _products.SingleOrDefault(p => p.Id == product.Id); //finds one element, usually id searches

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        Product productToUpdate;

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

    }
}