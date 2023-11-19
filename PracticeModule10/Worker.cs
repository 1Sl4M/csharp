using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule10
{
    public class Worker : IWorker
    {
        public void Build(IPart part, House house)
        {
            Console.WriteLine($"{part.Name} is built");
            part.Build();
        }
    }
}
