using System;
using BusinessLayer;
using DataAccessLayer;

namespace ServiceLayer
{
    public class Service
    {
        private static CategoryDAO m_categoryDAO;
        private static ProductDAO m_productDAO;

        public static void SetPath(string path)
        {
            m_categoryDAO = new CategoryDAO(path);
            m_productDAO = new ProductDAO(path);
        }
    }
}
