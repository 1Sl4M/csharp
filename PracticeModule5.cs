using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule5
{
    internal class PracticeModule5
    {
        static void Main(string[] args)
        {
            try
            {
                CallingMethod();
            }
            catch (OurException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
        static void CallingMethod()
        {
            try
            {
                SecondMethod();
            }
            catch (OurException ex)
            {
                Console.WriteLine("Exception was called from CallingMethod.");
                throw;
            }
        }

        static void SecondMethod()
        {
            throw new OurException("Exception called from second method.");
        }
    }
    class OurException : Exception
    {
        public OurException(string message) : base(message) { }
    }
}
