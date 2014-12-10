using System;

namespace Application{
	public class Mortgage{
		public int months(){
			System.Console.WriteLine("Please input amount you wish to borrow:");
			double borrow=double.Parse(System.Console.ReadLine());
			System.Console.WriteLine("\n");
			System.Console.WriteLine("Please input the annual interest rate: ");
			double rate=double.Parse(System.Console.ReadLine()); 
			System.Console.WriteLine("\n");
			System.Console.WriteLine("Please input the monthly payment: ");
			int payment=int.Parse(System.Console.ReadLine());
			System.Console.WriteLine("\n");
			int months=0;
			rate/=12;
			while(borrow>0){
				months++;
				double temp = borrow+borrow*(rate/100);
				temp=temp-payment;
				borrow=temp;
				
			}
			System.Console.Clear();
			return months;
		}
		public bool affordability(){
			int required=months();
			System.Console.WriteLine("Please input the number of months you wish to pay it off in: ");
			int wanted=int.Parse(System.Console.ReadLine());
			System.Console.WriteLine("\n");
			if(required>wanted){
				return false;
			}
			else{
				return true;
			}
		}
		static void Main(string[] args){

		Mortgage m = new Mortgage();
		
		int answer=0;
		while(answer!=3){
			System.Console.WriteLine("1.Find out how many months it will take to pay off the loan.\n2.Can I afford it?\n3.Exit\n");
			answer= int.Parse(System.Console.ReadLine());
			if(answer==1){
				System.Console.WriteLine(m.months()+" month(s) would be required to pay off the loan\n");
				System.Console.ReadLine();

			}
			if(answer==2){

				if(m.affordability()){
					System.Console.ReadLine();
					System.Console.WriteLine("You can afford the loan.\n");
				}
				else{
					System.Console.ReadLine();
					System.Console.WriteLine("You cannot afford the loan\n");
				}
			}
		}
		}

/*
Write a program to solve a mortgage problem.  Suppose you borrow $1000 at 12% annual interest rate and make monthly payments of $100. Each month you pay interest on the remaining balance. The interest rate is 1% per month, so the first month you pay $10 interest and 90% goes to reduce the balance to %910. The next month’s interest is $9.10 and $90.90 is applied to reduce the balance, and so on. The last month’s payment may be less than $100.

When the program starts, display a menu like the following:
1. Find out how may months it will take to pay off the loan
2. Can I afford to it?
3. Exit

If the user chooses 1, ask the user to enter three numbers: the amount he/she wants to borrow, interest rate and monthly payment. Your program will calculate how many months it will take to pay off the loan and display the result.

If the user chooses 2, ask the user to enter four numbers: the amount he/she wants to borrow, interest rate, monthly payment and the number of months to pay off the loan. You would need to calculate and tell whether he/she pay off the loan.

If the user chooses 3, finish the program.
*/


















	}
}
