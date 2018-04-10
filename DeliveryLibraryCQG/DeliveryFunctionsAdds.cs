using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryLibraryCQG
{
   public class DeliveryFunctionsAdds: DeliveryFunctions
    {
       public DeliveryFunctionsAdds() { }
        public List<OrderProduct> AddtoListOrderProduct(List<OrderProduct> TempProductList, OrderProduct TempOrderProduct)
        {
            TempProductList.Add(TempOrderProduct);
            return TempProductList;
        }
        public List<Order> AddtoListOrder(List<Order> TempOrderList, Order TempProductList) 
        {
            TempOrderList.Add(TempProductList);
            return TempOrderList;
        }
    }
}
