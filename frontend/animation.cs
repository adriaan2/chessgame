
using chess;

public static class Form2
{
              static  int x=0;
    static Form2(){
        
    }
    public static void playerpawnclick(object o, EventArgs eventArgs){

            if (o is Button button)
            {
                x++;

                button.Location = new Point(button.Location.X, button.Location.Y - 81);
                // new Point(button.Location.X, button.Location.Y - 72);

            }
    }
    public static void oppennentpawn(object o, EventArgs eventArgs){
        if (o is Button button)
        {
        button.Location = new Point(button.Location.X, button.Location.Y + 81);
   
        }

    }  
}