using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryLibraryCQG // Создал сущности, которые реализуют потенциальные таблицы БД
{
    public class Delivery
    {
        public Delivery() { }
        public  List<Company> GetOrderToCompanyFunction(List<Order> orders, List<Company> companies,out List<Int32> users) // Значения id продуктов совпадают, но различаются компании производящие их
        {                                                                                                                  // Users - список id тех, чей заказ обработан и кому должно прийти уведомление(могут повторяться)
            users = new List<Int32>();                                                                                     
            for (int order_i = 0; order_i < orders.Count(); order_i++) {
                users.Add(orders[order_i].getUser_id());
                List<OrderProduct> TempUserOrderProduct = orders[order_i].getOrder_product();
                for (int productorder_i = 0; productorder_i < TempUserOrderProduct.Count(); productorder_i++){
                    int TempCompanyId = TempUserOrderProduct[productorder_i].getCompany_id();
                    int TempProductId = TempUserOrderProduct[productorder_i].getProduct_id();
                    List<OrderProduct> TempCompanyOrderProduct = companies[TempCompanyId].getOrder_product();
                    TempCompanyOrderProduct[TempProductId].setCount(TempCompanyOrderProduct[TempProductId].getCount()+TempUserOrderProduct[productorder_i].getCount());
                    }
                }
            return companies;
        }
    }
}
