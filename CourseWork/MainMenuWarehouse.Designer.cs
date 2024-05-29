namespace CourseWork.forms
{
    partial class MainMenuWarehouse
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
            buttonLogout = new Button();
            buttonCheckProducts = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(286, 91);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(155, 15);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Вітаю, працівник складу ...!";
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(286, 268);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(147, 39);
            buttonLogout.TabIndex = 2;
            buttonLogout.Text = "Вийти";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonCheckProducts
            // 
            buttonCheckProducts.Location = new Point(286, 126);
            buttonCheckProducts.Name = "buttonCheckProducts";
            buttonCheckProducts.Size = new Size(147, 39);
            buttonCheckProducts.TabIndex = 4;
            buttonCheckProducts.Text = "Переглянути товари на складі";
            buttonCheckProducts.UseVisualStyleBackColor = true;
            buttonCheckProducts.Click += buttonCheckProducts_Click;
            // 
            // button1
            // 
            button1.Location = new Point(286, 171);
            button1.Name = "button1";
            button1.Size = new Size(147, 39);
            button1.TabIndex = 8;
            button1.Text = "Профіль";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainMenuWarehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonCheckProducts);
            Controls.Add(buttonLogout);
            Controls.Add(labelWelcome);
            Name = "MainMenuWarehouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarehouseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button buttonLogout;
        private Button buttonCheckProducts;
        private Button button1;
    }
}