using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class Bake : Step
    {
        private double time;
        private double temp;
        private Measurement length;
        private Measurement temptype;

        public Bake(double time, Measurement length, double temp, Measurement temptype)
        {
            this.time = time;
            this.length = length;
            this.temp = temp;
            this.temptype = temptype;
        }

        public override string Read()
        {
            return "Bake for " + time.ToString() + length.ToString() + " at " + temp.ToString() + temptype.ToString();
        }

        public override List<Container> GetIngredients()
        {
            return new List<Container>();
        }
    }
}
