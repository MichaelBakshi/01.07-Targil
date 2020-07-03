using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07_Targil
{
    class Apple:Fruit
    {
        public string color;
        public bool pinkLady;

        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} [color]:{color} [Pink Lady]:{pinkLady}";
        }

    }
}
