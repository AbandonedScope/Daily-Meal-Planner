using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product : Regularable, IEdible
    {
        private float m_protein;
        private float m_fats;
        private float m_carbs;
        private float m_calories;

        public string Name { get; set; }

        public int Gramms { get; set; }

        public float Fats
        {
            set
            {
                m_fats = value;
            }

            get => m_fats * Gramms / 100;
        }

        public float Protein
        {
            set
            {
                m_protein = value;
            }

            get => m_protein * Gramms / 100;
        }

        public float Carbs
        {
            set
            {
                m_carbs = value;
            }

            get => m_carbs * Gramms / 100;
        }

        public float Calories
        {
            set
            {
                m_calories = value;
            }

            get => m_calories * Gramms / 100;
        }

        public Product() 
        {
            Validate += (Regularable product, ref string message, ref bool flag) =>
            {
                if (flag)
                {
                    if (product is Product prod && string.IsNullOrEmpty(prod.Name))
                    {
                        message = "Name can't be empty";
                        flag = false;
                    }
                }
            };

            Validate += (Regularable product, ref string message, ref bool flag) =>
            {
                if (flag)
                {
                    if (product is Product prod && prod.Gramms < 0)
                    {
                        message = "Gramms can't be less than zero.";
                        flag = false;
                    }
                }
            };

            Validate += (Regularable product, ref string message, ref bool flag) =>
            {
                if (flag)
                {
                    if (product is Product prod && prod.m_fats < 0)
                    {
                        message = "Fats can't be less than zero.";
                        flag = false;
                    }
                }
            };

            Validate += (Regularable product, ref string message, ref bool flag) =>
            {
                if (flag)
                {
                    if (product is Product prod && prod.m_protein < 0)
                    {
                        message = "Protein can't be less than zero.";
                        flag = false;
                    }
                }
            };

            Validate += (Regularable product, ref string message, ref bool flag) =>
            {
                if (flag)
                {
                    if (product is Product prod && prod.m_calories < 0)
                    {
                        message = "Calories can't be less than zero.";
                        flag = false;
                    }
                }
            };


        }

        public Product(Product product) : this()
        {
            this.Name = product.Name;
            this.Gramms = product.Gramms;
            this.Fats = product.m_fats;
            this.Calories = product.m_calories;
            this.Carbs = product.m_carbs;
            this.Protein = product.m_protein;
        }

        public Product(string name) : this()
        {
            Name = name; 
        }


        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }

            Product product = obj as Product;
            if (product.Name == this.Name)
            {
                return true;
            }

            return false;
        }
    }
}
