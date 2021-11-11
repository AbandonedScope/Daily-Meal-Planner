using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Meal : IEdible
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

        public float Calories
        {
            get
            {
                float calories = 0;
                foreach(Product product in m_meal)
                {
                    calories += product.Calories;
                }

                return calories;
            }
        }

        public float Protein
        { 
            get
            {
                float protein = 0;
                foreach (Product product in m_meal)
                {
                    protein += product.Protein;
                }

                return protein;
            }
        }

        public float Fats
        {
            get
            {
                float fats = 0;
                foreach (Product product in m_meal)
                {
                    fats += product.Fats;
                }

                return fats;
            }
        }

        public float Carbs
        {
            get
            {
                float carbs = 0;
                foreach (Product product in m_meal)
                {
                    carbs += product.Carbs;
                }

                return carbs;
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
