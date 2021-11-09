using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Meal
    {
        private string m_name;
        private HashSet<Product> m_meal;

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
                return m_name;
            }
        }

        public Meal()
        {
            m_meal = new HashSet<Product>();
        }

        public void AddItem(Product product)
        {
            m_meal.Add(product);
        }

        public void DeleteItem(Product product)
        {
            m_meal.Remove(product);
        }
    }
}
