using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class SortIntegers
    {
        public SortIntegers()
        {
            this.myList = new List<int>();
            var rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                this.myList.Add(rand.Next(20000));
            }
        }

        public List<int> myList;

    }
}
