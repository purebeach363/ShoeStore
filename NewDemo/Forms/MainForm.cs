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
using Npgsql;
using System.Net.NetworkInformation;
using NewDemo.UserControls;
using System.Security.Cryptography.X509Certificates;

namespace NewDemo.Forms
{
    public partial class MainForm : Form
    {
        private User loggedUser;
        private DB db = new DB();
        private string order = "";
        public MainForm(User user)
        {
            InitializeComponent();

            loggedUser = user;

            if (loggedUser == null) lblUsername.Text = "Гость";
            else lblUsername.Text = loggedUser.fullName;

            comboBoxSuppliers.SelectedIndex = 0;
            LoadProducts();
            Access();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
        public void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();

            string seach = textBoxSearch.Text;
            string supplier = comboBoxSuppliers.SelectedItem.ToString();

            var products = db.GetProducts(order, seach, supplier);

            foreach (var product in products)
            {
                ProductUC productCard = new ProductUC();
                productCard.SetUser(loggedUser);
                productCard.LoadProduct(product);
                flowLayoutPanel1.Controls.Add(productCard);
            }
        }

        private void checkBoxASC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxASC.Checked == true)
            {
                checkBoxDesc.Checked = false;
                order = "ASC";
                LoadProducts();
            }
        }

        private void checkBoxDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDesc.Checked == true)
            {
                checkBoxASC.Checked = false;
                order = "DESC";
                LoadProducts();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void comboBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var form = new AddProductForm(loggedUser))
            {
                form.ShowDialog();
            }
            /*
            var form1 = this.FindForm() as MainForm;
            form1?.LoadProducts();
            */
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm?.LoadProducts();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm(loggedUser);
            form.Show();
            this.Hide();
        }
        private void Access()
        {
            if (loggedUser == null || loggedUser.role == "Авторизованный пользователь")
            {
                lblFilters.Visible = false;
                lblSearch.Visible = false;
                lblSuppliers.Visible = false;

                btnAddProduct.Visible = false;
                btnOrders.Visible = false;
                checkBoxASC.Visible = false;
                checkBoxDesc.Visible = false;
                textBoxSearch.Visible = false;
                comboBoxSuppliers.Visible = false;
            }
            if (loggedUser != null && loggedUser.role != "Администратор") btnAddProduct.Visible = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.Exit();
        }
    }
}
