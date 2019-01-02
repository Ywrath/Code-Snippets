using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDepencyCounter
{
    class DependencyCounter
    {
        public int dep { get; set; }
        public int[] counter = new int[6] { 0, 0, 0, 0, 0, 0 };
        public int quit = 999;

        public int GetReady()
        {
            Console.WriteLine("Enter dependents: ");
            dep = int.Parse(Console.ReadLine());
            return dep;
        }
        public int CountDependents()
        {
            counter[dep] = counter[dep] + 1;
            Console.WriteLine("Enter dependents: ");
            dep = int.Parse(Console.ReadLine());
            return dep;
        }
        public void FinishingUp()
        {
            Console.WriteLine("Dependency Count");
            dep = 0;

            while (dep < 6) {
                Console.WriteLine(counter[dep].ToString(), dep.ToString());
                dep = dep + 1;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DependencyCounter d = new DependencyCounter();
            d.GetReady();

            while (d.dep != d.quit)
            {
                d.CountDependents();
            }
            d.FinishingUp();

            Console.ReadKey();
        }
    }
}
