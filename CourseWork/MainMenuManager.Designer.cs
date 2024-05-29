namespace CourseWork.forms
{
    partial class MainMenuManager
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
            labelWelcome = new Label();
            buttonCheckOrder = new Button();
            buttonCheckProducts = new Button();
            buttonLogout = new Button();
            buttonCheckUsers = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(310, 72);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(121, 15);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Вітаю, менеджере ...!";
            // 
            // buttonCheckOrder
            // 
            buttonCheckOrder.Location = new Point(310, 107);
            buttonCheckOrder.Name = "buttonCheckOrder";
            buttonCheckOrder.Size = new Size(145, 44);
            buttonCheckOrder.TabIndex = 2;
            buttonCheckOrder.Text = "Переглянути закази";
            buttonCheckOrder.UseVisualStyleBackColor = true;
            buttonCheckOrder.Click += buttonCheckOrder_Click;
            // 
            // buttonCheckProducts
            // 
            buttonCheckProducts.Location = new Point(310, 157);
            buttonCheckProducts.Name = "buttonCheckProducts";
            buttonCheckProducts.Size = new Size(145, 44);
            buttonCheckProducts.TabIndex = 4;
            buttonCheckProducts.Text = "Переглянути товари на складі";
            buttonCheckProducts.UseVisualStyleBackColor = true;
            buttonCheckProducts.Click += buttonCheckProducts_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(310, 326);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(145, 44);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "Вийти";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonCheckUsers
            // 
            buttonCheckUsers.Location = new Point(310, 207);
            buttonCheckUsers.Name = "buttonCheckUsers";
            buttonCheckUsers.Size = new Size(145, 44);
            buttonCheckUsers.TabIndex = 6;
            buttonCheckUsers.Text = "Переглянути користувачів";
            buttonCheckUsers.UseVisualStyleBackColor = true;
            buttonCheckUsers.Click += buttonCheckUsers_Click;
            // 
            // button1
            // 
            button1.Location = new Point(308, 257);
            button1.Name = "button1";
            button1.Size = new Size(147, 39);
            button1.TabIndex = 7;
            button1.Text = "Профіль";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainMenuManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonCheckUsers);
            Controls.Add(buttonLogout);
            Controls.Add(buttonCheckProducts);
            Controls.Add(buttonCheckOrder);
            Controls.Add(labelWelcome);
            Name = "MainMenuManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button buttonCheckOrder;
        private Button buttonCheckProducts;
        private Button buttonLogout;
        private Button buttonCheckUsers;
        private Button button1;
    }
}