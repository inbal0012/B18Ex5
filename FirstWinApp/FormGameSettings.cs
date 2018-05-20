using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FirstWinApp
{
    public class FormGameSetting : Form
    {
        private Label m_LabelBoardSize;

        private RadioButton m_RadioButtonSixBySix;
        private RadioButton m_RadioButtonEightByEight;
        private RadioButton m_RadioButtonTenByTen;

        private Label m_LabelPlayers;

        private Label m_LabelPlayer1;
        private TextBox m_TextBoxPlayer1;
        public string Player1Name
        {
            get
            {
                return m_TextBoxPlayer1.Text;
            }
        }

        private CheckBox m_CheckBoxPlayer2;
        private Label m_LabelPlayer2;
        private TextBox m_TextBoxPlayer2;
        public string Player2Name
        {
            get
            {
                return m_TextBoxPlayer2.Text;
            }
        }

        private Button m_ButtonDone;

        public int BoardSize
        {
            get;
            private set;
        }


        public FormGameSetting()
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Game Setting";

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.m_LabelBoardSize = new System.Windows.Forms.Label();
            this.m_RadioButtonSixBySix = new System.Windows.Forms.RadioButton();
            this.m_RadioButtonEightByEight = new System.Windows.Forms.RadioButton();
            this.m_RadioButtonTenByTen = new System.Windows.Forms.RadioButton();
            this.m_LabelPlayers = new System.Windows.Forms.Label();
            this.m_LabelPlayer1 = new System.Windows.Forms.Label();
            this.m_TextBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.m_CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.m_LabelPlayer2 = new System.Windows.Forms.Label();
            this.m_TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.m_ButtonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_LabelBoardSize
            // 
            this.m_LabelBoardSize.AutoSize = true;
            this.m_LabelBoardSize.Location = new System.Drawing.Point(13, 13);
            this.m_LabelBoardSize.Name = "m_LabelBoardSize";
            this.m_LabelBoardSize.Size = new System.Drawing.Size(61, 13);
            this.m_LabelBoardSize.TabIndex = 0;
            this.m_LabelBoardSize.Text = "Board Size:";
            // 
            // m_RadioButtonSixBySix
            // 
            this.m_RadioButtonSixBySix.AutoSize = true;
            this.m_RadioButtonSixBySix.Checked = true;
            this.m_RadioButtonSixBySix.Location = new System.Drawing.Point(16, 40);
            this.m_RadioButtonSixBySix.Name = "m_RadioButtonSixBySix";
            this.m_RadioButtonSixBySix.Size = new System.Drawing.Size(48, 17);
            this.m_RadioButtonSixBySix.TabIndex = 1;
            this.m_RadioButtonSixBySix.TabStop = true;
            this.m_RadioButtonSixBySix.Text = "6 x 6";
            this.m_RadioButtonSixBySix.UseVisualStyleBackColor = true;
            this.m_RadioButtonSixBySix.CheckedChanged += new System.EventHandler(this.m_RadioButton_CheckedChanged);
            // 
            // m_RadioButtonEightByEight
            // 
            this.m_RadioButtonEightByEight.AutoSize = true;
            this.m_RadioButtonEightByEight.Location = new System.Drawing.Point(87, 40);
            this.m_RadioButtonEightByEight.Name = "m_RadioButtonEightByEight";
            this.m_RadioButtonEightByEight.Size = new System.Drawing.Size(48, 17);
            this.m_RadioButtonEightByEight.TabIndex = 2;
            this.m_RadioButtonEightByEight.Text = "8 x 8";
            this.m_RadioButtonEightByEight.UseVisualStyleBackColor = true;
            this.m_RadioButtonEightByEight.CheckedChanged += new System.EventHandler(this.m_RadioButton_CheckedChanged);
            // 
            // m_RadioButtonTenByTen
            // 
            this.m_RadioButtonTenByTen.AutoSize = true;
            this.m_RadioButtonTenByTen.Location = new System.Drawing.Point(160, 40);
            this.m_RadioButtonTenByTen.Name = "m_RadioButtonTenByTen";
            this.m_RadioButtonTenByTen.Size = new System.Drawing.Size(60, 17);
            this.m_RadioButtonTenByTen.TabIndex = 3;
            this.m_RadioButtonTenByTen.Text = "10 x 10";
            this.m_RadioButtonTenByTen.UseVisualStyleBackColor = true;
            this.m_RadioButtonTenByTen.CheckedChanged += new System.EventHandler(this.m_RadioButton_CheckedChanged);
            // 
            // m_LabelPlayers
            // 
            this.m_LabelPlayers.AutoSize = true;
            this.m_LabelPlayers.Location = new System.Drawing.Point(16, 76);
            this.m_LabelPlayers.Name = "m_LabelPlayers";
            this.m_LabelPlayers.Size = new System.Drawing.Size(44, 13);
            this.m_LabelPlayers.TabIndex = 4;
            this.m_LabelPlayers.Text = "Players:";
            // 
            // m_LabelPlayer1
            // 
            this.m_LabelPlayer1.AutoSize = true;
            this.m_LabelPlayer1.Location = new System.Drawing.Point(19, 102);
            this.m_LabelPlayer1.Name = "m_LabelPlayer1";
            this.m_LabelPlayer1.Size = new System.Drawing.Size(42, 13);
            this.m_LabelPlayer1.TabIndex = 5;
            this.m_LabelPlayer1.Text = "Player1";
            // 
            // m_TextBoxPlayer1
            // 
            this.m_TextBoxPlayer1.Location = new System.Drawing.Point(68, 102);
            this.m_TextBoxPlayer1.Name = "m_TextBoxPlayer1";
            this.m_TextBoxPlayer1.Size = new System.Drawing.Size(100, 20);
            this.m_TextBoxPlayer1.TabIndex = 6;
            // 
            // m_CheckBoxPlayer2
            // 
            this.m_CheckBoxPlayer2.AutoSize = true;
            this.m_CheckBoxPlayer2.Location = new System.Drawing.Point(22, 134);
            this.m_CheckBoxPlayer2.Name = "m_CheckBoxPlayer2";
            this.m_CheckBoxPlayer2.Size = new System.Drawing.Size(15, 14);
            this.m_CheckBoxPlayer2.TabIndex = 7;
            this.m_CheckBoxPlayer2.UseVisualStyleBackColor = true;
            this.m_CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.m_CheckBoxPlayer2_CheckedChanged);
            // 
            // m_LabelPlayer2
            // 
            this.m_LabelPlayer2.AutoSize = true;
            this.m_LabelPlayer2.Location = new System.Drawing.Point(43, 135);
            this.m_LabelPlayer2.Name = "m_LabelPlayer2";
            this.m_LabelPlayer2.Size = new System.Drawing.Size(42, 13);
            this.m_LabelPlayer2.TabIndex = 8;
            this.m_LabelPlayer2.Text = "Player2";
            // 
            // m_TextBoxPlayer2
            // 
            this.m_TextBoxPlayer2.Enabled = false;
            this.m_TextBoxPlayer2.Location = new System.Drawing.Point(91, 131);
            this.m_TextBoxPlayer2.Name = "m_TextBoxPlayer2";
            this.m_TextBoxPlayer2.Size = new System.Drawing.Size(100, 20);
            this.m_TextBoxPlayer2.TabIndex = 9;
            this.m_TextBoxPlayer2.Text = "[Computer]";
            // 
            // m_ButtonDone
            // 
            this.m_ButtonDone.Location = new System.Drawing.Point(145, 166);
            this.m_ButtonDone.Name = "m_ButtonDone";
            this.m_ButtonDone.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonDone.TabIndex = 10;
            this.m_ButtonDone.Text = "Done";
            this.m_ButtonDone.UseVisualStyleBackColor = true;
            this.m_ButtonDone.Click += new System.EventHandler(this.m_ButtonDone_Click);
            // 
            // FormGameSetting
            // 
            this.ClientSize = new System.Drawing.Size(239, 205);
            this.Controls.Add(this.m_ButtonDone);
            this.Controls.Add(this.m_TextBoxPlayer2);
            this.Controls.Add(this.m_LabelPlayer2);
            this.Controls.Add(this.m_CheckBoxPlayer2);
            this.Controls.Add(this.m_TextBoxPlayer1);
            this.Controls.Add(this.m_LabelPlayer1);
            this.Controls.Add(this.m_LabelPlayers);
            this.Controls.Add(this.m_RadioButtonTenByTen);
            this.Controls.Add(this.m_RadioButtonEightByEight);
            this.Controls.Add(this.m_RadioButtonSixBySix);
            this.Controls.Add(this.m_LabelBoardSize);
            this.Name = "FormGameSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void m_CheckBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if (m_CheckBoxPlayer2.Checked == true)
            {
                m_TextBoxPlayer2.Enabled = true;
            }
            else
                m_TextBoxPlayer2.Enabled = false;
        }
        private void m_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedSize;

            if (sender is RadioButton)
            {
                selectedSize = (sender as RadioButton);
            }
            else
                return;

            if (selectedSize == m_RadioButtonSixBySix)
                BoardSize = 6;
            else if (selectedSize == m_RadioButtonEightByEight)
                BoardSize = 8;
            else if (selectedSize == m_RadioButtonTenByTen)
                BoardSize = 10;
        }
        private void m_ButtonDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
