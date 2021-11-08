using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product : Regularable
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
            get
            {
                return m_gramms;
            }
        }

        public float Fats
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                m_fats = value;
            }

            get
            {
                return m_fats;
            }
        }

        public float Proteins
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                m_protein = value;
            }

            get
            {
                return m_protein;
            }
        }

        public float Carbs
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                m_carbs = value;
            }

            get
            {
                return m_carbs;
            }
        }

        public float Calories
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                m_calories = value;
            }

            get
            {
                return m_calories;
            }
        }

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
        public Product() { }
    }
}
