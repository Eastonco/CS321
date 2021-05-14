using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class StewHelper : Robot
    {
        public StewHelper() : base(5)
        {
            this.LoadRecipe();
        }

        private void LoadRecipe()
        {
            Recipe Chickpea = new Recipe("Chickpea Stew");
            Chickpea.AddStep(new Soak(new Container("Chickpea", 200, Measurement.gr), 8, Measurement.hr));
            Chickpea.AddStep(new Misc("Empty the Water"));
            Chickpea.AddStep(new Add(new Container("Water", 900, Measurement.ml)));
            Chickpea.AddStep(new Add(new Container("Celery", 100, Measurement.gr)));
            Chickpea.AddStep(new Add(new Container("Diced Tomatos", 200, Measurement.gr)));
            Chickpea.AddStep(new Add(new Container("Diced Carrots", 200, Measurement.gr)));
            Chickpea.AddStep(new Cook(1, Measurement.hr));
            this.recipe = Chickpea;
            this.ingredients[0].name = "Chickpea";
            this.ingredients[1].name = "Water";
            this.ingredients[2].name = "Celery";
            this.ingredients[3].name = "Diced Tomatos";
            this.ingredients[4].name = "Diced Carrots";
        }
    }
}
