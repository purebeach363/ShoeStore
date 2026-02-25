namespace NewDemo.Forms
{
    partial class OrdersForm
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
            lblUsername = new Label();
            btnReturn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAddOrder = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(473, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Имя пользователя";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(682, 412);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(115, 29);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Назад";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(664, 399);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(682, 42);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(115, 29);
            btnAddOrder.TabIndex = 3;
            btnAddOrder.Text = "Добавить заказ";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(809, 453);
            Controls.Add(btnAddOrder);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnReturn);
            Controls.Add(lblUsername);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Button btnReturn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAddOrder;
    }
}