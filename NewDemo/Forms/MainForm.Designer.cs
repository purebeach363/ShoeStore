namespace NewDemo.Forms
{
    partial class MainForm
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
            lblSearch = new Label();
            textBoxSearch = new TextBox();
            lblSuppliers = new Label();
            comboBoxSuppliers = new ComboBox();
            lblFilters = new Label();
            checkBoxASC = new CheckBox();
            checkBoxDesc = new CheckBox();
            btnAddProduct = new Button();
            btnOrders = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(599, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Имя пользователя";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(698, 399);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(133, 29);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Назад";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(680, 396);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(698, 32);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(47, 17);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(698, 52);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(133, 25);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // lblSuppliers
            // 
            lblSuppliers.AutoSize = true;
            lblSuppliers.Location = new Point(698, 80);
            lblSuppliers.Name = "lblSuppliers";
            lblSuppliers.Size = new Size(86, 17);
            lblSuppliers.TabIndex = 4;
            lblSuppliers.Text = "Поставщики";
            // 
            // comboBoxSuppliers
            // 
            comboBoxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSuppliers.FormattingEnabled = true;
            comboBoxSuppliers.Items.AddRange(new object[] { "Все поставщики", "Kari", "Обувь для вас" });
            comboBoxSuppliers.Location = new Point(698, 100);
            comboBoxSuppliers.Name = "comboBoxSuppliers";
            comboBoxSuppliers.Size = new Size(133, 25);
            comboBoxSuppliers.TabIndex = 5;
            comboBoxSuppliers.SelectedIndexChanged += comboBoxSuppliers_SelectedIndexChanged;
            // 
            // lblFilters
            // 
            lblFilters.AutoSize = true;
            lblFilters.Location = new Point(698, 128);
            lblFilters.Name = "lblFilters";
            lblFilters.Size = new Size(63, 17);
            lblFilters.TabIndex = 6;
            lblFilters.Text = "Фильтры";
            // 
            // checkBoxASC
            // 
            checkBoxASC.AutoSize = true;
            checkBoxASC.Location = new Point(698, 148);
            checkBoxASC.Name = "checkBoxASC";
            checkBoxASC.Size = new Size(132, 21);
            checkBoxASC.TabIndex = 7;
            checkBoxASC.Text = "По возрастанию";
            checkBoxASC.UseVisualStyleBackColor = true;
            checkBoxASC.CheckedChanged += checkBoxASC_CheckedChanged;
            // 
            // checkBoxDesc
            // 
            checkBoxDesc.AutoSize = true;
            checkBoxDesc.Location = new Point(698, 175);
            checkBoxDesc.Name = "checkBoxDesc";
            checkBoxDesc.Size = new Size(116, 21);
            checkBoxDesc.TabIndex = 8;
            checkBoxDesc.Text = "По убыванию";
            checkBoxDesc.UseVisualStyleBackColor = true;
            checkBoxDesc.CheckedChanged += checkBoxDesc_CheckedChanged;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(698, 202);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(133, 29);
            btnAddProduct.TabIndex = 9;
            btnAddProduct.Text = "Добавить товар";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(698, 302);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(133, 29);
            btnOrders.TabIndex = 10;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(843, 440);
            Controls.Add(btnOrders);
            Controls.Add(btnAddProduct);
            Controls.Add(checkBoxDesc);
            Controls.Add(checkBoxASC);
            Controls.Add(lblFilters);
            Controls.Add(comboBoxSuppliers);
            Controls.Add(lblSuppliers);
            Controls.Add(textBoxSearch);
            Controls.Add(lblSearch);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnReturn);
            Controls.Add(lblUsername);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ООО ОБУВЬ";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Button btnReturn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblSearch;
        private TextBox textBoxSearch;
        private Label lblSuppliers;
        private ComboBox comboBoxSuppliers;
        private Label lblFilters;
        private CheckBox checkBoxASC;
        private CheckBox checkBoxDesc;
        private Button btnAddProduct;
        private Button btnOrders;
    }
}