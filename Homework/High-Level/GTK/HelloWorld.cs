using System;
using Gtk;

public class GtkHelloWorld {

	public static void Main() {
		Application.Init();

		//Create the Window
		Window myWin = new Window("My First GTK# Application");
		myWin.Resize(200,200);

		//Create a label and put some text in it.
		Label myLabel = new Label();
		myLabel.Text = "Hello World!!!";

		//add the label to the form
		myWin.Add(myLabel);
		myWin.ShowAll();
		Application.Run();
	}
}
