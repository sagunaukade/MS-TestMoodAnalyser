using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestMoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the MSTest mood analyser program");
            Type type = typeof(MoodAnalyser);
            Console.WriteLine(type.FullName);
            Console.ReadLine();
        }
    }
}
