using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _01._07_Targil
{
    abstract class Fruit
    {
        public string _name;
        public int _calories;

        public abstract bool IsThisMyFavorite();
        public override string ToString()
        {
            return $"{ base.ToString()} [name] : {_name} [calories]:{_calories}";
        }
    }
}
