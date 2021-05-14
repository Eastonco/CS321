using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CookingRobots
{
    public class Recipe
    {
        public Recipe(string name)
        {
            this.currentStep = 0;
            this.ingredients = new List<Container>();
            this.steps = new List<Step>();
            this.name = name;
        }

        public string name;
        private List<Container> ingredients;
        private List<Step> steps;
        private int currentStep;

        private void UpdateList()
        {
            this.ingredients = this.ingredients.Distinct().ToList();
        }

        public void AddStep(Mix mixer)
        {
            steps.Add(mixer);
            ingredients.AddRange(mixer.GetIngredients());
            this.ingredients = this.ingredients.Distinct().ToList();
            UpdateList();
        }

        public void AddStep(Soak soak)
        {
            steps.Add(soak);
            ingredients.AddRange(soak.GetIngredients());
            UpdateList();
        }

        public void AddStep(Misc misc)
        {
            steps.Add(misc);
            ingredients.AddRange(misc.GetIngredients());
            UpdateList();
        }

        public void AddStep(Bake bake)
        {
            steps.Add(bake);
            ingredients.AddRange(bake.GetIngredients());
            UpdateList();
        }

        public void AddStep(Add add)
        {
            steps.Add(add);
            ingredients.AddRange(add.GetIngredients());
            UpdateList();
        }
        public void AddStep(Cook cook)
        {
            steps.Add(cook);
            ingredients.AddRange(cook.GetIngredients());
            UpdateList();
        }

        public Step NextStep()
        {
            if(currentStep > steps.Count-1)
            {
                return null;
            }
            else
            {
                return steps[currentStep++];
            }
        }

        public void Restart()
        {
            this.currentStep = 0;
        }
    }
}
