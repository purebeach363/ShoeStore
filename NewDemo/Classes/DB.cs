using NewDemo.UserControls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo.Classes
{
    public class DB
    {
        public string connectionString = "Port=5432;Host=localhost;Username=postgres;Password=postgres;Database=ShoesShoesShoes";

        public List<User> GetUsers()
        {
            var users = new List<User>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT roles.""role"", full_name, login, password
	            FROM public.users
	            JOIN public.roles ON roles.role_id = users.fk_role";

                using(var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            role = reader.GetString(0),
                            fullName = reader.GetString(1),
                            login = reader.GetString(2),
                            password = reader.GetString(3)
                        });
                    }
                }
            }
            return users;
        }
        public List<Product> GetProducts(string order, string search, string supplier)
        {
            var products =  new List<Product>();

            using(var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = $@"SELECT article, product_names.product_name, unit, price, suppliers.supplier, producers.producer, 
                categories.category, discount, amount, description, picture, products.fk_category, products.fk_producer, 
                products.fk_supplier, fk_product_name
	            FROM public.products
	            JOIN public.product_names ON product_names.product_name_id = products.fk_product_name
	            JOIN public.suppliers ON suppliers.supplier_id = products.fk_supplier
	            JOIN public.producers ON producers.producer_id = products.fk_producer
	            JOIN public.categories ON categories.category_id = products.fk_category
                {(search != "" || supplier != "Все поставщики" ? "WHERE " : "")}
                {(search != "" ? $"product_names.product_name ILIKE '%{search}%'" : "")}
                {(search != "" && supplier != "Все поставщики" ? " AND " : "")}
                {(supplier != "Все поставщики" ? $"suppliers.supplier = '{supplier}'" : "")}
                ORDER BY amount {order}";

                using(var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            article = reader.GetString(0),
                            productName = reader.GetString(1),
                            unit = reader.GetString(2),
                            price = reader.GetInt32(3),
                            supplier = reader.GetString(4),
                            producer = reader.GetString(5),
                            category = reader.GetString(6),
                            discount = reader.GetInt32(7),
                            quantity = reader.GetInt32(8),
                            description = reader.GetString(9),
                            picture = reader.IsDBNull(10) ? "picture.png" : reader.GetString(10),
                            categoryId = reader.GetInt32(11),
                            producerId = reader.GetInt32(12),
                            supplierId = reader.GetInt32(13),
                            productNameId = reader.GetInt32(14)
                        });
                    }
                }
            }
            return products;
        }
        public void InsertProduct(Product product)
        {
            using(var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO public.products(
	article, fk_product_name, unit, price, fk_supplier, fk_producer, fk_category, discount, amount, description)
	VALUES (@article, @productNameId, @unit, @price, @supplierId, @producerId, @categoryId, @discount, @amount, @description);";

                using(var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@article", product.article);
                    cmd.Parameters.AddWithValue("@productNameId", product.productNameId);
                    cmd.Parameters.AddWithValue("@unit", product.unit);
                    cmd.Parameters.AddWithValue("@price", product.price);
                    cmd.Parameters.AddWithValue("@supplierId", product.supplierId);
                    cmd.Parameters.AddWithValue("@producerId", product.producerId);
                    cmd.Parameters.AddWithValue("@categoryId", product.categoryId);
                    cmd.Parameters.AddWithValue("@discount", product.discount);
                    cmd.Parameters.AddWithValue("@amount", product.quantity);
                    cmd.Parameters.AddWithValue("@description", product.description);
                  //  cmd.Parameters.AddWithValue("@picture", product.picture);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Order> GetOrders()
        {
            var orders = new List<Order>();

            using(var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT id_item, fk_article, orders.delivery_date, orders.order_date, addresses.address, statuses.status, order_items.fk_order_id, quantity, fk_status, orders.fk_address,
				orders.fk_user
	            FROM public.order_items
	            JOIN orders ON order_items.fk_order_id = orders.id_order
	            JOIN addresses ON addresses.id_address = orders.fk_address
	            JOIN statuses ON statuses.id_status = orders.fk_status
				JOIN users ON users.user_id = orders.fk_user";

                using(var cmd = new NpgsqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            itemId = reader.GetInt32(0),
                            article = reader.GetString(1),
                            deliveryDate = reader.GetDateTime(2),
                            orderDate = reader.GetDateTime(3),
                            address = reader.GetString(4),
                            status = reader.GetString(5),
                            orderId = reader.GetInt32(6),
                            quantity = reader.GetInt32(7),
                            statusId = reader.GetInt32(8),
                            addressId = reader.GetInt32(9),
                            userId = reader.GetInt32(10),
                        });
                    }
                }
            }
            return orders;
        }
        public void UpdateProduct(Product product)
        {
            using(var conn = new NpgsqlConnection (connectionString))
            {
                conn.Open();
                string query = @"UPDATE public.products
	            SET 
                fk_product_name = @productNameId,
                unit = @unit,
                price = @price,
                fk_supplier = @supplierId,
                fk_producer = @producerId, 
                fk_category = @categoryId,
                discount = @discount,
                amount = @quantity,
                description = @description
	            WHERE article = @article";

                using (var cmd = new NpgsqlCommand(query, conn))
                { 
                    cmd.Parameters.AddWithValue("@productNameId", product.productNameId);
                    cmd.Parameters.AddWithValue("@unit", product.unit);
                    cmd.Parameters.AddWithValue("@price", product.price);
                    cmd.Parameters.AddWithValue("@supplierId", product.supplierId);
                    cmd.Parameters.AddWithValue("@producerId", product.producerId);
                    cmd.Parameters.AddWithValue("@categoryId", product.categoryId);
                    cmd.Parameters.AddWithValue("@discount", product.discount);
                    cmd.Parameters.AddWithValue("@quantity", product.quantity);
                    cmd.Parameters.AddWithValue("@description", product.description);
                    cmd.Parameters.AddWithValue("@article", product.article);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void InsertOrder(Order order)
        {
            using(var conn = new NpgsqlConnection (connectionString))
            {
                conn.Open();
                
                using(var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string orderQuery = @"INSERT INTO public.orders(
	                    order_date, delivery_date, fk_address, fk_user, fk_status)
	                    VALUES (@orderDate, @deliveryDate, @addressId, @userId, @statusId)
                        RETURNING id_order;";

                        int orderId;

                        using(var cmd = new NpgsqlCommand(orderQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@orderDate", order.orderDate);
                            cmd.Parameters.AddWithValue("@deliveryDate", order.deliveryDate);
                            cmd.Parameters.AddWithValue("@addressId", order.addressId);
                            cmd.Parameters.AddWithValue("@userId", order.userId);
                            cmd.Parameters.AddWithValue("@statusId", order.statusId);

                            orderId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string itemQuery = @"INSERT INTO public.order_items(
	                    fk_order_id, fk_article, quantity)
	                    VALUES (@orderId, @article, @quantity);";

                        using(var cmd = new NpgsqlCommand(itemQuery, conn, transaction))
                        {
                            cmd.Parameters.Add("@orderId", NpgsqlTypes.NpgsqlDbType.Integer);
                            cmd.Parameters.Add("@article", NpgsqlTypes.NpgsqlDbType.Text);
                            cmd.Parameters.Add("@quantity", NpgsqlTypes.NpgsqlDbType.Integer);

                            foreach(var item in order.items)
                            {
                                cmd.Parameters["@orderId"].Value = orderId;
                                cmd.Parameters["@article"].Value = item.Article;
                                cmd.Parameters["@quantity"].Value = item.quantity;

                                cmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void UpdateOrder(Order order)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using(var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string orderQuery = @"UPDATE public.orders
	                    SET order_date = @orderDate, delivery_date= @deliveryDate, fk_address= @addressId, fk_user= @userId, fk_status= @statusId
	                    WHERE id_order = @orderId;";

                        using(var cmd = new NpgsqlCommand(orderQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@orderDate", order.orderDate);
                            cmd.Parameters.AddWithValue("@deliveryDate", order.deliveryDate);
                            cmd.Parameters.AddWithValue("@addressId", order.addressId);
                            cmd.Parameters.AddWithValue("@userId", order.userId);
                            cmd.Parameters.AddWithValue("@statusId", order.statusId);
                            cmd.Parameters.AddWithValue("@orderId", order.orderId);

                            cmd.ExecuteNonQuery();
                        }

                        string itemQuery = @"UPDATE public.order_items
	                    SET fk_article= @article, quantity= @quantity
	                    WHERE id_item = @itemId;";

                        using(var cmd = new NpgsqlCommand(itemQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@itemId", order.itemId);
                            cmd.Parameters.AddWithValue("@article", order.article);
                            cmd.Parameters.AddWithValue("@quantity", order.quantity);

                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}