namespace CourseWork.forms
{
    partial class OrderHistoryForm
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
            dataGridViewHistory = new DataGridView();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AllowUserToAddRows = false;
            dataGridViewHistory.AllowUserToDeleteRows = false;
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Location = new Point(12, 12);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.ReadOnly = true;
            dataGridViewHistory.Size = new Size(776, 390);
            dataGridViewHistory.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(350, 408);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(106, 30);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // OrderHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(dataGridViewHistory);
            Name = "OrderHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Історія замовлень";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewHistory;
        private Button buttonBack;
    }
}