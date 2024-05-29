namespace CourseWork.forms
{
    partial class UsersForm
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
            dataGridView1 = new DataGridView();
            ButtonBack = new Button();
            buttonUproved = new Button();
            buttonSelectUsers = new Button();
            buttonSelectClients = new Button();
            buttonSelectStaff = new Button();
            buttonGiveRClient = new Button();
            buttonGiveRWC = new Button();
            buttonGiveRSeller = new Button();
            buttonGiveRManager = new Button();
            buttonDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Таблиця користувачів";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 284);
            dataGridView1.TabIndex = 1;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 396);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(182, 42);
            ButtonBack.TabIndex = 5;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // buttonUproved
            // 
            buttonUproved.Location = new Point(648, 396);
            buttonUproved.Name = "buttonUproved";
            buttonUproved.Size = new Size(140, 42);
            buttonUproved.TabIndex = 6;
            buttonUproved.Text = "Підтвердити зміни?";
            buttonUproved.UseVisualStyleBackColor = true;
            buttonUproved.Visible = false;
            // 
            // buttonSelectUsers
            // 
            buttonSelectUsers.Location = new Point(146, 12);
            buttonSelectUsers.Name = "buttonSelectUsers";
            buttonSelectUsers.Size = new Size(140, 42);
            buttonSelectUsers.TabIndex = 7;
            buttonSelectUsers.Text = "Показати користувачів";
            buttonSelectUsers.UseVisualStyleBackColor = true;
            buttonSelectUsers.Click += buttonSelectUsers_Click;
            // 
            // buttonSelectClients
            // 
            buttonSelectClients.Location = new Point(304, 12);
            buttonSelectClients.Name = "buttonSelectClients";
            buttonSelectClients.Size = new Size(140, 42);
            buttonSelectClients.TabIndex = 8;
            buttonSelectClients.Text = "Показати клієнтів";
            buttonSelectClients.UseVisualStyleBackColor = true;
            buttonSelectClients.Click += buttonSelectClients_Click;
            // 
            // buttonSelectStaff
            // 
            buttonSelectStaff.Location = new Point(462, 12);
            buttonSelectStaff.Name = "buttonSelectStaff";
            buttonSelectStaff.Size = new Size(140, 42);
            buttonSelectStaff.TabIndex = 9;
            buttonSelectStaff.Text = "Показати працівників";
            buttonSelectStaff.UseVisualStyleBackColor = true;
            buttonSelectStaff.Click += buttonSelectStaff_Click;
            // 
            // buttonGiveRClient
            // 
            buttonGiveRClient.Location = new Point(200, 381);
            buttonGiveRClient.Name = "buttonGiveRClient";
            buttonGiveRClient.Size = new Size(104, 57);
            buttonGiveRClient.TabIndex = 10;
            buttonGiveRClient.Text = "Дати роль клієнта";
            buttonGiveRClient.UseVisualStyleBackColor = true;
            buttonGiveRClient.Visible = false;
            buttonGiveRClient.Click += buttonGiveRClient_Click;
            // 
            // buttonGiveRWC
            // 
            buttonGiveRWC.Location = new Point(310, 381);
            buttonGiveRWC.Name = "buttonGiveRWC";
            buttonGiveRWC.Size = new Size(104, 57);
            buttonGiveRWC.TabIndex = 11;
            buttonGiveRWC.Text = "Дати роль працівника складу";
            buttonGiveRWC.UseVisualStyleBackColor = true;
            buttonGiveRWC.Visible = false;
            buttonGiveRWC.Click += buttonGiveRWC_Click;
            // 
            // buttonGiveRSeller
            // 
            buttonGiveRSeller.Location = new Point(420, 381);
            buttonGiveRSeller.Name = "buttonGiveRSeller";
            buttonGiveRSeller.Size = new Size(104, 57);
            buttonGiveRSeller.TabIndex = 12;
            buttonGiveRSeller.Text = "Дати роль продавця";
            buttonGiveRSeller.UseVisualStyleBackColor = true;
            buttonGiveRSeller.Visible = false;
            buttonGiveRSeller.Click += buttonGiveRSeller_Click;
            // 
            // buttonGiveRManager
            // 
            buttonGiveRManager.Location = new Point(530, 381);
            buttonGiveRManager.Name = "buttonGiveRManager";
            buttonGiveRManager.Size = new Size(104, 57);
            buttonGiveRManager.TabIndex = 13;
            buttonGiveRManager.Text = "Дати роль Менеджера";
            buttonGiveRManager.UseVisualStyleBackColor = true;
            buttonGiveRManager.Visible = false;
            buttonGiveRManager.Click += buttonGiveRManager_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Location = new Point(684, 9);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(104, 57);
            buttonDeleteUser.TabIndex = 14;
            buttonDeleteUser.Text = "Видалити обраного користувача";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonGiveRManager);
            Controls.Add(buttonGiveRSeller);
            Controls.Add(buttonGiveRWC);
            Controls.Add(buttonGiveRClient);
            Controls.Add(buttonSelectStaff);
            Controls.Add(buttonSelectClients);
            Controls.Add(buttonSelectUsers);
            Controls.Add(buttonUproved);
            Controls.Add(ButtonBack);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Користувачі";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button ButtonBack;
        private Button buttonUproved;
        private Button buttonSelectUsers;
        private Button buttonSelectClients;
        private Button buttonSelectStaff;
        private Button buttonGiveRClient;
        private Button buttonGiveRWC;
        private Button buttonGiveRSeller;
        private Button buttonGiveRManager;
        private Button buttonDeleteUser;
    }
}