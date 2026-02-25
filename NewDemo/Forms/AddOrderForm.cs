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
    public partial class AddOrderForm : Form
    {
        private User loggedUser;
        private DB db = new DB();
        public AddOrderForm(User user)
        {
            InitializeComponent();
            loggedUser = user;
            lblUsername.Text = loggedUser.fullName;

            comboBoxAddress.SelectedIndex = 0;
            comboBoxArticles.SelectedIndex = 0;
            comboBoxRecepient.SelectedIndex = 0;
            comboBoxStatuses.SelectedIndex = 0;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (listBoxItems.Items.Count == 0)
            {
                MessageBox.Show
                (
                "Добавьте хотя бы один товар!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }

            if (dateTimePickerOrderDate.Value > dateTimePickerDeliveryDate.Value)
            {
                MessageBox.Show
             (
             "Дата заказа не может быть позже чем дата доставки!",
             "Ошибка",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error
             );
                return;
            }

            var order = new Order();
            order.items = new List<OrderItem>();

            order.addressId = (int)comboBoxAddress.SelectedIndex + 1;
            order.statusId = (int)comboBoxStatuses.SelectedIndex + 1;
            order.userId = (int)comboBoxRecepient.SelectedIndex + 1;

            order.deliveryDate = dateTimePickerDeliveryDate.Value;
            order.orderDate = dateTimePickerOrderDate.Value;

            foreach(var item in listBoxItems.Items)
            {
                var parts = item.ToString().Split(' ');

                order.items.Add(new OrderItem
                {
                    Article = parts[0],
                    quantity = int.Parse(parts[1])
                });
            }

            db.InsertOrder(order);
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (numericUpDownQuantity.Value > 0)
                listBoxItems.Items.Add(comboBoxArticles.Text + " " + numericUpDownQuantity.Value.ToString());
        }
    }
}
