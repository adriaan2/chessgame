using System.Windows.Forms.VisualStyles;

public class initialization
{
    
    public initialization(){

    }
    public static Button buttoninitialization(string Text, int xsize, int ysize, int xlocation, int ylocation){
                            
                Button button=new();
                button.Text=Text;
                button.Location=new Point(xlocation,ylocation);
                button.Size=new Size(xsize,ysize);
                button.Tag="";
                return button;
    }
    public static Button buttoninitialization(string Text, int xsize, int ysize, int xlocation, int ylocation,object  Tag) 
    {
        return buttoninitialization(Text,xsize,ysize,xlocation,ylocation);
    } public static Panel panelInitialization(int xsize, int ysize, int xlocation, int ylocation)
{
    Panel panel = new Panel();
    panel.Size = new Size(xsize, ysize);
    panel.Location = new Point(xlocation, ylocation);
    return panel;
}

}