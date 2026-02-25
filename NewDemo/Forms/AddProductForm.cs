using NewDemo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDemo.Forms
{
    public partial class AddProductForm : Form
    {
        private User loggedUser;
        public AddProductForm(User user)
        {
            InitializeComponent();
            loggedUser = user;
            lblUsername.Text = loggedUser.fullName;

            comboBoxCategory.SelectedIndex = 0;
            comboBoxProducer.SelectedIndex = 0;
            comboBoxProductName.SelectedIndex = 0;
            comboBoxSupplier.SelectedIndex = 0;
            comboBoxUnit.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDescription.Text))
            {
                MessageBox.Show
                (
                    "Введите описание товара!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            if (!maskedTextBoxArticle.MaskCompleted)
            {
                MessageBox.Show
                (
                    "Введите описание артикул!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            if((int)numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show
                (
                    "Введите цену!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            Product product = new Product();

            product.price = (int)numericUpDownPrice.Value;
            product.quantity = (int)numericUpDownQuantity.Value;
            product.discount = (int)numericUpDownDiscount.Value;

            product.article = maskedTextBoxArticle.Text;
            product.unit = comboBoxUnit.SelectedItem.ToString();

            product.supplierId = comboBoxSupplier.SelectedIndex + 1;
            product.productNameId = comboBoxProductName.SelectedIndex + 1;
            product.producerId = comboBoxProducer.SelectedIndex + 1;
            product.categoryId = comboBoxCategory.SelectedIndex + 1;
            product.description = textBoxDescription.Text;

            var db = new DB();
            db.InsertProduct(product);
            this.Close();
        }
        public void LoadReferences()
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
