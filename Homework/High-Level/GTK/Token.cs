using Gtk;
using Cairo;
using System;

class SharpApp : Window {

	public SharpApp() : base("Simple drawing"){
		SetDefaultSize(230,150);
		SetPosition(WindowPosition.Center);
		DeleteEvent += delegate {Application.Quit();};

		DrawingArea darea = new DrawingArea();
		darea.ExposeEvent += OnExpose;

		Add(darea);
		
		ShowAll();
	}
	void OnExpose(object sender, ExposeEventArgs args){
		DrawingArea area = (DrawingArea) sender;
		Cairo.Context cr = Gdk.CairoHelper.Create(area.GdkWindow);
		cr.LineWidth = 9;
		cr.SetSourceRGB(.55,.56,0);
		int width, height;
		width = Allocation.Width;
		height = Allocation.Height;

		cr.Translate(width/2, height/2);
		cr.Arc(0,0, (width<height ? width : height) / 2-10,0,2*Math.PI);
		cr.StrokePreserve();

		cr.SetSourceRGBA(.5,.35,0,1.0);
		cr.Fill();

		((IDisposable) cr.GetTarget()).Dispose();
		((IDisposable) cr).Dispose();
		}
	public static void Main(){
		Application.Init();
		new SharpApp();
		Application.Run();
	}


}
