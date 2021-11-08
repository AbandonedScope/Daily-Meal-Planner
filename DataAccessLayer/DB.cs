using System;
using BusinessLayer;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace DataAccessLayer
{
    public class Db
    {
        private static HashSet<Category> m_categories;
        private static Db m_instance;

        private Db()
        { 

        }

        public Db Instance
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

        public void Deserialize(string path)
        {
            XmlSerializer serializer = new(typeof(Db));
            FileStream file = new(path, FileMode.Open, FileAccess.Read);
            Instance = (Db)serializer.Deserialize(file);
        }
    }
}
