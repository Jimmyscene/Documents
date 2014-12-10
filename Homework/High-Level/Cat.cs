namespace Application{
	public class Cat{
		private int x;
		private int y;
		private int z;
		public Cat(){
		x=0;
		y=0;
		z=0;
		}

		public void Walk(int a, int b){
			x+=a;
			y+=b;
		}
		public void Jump(int c){
			z+=c;
		}
		public void Display(){
			System.Console.WriteLine("Cat Position: ({0},{1},{2})",x,y,z);
		}
		
		
		static void Main(string[] args){
			Cat c= new Cat();
			c.Walk(1,2);
			c.Display();
		}
	}
}