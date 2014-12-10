using Gtk;
using Pango;
using Cairo;
using System;
using System.Collections.Generic;

public class Token : EventBox {
	bool selected= false;
	uint x;
	uint y;
	DrawingArea darea = new DrawingArea();
	public Token(uint x, uint y){
		this.x=x;
		this.y=y;
		
		darea.ExposeEvent += OnExpose;
		ButtonPressEvent += delegate {
			selected= !selected;	
			OnExpose(darea, new ExposeEventArgs());
			};
		Add(darea);
		darea.Show();
	}
	void OnExpose(object sender, ExposeEventArgs args){
		DrawingArea area = (DrawingArea) sender;
		Cairo.Context cr = Gdk.CairoHelper.Create(area.GdkWindow);
		cr.LineWidth = 9;
		if(!selected){
			cr.SetSourceRGB(.55,.56,0);
		}
		else
			cr.SetSourceRGB(.55,0,0);
			int width, height;
		width= Allocation.Width;
		height = Allocation.Height;

		cr.Translate(width/2, height/2);
		cr.Arc(0,0, (width<height ?width : height) / 2-10, 0, 2*Math.PI);
		cr.StrokePreserve();

		cr.SetSourceRGB(.5,.35,0);
		cr.Fill();
		((IDisposable) cr.GetTarget()).Dispose();
		((IDisposable) cr).Dispose();
	}
	public bool getActive(){
		return this.selected;
	}
	public void setActive(bool active){
		this.selected=active;
		OnExpose(darea, new ExposeEventArgs());	
	}
	public uint[] getLocation(){
		return new uint[] {x,y};
	}

}
public class Nim: Window{
	Label label = new Label("Your turn");
	String font="Arial 40";
	Table table = new Table(5,7, false);
	List<Token> tokens = new List<Token>();
	Button end_btn = new Button("End Turn");
	Button clear_selected= new Button("Clear Selected");
	VBox vbox= new VBox(true,1);
	uint[] nim = new uint[3] {3,5,7};
	uint x=0;
	
    


	public Nim() : base("Play A Game of Nim"){
		SetDefaultSize(600,450);
		SetPosition(WindowPosition.Center);
		DeleteEvent += delegate {Application.Quit();};
		KeyPressEvent += keyEvents;
		table.Attach(label,0,7,0,1);
		Pango.FontDescription fontdesc = Pango.FontDescription.FromString(font); 
		label.ModifyFont(fontdesc);
		for(uint rows=0; rows<nim.Length; rows++){
			for(uint cols=0; cols<nim[rows]; cols++){
				tokens.Add(new Token(rows,cols));
				
				table.Attach(tokens[(int)x], cols, cols+1, rows+1, rows+2);
				x++;
			}
		}	
				
		clear_selected.Clicked+= delegate {
			
		foreach(Token tkn in tokens){
			tkn.setActive(false);
		}
		QueueDraw();
		};

		end_btn.Clicked+= end_Turn;
		table.Attach(end_btn,0,4,4,5);
		table.Attach(clear_selected,4,7,4,5);
		vbox.PackStart(table);
		Add(vbox);
		ShowAll();
	}
	void keyEvents(object sender, KeyPressEventArgs args){
		if(args.Event.Key.ToString()[0]=='d'){
			end_btn.Click();
		}
		if(args.Event.Key.ToString()[0]=='n'){
			new Nim();
			Destroy();
		}

	}
	void end_Turn(object sender, EventArgs args){
		int selected=0;
		foreach(Token tkn in tokens){
			if(tkn.getActive()==true) selected++;
		}

		
		if(selected>3 || selected ==0){
			label.Text="Please select between one and three tokens.";
			label.ModifyFont(Pango.FontDescription.FromString("Arial 20"));
		}
		else
		{
			List<Token> mytokns= new List<Token>();
			foreach(Token tkn in tokens){
				if(tkn.getActive()==true) {table.Remove(tkn); mytokns.Add(tkn);}
			}
			foreach(Token tkn in mytokns){
				tokens.Remove(tkn);
			}
			if(tokens.Count==0){
				label.Text="Player loses!";
				end_btn.Sensitive=false;
				clear_selected.Label = "New Game";
				clear_selected.Clicked+= delegate{
					new Nim();
					Destroy();
				};
			}
			else{
			Random rand = new Random();
			int max=4;
			if(max>tokens.Count) max=tokens.Count;
			int myrand= rand.Next(1,max);
			label.Text=string.Format("CPU Chooses {0} tokens",myrand);
			for(int x=0; x<myrand; x++){
				int value=rand.Next(0,tokens.Count);
				table.Remove(tokens[value]);
				tokens.Remove(tokens[value]);
			}
			if(tokens.Count==0){
				label.Text="Player Wins!";
				end_btn.Sensitive=false;
				clear_selected.Label = "New Game";
				clear_selected.Clicked+= delegate{
					new Nim();
					Destroy();
				};

			}
}
		}
		

}
	
	public static void Main(){
		Application.Init();
		new Nim();
		Application.Run();
	}
}



