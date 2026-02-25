namespace NewDemo.UserControls
{
    partial class ProductUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUC));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnEditProduct = new Button();
            lblQuantity = new Label();
            lblUnit = new Label();
            lblDiscountedPrice = new Label();
            lblPrice = new Label();
            lblSupplier = new Label();
            lblProducer = new Label();
            lblDescription = new Label();
            lblProductName = new Label();
            lblCategory = new Label();
            panel2 = new Panel();
            lblDiscount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnEditProduct);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(lblUnit);
            panel1.Controls.Add(lblDiscountedPrice);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(lblSupplier);
            panel1.Controls.Add(lblProducer);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(lblCategory);
            panel1.Location = new Point(149, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 122);
            panel1.TabIndex = 1;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(197, 85);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(111, 32);
            btnEditProduct.TabIndex = 3;
            btnEditProduct.Text = "Редактировать";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(3, 102);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(149, 17);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Количество на складе:";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(3, 85);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(132, 17);
            lblUnit.TabIndex = 7;
            lblUnit.Text = "Единица измерения:";
            // 
            // lblDiscountedPrice
            // 
            lblDiscountedPrice.AutoSize = true;
            lblDiscountedPrice.Location = new Point(75, 68);
            lblDiscountedPrice.Name = "lblDiscountedPrice";
            lblDiscountedPrice.Size = new Size(111, 17);
            lblDiscountedPrice.TabIndex = 6;
            lblDiscountedPrice.Text = "Цена со скидкой";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 68);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 17);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Цена:";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(3, 51);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(82, 17);
            lblSupplier.TabIndex = 4;
            lblSupplier.Text = "Поставщик:";
            // 
            // lblProducer
            // 
            lblProducer.AutoSize = true;
            lblProducer.Location = new Point(3, 34);
            lblProducer.Name = "lblProducer";
            lblProducer.Size = new Size(106, 17);
            lblProducer.TabIndex = 3;
            lblProducer.Text = "Производитель:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(3, 17);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(118, 17);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Описание Товара:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(127, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(112, 17);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Наименование";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(3, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(82, 17);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Категория";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblDiscount);
            panel2.Location = new Point(468, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 122);
            panel2.TabIndex = 2;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(66, 51);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(21, 17);
            lblDiscount.TabIndex = 9;
            lblDiscount.Text = "%";
            // 
            // ProductUC
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ProductUC";
            Size = new Size(635, 128);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblSupplier;
        private Label lblProducer;
        private Label lblDescription;
        private Label lblQuantity;
        private Label lblUnit;
        private Label lblDiscountedPrice;
        private Label lblDiscount;
        private Button btnEditProduct;
    }
}
