using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericList<string> cityList = new GenericList<string>();

            Console.WriteLine("US CITIES:");
            cityList.Add("Milwaukee");
            cityList.Add("Nashville");
            cityList.Add("New York");
            cityList.Add("LA");
            cityList.Add("Seattle");
            cityList.Remove("Nashville");

            Console.WriteLine(String.Join(" | ",cityList));
            Console.ReadLine();
        }
    }
}
