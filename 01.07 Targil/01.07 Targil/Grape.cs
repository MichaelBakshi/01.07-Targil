using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07_Targil
{
    class Grape:Fruit
    {
        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ";
        }
    }
}
