namespace CourseWork.forms
{
    partial class ProfileCForm
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
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            buttonConfirm = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 76);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 123);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Фамілія";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 167);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Пошта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 211);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Адреса";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 255);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 4;
            label5.Text = "Номер телефону";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(338, 94);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(127, 23);
            textBoxName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(338, 141);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(127, 23);
            textBoxLastName.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(338, 185);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(127, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(338, 229);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(127, 23);
            textBoxAddress.TabIndex = 8;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(338, 273);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(127, 23);
            textBoxPhoneNumber.TabIndex = 9;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(338, 302);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(127, 44);
            buttonConfirm.TabIndex = 10;
            buttonConfirm.Text = "Підтвердити інформацію";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 394);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(127, 44);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Повернутись";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // ProfileCForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProfileCForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ваш профіль";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private Button buttonConfirm;
        private Button buttonBack;
    }
}