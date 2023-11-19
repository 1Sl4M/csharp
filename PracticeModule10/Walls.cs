using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule10
{
    public class Walls : IPart 
    {
        public string Name => "Wall";
        public bool IsBuilt { get; private set; }

        public void Build()
        {
            IsBuilt = true;
        }
    }
}
