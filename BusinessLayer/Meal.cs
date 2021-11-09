using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Meal
    {
        private string m_name;
        private List<Product> m_meal;

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

        public List<Product> Items
        {
            get
            {
                return m_meal;
            }
        }

        public Meal()
        {
            m_meal = new List<Product>();
        }

        public Meal(string name) : this()
        {
            Name = name;
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
