using BlahApp.Domain;
using Newtonsoft.Json;
using System;

namespace BlahApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string jsonClass1 = GetClass1();
            Console.WriteLine(jsonClass1);

            string jsonClass11 = GetClass11();
            Console.WriteLine(jsonClass11);
        }

        static string GetClass1()
        {
            Class1 c1 = new Class1
            {
                Id = 0,
                Name = "Jon Doe"
            };

            string json = JsonConvert.SerializeObject(c1);
            return json;
        }

        static string GetClass11()
        {
            Class11 c11 = new Class11
            {
                Id = 0,
                Name = "Jon Doe",
                Status = 2
            };

            string json = JsonConvert.SerializeObject(c11);
            return json;
        }
    }
}