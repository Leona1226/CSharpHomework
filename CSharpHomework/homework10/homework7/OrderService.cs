using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework7
{
    public class OrderService
    {
        public List<OrderDetails> list = new List<OrderDetails>();
        public void AddOrder(string num, String name, String cus, int sum)                   //添加订单
        {
            using (var db = new Model1())
            {
                var order = db.OrderDetails.SingleOrDefault(o => o.OrderNum == num);
                if (order == null)
                {
                    OrderDetails od = new OrderDetails(num, name, cus, sum);
                    db.OrderDetails.Add(od);
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("该订单已存在");
                }
                list = db.OrderDetails.ToList<OrderDetails>();
            }
        }
        public void RemoveOrder(string num, String name, String cus, int sum)                //删除订单
        {
            using (var db = new Model1())
            {
                var order = db.OrderDetails.SingleOrDefault(o => o.OrderNum ==num );
                if (order!=null)
                {
                    db.OrderDetails.Remove(order);
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("该订单不存在");
                }
                list = db.OrderDetails.ToList<OrderDetails>();
            }
        }
        public void AmendOrder(string num1, String name1, String cus1, int sum1, string num2, String name2, String cus2, int sum2)   //修改订单
        {
            using (var db = new Model1())
            {
                RemoveOrder(num1, name1, cus1, sum1);
                AddOrder(num2, name2, cus2, sum1);
            }
        }
        public void InquireByName(String name)                               //按商品名查找
        {
            using (var db = new Model1())
            {
                List<OrderDetails>list1  = db.OrderDetails.Where(o => o.ProductName.Equals(name)).ToList<OrderDetails>();
            }
            
        }
        public void InquireByNum(string num)                                   //按订单号查找
        {
            using (var db = new Model1())
            {
                List<OrderDetails> list1 = db.OrderDetails.Where(o => o.OrderNum.Equals(num)).ToList<OrderDetails>();
            }
        }
        public void InquireByCustomer(String cus)                           //按客户查找
        {
            using (var db = new Model1())
            {
                List<OrderDetails> list1 = db.OrderDetails.Where(o => o.Customer.Equals(cus)).ToList<OrderDetails>();
            }
        }
        public void InquireBySum(int sum)                           //按金额超过一万查找
        {
            using (var db = new Model1())
            {
                List<OrderDetails> list1 = db.OrderDetails.Where(o => o.sum.Equals(sum)).ToList<OrderDetails>();
            }
        }
    }
}

