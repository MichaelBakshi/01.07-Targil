using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07_Targil
{
    class Banana:Fruit
    {

        public bool hasBlackSpots;
        public bool isGreen;
        public float size;

        public override bool IsThisMyFavorite()
        {
            return true;
        }

        public override string ToString()
        {
            return $"{base.ToString()} [Has black spots]:{hasBlackSpots} [Is it green]:{isGreen} [size]:{size}";
        }

    }
}
