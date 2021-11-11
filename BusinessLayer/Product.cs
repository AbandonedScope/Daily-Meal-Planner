using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product : Regularable, IEdible
    {
        private string m_name;
        private int m_gramms;
        private float m_protein;
        private float m_fats;
        private float m_carbs;
        private float m_calories;

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

        public int Gramms
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                m_gramms = value;
            }

            get => m_gramms * m_gramms / 100;
        }

        public float Fats
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                m_fats = value;
            }

            get => m_fats * m_gramms / 100;
        }

        public float Protein
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                m_protein = value;
            }

            get
            {
                return m_protein * m_gramms / 100;
            }
        }

        public float Carbs
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                m_carbs = value;
            }

            get
            {
                return m_carbs * m_gramms / 100;
            }
        }

        public float Calories
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                m_calories = value;
            }

            get
            {
                return m_calories * m_gramms / 100;
            }
        }

        public Product() { }

        public Product(string name) { Name = name; }
        public override int GetHashCode()
        {
            return m_name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }

            Product product = obj as Product;
            if (product.m_name == this.m_name)
            {
                return true;
            }

            return false;
        }
    }
}
