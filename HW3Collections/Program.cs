using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(0, 10);
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            for (int i = 1; i <=n; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("Original list is {0}", string.Join(", ", list));

            while (list.Count > 1)
            {
                for (int i = 0; i < list.Count; i++)
                {

                    
                    if (i%2==0)
                    {
                        list.RemoveAt(i);
                        Console.WriteLine("Modified list is {0}", string.Join(", ", list));
                    }
                }

            }





        }
           
    }
}

