using System;
using System.Collections.Generic;
using System.Text;

namespace CookingRobots
{
    public class Container
    {
        public Measurement type;
        public string name;
        public double ammount;
        
        public Container(string name, double ammount, Measurement type)
        {
            this.name = name;
            this.ammount = ammount;
            this.type = type;
        }

        public void ChangeName(string newname)
        {
            this.name = newname;
        }

        public void ChangeAmmount(double newammount, Measurement newtype)
        {
            this.ammount = newammount;
            this.type = newtype;
        }
    }
}
