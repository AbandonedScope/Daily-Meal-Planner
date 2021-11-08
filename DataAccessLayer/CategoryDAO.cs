using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

#nullable enable

namespace DataAccessLayer
{
    class CategoryDAO
    {
        private Db m_dataBase;

        public CategoryDAO(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            m_dataBase = Db.Instance;
            m_dataBase.Deserialize(path);
        }


        public Category? GetCategory(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
            {
                throw new ArgumentNullException(nameof(categoryName));
            }

            foreach(Category category in m_dataBase.Categories)
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
            return m_dataBase.Categories;
        }
    }
}
