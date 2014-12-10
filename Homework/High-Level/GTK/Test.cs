using Gtk;
using System;

public class Nim: Window {
	public Nim() : base("Table test"){
		SetDefaultSize(250,250);
		DeleteEvent += delegate {Application.Quit();};
		Table table = new Table(15,15,false);
		Button[] button =  new Button[15];
		uint x=0;
		uint[] nim = new uint[3] {3,5,7};
		
	

		}
		Add(table);
		ShowAll();
		}
		
	
	public static void Main(){
		Application.Init();
		new Nim();
		Application.Run();
	}
}