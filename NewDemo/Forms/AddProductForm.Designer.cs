namespace NewDemo.Forms
{
    partial class AddProductForm
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
            lblArticle = new Label();
            maskedTextBoxArticle = new MaskedTextBox();
            lblProductName = new Label();
            comboBoxProductName = new ComboBox();
            lblSupplier = new Label();
            comboBoxSupplier = new ComboBox();
            lblProducer = new Label();
            comboBoxProducer = new ComboBox();
            lblCategory = new Label();
            comboBoxCategory = new ComboBox();
            lblPrice = new Label();
            numericUpDownPrice = new NumericUpDown();
            lblDiscount = new Label();
            numericUpDownDiscount = new NumericUpDown();
            numericUpDownQuantity = new NumericUpDown();
            lblQuantity = new Label();
            lblDescription = new Label();
            textBoxDescription = new TextBox();
            lblPicture = new Label();
            pictureBoxPicture = new PictureBox();
            btnLoadPicture = new Button();
            btnReturn = new Button();
            btnAddProduct = new Button();
            lblUnit = new Label();
            comboBoxUnit = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPicture).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(450, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Имя пользователя";
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Location = new Point(12, 44);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(60, 17);
            lblArticle.TabIndex = 1;
            lblArticle.Text = "Артикул";
            // 
            // maskedTextBoxArticle
            // 
            maskedTextBoxArticle.Location = new Point(12, 64);
            maskedTextBoxArticle.Mask = ">L000L0";
            maskedTextBoxArticle.Name = "maskedTextBoxArticle";
            maskedTextBoxArticle.Size = new Size(151, 25);
            maskedTextBoxArticle.TabIndex = 2;
            maskedTextBoxArticle.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 92);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(145, 17);
            lblProductName.TabIndex = 3;
            lblProductName.Text = "Наименование товара";
            // 
            // comboBoxProductName
            // 
            comboBoxProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductName.FormattingEnabled = true;
            comboBoxProductName.Items.AddRange(new object[] { "Ботинки", "Туфли", "Кроссовки", "Полуботинки", "Кеды", "Тапочки", "Сапоги" });
            comboBoxProductName.Location = new Point(12, 112);
            comboBoxProductName.Name = "comboBoxProductName";
            comboBoxProductName.Size = new Size(151, 25);
            comboBoxProductName.TabIndex = 4;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(12, 140);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(79, 17);
            lblSupplier.TabIndex = 5;
            lblSupplier.Text = "Поставщик";
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Items.AddRange(new object[] { "Завершен", "Новый" });
            comboBoxSupplier.Location = new Point(12, 160);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(151, 25);
            comboBoxSupplier.TabIndex = 6;
            // 
            // lblProducer
            // 
            lblProducer.AutoSize = true;
            lblProducer.Location = new Point(12, 188);
            lblProducer.Name = "lblProducer";
            lblProducer.Size = new Size(103, 17);
            lblProducer.TabIndex = 7;
            lblProducer.Text = "Производитель";
            // 
            // comboBoxProducer
            // 
            comboBoxProducer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducer.FormattingEnabled = true;
            comboBoxProducer.Items.AddRange(new object[] { "Kari", "Marco Tozzi", "Рос", "Rieker", "Alessio Nesca", "CROSBY" });
            comboBoxProducer.Location = new Point(12, 208);
            comboBoxProducer.Name = "comboBoxProducer";
            comboBoxProducer.Size = new Size(151, 25);
            comboBoxProducer.TabIndex = 8;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 236);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(119, 17);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Категория товара";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Женская обувь", "Мужская обувь" });
            comboBoxCategory.Location = new Point(12, 256);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 25);
            comboBoxCategory.TabIndex = 10;
            comboBoxCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(207, 92);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 17);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Цена";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(207, 113);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(150, 25);
            numericUpDownPrice.TabIndex = 12;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(207, 141);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(54, 17);
            lblDiscount.TabIndex = 13;
            lblDiscount.Text = "Скидка";
            // 
            // numericUpDownDiscount
            // 
            numericUpDownDiscount.Location = new Point(207, 161);
            numericUpDownDiscount.Name = "numericUpDownDiscount";
            numericUpDownDiscount.Size = new Size(150, 25);
            numericUpDownDiscount.TabIndex = 14;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(207, 208);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(150, 25);
            numericUpDownQuantity.TabIndex = 15;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(207, 188);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(146, 17);
            lblQuantity.TabIndex = 16;
            lblQuantity.Text = "Количество на складе";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(388, 44);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 17);
            lblDescription.TabIndex = 17;
            lblDescription.Text = "Описание товара";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(388, 64);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(150, 169);
            textBoxDescription.TabIndex = 18;
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.Location = new Point(566, 44);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(92, 17);
            lblPicture.TabIndex = 19;
            lblPicture.Text = "Изображение";
            // 
            // pictureBoxPicture
            // 
            pictureBoxPicture.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPicture.Location = new Point(566, 64);
            pictureBoxPicture.Name = "pictureBoxPicture";
            pictureBoxPicture.Size = new Size(150, 134);
            pictureBoxPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPicture.TabIndex = 20;
            pictureBoxPicture.TabStop = false;
            // 
            // btnLoadPicture
            // 
            btnLoadPicture.Location = new Point(566, 204);
            btnLoadPicture.Name = "btnLoadPicture";
            btnLoadPicture.Size = new Size(150, 29);
            btnLoadPicture.TabIndex = 21;
            btnLoadPicture.Text = "Загрузить";
            btnLoadPicture.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(388, 252);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(150, 29);
            btnReturn.TabIndex = 22;
            btnReturn.Text = "Назад";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(566, 252);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(150, 29);
            btnAddProduct.TabIndex = 23;
            btnAddProduct.Text = "Добавить товар";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(207, 44);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(129, 17);
            lblUnit.TabIndex = 24;
            lblUnit.Text = "Единица измерения";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Items.AddRange(new object[] { "шт" });
            comboBoxUnit.Location = new Point(207, 64);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(150, 25);
            comboBoxUnit.TabIndex = 25;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(732, 295);
            Controls.Add(comboBoxUnit);
            Controls.Add(lblUnit);
            Controls.Add(btnAddProduct);
            Controls.Add(btnReturn);
            Controls.Add(btnLoadPicture);
            Controls.Add(pictureBoxPicture);
            Controls.Add(lblPicture);
            Controls.Add(textBoxDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblQuantity);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(numericUpDownDiscount);
            Controls.Add(lblDiscount);
            Controls.Add(numericUpDownPrice);
            Controls.Add(lblPrice);
            Controls.Add(comboBoxCategory);
            Controls.Add(lblCategory);
            Controls.Add(comboBoxProducer);
            Controls.Add(lblProducer);
            Controls.Add(comboBoxSupplier);
            Controls.Add(lblSupplier);
            Controls.Add(comboBoxProductName);
            Controls.Add(lblProductName);
            Controls.Add(maskedTextBoxArticle);
            Controls.Add(lblArticle);
            Controls.Add(lblUsername);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление продукта";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblArticle;
        private MaskedTextBox maskedTextBoxArticle;
        private Label lblProductName;
        private ComboBox comboBoxProductName;
        private Label lblSupplier;
        private ComboBox comboBoxSupplier;
        private Label lblProducer;
        private ComboBox comboBoxProducer;
        private Label lblCategory;
        private ComboBox comboBoxCategory;
        private Label lblPrice;
        private NumericUpDown numericUpDownPrice;
        private Label lblDiscount;
        private NumericUpDown numericUpDownDiscount;
        private NumericUpDown numericUpDownQuantity;
        private Label lblQuantity;
        private Label lblDescription;
        private TextBox textBoxDescription;
        private Label lblPicture;
        private PictureBox pictureBoxPicture;
        private Button btnLoadPicture;
        private Button btnReturn;
        private Button btnAddProduct;
        private Label lblUnit;
        private ComboBox comboBoxUnit;
    }
}