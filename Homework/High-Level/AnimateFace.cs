//Copyright (c) 2002, Art Gittleman
//This example is provided WITHOUT ANY WARRANTY 
//either expressed or implied.

/* Animates a face, drawing it in three different sizes
 * with an interval of 300 milliseconds between each
 * repainting.
 */

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
public class AnimateFace : Form {
  private int x = 10, y = 10;
  private int width = 200, height = 200;
  private int leftEyeX = 50, leftEyeY = 70;
  private int lwidth = 30, lheight = 30;
  private int rightEyeX = 150, rightEyeY = 70;
  private int rwidth = 30, rheight = 30;
  private int leftNoseX = 90, leftNoseY = 120;
  private int rightNoseX = 140, rightNoseY = 120;
  private int mouthX = 50, mouthY = 130;  
  private int mouthWidth = 120, mouthHeight = 40;
  private Button suspend = new Button();
  private Button resume = new Button();
  private Button abort = new Button();
  private Thread t;

  public AnimateFace() {
    BackColor = Color.White;
    Text = "Animate Ball";
    abort.Text = "Abort";
    suspend.Text = "Suspend";
    resume.Text = "Resume";
 
    Controls.Add(suspend);
    Controls.Add(resume);
    Controls.Add(abort);

    int w = 20;
    suspend.Location = new Point(w, 240);
    resume.Location = new Point(w += 10 + suspend.Width, 240);     
    abort.Location = new Point(w += 10 + resume.Width, 240);

    abort.Click += new EventHandler(Abort_Click);
    suspend.Click += new EventHandler(Suspend_Click);
    resume.Click += new EventHandler(Resume_Click);

    t = new Thread(new ThreadStart(Run));
    t.Start();
  }
  protected void Abort_Click(object sender, EventArgs e) {
    t.Abort();
  }
  protected void Suspend_Click(object sender, EventArgs e) {
    t.Suspend();
  }
  protected void Resume_Click(object sender, EventArgs e) {
    t.Resume();
  }
  protected override void OnPaint( PaintEventArgs e )   {
    Graphics g = e.Graphics;
    Pen green = new Pen(Color.Green, 3);  
    Brush red = new SolidBrush(Color.Red);
    g.DrawEllipse(green, x, y, width, height);
    g.FillEllipse
         (Brushes.Blue, leftEyeX, leftEyeY, lwidth, lheight);
    g.FillEllipse
         (Brushes.Blue, rightEyeX, rightEyeY, rwidth, rheight);
    g.DrawLine(green, leftNoseX, leftNoseY, 
                                       rightNoseX, rightNoseY);
    g.FillPie(Brushes.Red, mouthX, mouthY, mouthWidth,
                                        mouthHeight, 0, 180);
    base.OnPaint(e);
  }
  public void Run() {
    int dx=9, dy=9;
    while (true) {
      for (int i = 0; i < 3; i++) { 
        x += dx; 
        y += dy; 
        width -= dx; 
        height -= dy;
        leftEyeX += dx; 
        leftEyeY += dy;
        lwidth -= dx; 
        lheight -= dy;
        rightEyeX += dx; 
        rightEyeY += dy;
        rwidth -= dx; 
        rheight -= dy;
        leftNoseX += dx; 
        rightNoseX -= dx;
        mouthX += dx; 
        mouthY += dy;
        mouthWidth -= dx; 
        mouthHeight -= dy;  
        Invalidate();
        Thread.Sleep(300);
      }
      dx = -dx; dy = -dy; 
    }
  }
  public static void Main( ) {
    Application.Run(new AnimateFace());
  }        
}