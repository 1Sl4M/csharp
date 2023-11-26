using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule9
{
    class HDD : Storage
    {
        private double usbSpeed;
        private int partitions;
        private double partitionSize;

        public HDD(string name, string model, double usbSpeed, int partitions, double partitionSize)
            : base(name, model)
        {
            this.usbSpeed = usbSpeed;
            this.partitions = partitions;
            this.partitionSize = partitionSize;
        }

        public override double GetMemory()
        {
            return partitions * partitionSize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to HDD (USB {usbSpeed}): {dataSize} GB");
        }

        public override double GetFreeMemory()
        {
            return partitions * partitionSize * 0.95;
        }

        public override string GetDeviceInfo()
        {
            return $"HDD: {name}, Model: {model}, USB Speed: {usbSpeed} GB/s, Partitions: {partitions}, Partition Size: {partitionSize} GB";
        }
    }
}
