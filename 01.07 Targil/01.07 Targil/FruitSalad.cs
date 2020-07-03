using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07_Targil
{
    class FruitSalad
    {
        public Fruit[] fruits;
        public int totalCalories = 0;
         

        public  int GetTotalCalories()
        {
            for (int i = 0; i < fruits.Length; i++)
            {
                totalCalories = totalCalories + fruits[i]._calories;
            }
            return totalCalories;
        }

        public bool ContainsMyFavoriteFruit()
        {
            for (int i = 0; i <fruits.Count(); i++)
            {
                if (fruits[i].IsThisMyFavorite() == true)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} [Total calories]:{GetTotalCalories()} [Contains my favourite fruit]: {ContainsMyFavoriteFruit()}";
        }



    }
}
