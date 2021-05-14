using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class BakerHelper : Robot
    {
        public BakerHelper() : base(4)
        {
            this.LoadRecipie();
        }

        private void LoadRecipie()
        {
            Recipe Sourdough = new Recipe("Sourdough");
            Sourdough.AddStep(new Add(new Container("Flour", 500, Measurement.gr)));
            Sourdough.AddStep(new Add(new Container("Water", 400, Measurement.ml)));
            Sourdough.AddStep(new Add(new Container("Salt", 10, Measurement.gr)));
            Sourdough.AddStep(new Add(new Container("Starter", 100, Measurement.gr)));
            Mix mix = new Mix(new Container("Flour", 500, Measurement.gr));
            mix.AddToMix(new Container("Water", 400, Measurement.ml));
            Sourdough.AddStep(mix);
            Sourdough.AddStep(new Misc("Add Salt and Starter to Mix"));
            Sourdough.AddStep(new Misc("for 2h the dough is mixed every 30 min (low speed, for the duration of 1 min each time)"));
            Sourdough.AddStep(new Misc("Set aside for 2h"));
            Sourdough.AddStep(new Bake(20, Measurement.min, 500, Measurement.F));
            Sourdough.AddStep(new Bake(25, Measurement.min, 450, Measurement.F));
            this.recipe = Sourdough;
            this.ingredients[0].name = "Flour";
            this.ingredients[1].name = "Water";
            this.ingredients[2].name = "Salt";
            this.ingredients[3].name = "Starter";
        }
    }
}
