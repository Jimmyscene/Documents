using System;

namespace Application{
	public class Warehouse{
	int radios;
	int televisions;
	int computers;
		public Warehouse(){
			this.radios=0;
			this.televisions=0;
			this.computers=0;
		}
		public void setRadios(int count){
			if (count*-1>this.radios){
				System.Console.Write("Amount to remove greater than amount owned. Ignoring request.");
				System.Console.Read();
				System.Console.Clear();
				return;
			}
			this.radios+=count;
			System.Console.Clear();
			System.Console.Write("Value Set.\n");
		}
		public void setTelevisions(int count){
			if (count*-1>this.televisions){
				System.Console.Write("Amount to remove greater than amount owned. Ignoring request.");
				System.Console.Read();
				System.Console.Clear();
				return;
			}
			this.televisions+=count;
			System.Console.Clear();
			System.Console.Write("Value Set.\n");
		}
		public void setComputers(int count){
			if (count*-1>this.computers){
				System.Console.Write("Amount to remove greater than amount owned. Ignoring request.");
				System.Console.Read();
				System.Console.Clear();
				return;
			}
			this.computers+=count;
			System.Console.Clear();
			System.Console.Write("Value Set.\n");
		}
		public void displayContents(){
			System.Console.Write("Radios: {0}\nTelevisions: {1}\nComputers: {2}\n\n\n", radios, televisions,computers);
			System.Console.Read();
			System.Console.Clear();
		}

	}

	public class myApp{
		static void Main(string[] args){
			System.Console.Clear();
			Warehouse w = new Warehouse();
			int answer=0;
			while(answer!=8){
				System.Console.Write("1. Add Radios\n2. Add Televisions\n3. Add Computers\n4. Remove Radios\n5. Remove Televisions\n6. Remove Computers\n7. Display Contents\n8. Quit.\n\nPlease Choose One: ");
				answer=int.Parse(System.Console.ReadLine());
				switch (answer){
					case 1:
						System.Console.Write("Please Enter a quantity to add: ");
						w.setRadios(int.Parse(System.Console.ReadLine()));
						break;
					case 2:
						System.Console.Write("Please Enter a quantity to add: ");
						w.setTelevisions(int.Parse(System.Console.ReadLine()));
						break;
					case 3:
						System.Console.Write("Please Enter a quantity to add: ");	
						w.setComputers(int.Parse(System.Console.ReadLine()));	
						break;
					case 4:
						System.Console.Write("Please Enter a quantity to remove: ");
						w.setRadios(-1*int.Parse(System.Console.ReadLine()));
						break;
					case 5:
						System.Console.Write("Please Enter a quantity to remove: ");
						w.setTelevisions(-1*int.Parse(System.Console.ReadLine()));
						break;
					case 6:
						System.Console.Write("Please Enter a quantity to remove: ");
						w.setComputers(-1*int.Parse(System.Console.ReadLine()));
						break;
					case 7:
						System.Console.Clear();
						w.displayContents();
						break;
					default:
						System.Console.Clear();
						break;
				}
			}
			
		}
	}

}
