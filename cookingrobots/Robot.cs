using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class Robot
    {
        internal Recipe recipe;
        internal Container[] ingredients;
        internal int ingredientsCount;
        public Robot(int size)
        {
            if(size > 10)
            {
                Console.WriteLine("Container count > 10, setting to max");
                this.ingredientsCount = 10;
                this.ingredients = new Container[10];
            }
            if (size < 1)
            {
                Console.WriteLine("Container count < 1, setting to min");
                this.ingredientsCount = 1;
                this.ingredients = new Container[1];
            }
            else
            {
                this.ingredientsCount = size;
                this.ingredients = new Container[size];
            }
            for (int i = 0; i < ingredientsCount; i++)
            {
                this.ingredients[i] = new Container("Empty", 0, Measurement.gr);
            }
        }

        internal void SetLabels()
        {
            int i = 1;
            foreach (Container ingreedient in ingredients)
            {
                Console.Write("Container " + i.ToString() + " name: ");
                this.ingredients[i-1].name = Console.ReadLine();
                i++;
            }
            Console.WriteLine("Containers Set");
        }

        public void AddRecipie(Recipe newrecipe)
        {
            this.recipe = newrecipe;
        }

        public void Make()
        {
            Console.WriteLine("Starting Recipe named: " + this.recipe.name);
            Step currentstep;
            List<Container> needslist;
            currentstep = recipe.NextStep();
            while (currentstep != null)
            {
                needslist = currentstep.GetIngredients();
                bool hasIngredient;
                foreach (Container ing in needslist)
                {
                    hasIngredient = false;
                    for(int i = 0; i < this.ingredients.Length; i++)
                    {
                        if (ing.name == this.ingredients[i].name){
                            hasIngredient = true;
                        }
                    }
                    if(hasIngredient == false)
                    {
                        Console.WriteLine("ERROR: No " + ing.name);
                        return;
                    }
                }

                Console.WriteLine(currentstep.Read());
                currentstep = recipe.NextStep();
            }
            Console.WriteLine("Recipe Complete");
            recipe.Restart();
        }
    }
}
