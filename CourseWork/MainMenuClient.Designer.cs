namespace CourseWork.forms
{
    partial class MainMenuClient
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
            buttonShop = new Button();
            buttonOrderHistory = new Button();
            buttonLogout = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 15F);
            labelWelcome.Location = new Point(264, 59);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(294, 28);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Радий тебе бачити, {username}!";
            // 
            // buttonShop
            // 
            buttonShop.Location = new Point(330, 110);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(147, 39);
            buttonShop.TabIndex = 1;
            buttonShop.Text = "Перейти до магазину";
            buttonShop.UseVisualStyleBackColor = true;
            buttonShop.Click += buttonShop_Click;
            // 
            // buttonOrderHistory
            // 
            buttonOrderHistory.Location = new Point(330, 155);
            buttonOrderHistory.Name = "buttonOrderHistory";
            buttonOrderHistory.Size = new Size(147, 39);
            buttonOrderHistory.TabIndex = 2;
            buttonOrderHistory.Text = "Історія замовлень";
            buttonOrderHistory.UseVisualStyleBackColor = true;
            buttonOrderHistory.Click += buttonOrderHistory_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(330, 245);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(147, 39);
            buttonLogout.TabIndex = 3;
            buttonLogout.Text = "Вийти";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // button1
            // 
            button1.Location = new Point(330, 200);
            button1.Name = "button1";
            button1.Size = new Size(147, 39);
            button1.TabIndex = 4;
            button1.Text = "Профіль";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainMenuClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonLogout);
            Controls.Add(buttonOrderHistory);
            Controls.Add(buttonShop);
            Controls.Add(labelWelcome);
            Name = "MainMenuClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головне меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button buttonShop;
        private Button buttonOrderHistory;
        private Button buttonLogout;
        private Button button1;
    }
}