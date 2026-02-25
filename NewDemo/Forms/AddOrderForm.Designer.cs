namespace NewDemo.Forms
{
    partial class AddOrderForm
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
            btnAddOrder = new Button();
            lblArticle = new Label();
            comboBoxArticles = new ComboBox();
            numericUpDownQuantity = new NumericUpDown();
            btnAddItem = new Button();
            listBoxItems = new ListBox();
            lblAddress = new Label();
            comboBoxAddress = new ComboBox();
            lblRecepient = new Label();
            comboBoxRecepient = new ComboBox();
            lblStatus = new Label();
            comboBoxStatuses = new ComboBox();
            lblOrderDate = new Label();
            dateTimePickerOrderDate = new DateTimePicker();
            lblDeliveryDate = new Label();
            dateTimePickerDeliveryDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(289, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Имя пользователя";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(280, 265);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Назад";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(380, 265);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(117, 29);
            btnAddOrder.TabIndex = 2;
            btnAddOrder.Text = "Добавить заказ";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Location = new Point(12, 41);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(60, 17);
            lblArticle.TabIndex = 3;
            lblArticle.Text = "Артикул";
            // 
            // comboBoxArticles
            // 
            comboBoxArticles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArticles.FormattingEnabled = true;
            comboBoxArticles.Items.AddRange(new object[] { "B320R5", "B431R5", "R333R3", "D268G5", "D329H3", "D364R4", "D572U8", "E482R4", "F427R5", "F525D2", "F572H7", "F635R4", "G432E4", "G531F4", "G783F5", "H535R5", "H782T5", "J384T6", "K228K2", "K345R4", "K358H6", "L754R4", "M542T5", "N457T5", "O754F4", "P764G4", "S213E3", "S326R5", "S634B5", "T324F5", "А112Т4" });
            comboBoxArticles.Location = new Point(12, 61);
            comboBoxArticles.Name = "comboBoxArticles";
            comboBoxArticles.Size = new Size(138, 25);
            comboBoxArticles.TabIndex = 4;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(156, 62);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(93, 25);
            numericUpDownQuantity.TabIndex = 5;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(156, 93);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(93, 29);
            btnAddItem.TabIndex = 6;
            btnAddItem.Text = "Добавить";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 17;
            listBoxItems.Location = new Point(12, 92);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(138, 106);
            listBoxItems.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 201);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(144, 17);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Адрес пункта выдачи";
            // 
            // comboBoxAddress
            // 
            comboBoxAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddress.FormattingEnabled = true;
            comboBoxAddress.Items.AddRange(new object[] { "420151, г. Лесной, ул. Вишневая, 32", "125061, г. Лесной, ул. Подгорная, 8", "630370, г. Лесной, ул. Шоссейная, 24", "400562, г. Лесной, ул. Зеленая, 32", "614510, г. Лесной, ул. Маяковского, 47", "410542, г. Лесной, ул. Светлая, 46", "620839, г. Лесной, ул. Цветочная, 8", "443890, г. Лесной, ул. Коммунистическая, 1", "603379, г. Лесной, ул. Спортивная, 46", "603721, г. Лесной, ул. Гоголя, 41", "410172, г. Лесной, ул. Северная, 13", "614611, г. Лесной, ул. Молодежная, 50", "454311, г.Лесной, ул. Новая, 19", "660007, г.Лесной, ул. Октябрьская, 19", "603036, г. Лесной, ул. Садовая, 4", "394060, г.Лесной, ул. Фрунзе, 43", "410661, г. Лесной, ул. Школьная, 50", "625590, г. Лесной, ул. Коммунистическая, 20", "625683, г. Лесной, ул. 8 Марта", "450983, г.Лесной, ул. Комсомольская, 26", "394782, г. Лесной, ул. Чехова, 3", "603002, г. Лесной, ул. Дзержинского, 28", "450558, г. Лесной, ул. Набережная, 30", "344288, г. Лесной, ул. Чехова, 1", "614164, г.Лесной,  ул. Степная, 30", "394242, г. Лесной, ул. Коммунистическая, 43", "660540, г. Лесной, ул. Солнечная, 25", "125837, г. Лесной, ул. Шоссейная, 40", "125703, г. Лесной, ул. Партизанская, 49", "625283, г. Лесной, ул. Победы, 46", "614753, г. Лесной, ул. Полевая, 35", "426030, г. Лесной, ул. Маяковского, 44", "450375, г. Лесной ул. Клубная, 44", "625560, г. Лесной, ул. Некрасова, 12", "630201, г. Лесной, ул. Комсомольская, 17", "190949, г. Лесной, ул. Мичурина, 26" });
            comboBoxAddress.Location = new Point(12, 221);
            comboBoxAddress.Name = "comboBoxAddress";
            comboBoxAddress.Size = new Size(237, 25);
            comboBoxAddress.TabIndex = 9;
            // 
            // lblRecepient
            // 
            lblRecepient.AutoSize = true;
            lblRecepient.Location = new Point(12, 249);
            lblRecepient.Name = "lblRecepient";
            lblRecepient.Size = new Size(83, 17);
            lblRecepient.TabIndex = 10;
            lblRecepient.Text = "Получатель";
            // 
            // comboBoxRecepient
            // 
            comboBoxRecepient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRecepient.FormattingEnabled = true;
            comboBoxRecepient.Items.AddRange(new object[] { "Никифорова Весения Николаевна", "Сазонов Руслан Германович", "Одинцов Серафим Артёмович", "Степанов Михаил Артёмович", "Ворсин Петр Евгеньевич", "Старикова Елена Павловна", "Михайлюк Анна Вячеславовна", "Ситдикова Елена Анатольевна", "Ворсин Петр Евгеньевич", "Старикова Елена Павловна" });
            comboBoxRecepient.Location = new Point(12, 269);
            comboBoxRecepient.Name = "comboBoxRecepient";
            comboBoxRecepient.Size = new Size(237, 25);
            comboBoxRecepient.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(280, 41);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(97, 17);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Статус заказа";
            // 
            // comboBoxStatuses
            // 
            comboBoxStatuses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatuses.FormattingEnabled = true;
            comboBoxStatuses.Items.AddRange(new object[] { "Завершен", "Новый" });
            comboBoxStatuses.Location = new Point(280, 62);
            comboBoxStatuses.Name = "comboBoxStatuses";
            comboBoxStatuses.Size = new Size(217, 25);
            comboBoxStatuses.TabIndex = 13;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(280, 90);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(83, 17);
            lblOrderDate.TabIndex = 14;
            lblOrderDate.Text = "Дата заказа";
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.Location = new Point(280, 110);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(217, 25);
            dateTimePickerOrderDate.TabIndex = 15;
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(280, 138);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(100, 17);
            lblDeliveryDate.TabIndex = 16;
            lblDeliveryDate.Text = "Дата доставки";
            // 
            // dateTimePickerDeliveryDate
            // 
            dateTimePickerDeliveryDate.Location = new Point(280, 158);
            dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            dateTimePickerDeliveryDate.Size = new Size(217, 25);
            dateTimePickerDeliveryDate.TabIndex = 17;
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(512, 309);
            Controls.Add(dateTimePickerDeliveryDate);
            Controls.Add(lblDeliveryDate);
            Controls.Add(dateTimePickerOrderDate);
            Controls.Add(lblOrderDate);
            Controls.Add(comboBoxStatuses);
            Controls.Add(lblStatus);
            Controls.Add(comboBoxRecepient);
            Controls.Add(lblRecepient);
            Controls.Add(comboBoxAddress);
            Controls.Add(lblAddress);
            Controls.Add(listBoxItems);
            Controls.Add(btnAddItem);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(comboBoxArticles);
            Controls.Add(lblArticle);
            Controls.Add(btnAddOrder);
            Controls.Add(btnReturn);
            Controls.Add(lblUsername);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление заказа";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Button btnReturn;
        private Button btnAddOrder;
        private Label lblArticle;
        private ComboBox comboBoxArticles;
        private NumericUpDown numericUpDownQuantity;
        private Button btnAddItem;
        private ListBox listBoxItems;
        private Label lblAddress;
        private ComboBox comboBoxAddress;
        private Label lblRecepient;
        private ComboBox comboBoxRecepient;
        private Label lblStatus;
        private ComboBox comboBoxStatuses;
        private Label lblOrderDate;
        private DateTimePicker dateTimePickerOrderDate;
        private Label lblDeliveryDate;
        private DateTimePicker dateTimePickerDeliveryDate;
    }
}