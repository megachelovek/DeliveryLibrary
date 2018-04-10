using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryLibraryCQG
{
   public class Company
    {
       int company_id;
        string company_name;
        List<OrderProduct> order_product; // Список заказанных у компании 
        public Company(int id, string name, List<OrderProduct> order_product)
        {
            this.company_id = id;
            this.company_name = name;
            this.order_product = order_product;
        }
        public int getCompany_id() { return this.company_id; }
        public string getCompany_name() { return this.company_name; }
        public List<OrderProduct> getOrder_product() { return this.order_product; }
        public void setCompany_id(int company_id) { this.company_id = company_id; }
        public void setCompany_name(string company_name) { this.company_name = company_name; }
        public void setOrder_product(List<OrderProduct> order_product) { this.order_product = order_product; }
    }
}
