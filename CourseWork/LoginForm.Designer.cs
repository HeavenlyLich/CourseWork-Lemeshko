namespace CourseWork
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            linkLabelRegister = new LinkLabel();
            buttonOK1 = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(311, 79);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 0;
            label1.Text = "Ласкаво Просимо!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 116);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Логін";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 190);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // LoginBox
            // 
            LoginBox.Location = new Point(292, 150);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(216, 23);
            LoginBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(292, 221);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(216, 23);
            PasswordBox.TabIndex = 4;
            // 
            // linkLabelRegister
            // 
            linkLabelRegister.AutoSize = true;
            linkLabelRegister.Location = new Point(292, 247);
            linkLabelRegister.Name = "linkLabelRegister";
            linkLabelRegister.Size = new Size(216, 15);
            linkLabelRegister.TabIndex = 5;
            linkLabelRegister.TabStop = true;
            linkLabelRegister.Text = "Ще немає аккаунту? Зареєструватись.";
            linkLabelRegister.LinkClicked += linkLabelRegister_LinkClicked;
            // 
            // buttonOK1
            // 
            buttonOK1.Location = new Point(420, 276);
            buttonOK1.Name = "buttonOK1";
            buttonOK1.Size = new Size(88, 38);
            buttonOK1.TabIndex = 6;
            buttonOK1.Text = "Далі";
            buttonOK1.UseVisualStyleBackColor = true;
            buttonOK1.Click += buttonOK1_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(292, 276);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(88, 38);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Вихід";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonOK1);
            Controls.Add(linkLabelRegister);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вхід";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private LinkLabel linkLabelRegister;
        private Button buttonOK1;
        private Button buttonExit;
    }
}