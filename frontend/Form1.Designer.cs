namespace chess;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1200, 850);
        this.Text = "Form1";
        Button button=initialization.buttoninitialization("Play as white",400,100,100,0);
      
        
      
        button.Click+=white2;

        Button button1=initialization.buttoninitialization("Play as black",400,100,100,100);
        
        button1.Click+=black;

    
        Controls.Add(button);
        Controls.Add(button1);
    }
    public void white(Panel[,] panels,Button[] opponentpieces,Button [] playerpieces,Button [] playerpawns, Button [] opponetpawns){
        Controls.RemoveAt(0);
        Controls.RemoveAt(0);
        arrayadder(opponentpieces);
        arrayadder(playerpieces);
        arrayadder(playerpawns);
       arrayadder(opponetpawns);

        for (int i = 0; i < panels.GetLength(0); i++)
        {
            for (int j = 0; j < panels.GetLength(0); j++)
            {
             Controls.Add(panels[i,j]);   
            }
        }
    }
    public void arrayadder(Control [] objects){
        for (byte i = 0; i < objects.Length; i++)
        {
            Controls.Add(objects[i]);
        }
    }

    #endregion
}
