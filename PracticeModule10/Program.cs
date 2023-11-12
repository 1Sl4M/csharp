using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            IWorker[] team = { new Worker() };
            
            Team constructionTeam = new Team(team);
            
            constructionTeam.BuildHouse(house);
            
            Console.ReadKey();
        }
    }
}
