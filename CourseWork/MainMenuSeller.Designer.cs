namespace CourseWork.forms
{
    partial class MainMenuSeller
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
            buttonLogout = new Button();
            buttonCheckProducts = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(312, 68);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(116, 15);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Вітаю Продавець ...!";
            // 
            // buttonCheckOrder
            // 
            buttonCheckOrder.Location = new Point(297, 100);
            buttonCheckOrder.Name = "buttonCheckOrder";
            buttonCheckOrder.Size = new Size(145, 44);
            buttonCheckOrder.TabIndex = 1;
            buttonCheckOrder.Text = "Переглянути закази";
            buttonCheckOrder.UseVisualStyleBackColor = true;
            buttonCheckOrder.Click += buttonCheckOrder_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(297, 298);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(145, 44);
            buttonLogout.TabIndex = 2;
            buttonLogout.Text = "Вийти";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonCheckProducts
            // 
            buttonCheckProducts.Location = new Point(297, 159);
            buttonCheckProducts.Name = "buttonCheckProducts";
            buttonCheckProducts.Size = new Size(145, 44);
            buttonCheckProducts.TabIndex = 3;
            buttonCheckProducts.Text = "Переглянути товари на складі";
            buttonCheckProducts.UseVisualStyleBackColor = true;
            buttonCheckProducts.Click += buttonCheckProducts_Click;
            // 
            // button1
            // 
            button1.Location = new Point(297, 209);
            button1.Name = "button1";
            button1.Size = new Size(147, 39);
            button1.TabIndex = 8;
            button1.Text = "Профіль";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainMenuSeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonCheckProducts);
            Controls.Add(buttonLogout);
            Controls.Add(buttonCheckOrder);
            Controls.Add(labelWelcome);
            Name = "MainMenuSeller";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головне меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button buttonCheckOrder;
        private Button buttonLogout;
        private Button buttonCheckProducts;
        private Button button1;
    }
}