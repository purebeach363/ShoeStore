using NewDemo.Classes;
using NewDemo.UserControls;
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
    public partial class OrdersForm : Form
    {
        private User loggedUser;
        private DB db = new DB();
        public OrdersForm(User user)
        {
            InitializeComponent();
            loggedUser = user;
            lblUsername.Text = loggedUser.fullName;
            if (loggedUser.role != "Администратор") btnAddOrder.Visible = false;
            LoadOrders();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(loggedUser);
            form.Show();
            this.Close();
        }
        public void LoadOrders()
        {
            flowLayoutPanel1.Controls.Clear();

            var orders = db.GetOrders();

            foreach (var order in orders)
            {
                OrderUC orderCard = new OrderUC();
                orderCard.LoadOrder(order);
                orderCard.SetUser(loggedUser);
                flowLayoutPanel1.Controls.Add(orderCard);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            using(var form = new AddOrderForm(loggedUser)) form.ShowDialog();

            var ordersForm = this.FindForm() as OrdersForm;
            ordersForm?.LoadOrders();
        }
    }
}
