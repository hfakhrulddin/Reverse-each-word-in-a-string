using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Each_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the list of words");
            string inputlist = Console.ReadLine();

            string outputlist = string.Join(" ", inputlist
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));




                Console.WriteLine(outputlist);
                Console.Read();
        }
    }
}
