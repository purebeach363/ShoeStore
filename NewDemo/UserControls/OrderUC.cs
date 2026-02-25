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
    public partial class OrderUC : UserControl
    {
        private User loggedUser;
        private Order orderToEdit;
        public OrderUC()
        {
            InitializeComponent();
        }
        public void LoadOrder(Order order)
        {
            orderToEdit = order;

            lblArticle.Text = order.article;
            lblDeliveryDate.Text += $" {order.deliveryDate.ToString("d")}";
            lblOrderDate.Text += $" {order.orderDate.ToString("d")}";
            lblStatus.Text += $" {order.status}";
            lblAddress.Text += $" {order.address}";
        }
        public void SetUser(User user)
        {
            loggedUser = user;

            if (loggedUser.role == "Менеджер") btnEdit.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var form = new EditOrderForm(loggedUser, orderToEdit))
            {
                form.ShowDialog();
            }
            var orderForm = this.FindForm() as OrdersForm;
            orderForm?.LoadOrders();
        }
    }
}
