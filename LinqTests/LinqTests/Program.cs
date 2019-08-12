using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Just testing");
        }
    }
    public class Car
    {
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Displacement { get; set; }
        public int Cylinders { get; set; }
        public int City { get; set; }
        public int Highway { get; set; }
        public int Combined { get; set; }
    }
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Headquarters { get; set; }
        public int Year { get; set; }
    }
}
