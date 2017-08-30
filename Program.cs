using System;

namespace consoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello .NET World!!!!");

            Console.WriteLine("Please enter fahrenheit temp to convert in celsius..");
            string input = Console.ReadLine();
            float result = F2C(input);
            Console.WriteLine("Temp in celsius is {0} for today ", result.ToString());

            Console.WriteLine("Press any key");
            Console.ReadKey();

			Console.WriteLine("Please enter celsius temp to convert in fahrenheit..");
            string input1 = Console.ReadLine();
			float result1 = C2F(input1);
            Console.WriteLine($"Temp in fahrenheit is {result1.ToString()} for today");

			Console.WriteLine("Press any key");
			Console.ReadKey();

		}

        private static float F2C(string input)
        {
            	float fahrenheit = 0;

                //fahrenheit = float.Parse(input);
                if (float.TryParse(input, out fahrenheit))
                {
                    var result = (fahrenheit - 32) * (5.0f / 9);
                    return result;
                }
                else
                {
                    throw new Exception($"Your input {input} could npt be converted into the number..");
                }
        }

		private static float C2F(string input1)
		{
			float celsius = float.Parse(input1);

			var result1 = (celsius * 1.8f) + 32;
			return result1;
		}
    }
}
