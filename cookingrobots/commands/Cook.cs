using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class Cook : Step
    {
        private double time;
        private Measurement length;
        public Cook(double time, Measurement length)
        {
            this.time = time;
            this.length = length;
        }

        public override string Read()
        {
            return "Cook for " + time.ToString() + length.ToString();
        }

        public override List<Container> GetIngredients()
        {
            return new List<Container>();
        }
    }
}
