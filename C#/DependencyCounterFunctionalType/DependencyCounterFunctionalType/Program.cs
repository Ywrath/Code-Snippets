using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyCounterFunctionalType
{
    class Program
    {
        int dep;
        int quit = 999;
        int[] count = new int[6] { 0, 0, 0, 0, 0, 0 };

        public int getReady()
        {
            try
            {
                Console.WriteLine("Enter dependency or '999' to quit application: ");
                dep = int.Parse(Console.ReadLine());
            }
            catch(IndexOutOfRangeException ex) 
            {
                Console.WriteLine("No such dependency", ex);
                Console.WriteLine("Enter dependency or '999' to quit application: ");
                dep = int.Parse(Console.ReadLine());
            }
            return dep;
        }
        public int countDependency()
        {
            try
            {
                count[dep] += 1;
                Console.WriteLine("Enter dependency or '999' to quit application: ");
                dep = int.Parse(Console.ReadLine());
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("No such dependency", ex);
                Console.WriteLine("Enter dependency or '999' to quit application: ");
                dep = int.Parse(Console.ReadLine()); 
            }
            return dep;
        }
        public void finishUp()
        {
            Console.WriteLine("Dependency Count");
            dep = 0;
            while (dep < 6)
            {
                Console.WriteLine(count[dep].ToString(), dep.ToString());
                dep++;
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.getReady();
            while (p.dep != p.quit)
            {
                p.countDependency();
            }
            p.finishUp();

            Console.ReadKey();
        }
    }
}
