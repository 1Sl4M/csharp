using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule10
{
    public class TeamLeader : IWorker
    {
        public void Build(IPart part, House house)
        {
            if (part.IsBuilt)
            {
                Console.WriteLine($"TeamLeader: {part.Name} is already built.");
            }
            else
            {
                Console.WriteLine($"TeamLeader: {part.Name} is not built.");
            }
        }
    }
}
