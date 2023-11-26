using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule12
{
    public class SportsCar : Car
    {
        public SportsCar(string model, int speed) : base(model, speed) { }

        public override void GoToStart()
        {
            Console.WriteLine($"{Model} подъехал к стартовой линии");
        }
    }
}
