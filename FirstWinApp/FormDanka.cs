using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FirstWinApp
{
    public class FormDanka : Form
    {
        private Label m_LabelPlayer1;
        private Label m_LabelPlayer1Score;
        private Label m_LabelPlayer2Score;
        private Label m_LabelPlayer2Name;
        private TableLayoutPanel m_TableLayoutPanelBoard;
        private FormGameSetting m_GameSetting = new FormGameSetting();

        public FormDanka()
        {
            m_GameSetting.ShowDialog();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.m_LabelPlayer1 = new Label();
            this.m_LabelPlayer1Score = new Label();
            this.m_LabelPlayer2Score = new Label();
            this.m_LabelPlayer2Name = new Label();
            this.m_TableLayoutPanelBoard = new TableLayoutPanel();
            this.SuspendLayout();
            // 
            // m_LabelPlayer1
            // 
            this.m_LabelPlayer1.AutoSize = true;
            this.m_LabelPlayer1.Location = new Point(58, 13);
            this.m_LabelPlayer1.Name = "m_LabelPlayer1";
            this.m_LabelPlayer1.Size = new Size(70, 13);
            this.m_LabelPlayer1.TabIndex = 0;
            this.m_LabelPlayer1.Text = m_GameSetting.Player1Name + ":";
            this.m_LabelPlayer1.Size = TextRenderer.MeasureText(m_LabelPlayer1.Text, m_LabelPlayer1.Font);

            // 
            // m_LabelPlayer1Score
            // 
            this.m_LabelPlayer1Score.AutoSize = true;
            this.m_LabelPlayer1Score.Location = new Point(128, 13);
            this.m_LabelPlayer1Score.Name = "m_LabelPlayer1Score";
            this.m_LabelPlayer1Score.Size = new Size(73, 13);
            this.m_LabelPlayer1Score.TabIndex = 1;
            //TODO Text
            this.m_LabelPlayer1Score.Text = "Score";
            this.m_LabelPlayer1Score.Size = TextRenderer.MeasureText(m_LabelPlayer1Score.Text, m_LabelPlayer1Score.Font);
            this.m_LabelPlayer1Score.Left = m_LabelPlayer1.Right;
            // 
            // m_LabelPlayer2Score
            // 
            this.m_LabelPlayer2Score.AutoSize = true;
            this.m_LabelPlayer2Score.Name = "m_LabelPlayer2Score";
            this.m_LabelPlayer2Score.Size = new Size(73, 13);
            this.m_LabelPlayer2Score.TabIndex = 3;
            this.m_LabelPlayer2Score.BackColor = Color.Azure;
            this.m_LabelPlayer2Score.Text = "Score2";
            this.m_LabelPlayer2Score.Size = TextRenderer.MeasureText(m_LabelPlayer2Score.Text, m_LabelPlayer2Score.Font);
            this.m_LabelPlayer2Score.Location = new Point(ClientSize.Width - m_LabelPlayer2Score.Width, 13);

            // 
            // m_LabelPlayer2Name
            // 
            this.m_LabelPlayer2Name.AutoSize = true;
            this.m_LabelPlayer2Name.Name = "m_LabelPlayer2Name";
            this.m_LabelPlayer2Name.Size = new Size(70, 13);
            this.m_LabelPlayer2Name.BackColor = Color.Azure;
            this.m_LabelPlayer2Name.TabIndex = 2;
            this.m_LabelPlayer2Name.Size = TextRenderer.MeasureText(m_LabelPlayer2Name.Text, m_LabelPlayer2Name.Font);
            this.m_LabelPlayer2Name.Location = new Point(m_LabelPlayer2Score.Left - m_LabelPlayer2Name.Width, m_LabelPlayer1.Top);
            this.m_LabelPlayer2Name.Text = m_GameSetting.Player2Name + ":";
            // 
            // m_TableLayoutPanelBoard
            // 
            //this.m_TableLayoutPanelBoard
            this.m_TableLayoutPanelBoard.ColumnCount = m_GameSetting.BoardSize;
            //this.m_TableLayoutPanelBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            //this.m_TableLayoutPanelBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            //this.m_TableLayoutPanelBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            this.m_TableLayoutPanelBoard.Location = new Point(149, 144);
            this.m_TableLayoutPanelBoard.Name = "m_TableLayoutPanelBoard";
            this.m_TableLayoutPanelBoard.RowCount = m_GameSetting.BoardSize;
            //this.m_TableLayoutPanelBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            //this.m_TableLayoutPanelBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.m_TableLayoutPanelBoard.Size = new Size(200, 100);
            this.m_TableLayoutPanelBoard.TabIndex = 4;
            // 
            // FormDanka
            // 
            //this.ClientSize = new Size(445, 421);
            this.Controls.Add(this.m_TableLayoutPanelBoard);
            this.Controls.Add(this.m_LabelPlayer2Score);
            this.Controls.Add(this.m_LabelPlayer2Name);
            this.Controls.Add(this.m_LabelPlayer1Score);
            this.Controls.Add(this.m_LabelPlayer1);
            this.Name = "FormDanka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
