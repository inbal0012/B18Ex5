using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinApp
{
    public class Matrix : Control
    {
        Button[,] m_board;
        int m_Size;

        public int MatrixSize
        {
            get { return m_Size; }
        }

        public Matrix(int i_Size)
        {
            m_Size = i_Size;
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            m_board = new Button[m_Size, m_Size];

            m_board[0, 0].Location = this.Location;

            for (int j = 1; j < m_Size; j++)
            {
                m_board[0, j].Location = new System.Drawing.Point(m_board[0, j - 1].Left, m_board[0, j - 1].Top);
            }
            for (int i = 1; i < m_Size; i++)
            {
                m_board[i, 0].Location = new System.Drawing.Point(m_board[i - 1, 0].Left, m_board[i - 1, 0].Bottom);
                for (int j = 1; j < m_Size; j++)
                {
                    m_board[i,j] = new Button();
                    m_board[i, j].Location = new System.Drawing.Point(m_board[i, j - 1].Right, m_board[i, j - 1].Top);
                    if ((i + j) % 2 == 1)
                    {
                        m_board[i, j].Enabled = (i + j) % 2 == 1;
                        m_board[i, j].BackColor = System.Drawing.Color.White;
                        m_board[i, j].Name = string.Format("{0},{1}", i, j);
                        //TODO m_board[i, j].Text 
                        m_board[i, j].Text = m_board[i, j].Name;
                    }
                }
                //this.button2 = new System.Windows.Forms.Button();
                //// 
                //// button1
                //// 
                //this.button1.BackColor = System.Drawing.Color.White;
                //this.button1.Location = new System.Drawing.Point(13, 31);
                //this.button1.Name = "button1";
                //this.button1.Size = new System.Drawing.Size(40, 40);
                //this.button1.TabIndex = 0;
                //this.button1.Text = "button1";
                //this.button1.UseVisualStyleBackColor = false;
                //// 
                //// button2
                //// 
                //this.button2.BackColor = System.Drawing.Color.White;
                //this.button2.Enabled = false;
                //this.button2.Location = new System.Drawing.Point(53, 31);
                //this.button2.Name = "button2";
                //this.button2.Size = new System.Drawing.Size(40, 40);
                //this.button2.TabIndex = 1;
                //this.button2.Text = "button2";
                //this.button2.UseVisualStyleBackColor = false;
            }
            //this.to
        }

        
    }
}
