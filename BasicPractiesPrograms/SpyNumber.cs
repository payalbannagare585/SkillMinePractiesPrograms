using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractiesPrograms
{
	internal class SpyNumber
	{
		static void Main(string[] args)
		{

			int n;
			Console.WriteLine("Enter the number: ");
			n = int.Parse(Console.ReadLine());
			int digit, sum = 0,
				product = 1;
			while (n > 0)
			{
				digit = n % 10;


				sum += digit;

				// getting the product
				// of digits
				product *= digit;
				n = n / 10;
			}

			if (sum == product)
			{
				Console.WriteLine("Given Number is spy number.");
			}
			else
			{
				Console.WriteLine("Giveen Number is not spy number.");
			}
		}
	}
}
