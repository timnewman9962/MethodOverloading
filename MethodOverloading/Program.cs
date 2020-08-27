using System;

namespace MethodOverloading
{
    class Program
    {
		static int Add(int a, int b)
		{
			return a + b;
		}

		static decimal Add(decimal a, decimal b)
		{
			return a + b;
		}

		static string Add(int a, int b, bool bShow)
		{
			if (!bShow)
				return $"{a + b}";

			return $"{a + b} dollar{(a + b == 1 ? "" : "s")}";
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Input a number:");
			var a = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine(a);
			Console.WriteLine("Input another number:");
			var b = Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine(b);

			Console.WriteLine($"\nAdd integers: {Add(a, b)}");

			var A = a * 1.0m;
			var B = b * 1.0m;
			Console.WriteLine($"\nAdd decimals: {Add(A, B)}");

			Console.WriteLine($"\nAdd with bool = true: {Add(a, b, true)}");
			Console.WriteLine($"\nAdd with bool = false: {Add(a, b, false)}");

		}
	}
}
