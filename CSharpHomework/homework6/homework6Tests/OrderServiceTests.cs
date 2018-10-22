using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void RemoveOrderTest()
        {
            int num = 1;
            string name = "LeoZB";
            string cus = "Leona";
            int sum = 1000;
            OrderService os = new OrderService();
            os.AddOrder(num, name, cus, sum);
            bool result = os.RemoveOrder(num, name, cus, sum);
            Assert.IsTrue(result);
        }
        public void RemoveOrderTest2()
        {
            int num = 1;
            string name = "LeoZB";
            string cus = "Leona";
            int sum = 1000;
            OrderService os = new OrderService();
            bool result = os.RemoveOrder(num, name, cus, sum);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void AmendOrderTest()
        {
            int num1 = 1;
            string name1 = "LeoZB";
            string cus1 = "Leona";
            int sum1 = 1000;
            OrderService os = new OrderService();
            os.AddOrder(num1, name1, cus1, sum1);
            int num2 = 1;
            string name2 = "JohnnyZB";
            string cus2 = "Leona";
            int sum2 = 1000;
            bool result = os.AmendOrder(num1, name1, cus1, sum1, num2, name2, cus2, sum2);
            Assert.IsTrue(result);
        }
        public void AmendOrderTest2()
        {
            int num1 = 1;
            string name1 = "LeoZB";
            string cus1 = "Leona";
            int sum1 = 1000;
            OrderService os = new OrderService();
            int num2 = 1;
            string name2 = "JohnnyZB";
            string cus2 = "Leona";
            int sum2 = 1000;
            bool result = os.AmendOrder(num1, name1, cus1, sum1, num2, name2, cus2, sum2);
            Assert.IsFalse(result);
        }
    }
    
}