using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule10
{
    public class Team
    {
        private IWorker[] workers;

        public Team(IWorker[] workers)
        {
            this.workers = workers;
        }

        public void BuildHouse(House house)
        {
            Console.WriteLine("Team starts building the house.");
            foreach (var worker in workers)
            {
                foreach (var part in house.parts)
                {
                    worker.Build(part, house);
                }
            }
            Console.WriteLine("Team has finished building the house.");
        }
    }
}
