using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule9
{
    class DVD : Storage
    {
        private double readWriteSpeed;
        private string type;

        public DVD(string name, string model, double readWriteSpeed, string type)
            : base(name, model)
        {
            this.readWriteSpeed = readWriteSpeed;
            this.type = type;
        }

        public override double GetMemory()
        {
            return (type == "Single") ? 4.7 : 9;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to DVD (Speed: {readWriteSpeed}x, Type: {type}): {dataSize} GB");
        }

        public override double GetFreeMemory()
        {
            return 0;
        }

        public override string GetDeviceInfo()
        {
            return $"DVD: {name}, Model: {model}, Read/Write Speed: {readWriteSpeed}x, Type: {type}";
        }
    }
}
