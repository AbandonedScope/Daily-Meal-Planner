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
        private string m_description;
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

        public string Description
        {
            set
            {
                m_description = value ?? throw new ArgumentNullException(nameof(value));
            }
            get
            {
                return m_description ?? throw new ArgumentNullException(nameof(m_description));
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
