using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product : Regularable, IEdible
    {
        public string Name {set; get; }

        public int Gramms {set; get; }

        public float Fats {set; get; }

        public float Protein {set; get; }

        public float Carbs {set; get; }

        public float Calories {set; get; }

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
                    if (product is Product prod && prod.Fats < 0)
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
                    if (product is Product prod && prod.Protein < 0)
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
                    if (product is Product prod && prod.Calories < 0)
                    {
                        message = "Calories can't be less than zero.";
                        flag = false;
                    }
                }
            };


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
