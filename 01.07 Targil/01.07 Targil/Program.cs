using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07_Targil
{
    class Program
    {
        static void PrintAppleColor(Apple a)
        {
            Console.WriteLine(a.color);
        }

        static void PrintBananaSize(Banana b)
        {
            Console.WriteLine(b.size);
        }

        static void PrintCalories(FruitSalad fruitSalad)
        {
            int totalCalories = 0;
            for (int i = 0; i < fruitSalad.fruits.Length; i++)
            {
                totalCalories += fruitSalad.fruits[i]._calories;
            }

            Console.WriteLine(totalCalories);
        }

        static void PrintFavorite (FruitSalad fruitSalad)
        {
            Console.WriteLine(fruitSalad.ContainsMyFavoriteFruit());
        }

        static void Main(string[] args)
        {
            FruitSalad firstSalad = new FruitSalad
            {
                fruits = new Fruit[]
                {
                    new Apple
                    {
                        _calories = 50,
                    },
                    new Mango
                    {
                        _calories=80,

                    },
                    new Grape
                    {
                        _calories=65
                    },
                    new Banana
                    {
                        _calories=25,
                    }
                }
            };

            Apple apple = new Apple
            { 
                color = "red"
            };
            PrintAppleColor(apple);

            Banana banana = new Banana
            {
                size = 15.2f
            };
            PrintBananaSize(banana);

            PrintCalories(firstSalad);

            PrintFavorite(firstSalad);

        }
    }
}
