//Copyright (c) 2002, Art Gittleman
//This example is provided WITHOUT ANY WARRANTY 
//either expressed or implied.

/* Illustrates some menu and dialog features.
 */

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
public class Notepad : Form {

    // Create control
  TextBox text = new TextBox();
  String filename=null;
  public Notepad() {
      // Configure form
    Size = new Size(500,200);
    Text = "Notepad";
      // Configure text box
    text.Size = new Size(450,120);
    text.Multiline = true;
    text.ScrollBars = ScrollBars.Both;
    text.WordWrap = false;
    text.Location = new Point(20,20);
    text.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
      // Configure file menu
    MenuItem fileMenu = new MenuItem("File");
    MenuItem newfile = new MenuItem("New");
    newfile.Shortcut= Shortcut.CtrlN;
    MenuItem save = new MenuItem("Save");
    save.Shortcut = Shortcut.CtrlS;
    MenuItem open = new MenuItem("Open");
    open.Shortcut = Shortcut.CtrlO;
    MenuItem saveAs = new MenuItem("Save As...");
    saveAs.Shortcut = Shortcut.CtrlShiftS;
    MenuItem close = new MenuItem("Close");
    close.Shortcut = Shortcut.CtrlW;
    fileMenu.MenuItems.Add(newfile);
    fileMenu.MenuItems.Add(open);
    fileMenu.MenuItems.Add(save);
    fileMenu.MenuItems.Add(saveAs);
    fileMenu.MenuItems.Add(close);


      // Configure feedback menu 
    MenuItem feedbackMenu = new MenuItem("Feedback");
    MenuItem message = new MenuItem("Message");
    message.Shortcut = Shortcut.CtrlM;
    feedbackMenu.MenuItems.Add(message); 

      // Configure format menu
    MenuItem formatMenu = new MenuItem("Format");
    MenuItem font = new MenuItem("Font");
    font.Shortcut = Shortcut.CtrlF;
    formatMenu.MenuItems.Add(font);
    
      // Configure edit menu
    MenuItem editorMenu = new MenuItem("Editor");
    MenuItem cut = new MenuItem("Cut");
    MenuItem copy = new MenuItem("Copy");
    MenuItem paste = new MenuItem("Paste");
    editorMenu.MenuItems.Add(cut);
    cut.Shortcut = Shortcut.CtrlX;
    editorMenu.MenuItems.Add(copy);
    copy.Shortcut = Shortcut.CtrlC;
    editorMenu.MenuItems.Add(paste);
    paste.Shortcut = Shortcut.CtrlV;

    //configure help menu
    MenuItem help = new MenuItem("Help");
    MenuItem author = new MenuItem("Author");
    MenuItem date = new MenuItem("What Is Today's Date?");
    help.MenuItems.Add(author);
    help.MenuItems.Add(date);

  // Configure main menu
    MainMenu bar = new MainMenu();
    Menu = bar;
    bar.MenuItems.Add(fileMenu);
    bar.MenuItems.Add(editorMenu);
    bar.MenuItems.Add(feedbackMenu);
    bar.MenuItems.Add(formatMenu);
    bar.MenuItems.Add(help);
      // Add control to form
    Controls.Add(text);

      // Register event handlers  
    newfile.Click += new EventHandler(New_Click);
    open.Click += new EventHandler(Open_Click);
    save.Click += new EventHandler(Save_Click);
    saveAs.Click += new EventHandler(SaveAs_Click);
    close.Click += new EventHandler(New_Click);
    cut.Click += new EventHandler(Cut_Click);
    copy.Click += new EventHandler(Copy_Click);
    paste.Click += new EventHandler(Paste_Click);
    message.Click += new EventHandler(Message_Click);
    font.Click += new EventHandler(Font_Click); 
    author.Click += new EventHandler(Author_Click);
    date.Click += new EventHandler(Date_Click);
  }
  protected override void OnFormClosing(FormClosingEventArgs e){
    // System.Console.WriteLine("called");
    // e.Cancel=true;
    
  }
  // Handle open menu item
  protected void Open_Click(Object sender, EventArgs e) {
    OpenFileDialog o = new OpenFileDialog();
    if(o.ShowDialog() == DialogResult.OK) {
      Stream file = o.OpenFile();
      filename=o.FileName;
      StreamReader reader = new StreamReader(file);
      char[] data = new char[file.Length];
      reader.ReadBlock(data,0,(int)file.Length);
      text.Text = new String(data);  
      reader.Close();
    }
    text.SelectionStart=0;
  }
  // Handle Save menu Item
  protected void Save_Click(Object sender, EventArgs e){
   if(filename==null){
    SaveFileDialog s = new SaveFileDialog();
    if(s.ShowDialog() == DialogResult.OK) {
      filename=s.FileName;
      StreamWriter writer = new StreamWriter(s.OpenFile());
      writer.Write(text.Text);
      writer.Close();
    }}
    else{
    StreamWriter writer = new StreamWriter(filename);
      writer.Write(text.Text);
      writer.Close();
    }
  }
   protected void New_Click(Object sender, EventArgs e) {
    // Application.Run(new Notepad());
    text.Text="";
    filename=null;
  }
    // Handle saveAs menu item
  protected void SaveAs_Click(Object sender, EventArgs e) {
    SaveFileDialog s = new SaveFileDialog();
    if(s.ShowDialog() == DialogResult.OK) {
      filename=s.FileName;
      StreamWriter writer = new StreamWriter(s.OpenFile());
      writer.Write(text.Text);
      writer.Close();
    }
  }
  protected void Cut_Click(Object sender, EventArgs e){
    if(text.SelectedText!=""){
      text.Cut();
    }
  }

    
protected void Copy_Click(Object sender, EventArgs e){
    if(text.SelectionLength>0){
      text.Copy();
    }
  }

protected void Paste_Click(Object sender, EventArgs e){
  if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)==true){
    text.Paste();
  }
}
  // Handle message menu
  protected void Author_Click(Object sender, EventArgs e){
    MessageBox.Show("The Author Of This Application Is Blake Easley.");
  }

  protected void Date_Click(Object sender, EventArgs e){
    MessageBox.Show("Today's date is " +DateTime.Today.ToString("D")+".");
  }
  protected void Message_Click(Object sender, EventArgs e) {
    MessageBox.Show
                ("You clicked the Message menu", "My message");
  }

    // Handle font menu
  protected void Font_Click(Object sender, EventArgs e) {
    FontDialog f = new FontDialog();
    if(f.ShowDialog() == DialogResult.OK) 
      text.Font = f.Font;
  }

  public static void Main() {
    Application.Run(new Notepad());
  }
}
           