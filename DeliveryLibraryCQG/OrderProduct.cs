using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryLibraryCQG
{
    public class OrderProduct
    {
        int product_id;
        int company_id;
        int count; // В задании сказано, что количество не обязательно, но я решил реализовать с ним, т.к. задача интереснее
        public OrderProduct(){ }
        public OrderProduct(int product_id,int company_id, int count)
        {
            this.product_id = product_id;
            this.company_id = company_id;
            this.count = count;
        }
        public int getProduct_id() { return this.product_id; }
        public int getCompany_id() { return this.company_id; }
        public int getCount() { return this.count; }
        public void setProduct_id(int product_id) { this.product_id = product_id; }
        public void setCompany_id(int company_id) { this.company_id = company_id; }
        public void setCount(int count) { this.count = count; }
    }
}
