namespace NewDemo.UserControls
{
    partial class OrderUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblOrderDate = new Label();
            lblAddress = new Label();
            lblStatus = new Label();
            lblArticle = new Label();
            btnEdit = new Button();
            panel2 = new Panel();
            lblDeliveryDate = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblOrderDate);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblArticle);
            panel1.Location = new Point(14, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 75);
            panel1.TabIndex = 0;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDate.Location = new Point(3, 51);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(86, 17);
            lblOrderDate.TabIndex = 3;
            lblOrderDate.Text = "Дата заказа:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(3, 34);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(147, 17);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Адрес пункта выдачи:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(3, 17);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 17);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Статус заказа:";
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArticle.Location = new Point(3, 0);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(68, 17);
            lblArticle.TabIndex = 0;
            lblArticle.Text = "Артикул";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(78, 46);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 24);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(lblDeliveryDate);
            panel2.Location = new Point(403, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 75);
            panel2.TabIndex = 1;
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeliveryDate.Location = new Point(-1, 26);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(103, 17);
            lblDeliveryDate.TabIndex = 4;
            lblDeliveryDate.Text = "Дата доставки:";
            // 
            // OrderUC
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "OrderUC";
            Size = new Size(600, 82);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblArticle;
        private Label lblStatus;
        private Label lblAddress;
        private Label lblOrderDate;
        private Label lblDeliveryDate;
        private Button btnEdit;
    }
}
