using System;
using BusinessLayer;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace DataAccessLayer
{
    public class DataBase
    {
        private HashSet<Category> m_categories;
        private static DataBase m_instance;

        private DataBase() { m_categories = new(); }

        public static DataBase Instance
        {
            private set
            {
                if (m_instance == null)
                {
                    m_instance = new();
                }
                m_instance = value;
            }
            get
            {
                if (m_instance == null)
                {
                    m_instance = new();
                }
                return m_instance;
            }
        }

        public HashSet<Category> Categories
        {
            get
            {
                return m_instance.m_categories;
            }
        }

        public void Deserialize(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }
            m_instance.m_categories = new();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            Category categoryBuff;
            Product productBuff;
            XmlNode attr;
            foreach (XmlNode category in root)
            {
                attr = category.Attributes.GetNamedItem("name");
                categoryBuff = new();
                categoryBuff.Name = attr.Value;
                attr = category.Attributes.GetNamedItem("description");
                categoryBuff.Description = attr.Value;
                foreach (XmlNode product in category.ChildNodes)
                {
                    productBuff = new();
                    productBuff.Name = product.ChildNodes[0].InnerText;
                    productBuff.Gramms = int.Parse(product.ChildNodes[1].InnerText);
                    productBuff.Proteins = float.Parse(product.ChildNodes[2].InnerText);
                    productBuff.Fats = float.Parse(product.ChildNodes[3].InnerText);
                    productBuff.Carbs = float.Parse(product.ChildNodes[4].InnerText);
                    productBuff.Calories = float.Parse(product.ChildNodes[5].InnerText);
                    categoryBuff.Products.Add(productBuff);
                }
                m_instance.Categories.Add(categoryBuff);
            }
        }
    }
}
