namespace CourseWork
{
    partial class RegistrationForm
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
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxRPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonOk = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 79);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Реєстрація:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(295, 129);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(166, 23);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(297, 184);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(164, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxRPassword
            // 
            textBoxRPassword.Location = new Point(297, 228);
            textBoxRPassword.Name = "textBoxRPassword";
            textBoxRPassword.Size = new Size(164, 23);
            textBoxRPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 111);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Введіть логін:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 166);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 5;
            label3.Text = "Введіть пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 210);
            label4.Name = "label4";
            label4.Size = new Size(148, 15);
            label4.TabIndex = 6;
            label4.Text = "Введіть пароль повторно:";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(378, 257);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(83, 33);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Далі";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(295, 257);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(83, 33);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonOk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxRPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстраційне вікно";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxRPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonOk;
        private Button buttonBack;
    }
}