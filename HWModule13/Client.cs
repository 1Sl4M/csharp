using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule13
{
    public class Client
    {
        public string IIN { get; }
        public ServiceType Service { get; }

        public Client(string iin, ServiceType service)
        {
            IIN = iin;
            Service = service;
        }
    }
}
