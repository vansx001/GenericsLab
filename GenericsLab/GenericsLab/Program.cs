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

            Console.WriteLine("//*LIST ONE*. ADDING TO A LIST:");
            cityList.Add("Milwaukee");
            cityList.Add("Nashville");
            cityList.Add("New York");
            cityList.Add("LA");
            cityList.Add("Seattle");
            cityList.Print();
            Console.ReadLine();

            Console.WriteLine("//REMOVING FROM A LIST (BYE NASHVILLE):");
            cityList.Remove("Nashville");
            cityList.Print();
            Console.ReadLine();

            Console.WriteLine("//THERE ARE {0} CITIES IN THE LIST.", cityList.Count());
            string builder = cityList.GenericToString();
            Console.WriteLine(builder);
            Console.ReadLine();

            GenericList<string> cityListTwo = new GenericList<string>();
            Console.WriteLine("//*LIST TWO*.");
            cityListTwo.Add("New Orleans");
            cityListTwo.Add("Las Vegas");
            //cityListTwo.Add("Atlanta");
            //cityListTwo.Add("Springfield");
            cityListTwo.Print();
            Console.ReadLine();

            GenericList<string> combinedList = new GenericList<string>();
            Console.WriteLine("//OVERLOADING OPERATORS (+). LIST ONE + LIST TWO.");
            combinedList = cityList + cityListTwo;
            combinedList.Print();
            Console.ReadLine();

            Console.WriteLine("//OVERLOADING OPERATORS (-). REMOVING LIST ONE.");
            combinedList = combinedList - cityList;
            combinedList.Print();
            Console.ReadLine();

            Console.WriteLine("//ZIPPER");
            GenericList<string> zipList = new GenericList<string>();
            zipList.Zipper(cityList, cityListTwo);
            zipList.Print();
            Console.ReadLine();
        }
    }
}
