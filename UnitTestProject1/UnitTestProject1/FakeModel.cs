using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    public class Customer
    {
        public int Age;
    }

    public class Order
    {
        public Customer Customer;
    }

    public class FakeModel : IModel
    {
        private Func<Order, bool> _func;
        public Func<Order,bool> GetDeleteFunc => _func;

        public void Delete(Func<Order, bool> func)
        {
            _func = func;
            //Orders = Orders.Where(func).ToList();
        }


        public List<Order> Orders { get; set; }
    }
}