using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class Misc : Step
    {
        private string command;
        public Misc(string command)
        {
            this.command = command;
        }

        public override string Read()
        {
            return command;
        }

        public override List<Container> GetIngredients()
        {
            return new List<Container>();
        }
    }
}
