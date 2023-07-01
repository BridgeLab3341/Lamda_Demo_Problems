using System.Xml.Serialization;

namespace Lamda_Demo_Problems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lamda Expressions Demo");
            Console.WriteLine("----------------------");
            //LamdaOpearations.Animals();
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //LamdaOpearations.EvenNmbers(list);
            //LamdaOpearations.GreaterNmbers5(list);
            LamdaOpearations.Less_Than_7(list);
        }
    }
}