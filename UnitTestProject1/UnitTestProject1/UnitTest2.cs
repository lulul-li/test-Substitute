using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var modelController = new ModelController();
            var fakeModel=new FakeModel();
            modelController._model = fakeModel;
            modelController.RemoveAdultAge();

            var resultFuc = fakeModel.GetDeleteFunc;
            Assert.IsTrue(resultFuc(new Order(){Customer = new Customer(){Age = 19}}));
        }


        [TestMethod]
        public void TestMethod2()
        {
            Func<Order,bool> resultFuc = null;
            var fakeModel = Substitute.For<IModel>();
            var modelController = new ModelController()
            {
                _model = fakeModel
            };
            fakeModel.Delete(Arg.Do<Func<Order,bool>>(x=>resultFuc=x));
            modelController.RemoveAdultAge();


            Assert.IsTrue(resultFuc(new Order(){Customer = new Customer(){Age = 19}}));
        }

    }
}
