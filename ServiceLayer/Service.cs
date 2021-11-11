using System;
using System.Collections.Generic;
using BusinessLayer;
using DataAccessLayer;
#nullable enable

namespace ServiceLayer
{
    public static class Service
    {
        private static CategoryDAO? m_categoryDAO;
        private static ProductDAO? m_productDAO;
        private static DailyRation? m_dailyRation;

        public static void SetPath(string path)
        {
            m_categoryDAO = new CategoryDAO(path);
            m_productDAO = new ProductDAO(path);
            if (m_dailyRation == null)
            {
                m_dailyRation = new DailyRation();
            }
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

        public static void AddMealToRation(Meal meal)
        {
            m_dailyRation ??= new DailyRation();

            m_dailyRation.AddMeal(meal);
        }

        public static void AddProductToMeal(Product product, Meal meal)
        {
            m_dailyRation ??= new DailyRation();

            m_dailyRation.AddProductToMeal(product, meal);
        }

        public static void DeletePruductFromDailyMeal(Product product, Meal meal)
        {
            if (m_dailyRation != null)
            {
                m_dailyRation.RemoveProductFromMeal(product, meal);
            }
        }

        public static void DeleteMealFromDaileRation(Meal meal)
        {
            if (m_dailyRation != null)
            {
                m_dailyRation.RemoveMeal(meal);
            }
        }
    }
}
