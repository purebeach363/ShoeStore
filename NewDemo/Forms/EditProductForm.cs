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
    public partial class EditProductForm : Form
    {
        private User loggedUser;
        private DB db = new DB();
        private Product productForEdit;
        public EditProductForm(User user, Product product)
        {
            InitializeComponent();
            loggedUser = user;
            lblUsername.Text = loggedUser.fullName;
            productForEdit = product;
            LoadProduct();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {

        }
        private void LoadProduct()
        {
            textBoxDescription.Text = productForEdit.description;

            comboBoxCategory.SelectedIndex = productForEdit.categoryId - 1;
            comboBoxProducer.SelectedIndex = productForEdit.producerId - 1;
            comboBoxProductName.SelectedIndex = productForEdit.productNameId - 1;
            comboBoxSupplier.SelectedIndex = productForEdit.supplierId - 1;
            comboBoxUnit.SelectedIndex = 0;

            numericUpDownDiscount.Value = productForEdit.discount;
            numericUpDownPrice.Value = productForEdit.price;
            numericUpDownQuantity.Value = productForEdit.quantity;
            
            maskedTextBoxArticle.Text = productForEdit.article;

            if (string.IsNullOrEmpty(productForEdit.picture))
            {
                pictureBox1.ImageLocation = @"C:\Users\slavi\demo\6\import\picture.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\slavi\demo\6\import\" + productForEdit.picture;
            }
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!maskedTextBoxArticle.MaskCompleted)
            {
                MessageBox.Show
                    (
                        "Введите артикул товара!",
                         "Ошибка",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                    );
            }
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
            if((int)numericUpDownPrice.Value == 0)
            {
                MessageBox.Show
                    (
                        "Введите цену товара!",
                         "Ошибка",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                    );
            }
            
            productForEdit.description = textBoxDescription.Text;

            productForEdit.price = (int)numericUpDownPrice.Value;
            productForEdit.quantity = (int)numericUpDownQuantity.Value;
            productForEdit.discount = (int)numericUpDownDiscount.Value;

            productForEdit.categoryId = comboBoxCategory.SelectedIndex + 1;
            productForEdit.producerId = comboBoxProducer.SelectedIndex + 1;
            productForEdit.supplierId = comboBoxSupplier.SelectedIndex + 1;
            productForEdit.productNameId = comboBoxProductName.SelectedIndex + 1;
            productForEdit.unit = comboBoxUnit.Text;
            productForEdit.article = maskedTextBoxArticle.Text;

            db.UpdateProduct(productForEdit);
            this.Close();
        }
    }
}
