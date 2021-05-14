using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class Add : Step
    {
        public Container ingredient;
        public Add(Container ingredient)
        {
            this.ingredient = ingredient;
        }

        public override string Read()
        {
            string str = "Add " + ingredient.ammount.ToString() + ingredient.type.ToString() + " of " + ingredient.name;
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
