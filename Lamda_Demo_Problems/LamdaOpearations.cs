﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Demo_Problems
{
    public class LamdaOpearations
    {
        public static void Animals()
        {
            List<Model> models = new List<Model>();
            models.Add(new Model(1, "Dog", 3));
            models.Add(new Model(2, "Horse", 12));
            models.Add(new Model(3, "Cat", 2));
            models.Add(new Model(4, "Rat", 1));
            models.Add(new Model(5, "Goat", 4));
            models.Add(new Model(6, "Cow", 9));
            var result1 = models.Select(x => x.S_NO);
            var result2 = models.Select(x => x.Name);
            var result3 = models.Select(x => x.Age);
            Console.WriteLine("S_No Displaying");
            Console.WriteLine("---------------");
            foreach (var data in result1)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Names Displaying");
            Console.WriteLine("---------------");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Age Displaying");
            Console.WriteLine("---------------");
            foreach (var sos in result3)
            {
                Console.WriteLine(sos);
            }
        }
        public static void EvenNmbers(List<int> list)
        {
            Console.WriteLine("Even Numbers");
            Console.WriteLine("-------------");
            foreach (int data in list.FindAll(x => (x % 2) == 0))
            {
                Console.WriteLine(data);
            }
        }
        public static void GreaterNmbers5(List<int> list)
        {
            Console.WriteLine("Greater Than 5 Numbers");
            Console.WriteLine("----------------------");
            foreach (int data in list.FindAll(x => (x > 5)))
            {
                Console.WriteLine(data);
            }
        }
        public static void Less_Than_7(List<int> list)
        {
            Console.WriteLine("Less Than 7 Numbers");
            Console.WriteLine("----------------------");
            if (list.Any(x => (x < 7)))
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
