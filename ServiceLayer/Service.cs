using System;
using System.Drawing;
using System.Collections.Generic;
using BusinessLayer;
using DataAccessLayer;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

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

        public static void SaveToPDF(string filename)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            PdfFont headerFont = new PdfTrueTypeFont(new Font("Segoe UI", 14, FontStyle.Bold | FontStyle.Italic), 40, true);
            PdfFont subHeaderFont = new PdfTrueTypeFont(new Font("Segoe UI", 14), 18, true);
            PdfFont simpleTextFont = new PdfTrueTypeFont(new Font("Segoe UI", 14), 14, true);

            PdfSolidBrush brush = new PdfSolidBrush(Color.FromArgb(56, 65, 74));
            PdfSolidBrush linesBrush = new PdfSolidBrush(Color.FromArgb(104, 121, 140));
            PdfBrush solidBrush = new PdfSolidBrush(Color.FromArgb(171, 205, 239));
            PointF prevPoint = new PointF(0, 0);
            PointF prevProductPoint;
            SizeF headerSize = new SizeF(graphics.ClientSize.Width, 50);
            SizeF mealSize = new SizeF(graphics.ClientSize.Width, 40);
            RectangleF bounds = new RectangleF(prevPoint, headerSize);
            PdfLinearGradientBrush linearGradientBrush = new PdfLinearGradientBrush(prevPoint, new PointF(headerSize.Width, 0), Color.FromArgb(171, 205, 239), Color.Transparent);
            PdfPath path = RoundedRectangle(bounds);
            graphics.DrawPath(solidBrush, path);

            graphics.DrawString("Your Daily Ration", headerFont, brush, prevPoint.X + 90, prevPoint.Y, new PdfStringFormat(PdfTextAlignment.Justify));
            prevPoint.Y += bounds.Height + 10;
            graphics.DrawLine(new PdfPen(linesBrush, 5), prevPoint, new PointF(prevPoint.X + headerSize.Width, prevPoint.Y));
            prevPoint.Y += 10;
            graphics.DrawString($"User Information :", subHeaderFont, brush, prevPoint);
            prevPoint.Y += simpleTextFont.Size * 1.5f;
            prevPoint.X += 10;
            graphics.DrawString($"Age : {m_user.Age} years", simpleTextFont, brush, prevPoint);
            prevPoint.Y += simpleTextFont.Size * 1.5f;
            graphics.DrawString($"Height : {m_user.Height} cm", simpleTextFont, brush, prevPoint);
            prevPoint.Y += simpleTextFont.Size * 1.5f;
            graphics.DrawString($"Weight : {m_user.Weight} kg", simpleTextFont, brush, prevPoint);
            prevPoint.Y += simpleTextFont.Size * 1.5f;
            graphics.DrawString($"Daily Calories to maintain current weight : {m_user.DailyMaximum} kcal", simpleTextFont, brush, prevPoint);
            prevPoint.Y += simpleTextFont.Size * 1.5f + 10;
            prevPoint.X -= 10;
            graphics.DrawLine(new PdfPen(linesBrush, 5), prevPoint, new PointF(prevPoint.X + headerSize.Width, prevPoint.Y));
            prevPoint.Y += 10;
            foreach (Meal meal in m_dailyRation.Meals)
            {
                PdfPath buffPath = RoundedRectangle(new RectangleF (prevPoint, new SizeF(graphics.ClientSize.Width, subHeaderFont.Size * 1.5f)));
                graphics.DrawPath(linearGradientBrush, buffPath);
                prevPoint.X += 5;
                graphics.DrawString($"{meal.Name} :", subHeaderFont, brush, prevPoint);
                prevPoint.X -= 5;
                prevPoint.Y += subHeaderFont.Size * 1.5f + 8;
                prevProductPoint = prevPoint;
                prevProductPoint.X += 45;
                foreach (Product product in meal.Items)
                {
                    graphics.DrawString(product.Name, simpleTextFont, brush, prevProductPoint);
                    prevProductPoint.Y += simpleTextFont.Size * 1.5f + 5;
                }
                prevPoint.Y = prevProductPoint.Y;
            }
            graphics.DrawLine(new PdfPen(linesBrush, 5), prevPoint, new PointF(prevPoint.X + headerSize.Width, prevPoint.Y));
            prevPoint.Y += 10;
            graphics.DrawString($"Current calories : {m_dailyRation.Calories} kcal", subHeaderFont, brush, prevPoint);
            document.Save(filename);
            document.Close(true);
        }

        private static PdfPath RoundedRectangle(RectangleF bounds)
        {
            PdfPath path = new();
            path.AddArc(bounds.X, bounds.Y, bounds.Height / 2, bounds.Height / 2, 180, 90);
            path.AddArc(bounds.X + bounds.Width - bounds.Height / 2, bounds.Y, bounds.Height / 2, bounds.Height / 2, 270, 90);
            path.AddArc(bounds.X + bounds.Width - bounds.Height / 2, bounds.Y + bounds.Height / 2, bounds.Height / 2, bounds.Height / 2, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height / 2, bounds.Height / 2, bounds.Height / 2, 90, 90);

            return path;
        }
    }
}
