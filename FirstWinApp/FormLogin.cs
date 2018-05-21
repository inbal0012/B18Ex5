using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FirstWinApp
{
    public class FormLogin : Form
    {
        TextBox m_TextboxUsername = new TextBox();
        TextBox m_TextboxPassword = new TextBox();

        Label m_LabelUserName = new Label();
        Label m_LabelPassword = new Label();

        Button m_ButtonOK = new Button();
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Matrix matrix1;
        Button m_ButtonCancel = new Button();

        public FormLogin()
        {
            this.Size = new Size(150, 150);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login";
        }

        /// <summary>
        /// This method will be called once, just before the first time the form is displayed
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitControls();
        }

        /// <summary>
        /// Layouting the controls (textboxes, lables, buttons) on the form
        /// </summary>
        private void InitControls()
        {
            m_LabelUserName.Text = "User Name:";
            m_LabelUserName.Location = new Point(10, 20);

            m_LabelPassword.Text = "Password:";
            m_LabelPassword.Location = new Point(10, 50);

            int textBoxTop = m_LabelUserName.Top + m_LabelUserName.Height / 2;
            textBoxTop -= m_TextboxUsername.Height / 2;

            m_TextboxUsername.Location = new Point(m_LabelUserName.Right + 8,
                textBoxTop);

            int textBoxPasswordTop = m_LabelPassword.Top + m_LabelPassword.Height / 2;
            textBoxPasswordTop -= m_TextboxPassword.Height / 2;

            m_TextboxPassword.Location = new Point(m_LabelPassword.Right + 8,
                textBoxPasswordTop);

            this.Width = m_TextboxPassword.Right + 16;

            m_ButtonCancel.Text = "Cancel";
            m_ButtonCancel.Location = new Point(this.ClientSize.Width - m_ButtonCancel.Width - 8,
                this.ClientSize.Height - m_ButtonCancel.Height - 8);

            m_ButtonOK.Text = "OK";
            m_ButtonOK.Location = new Point(m_ButtonCancel.Left - m_ButtonOK.Width - 8,
                this.ClientSize.Height - m_ButtonOK.Height - 8);


            this.Controls.AddRange(new Control[] { m_LabelPassword, m_LabelUserName, m_TextboxPassword, m_TextboxUsername, m_ButtonOK, m_ButtonCancel });

            this.m_ButtonCancel.Click += new EventHandler(m_ButtonCancel_Click);
            this.m_ButtonOK.Click += new EventHandler(m_ButtonOK_Click);
        }

        /// <summary>
        /// Uppon cancel - close the dialog with DialogResult.Cancel
        /// </summary>
        void m_ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Uppon cancel - close the dialog with DialogResult.OK
        /// </summary>
        void m_ButtonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string UserName
        {
            get { return m_TextboxUsername.Text; }
            set { m_TextboxUsername.Text = value; }
        }

        public string Password
        {
            get { return m_TextboxPassword.Text; }
            set { m_TextboxPassword.Text = value; }
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.matrix1 = new Matrix(6);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(53, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(105, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(button1.Left, button1.Bottom);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // matrix1
            //matrix1.
            // 
            // FormLogin
            // 
            this.ClientSize = new System.Drawing.Size(481, 371);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormLogin";
            this.ResumeLayout(false);

        }
        
    }
}
