using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule9
{
    class Flash : Storage
    {
        private double usbSpeed;
        private double memorySize;

        public Flash(string name, string model, double usbSpeed, double memorySize)
            : base(name, model)
        {
            this.usbSpeed = usbSpeed;
            this.memorySize = memorySize;
        }

        public override double GetMemory()
        {
            return memorySize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to Flash (USB {usbSpeed}): {dataSize} GB");
        }

        public override double GetFreeMemory()
        {
            return memorySize * 0.9;
        }

        public override string GetDeviceInfo()
        {
            return $"Flash Drive: {name}, Model: {model}, USB Speed: {usbSpeed} GB/s, Memory Size: {memorySize} GB";
        }
    }
}
