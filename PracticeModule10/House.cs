using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule10
{
    public class House
    {
        internal IPart[] parts;
        public House()
        {
            parts = new IPart[]
            {
            new Basement(),
            new Walls(),
            new Walls(),
            new Walls(),
            new Walls(),
            new Door(),
            new Window(),
            new Window(),
            new Window(),
            new Window(),
            new Roof()
            };
        }

        public void Show()
        {
            Console.WriteLine("House is built. Parts:");
            foreach (var part in parts)
            {
                Console.WriteLine($"{part.Name} is {(part.IsBuilt ? "built" : "not built")}");
            }
        }
    }
}
