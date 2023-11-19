using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule10
{
    public interface IWorker
    {
        void Build(IPart part, House house);
    }
}
