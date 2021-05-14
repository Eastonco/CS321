using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class Soak : Step
    {
        public Container ingredient;
        private double time;
        private Measurement timelen;
        public Soak(Container ingredient, double time, Measurement length)
        {
            this.ingredient = ingredient;
            this.timelen = length;
            this.time = time;
        }

        public override string Read()
        {
            string str = "Soak " + ingredient.ammount.ToString() + ingredient.type.ToString() + " of " + ingredient.name + " for " + time.ToString() + timelen.ToString();
            return str;
        }

        public override List<Container> GetIngredients()
        {
            List<Container> needs = new List<Container>();
            needs.Add(this.ingredient);
            return needs;
        }

    }
}
