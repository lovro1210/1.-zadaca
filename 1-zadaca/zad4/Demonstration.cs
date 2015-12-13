using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    public class Demonstration
    {
        public static void Main(string[] args)
        {
            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("!");
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
