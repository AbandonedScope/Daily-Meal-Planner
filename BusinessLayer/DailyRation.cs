﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class DailyRation : IEdible
    {
        private HashSet<Meal> m_meals;

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
    }
}