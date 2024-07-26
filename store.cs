// using System.Security.Cryptography.X509Certificates;

// namespace chess;

// public partial class Form1 : Form
// {
//     string whitepawn="♙ ";
//     string blackpawn="♟ ";
//     string [] blackpieces=new string[]{
//         "♜",
//         "♞",
//         "♝",
//         "♛",
//         "♚",
//         "♝",
//         "♞",
//         "♜"
       
        


//     };
//     public string[] whitepieces=new string[]{
//         "♖",
//         "♘",
//         "♗",
//         "♕",
//         "♔",
//         "♗",
//         "♘",
//         "♖",
//     };
//     public Form1()
//     {
//         InitializeComponent();
//     }
       
//     public void printboard(Func<int,int,bool> func,string [] strings1, string [] strings2, string toppiece, string lowerpieces ){
//             Panel [,] chesspieces=new Panel[8,8];
//             Button [] upperchespieces=new Button[8];
//             Button[] playerpawn=new  Button[8];
//             Button [] opponentpawn=new Button[8];
//             Button [] lowerchesspieces=new Button[8];
//             for (int i = 0; i < chesspieces.GetLength(0); i++)
//             {
//                // MessageBox.Show("first loop");
//                 for (int j = 0; j < chesspieces.GetLength(1); j++)
//                 {
//                     if (i==0)
//                     {
//                         Button chesspiece=new();
//                         chesspiece.Location=new Point((80*j)+160,(80*i)+54);
//                         chesspiece.Text=strings1[j];
//                         chesspiece.Size=new Size(60,60);
//                         upperchespieces[j]=chesspiece;  
//                         chesspiece.Font = new Font(chesspiece.Font.FontFamily, chesspiece.Font.Size*(float) 3.2);
                      

//                     }
//                     if (i==6)
//                     {
//                         Button button =new();
//                         button.Text=toppiece;
//                         button.Location=new Point((80*j)+160,(80*i)+54);
//                         button.Size=new Size(60,60);
//                         playerpawn[j]=button;
//                         button.Font = new Font(button.Font.FontFamily, button.Font.Size*(float) 3.2);

//                     }
//                     if (i==6)
//                     {
//                          Button button =new();
//                         button.Text=toppiece;
//                         opponentpawn[j]=button;   
//                     }

                    
//                     if (i==7)
//                     {
//                         Button chesspiece=new();
//                         chesspiece.Location=new Point((80*j)+160,(80*i)+54);
//                         chesspiece.Text=strings2[j];
//                         chesspiece.Size=new Size(60,60);
//                         lowerchesspieces[j]=chesspiece;                        
//                         chesspiece.Font = new Font(chesspiece.Font.FontFamily, chesspiece.Font.Size*(float)3.1);
//                         chesspiece.BackColor=Color.Transparent;
//                         chesspiece.UseVisualStyleBackColor = false; // Ensure no default styling


//                     }
//                     chesspieces[i,j]=new();
//                     chesspieces[i,j].Size=new Size(80,80);
//                     chesspieces[i,j].Location=new Point((80*j)+150,(80*i)+50);
               
//                    if (func(i,j))
//                     {

//                         chesspieces[i,j].BackColor=Color.White;
//                     }
//                 else 
//                     {
                        

//                     chesspieces[i,j].BackColor=Color.Black;
                    
                        
                    
                       
                    
//     //Location: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.5\System.ComponentModel.dll
                
//                 }}
//             }

//         white(chesspieces,upperchespieces,lowerchesspieces,playerpawn,opponentpawn);
//     }

//     public  void black(object o, EventArgs eventArgs){
//         Func<int, int ,bool> func =    (int x ,int y)=> (x%2!=0&&y%2==0)||(x%2==0&&y%2!=0);

// printboard(func,whitepieces, blackpieces,blackpawn,whitepawn);
        

// }
//     public  void white2(object o, EventArgs eventArgs){
//         Func<int, int ,bool> func =    (int x ,int y)=> (x%2!=0&&y%2!=0)||(x%2==0&&y%2==0);
// printboard(func,blackpieces,whitepieces,whitepawn,blackpawn);
        

// }

// }