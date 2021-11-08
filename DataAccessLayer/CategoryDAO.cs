using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

#nullable enable

namespace DataAccessLayer
{
    class CategoryDAO : DAO
    {
        private DataBase? m_dataBase;

        public CategoryDAO(string path) : base(path) { }


        public Category? GetCategory(string categoryName) 
        {
            if (string.IsNullOrEmpty(categoryName))
            {
                throw new ArgumentNullException(nameof(categoryName));
            }

            if (m_dataBase == null)
            {
                throw new ArgumentNullException(nameof(m_dataBase));
            }

            foreach (Category category in m_dataBase.Categories)
            {
                if(category.Name == categoryName)
                {
                    return category;
                }
            }

            return null;
        }
        public HashSet<Category> GetCategories()
        {
            if(m_dataBase == null)
            {
                throw new ArgumentNullException(nameof(m_dataBase));
            }

            return m_dataBase.Categories;
        }
    }
}
