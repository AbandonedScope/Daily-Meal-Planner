using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Category : Regularable
    {
        private string m_name;
        private HashSet<Product> m_products;
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                m_name = value;
            }
            get
            {
                if (string.IsNullOrEmpty(m_name))
                {
                    throw new ArgumentNullException(nameof(m_name));
                }

                return m_name;
            }
        }

        public HashSet<Product> Products
        {
            set
            {
                m_products = value;
            }
            get
            {
                return m_products;
            }
        }
    }
}
