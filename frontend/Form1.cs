
using System.Security.Cryptography.X509Certificates;

namespace chess;

public partial class Form1 : Form
{
    string whitepawn="♙ ";
    string blackpawn="♟ ";
    string [] blackpieces=new string[]{
        "♜",
        "♞",
        "♝",
        "♛",
        "♚",
        "♝",
        "♞",
        "♜"
       
        


    };
    public string[] whitepieces=new string[]{
        "♖",
        "♘",
        "♗",
        "♕",
        "♔",
        "♗",
        "♘",
        "♖",
    };
    public Form1()
    {
        InitializeComponent();
    }
       
public void printboard(Func<int,int,bool> func, string[] playerpieces, string[] opponentpieces, string playerpawn, string oppennentpawn)
{
    Panel[,] chesspieces = new Panel[8, 8];
    Button[] playerpiecearray = new Button[8];
    Button[] playerpawns = new Button[8];
    Button[] opponentpawn = new Button[8];
    Button[] opponentchesspiecesarray = new Button[8];

    for (int i = 0; i < chesspieces.GetLength(0); i++)
    {
        for (int j = 0; j < chesspieces.GetLength(1); j++)
        {
            if (i == 0)
            {
                Button chesspiece =initialization.buttoninitialization(playerpieces[j], 60, 60, (80 * j) + 160, (80 * i) + 54);
                playerpiecearray[j] = chesspiece;
                chesspiece.Font = new Font(chesspiece.Font.FontFamily, chesspiece.Font.Size * (float)3.2);
            }
            if (i == 6)
            {
                Button button =initialization.buttoninitialization(playerpawn, 60, 60, (80 * j) + 160, (80 * i) + 54);
                playerpawns[j] = button;
                button.Font = new Font(button.Font.FontFamily, button.Font.Size * (float)3.2);
#pragma warning disable CS8622 
                button.Click += Form2.playerpawnclick;
#pragma warning restore CS8622 
            }
            if (i == 1)
            {

                Button button =initialization.buttoninitialization(oppennentpawn, 60, 60, (80 * j) + 160, (80 * i) + 54);
             button.Font = new Font(button.Font.FontFamily, button.Font.Size * (float)3.2);

                opponentpawn[j] = button;
#pragma warning disable CS8622 
                    button.Click += Form2.oppennentpawn;
#pragma warning restore CS8622
                }

            if (i == 7)
            {
                Button chesspiece =initialization.buttoninitialization(opponentpieces[j], 60, 60, (80 * j) + 160, (80 * i) + 54,opponentpieces[j]);
                opponentchesspiecesarray[j] = chesspiece;
                chesspiece.Font = new Font(chesspiece.Font.FontFamily, chesspiece.Font.Size * (float)3.1);
            }

            chesspieces[i, j] =initialization.panelInitialization(80,80,80*j+150,(80*i+54));
           

            if (func(i, j))
            {
                chesspieces[i, j].BackColor = Color.White;
            }
            else
            {
                chesspieces[i, j].BackColor = Color.Black;
            }
        }
    }

    white(chesspieces, playerpiecearray, opponentchesspiecesarray, playerpawns, opponentpawn);
}

    public  void black(object o, EventArgs eventArgs){
        Func<int, int ,bool> func =    (int x ,int y)=> (x%2!=0&&y%2==0)||(x%2==0&&y%2!=0);

printboard(func,whitepieces, blackpieces,blackpawn,whitepawn);
        

}
    public  void white2(object o, EventArgs eventArgs){
        Func<int, int ,bool> func =    (int x ,int y)=> (x%2!=0&&y%2!=0)||(x%2==0&&y%2==0);
printboard(func,blackpieces,whitepieces,whitepawn,blackpawn);
        

}

}