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
        }

        static string GetClass1()
        {
            Class1 c1 = new Class1()
            {
                Id = 0,
                Name = "Jon Doe"
            };

            string json = JsonConvert.SerializeObject(c1);

            return json;
        }
    }
}