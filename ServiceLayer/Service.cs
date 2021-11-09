using System;
using System.Collections.Generic;
using BusinessLayer;
using DataAccessLayer;
#nullable enable

namespace ServiceLayer
{
    public class Service
    {
        private static CategoryDAO? m_categoryDAO;
        private static ProductDAO? m_productDAO;

        public static void SetPath(string path)
        {
            m_categoryDAO = new CategoryDAO(path);
            m_productDAO = new ProductDAO(path);
        }

        public static Category? GetCategory(string name)
        {
            if (m_categoryDAO == null)
            {
                throw new ArgumentNullException(nameof(m_categoryDAO));
            }

            return m_categoryDAO.GetCategory(name);
        }

        public static HashSet<Category> GetCategories()
        {
            if (m_categoryDAO == null)
            {
                throw new ArgumentNullException(nameof(m_categoryDAO));
            }
            return m_categoryDAO.GetCategories();
        }

        public static Product? GetProduct(string name)
        {
            if (m_productDAO == null)
            {
                throw new ArgumentNullException(nameof(m_productDAO));
            }

            return m_productDAO.GetProduct(name);
        }

        public static HashSet<Product>? GetProductsByCategory(string categoryName)
        {
            Category? category = GetCategory(categoryName);
            if (category == null)
            {
                return null;
            }

            return category.Products;
        }
    }
}
