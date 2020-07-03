using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07_Targil
{
    class Mango:Fruit
    {
        public override bool IsThisMyFavorite()
        {
            return true;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ";
        }
    }
}
