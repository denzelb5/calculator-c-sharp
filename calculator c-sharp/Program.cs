using System;
using System.Linq;

namespace calculator_c_sharp
{
    class Program
    {
        public static object Multiply { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers separated by commas with no spaces.");
            var csv = Console.ReadLine();
            var nums = csv.Split(',').Select(n => int.Parse(n)).ToArray();
            

            Console.WriteLine("Type m for multiply or s for square");
            var response = Console.ReadLine();

            switch (response)
            {
                case "m":
                    var finalProduct = 1;

                    for (var i = 0; i < nums.Length; i++)
                    {
                        finalProduct = finalProduct * nums[i];
                    }

                    Console.WriteLine(finalProduct);
                    break;

                case "s":
                    int squaredNumbers;
                    var squaredNumberList = "";
                    for (var i = 0; i < nums.Length; i++)
                    {
                        squaredNumbers = nums[i] * nums[i];
                        squaredNumberList = $"{squaredNumbers}, ";
                        Console.WriteLine(squaredNumberList);
                    }
                    break;
            }

        }
    }
}
    
