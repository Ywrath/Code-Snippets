using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemFinder
{
    class Program
    {
        int item;
        const int ARRAY_SIZE = 6;
        int[] valid_items = new int[ARRAY_SIZE] {100, 200, 300, 400, 500, 600 };
        int[] valid_prices = new int[ARRAY_SIZE] { 100, 150, 200, 250, 300, 350 };
        int itemprice;
        int selecteditem;
        int sub;
        string foundit;
        int baditemcount = 0;
        string message_yes = "Item is available";
        string message_no = "Item is not available";
        int finish = 999;

        public int getReady()
        {
            Console.WriteLine("Enter an item number or enter '999' to quit application: ");
            item = int.Parse(Console.ReadLine());
            return item;
        }

        public int findItem()
        {
            foundit = "N";
            sub = 0;

            while (sub < ARRAY_SIZE)
            {
                if (item == valid_items[sub])
                {
                    foundit = "Y";
                    selecteditem = valid_items[sub];
                    itemprice = valid_prices[sub];
                }
                sub +=1;
            }
            if (foundit == "Y")
            {
                Console.WriteLine(message_yes);
                Console.WriteLine("The price of item {0} is {1} pesos",selecteditem, itemprice);
            }
            else if (foundit == "N")
            {
                Console.WriteLine(message_no);
                baditemcount += 1;
            }
            Console.WriteLine("Enter an item number or enter '999' to quit application: ");
            item = int.Parse(Console.ReadLine());
            return item;
            
        }

        public void finishUp()
        {
            Console.WriteLine("{0} items had invalid numbers", baditemcount);
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.getReady();

            while (p.item != p.finish)
            {
                p.findItem();
            }

            p.finishUp();
            Console.ReadKey();
        }
    }
}
