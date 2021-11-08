using System;
using BusinessLayer;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace DataAccessLayer
{
    public class DataBase
    {
        [XmlArray("Db")]
        private HashSet<Category> m_categories;
        private static DataBase m_instance;

        private DataBase() { }

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
                return m_categories;
            }
        }

        public void Deserialize(string path)
        {
            XmlSerializer serializer = new(typeof(HashSet<Category>));
            FileStream file = new(path, FileMode.Open, FileAccess.Read);
            Instance.m_categories = (HashSet<Category>)serializer.Deserialize(file);
        }
    }
}
