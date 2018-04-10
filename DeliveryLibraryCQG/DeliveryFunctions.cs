using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryLibraryCQG
{
    public interface DeliveryFunctions
    {
         List<OrderProduct> AddtoListOrderProduct(List<OrderProduct> TempProductList, OrderProduct TempOrderProduct);

         List<Order> AddtoListOrder(List<Order> TempOrderList, Order TempProductList);
    }
}
