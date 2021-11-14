using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DailyRation : IEdible
    {
        private List<Meal> m_meals;

        public float Calories
        {
            get
            {
                float calories = 0;
                foreach(Meal meal in m_meals)
                {
                    calories += meal.Calories;
                }

                return calories;
            }
        }

        public List<Meal> Meals
        {
            get
            {
                return m_meals;
            }
        }

        public float Protein
        {
            get
            {
                float protein = 0;
                foreach (Meal meal in m_meals)
                {
                    protein += meal.Protein;
                }

                return protein;
            }
        }

        public float Carbs
        {
            get
            {
                float carbs = 0;
                foreach (Meal meal in m_meals)
                {
                    carbs += meal.Carbs;
                }

                return carbs;
            }
        }

        public float Fats
        {
            get
            {
                float fats = 0;
                foreach (Meal meal in m_meals)
                {
                    fats += meal.Fats;
                }

                return fats;
            }
        }

        public DailyRation()
        {
            m_meals = new();
        }

        public void AddMeal(Meal mealToAdd)
        {
            m_meals.Add(mealToAdd);
        }

        public void AddProductToMeal(Product product, Meal meal)
        {
            if (m_meals.Contains(meal))
            {
                meal.AddItem(product);
            }
        }

        public void RemoveMeal(Meal mealToRemove)
        {
            m_meals.Remove(mealToRemove);
        }

        public void RemoveProductFromMeal(Product productToRemove, Meal mealToRemoveFrom)
        {
            if (m_meals.Contains(mealToRemoveFrom))
            {
                mealToRemoveFrom.DeleteItem(productToRemove);
            }
        }

        public void Clear()
        {
            m_meals.Clear();
        }
    }
}
