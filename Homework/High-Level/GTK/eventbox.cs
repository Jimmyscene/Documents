using Cairo;
using Gtk;
using System;

class SharpApp : Window {
	public SharpApp() : base("EventBox Example"){
		SetDefaultSize(230,150);
		SetPosition(WindowPosition.Center);
		DeleteEvent += delegate {Application.Quit();};

		EventBox ebox = new EventBox();
		Add(ebox);
		ebox.Show();
		Label label = new Label("Do Not Touch");
		ebox.Add(label);
		label.Show();
		label.SetSizeRequest(110,20);

		ebox.ButtonPressEvent += delegate{ System.Console.WriteLine("Hello");};
		ebox.Realize();

		Show();
	}

	public static void Main(){
		Application.Init();
		new SharpApp();
		Application.Run();
	}
}
