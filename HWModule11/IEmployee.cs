using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HWModule11.Program;

namespace HWModule11
{
    public interface IEmployee
    {
        string Name { get; set; }
        int Age { get; set; }
        Gender Gender { get; set; }
        string Position { get; set; }
        int Salary { get; set; }
        DateTime Hiredate { get; set; }
    }
}
