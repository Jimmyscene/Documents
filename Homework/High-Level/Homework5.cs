class Company{
	int[][] sales;
	int[] stores;
	public Company(){
		this.sales= new int[3][];
		this.stores= new int[] {5,3,2};
		for(int x=0; x<stores.Length; x++){
		this.sales[x]= new int[this.stores[x]]; 
		}
	}
	public void average(){
		double[] average= new double[3];
		for(int region=0; region<this.stores.Length; region++){
			

			for(int sale=0; sale<this.sales[region].Length; sale++){
				average[region]+=sales[region][sale];
			}
			average[region]/=sales[region].Length;

			System.Console.WriteLine("Average Sales For Region {0}: {1:C}",region+1,average[region]);
			
		}
		double temp=0;
		for(int region=0; region<average.Length; region++){
				temp+=average[region];
			}
		temp/=this.stores.Length;
		System.Console.WriteLine("Average Sales For Whole Company: {0:C}",temp);
	}
	static void Main(){
		Company a= new Company();
		for(int store=0; store<3; store++){
			System.Console.WriteLine("Please Input sales for Region {0}.",store+1);
			for(int x=0; x<a.stores[store]; x++){
				System.Console.WriteLine("Please Input Sales for Store {0}:",x+1);
				a.sales[store][x]= int.Parse(System.Console.ReadLine());
				
			}
		}
		a.average();
	}
}

/*
A company has three regions, with five stores in the first region, three in the second, and two in the third. Input the weekly sales for each store. Find the average weekly sales for each region and for the whole company.

You are required to use two dimensional arrays to solve this problem.
*/
