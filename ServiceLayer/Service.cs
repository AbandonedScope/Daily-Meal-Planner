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
        private static DailyRation m_dailyRation = new();
        private static User m_user = new();

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

        public static void AddMealToRation(Meal meal)
        {
            m_dailyRation.AddMeal(meal);
        }

        public static void AddProductToMeal(Product product, Meal meal)
        {
            m_dailyRation.AddProductToMeal(product, meal);
        }

        public static void DeletePruductFromDailyMeal(Product product, Meal meal)
        {
            m_dailyRation.RemoveProductFromMeal(product, meal);
        }

        public static void DeleteMealFromDaileRation(Meal meal)
        {
           m_dailyRation.RemoveMeal(meal);
        }

        public static void RationClear()
        {
            m_dailyRation.Clear();
        }

        public static void SetUserWeight(int weight)
        {
            m_user.Weight = weight;
        }

        public static void SetUserHeight(int height)
        {
            m_user.Height = height;
        }

        public static void SetUserAge(int age)
        {
            m_user.Age = age;
        }

        public static void SetUserActivety(ActivityType activety)
        {
            m_user.Activety = activety;
        }

        public static bool UserValidate(ref string message)
        {
            bool flag = true;
            m_user.Validate(m_user, ref message, ref flag);
            return flag;
        }

        public static int GetCurrentCalories()
        {
            return (int)m_dailyRation.Calories;
        }

        public static int GetDailyMaximum()
        {
            return m_user.DailyMaximum;
        }
    }
}
