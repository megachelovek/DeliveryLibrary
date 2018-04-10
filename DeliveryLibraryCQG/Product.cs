using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryLibraryCQG
{
    public class Product
    {
        int product_id;
        string product_name;
        int company_id;
        public Product(int product_id, string product_name, int company_id)
        {
            this.product_id = product_id;
            this.product_name = product_name;
            this.company_id = company_id;
        }
        public int getProduct_id() { return this.product_id; }
        public string getProduct_name() { return this.product_name; }
        public int getCompany_id() { return this.company_id; }
        public void setProduct_id(int product_id) { this.product_id = product_id; }
        public void setProduct_name(string product_name) { this.product_name = product_name; }
        public void setCompany_id(int company_id) { this.company_id = company_id; }
    }
}
