using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
       public  Button[] b = new Button[8];
        bool turn = false; //x-xturn ,true -o turn
        string s = "THE WINNER IS PLAYER  ";

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void clickChanged(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                label1.Visible = true;
                label2.Visible = false;
                label3.Text = " TURN O";
                
            }
            else
            {
                b.Text = "O";
                label2.Visible = true;
                label1.Visible = false;
                label3.Text = "TURN X";
            }
            turn = !turn;
            b.Enabled = false;
            makeaMove();
        }

        private void makeaMove( )
        {
            bool win = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            
            
                win = true;
           
               // lblWin.Text =s + A1.Text.ToString();
            
            else if( (B1.Text == B2.Text )&&( B2.Text == B3.Text) && (!B1.Enabled))
                
                win = true;
               // lblWin.Text = s + B1.Text.ToString();
            
           else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled) )
            
                win = true;
              //  lblWin.Text = s + C1.Text.ToString();
            
           else  if ( (A1.Text == B1.Text) && (A1.Text == C1.Text) && (!C1.Enabled) )
            
                win = true;
              //  lblWin.Text = s + A1.Text.ToString();
            
           else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!C2.Enabled))
            
                win = true;
               // lblWin.Text = s + A2.Text.ToString();
            
           else if ( (A3.Text ==B3.Text) && (B3.Text == C3.Text) && (!C3.Enabled))
            
                win = true;
              //  lblWin.Text = s + A3.Text.ToString();
            
           else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!B2.Enabled)  )
           
                win = true;
            // lblWin.Text = s + A1.Text.ToString();

           else if ( ( A3.Text == B2.Text) && (B2.Text == C1.Text) && (!B2.Enabled)  )
            
                win = true;
            // lblWin.Text = s + A3.Text.ToString();

            if (win == true)
            {
                gameOver();

                if (turn)
                
                     lblWin.Text = s + "O";
                
                else
                
                    lblWin.Text = s + "X";
                
            }
                
        }

        private void gameOver()
        {
            try
            {
                foreach (Control k in Controls)
                {
                   Button  b = (Button)k;
                    k.Enabled = false;
                }
            }
            catch
           { }
        }
        private void bTNeXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
