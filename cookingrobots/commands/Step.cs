using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public abstract class Step
    {
        public abstract string Read();

        public abstract List<Container> GetIngredients();
    }
}
