using NewDemo.Classes;
using NewDemo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDemo.UserControls
{
    public partial class ProductUC : UserControl
    {
        private User loggedUser;
        private Product productForEdit;
        public ProductUC()
        {
            InitializeComponent();
        }
        public void LoadProduct(Product product)
        {

            productForEdit = product;

            lblCategory.Text = product.category + "  |";
            lblProductName.Text = product.productName;

            lblDescription.Text += " " + product.description;
            lblDiscount.Text = $"{product.discount}%";
            lblPrice.Text += " " + product.price.ToString();
            lblProducer.Text += " " + product.producer;
            lblQuantity.Text += " " + product.quantity.ToString();
            lblSupplier.Text += " " + product.supplier;
            lblUnit.Text += " " + product.unit;

            if (string.IsNullOrEmpty(product.picture))
            {
                pictureBox1.ImageLocation = @"C:\Users\slavi\demo\6\import\picture.png";
            }
            else
            {
                pictureBox1.ImageLocation = $@"C:\Users\slavi\demo\6\import\" + product.picture;
            }

            if (product.quantity == 0) lblQuantity.ForeColor = Color.Aqua;
            if (product.discount > 15) panel2.BackColor = ColorTranslator.FromHtml("#2E8B57");

            if (product.discount > 0)
            {
                decimal discountedPrice = product.price - (product.price * product.discount / 100m);
                lblDiscountedPrice.Text = discountedPrice.ToString() + " руб.";
                lblPrice.ForeColor = Color.Red;
                lblPrice.Font = new Font(lblPrice.Font, FontStyle.Strikeout);
            }
        }
        public void SetUser(User user)
        {
            loggedUser = user;
            if (loggedUser == null || loggedUser.role != "Администратор") btnEditProduct.Visible = false;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new EditProductForm(loggedUser, productForEdit)) form.ShowDialog();

                var mainForm = this.FindForm() as MainForm;
                mainForm?.LoadProducts();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
