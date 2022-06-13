using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCSharp.Entities
{
    internal class Tiger : Animal
    {
        public override Meat GetFood()
        {
            return new Meat()
            {
                FoodType = "ss",
                MeatSize = 2
            };
        }
    }
}
