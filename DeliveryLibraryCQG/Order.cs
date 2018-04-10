using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryLibraryCQG
{
    public class Order
    {
        List<OrderProduct> order_product;
        int user_id;
        public Order(List<OrderProduct> order_product, int user_id)
        {
            this.order_product = order_product;
            this.user_id = user_id;
        }
        public List<OrderProduct> getOrder_product() { return this.order_product; }
        public int getUser_id() { return this.user_id; }
        public void setOrder_product(List<OrderProduct> order_product) { this.order_product = order_product; }
        public void setUser_id(int user_id) { this.user_id = user_id; }
    }
}
