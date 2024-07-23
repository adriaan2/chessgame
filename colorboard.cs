// namespace chess;

// partial class Form1
// {
//     /// <summary>
//     ///  Required designer variable.
//     /// </summary>
//     private System.ComponentModel.IContainer components = null;

//     /// <summary>
//     ///  Clean up any resources being used.
//     /// </summary>
//     /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//     protected override void Dispose(bool disposing)
//     {
//         if (disposing && (components != null))
//         {
//             components.Dispose();
//         }
//         base.Dispose(disposing);
//     }

//     #region Windows Form Designer generated code

//     /// <summary>
//     ///  Required method for Designer support - do not modify
//     ///  the contents of this method with the code editor.
//     /// </summary>
//     private void InitializeComponent()
//     {
//         this.components = new System.ComponentModel.Container();
//         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//         this.ClientSize = new System.Drawing.Size(1200, 850);
//         this.Text = "Form1";
//         Button button=new Button();
//         button.Size=new Size(400,100);
//         button.Location=new Point(100);
//         button.Text="Play as White";
//         button.Click+=white2;

//         Button button1=new();
//         button1.Text="Play as black";
//         button1.Size=new Size(400,100);
//         button1.Location=new Point(100,100);
//         button1.Click+=black;

    
//         Controls.Add(button);
//         Controls.Add(button1);
//     }
//     public void white(Panel[,] panels,Button[] pieces,Button [] lowerpieces,Button [] playerpieces, Button [] oppennentpieces){
//         Controls.RemoveAt(0);
//         Controls.RemoveAt(0);
//         for (int i = 0; i < pieces.Length; i++)
//         {
//             Controls.Add(pieces[i]);

//         }
//         for (int i = 0; i < playerpieces.Length; i++)
//         {
//             Controls.Add(playerpieces[i]);

//         }
//         for (int i = 0; i < lowerpieces.Length; i++)
//         {
//                                                     Controls.Add(lowerpieces[i]);

//         }

//         for (int i = 0; i < panels.GetLength(0); i++)
//         {
//             for (int j = 0; j < panels.GetLength(0); j++)
//             {
//              Controls.Add(panels[i,j]);   
//             }
//         }
        

//     }

//     #endregion
// }
