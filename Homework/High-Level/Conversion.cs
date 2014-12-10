using System;

namespace Application{

	public class HelloWorld{
		public int temp(int temperature){
			return 5*(temperature-32)/9;
		}
		public int miles(int miles){
			return miles*5280;
		}

		static void Main (string[] args)
		{
			HelloWorld cs = new HelloWorld();
			System.Console.WriteLine("1. Convert Miles To Feet\n2. Convert Fahrenheit to Celsius");
			int answer = int.Parse(System.Console.ReadLine());
			switch(answer){
				case 1:
				System.Console.WriteLine("Input Number of Miles to Convert To Feet");
				int answer2=int.Parse(System.Console.ReadLine());
				System.Console.WriteLine("{0} miles is equivalent to {1} feet", answer2, cs.miles(answer2));
				break;
				case 2:
				System.Console.WriteLine("Input Temperature in Fahrenheit to Convert to Celsius");
				int answer3=int.Parse(System.Console.ReadLine());
				System.Console.WriteLine("{0} degrees Fahrenheit is equivalent to {1} degrees Celsius", answer3, cs.temp(answer3));
				break;
				default:
				System.Console.WriteLine("Incorrect Input");
				break;
			}

		}
	
	}
}