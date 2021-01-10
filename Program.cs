using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name ");
            string name = Console.In.ReadLine();
            Console.WriteLine("age ");
            int age = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine("job ");
            string job = Console.In.ReadLine();
            Console.WriteLine("name:  " + name + "\njob: "+job+"\nage: "+age+" years old");
        }
    }
}
