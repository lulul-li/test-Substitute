using System;

namespace UnitTestProject1
{
    public interface IModel
    {
        void Delete(Func<Order, bool> func);
    }
}