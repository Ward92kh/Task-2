using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt_path = "d:\\file.txt";
            int order;
            bool OrderByASC = true;
           // bool OrderByDes = false;
            var dict = new Dictionary<string, int>();
            Console.WriteLine("Please press 1 to Descending order or 2 to Ascending order..");
            order=Convert.ToInt32(Console.ReadLine()); 
            foreach (string line in File.ReadLines(txt_path))
            {
                dict[line.Substring(0, line.LastIndexOf(' ') - 1)] = int.Parse(line.Substring(line.LastIndexOf(' ') + 1));
            }
            if (OrderByASC & order==2)
            {
                foreach (KeyValuePair<string, int> dict_ in dict.OrderBy(key => key.Value))
                {
                    Console.WriteLine("Name: {0}, ID: {1}", dict_.Key, dict_.Value);
                }
            }
            else
            {
                foreach (KeyValuePair<string, int> dict_ in dict.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine("Name: {0}, ID: {1}", dict_.Key, dict_.Value);
                }
            }
            Console.ReadLine();

        }
    }
}
