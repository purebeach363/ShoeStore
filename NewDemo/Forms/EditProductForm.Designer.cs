namespace NewDemo.Forms
{
    partial class EditProductForm
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
            btnReturn = new Button();
            lblUsername = new Label();
            lblArticle = new Label();
            maskedTextBoxArticle = new MaskedTextBox();
            lblProductName = new Label();
            comboBoxProductName = new ComboBox();
            lblUnit = new Label();
            comboBoxUnit = new ComboBox();
            lblSupplier = new Label();
            comboBoxSupplier = new ComboBox();
            lblProducer = new Label();
            comboBoxProducer = new ComboBox();
            comboBoxCategory = new ComboBox();
            lblCategory = new Label();
            numericUpDownDiscount = new NumericUpDown();
            lblDiscount = new Label();
            lblPrice = new Label();
            numericUpDownPrice = new NumericUpDown();
            lblQuantity = new Label();
            numericUpDownQuantity = new NumericUpDown();
            lblDescription = new Label();
            textBoxDescription = new TextBox();
            pictureBox1 = new PictureBox();
            btnLoadImage = new Button();
            btnSaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(359, 285);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(73, 29);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Назад";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(359, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Имя пользователя";
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Location = new Point(12, 29);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(60, 17);
            lblArticle.TabIndex = 2;
            lblArticle.Text = "Артикул";
            // 
            // maskedTextBoxArticle
            // 
            maskedTextBoxArticle.Location = new Point(12, 49);
            maskedTextBoxArticle.Mask = ">L000L0";
            maskedTextBoxArticle.Name = "maskedTextBoxArticle";
            maskedTextBoxArticle.Size = new Size(151, 25);
            maskedTextBoxArticle.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 77);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(145, 17);
            lblProductName.TabIndex = 4;
            lblProductName.Text = "Наименование товара";
            // 
            // comboBoxProductName
            // 
            comboBoxProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductName.FormattingEnabled = true;
            comboBoxProductName.Items.AddRange(new object[] { "Ботинки", "Туфли", "Кроссовки", "Полуботинки", "Кеды", "Тапочки", "Сапоги" });
            comboBoxProductName.Location = new Point(12, 97);
            comboBoxProductName.Name = "comboBoxProductName";
            comboBoxProductName.Size = new Size(151, 25);
            comboBoxProductName.TabIndex = 5;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(12, 125);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(129, 17);
            lblUnit.TabIndex = 6;
            lblUnit.Text = "Единица измерения";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Items.AddRange(new object[] { "шт" });
            comboBoxUnit.Location = new Point(12, 145);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(151, 25);
            comboBoxUnit.TabIndex = 7;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(12, 173);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(79, 17);
            lblSupplier.TabIndex = 8;
            lblSupplier.Text = "Поставщик";
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Items.AddRange(new object[] { "Kari", "Обувь для вас" });
            comboBoxSupplier.Location = new Point(12, 193);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(151, 25);
            comboBoxSupplier.TabIndex = 9;
            // 
            // lblProducer
            // 
            lblProducer.AutoSize = true;
            lblProducer.Location = new Point(12, 221);
            lblProducer.Name = "lblProducer";
            lblProducer.Size = new Size(103, 17);
            lblProducer.TabIndex = 10;
            lblProducer.Text = "Производитель";
            // 
            // comboBoxProducer
            // 
            comboBoxProducer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducer.FormattingEnabled = true;
            comboBoxProducer.Items.AddRange(new object[] { "Kari", "Marco Tozzi", "Рос", "Rieker", "Alessio Nesca", "CROSBY" });
            comboBoxProducer.Location = new Point(12, 241);
            comboBoxProducer.Name = "comboBoxProducer";
            comboBoxProducer.Size = new Size(151, 25);
            comboBoxProducer.TabIndex = 11;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Женская обувь", "Мужская обувь" });
            comboBoxCategory.Location = new Point(12, 289);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 25);
            comboBoxCategory.TabIndex = 13;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 269);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(119, 17);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Категория товара";
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Location = new Point(185, 49);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(150, 25);
            numericUpDownDiscount.TabIndex = 14;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(185, 29);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(54, 17);
            lblDiscount.TabIndex = 15;
            lblDiscount.Text = "Скидка";
            lblDiscount.Click += lblDiscount_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(185, 77);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 17);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Цена";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(185, 97);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(150, 25);
            numericUpDownPrice.TabIndex = 16;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(185, 125);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(146, 17);
            lblQuantity.TabIndex = 19;
            lblQuantity.Text = "Количество на складе";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(185, 145);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(150, 25);
            numericUpDownQuantity.TabIndex = 18;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(185, 173);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 17);
            lblDescription.TabIndex = 20;
            lblDescription.Text = "Описание товара";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(185, 191);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(150, 123);
            textBoxDescription.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(359, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(359, 250);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(245, 29);
            btnLoadImage.TabIndex = 23;
            btnLoadImage.Text = "Загрузить изображение";
            btnLoadImage.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(438, 285);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(166, 29);
            btnSaveChanges.TabIndex = 24;
            btnSaveChanges.Text = "Сохранить изменения";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(609, 327);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnLoadImage);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblQuantity);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(lblPrice);
            Controls.Add(numericUpDownPrice);
            Controls.Add(lblDiscount);
            Controls.Add(numericUpDownDiscount);
            Controls.Add(comboBoxCategory);
            Controls.Add(lblCategory);
            Controls.Add(comboBoxProducer);
            Controls.Add(lblProducer);
            Controls.Add(comboBoxSupplier);
            Controls.Add(lblSupplier);
            Controls.Add(comboBoxUnit);
            Controls.Add(lblUnit);
            Controls.Add(comboBoxProductName);
            Controls.Add(lblProductName);
            Controls.Add(maskedTextBoxArticle);
            Controls.Add(lblArticle);
            Controls.Add(lblUsername);
            Controls.Add(btnReturn);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "EditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование товара";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReturn;
        private Label lblUsername;
        private Label lblArticle;
        private MaskedTextBox maskedTextBoxArticle;
        private Label lblProductName;
        private ComboBox comboBoxProductName;
        private Label lblUnit;
        private ComboBox comboBoxUnit;
        private Label lblSupplier;
        private ComboBox comboBoxSupplier;
        private Label lblProducer;
        private ComboBox comboBoxProducer;
        private ComboBox comboBoxCategory;
        private Label lblCategory;
        private NumericUpDown numericUpDownDiscount;
        private Label lblDiscount;
        private Label lblPrice;
        private NumericUpDown numericUpDownPrice;
        private Label lblQuantity;
        private NumericUpDown numericUpDownQuantity;
        private Label lblDescription;
        private TextBox textBoxDescription;
        private PictureBox pictureBox1;
        private Button btnLoadImage;
        private Button btnSaveChanges;
    }
}