using NewDemo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDemo.Forms
{
    public partial class EditOrderForm : Form
    {
        private User loggedUser;
        private Order orderToEdit;
        private DB db = new DB();
        public EditOrderForm(User user, Order orderToEdit)
        {
            InitializeComponent();
            loggedUser = user;
            lblUsername.Text = loggedUser.fullName;

            comboBoxAddresses.SelectedIndex = 0;
            comboBoxArticle.SelectedIndex = 0;
            comboBoxStatuses.SelectedIndex = 0;
            comboBoxUsers.SelectedIndex = 0;
            this.orderToEdit = orderToEdit;
            LoadOrder();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void lblOrderDate_Click(object sender, EventArgs e)
        {

        }
        private void LoadOrder()
        {
            comboBoxAddresses.SelectedIndex = orderToEdit.addressId - 1;
            comboBoxUsers.SelectedIndex = orderToEdit.userId - 1;
            comboBoxStatuses.SelectedIndex = orderToEdit.statusId - 1;
            dateTimePickerDelivery.Value = orderToEdit.deliveryDate;
            dateTimePickerOrder.Value = orderToEdit.orderDate;
            numericUpDownQuantity.Value = orderToEdit.quantity;
            comboBoxArticle.Text = orderToEdit.article;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(dateTimePickerOrder.Value > dateTimePickerDelivery.Value)
            {
                MessageBox.Show
                    ("Дата заказа не может быть позже чем дата доставки",
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }

            orderToEdit.article = comboBoxArticle.Text;
            orderToEdit.statusId = comboBoxStatuses.SelectedIndex + 1;
            orderToEdit.addressId = comboBoxAddresses.SelectedIndex + 1;
            orderToEdit.userId = comboBoxUsers.SelectedIndex + 1;
            orderToEdit.quantity = (int)numericUpDownQuantity.Value;
            orderToEdit.orderDate = dateTimePickerOrder.Value;
            orderToEdit.deliveryDate = dateTimePickerDelivery.Value;

            db.UpdateOrder(orderToEdit);
            this.Close();
        }
    }
}
