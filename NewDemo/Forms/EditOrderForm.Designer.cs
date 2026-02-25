namespace NewDemo.Forms
{
    partial class EditOrderForm
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
            comboBoxArticle = new ComboBox();
            lblArticle = new Label();
            btnReturn = new Button();
            lblAddress = new Label();
            comboBoxAddresses = new ComboBox();
            lblUser = new Label();
            comboBoxUsers = new ComboBox();
            lblStatus = new Label();
            comboBoxStatuses = new ComboBox();
            lblOrderDate = new Label();
            dateTimePickerOrder = new DateTimePicker();
            lblDeliveryDate = new Label();
            dateTimePickerDelivery = new DateTimePicker();
            labelQuantity = new Label();
            numericUpDownQuantity = new NumericUpDown();
            btnSaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(262, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Имя пользователя";
            // 
            // comboBoxArticle
            // 
            comboBoxArticle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArticle.FormattingEnabled = true;
            comboBoxArticle.Items.AddRange(new object[] { "B320R5", "B431R5", "D268G5", "D329H3", "D364R4", "D572U8", "E482R4", "F427R5", "F525D2", "F572H7", "F635R4", "G432E4", "G531F4", "G783F5", "H535R5", "H782T5", "J384T6", "K228K2", "K345R4", "K358H6", "L754R4", "M542T5", "N457T5", "O754F4", "P764G4", "R333R3", "S213E3", "S326R5", "S634B5", "T324F5", "А112Т4" });
            comboBoxArticle.Location = new Point(12, 57);
            comboBoxArticle.Name = "comboBoxArticle";
            comboBoxArticle.Size = new Size(243, 25);
            comboBoxArticle.TabIndex = 1;
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Location = new Point(12, 37);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(60, 17);
            lblArticle.TabIndex = 2;
            lblArticle.Text = "Артикул";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(282, 198);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(64, 29);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Назад";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 85);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(138, 17);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Адрес точки выдачи";
            // 
            // comboBoxAddresses
            // 
            comboBoxAddresses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAddresses.FormattingEnabled = true;
            comboBoxAddresses.Items.AddRange(new object[] { "420151, г. Лесной, ул. Вишневая, 32", "125061, г. Лесной, ул. Подгорная, 8", "630370, г. Лесной, ул. Шоссейная, 24", "400562, г. Лесной, ул. Зеленая, 32", "614510, г. Лесной, ул. Маяковского, 47", "410542, г. Лесной, ул. Светлая, 46", "620839, г. Лесной, ул. Цветочная, 8", "443890, г. Лесной, ул. Коммунистическая, 1", "603379, г. Лесной, ул. Спортивная, 46", "603721, г. Лесной, ул. Гоголя, 41", "410172, г. Лесной, ул. Северная, 13", "614611, г. Лесной, ул. Молодежная, 50", "454311, г.Лесной, ул. Новая, 19", "660007, г.Лесной, ул. Октябрьская, 19", "603036, г. Лесной, ул. Садовая, 4", "394060, г.Лесной, ул. Фрунзе, 43", "410661, г. Лесной, ул. Школьная, 50", "625590, г. Лесной, ул. Коммунистическая, 20", "625683, г. Лесной, ул. 8 Марта", "450983, г.Лесной, ул. Комсомольская, 26", "394782, г. Лесной, ул. Чехова, 3", "603002, г. Лесной, ул. Дзержинского, 28", "450558, г. Лесной, ул. Набережная, 30", "344288, г. Лесной, ул. Чехова, 1", "614164, г.Лесной,  ул. Степная, 30", "394242, г. Лесной, ул. Коммунистическая, 43", "660540, г. Лесной, ул. Солнечная, 25", "125837, г. Лесной, ул. Шоссейная, 40", "125703, г. Лесной, ул. Партизанская, 49", "625283, г. Лесной, ул. Победы, 46", "614753, г. Лесной, ул. Полевая, 35", "426030, г. Лесной, ул. Маяковского, 44", "450375, г. Лесной ул. Клубная, 44", "625560, г. Лесной, ул. Некрасова, 12", "630201, г. Лесной, ул. Комсомольская, 17", "190949, г. Лесной, ул. Мичурина, 26" });
            comboBoxAddresses.Location = new Point(12, 105);
            comboBoxAddresses.Name = "comboBoxAddresses";
            comboBoxAddresses.Size = new Size(243, 25);
            comboBoxAddresses.TabIndex = 5;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 133);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(83, 17);
            lblUser.TabIndex = 6;
            lblUser.Text = "Получатель";
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Items.AddRange(new object[] { "Никифорова Весения Николаевна", "Сазонов Руслан Германович", "Одинцов Серафим Артёмович", "Степанов Михаил Артёмович", "Ворсин Петр Евгеньевич", "Старикова Елена Павловна", "Михайлюк Анна Вячеславовна", "Ситдикова Елена Анатольевна" });
            comboBoxUsers.Location = new Point(12, 153);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(243, 25);
            comboBoxUsers.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 181);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(97, 17);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Статус заказа";
            // 
            // comboBoxStatuses
            // 
            comboBoxStatuses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatuses.FormattingEnabled = true;
            comboBoxStatuses.Items.AddRange(new object[] { "Завершен", "Новый" });
            comboBoxStatuses.Location = new Point(12, 201);
            comboBoxStatuses.Name = "comboBoxStatuses";
            comboBoxStatuses.Size = new Size(243, 25);
            comboBoxStatuses.TabIndex = 9;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(282, 85);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(83, 17);
            lblOrderDate.TabIndex = 10;
            lblOrderDate.Text = "Дата заказа";
            lblOrderDate.Click += lblOrderDate_Click;
            // 
            // dateTimePickerOrder
            // 
            dateTimePickerOrder.Location = new Point(282, 105);
            dateTimePickerOrder.Name = "dateTimePickerOrder";
            dateTimePickerOrder.Size = new Size(203, 25);
            dateTimePickerOrder.TabIndex = 11;
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(282, 133);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(100, 17);
            lblDeliveryDate.TabIndex = 12;
            lblDeliveryDate.Text = "Дата доставки";
            // 
            // dateTimePickerDelivery
            // 
            dateTimePickerDelivery.Location = new Point(282, 153);
            dateTimePickerDelivery.Name = "dateTimePickerDelivery";
            dateTimePickerDelivery.Size = new Size(203, 25);
            dateTimePickerDelivery.TabIndex = 13;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(282, 37);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(127, 17);
            labelQuantity.TabIndex = 14;
            labelQuantity.Text = "Количество товара";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(282, 57);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(203, 25);
            numericUpDownQuantity.TabIndex = 15;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(352, 198);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(153, 29);
            btnSaveChanges.TabIndex = 16;
            btnSaveChanges.Text = "Сохранить изменения";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // EditOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(514, 242);
            Controls.Add(btnSaveChanges);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(dateTimePickerDelivery);
            Controls.Add(lblDeliveryDate);
            Controls.Add(dateTimePickerOrder);
            Controls.Add(lblOrderDate);
            Controls.Add(comboBoxStatuses);
            Controls.Add(lblStatus);
            Controls.Add(comboBoxUsers);
            Controls.Add(lblUser);
            Controls.Add(comboBoxAddresses);
            Controls.Add(lblAddress);
            Controls.Add(btnReturn);
            Controls.Add(lblArticle);
            Controls.Add(comboBoxArticle);
            Controls.Add(lblUsername);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "EditOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование заказа";
            Load += EditOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private ComboBox comboBoxArticle;
        private Label lblArticle;
        private Button btnReturn;
        private Label lblAddress;
        private ComboBox comboBoxAddresses;
        private Label lblUser;
        private ComboBox comboBoxUsers;
        private Label lblStatus;
        private ComboBox comboBoxStatuses;
        private Label lblOrderDate;
        private DateTimePicker dateTimePickerOrder;
        private Label lblDeliveryDate;
        private DateTimePicker dateTimePickerDelivery;
        private Label labelQuantity;
        private NumericUpDown numericUpDownQuantity;
        private Button btnSaveChanges;
    }
}