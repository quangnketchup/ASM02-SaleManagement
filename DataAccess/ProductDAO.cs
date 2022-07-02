using DataAccess.DataAccess;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        //-----------------------
        //using singleton
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        //-----------------------
        public IEnumerable<Product> getProductList()
        {
            var products = new List<Product>();
            try
            {
                using var context = new AssignmentContext();
                products = context.Products.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return products;
        }


        //-----------------------
        public Product getProductByID(int ProductId)
        {
            Product product = null;
            try
            {
                using var context = new AssignmentContext();
                product = context.Products.SingleOrDefault(c => c.ProductId == ProductId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }

        //-----------------------
        public void addNewProduct(Product product)
        {
            try
            {
                Product pro = getProductByID(product.ProductId);
                if (pro == null)
                {
                    using var context = new AssignmentContext();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------
        public void updateProduct(Product product)
        {
            try
            {
                Product pro = getProductByID(product.ProductId);
                if (pro == null)
                {
                    using var context = new AssignmentContext();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-------------------------God help me
        public void removeProduct(int productId)
        {
            try
            {
                Product pro = getProductByID(productId);
                if (pro != null)
                {
                    using var context = new AssignmentContext();
                    context.Products.Remove(pro);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The product does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //filter the product list
        public List<Product> GetFilteredProduct(String tag)
        {
            List<Product> filtered = new List<Product>();
            foreach (Product product in getProductList())
            {
                int add = 0;
                if (product.ProductId.ToString().Contains(tag))
                    add = 1;
                if (product.ProductName.Contains(tag))
                    add = 1;
                if (product.UnitPrice.ToString().Contains(tag))
                    add = 1;
                if (product.UnitslnStock.ToString().Contains(tag))
                    add = 1;
                if (add == 1)
                    filtered.Add(product);
            }
            return filtered;
        }
    }
}
