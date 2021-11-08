using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
#nullable enable

namespace DataAccessLayer
{
    public class ProductDAO : DAO
    {
        public ProductDAO(string path) : base(path) { }

        public Product? GetProduct(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (m_dataBase == null)
            {
                throw new ArgumentNullException(nameof(m_dataBase));
            }

            foreach (Category category in m_dataBase.Categories)
            {
                foreach(Product product in category.Products)
                {
                    if(product.Name == name)
                    {
                        return product;
                    }
                }
            }

            return null;
        }
    }
}
