using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class Mix : Step
    {
        public List<Container> ingredients = new List<Container>();

        public Mix(Container ingredient)
        {
            this.ingredients.Add(ingredient);

        }

        public void AddToMix(Container ingredient)
        { 
            this.ingredients.Add(ingredient);
        }

        public override string Read()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mix ");

            for (int i = 0; i < ingredients.Count; i++)
            {
                if(i == ingredients.Count -1)
                {
                    sb.Append("and ");
                }
                sb.Append(ingredients[i].ammount.ToString());
                sb.Append(ingredients[i].type.ToString());
                sb.Append(" of ");
                sb.Append(ingredients[i].name);
                if (i != ingredients.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }

        public override List<Container> GetIngredients()
        {
            return this.ingredients;
        }

    }
}
