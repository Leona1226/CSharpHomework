using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace homework7
{
    public class OrderService
    {
        public List<OrderDetails> list = new List<OrderDetails>();
        public void AddOrder(String num, String name, String cus, int sum, String pNum)                   //添加订单
        {
            string pattern = "^[0-9]{4}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[0-9]{3}$";
            string pat = "^[0-9]{11}$";
            Regex rx = new Regex(pattern);
            Regex rx1 = new Regex(pat);
            Match m = rx.Match(num);
            Match m1 = rx1.Match(pNum);
            OrderDetails od = null;
            foreach (OrderDetails OD in list)
            {
                if (OD.OrderNum == num && OD.ProductName == name && OD.Customer == cus && OD.sum == sum)
                {
                    od = OD;
                }
            }
                if (od == null)
                {
                    if (m.Success)
                    {
                        OrderDetails od1 = new OrderDetails(num, name, cus, sum, pNum);
                        list.Add(od1);
                    }
                    else
                    {
                        Console.WriteLine("订单号格式不正确");
                    }
                }
            else
            {
                Console.WriteLine("该订单号依存在");
            }
        }
        public bool RemoveOrder(String num, String name, String cus, int sum)                //删除订单
        {
            OrderDetails od = null;
            foreach (OrderDetails OD in list)
            {
                if (OD.OrderNum == num && OD.ProductName == name && OD.Customer == cus && OD.sum == sum)
                {
                    od = OD;
                    list.Remove(OD);
                    Console.WriteLine("删除订单成功");
                    return true;
                }

            }
            if (od == null)
            {
                Console.WriteLine("没有该订单，删除失败");
                return false;
            }
            else
                return true;
        }
        public bool AmendOrder(String num1, String name1, String cus1, int sum1, String num2, String name2, String cus2, int sum2)   //修改订单
        {
            OrderDetails od = null;
            foreach (OrderDetails OD in list)
            {
                if (OD.OrderNum == num1 && OD.ProductName == name1 && OD.Customer == cus1 && OD.sum == sum1)
                {
                    OD.OrderNum = num2;
                    OD.ProductName = name2;
                    OD.Customer = cus2;
                    OD.sum = sum2;
                    od = OD;
                    Console.WriteLine("修改成功");
                    return true;
                }
            }
            if (od == null)
            {
                Console.WriteLine("未找到该订单，修改失败");
                return false;
            }
            else
                return true;
        }
        public void InquireByName(String name)                               //按商品名查找
        {
            var order = from o in list where o.ProductName == name select o;
            if (order == null)
            {
                Console.WriteLine("不存在该商品的订单");
            }
            else
            {
                foreach (OrderDetails o in order)
                {
                    Console.WriteLine(o.OrderNum + " " + o.ProductName + " " + o.Customer + " " + o.sum);
                }
            }
        }
        public void InquireByNum(String num)                                   //按订单号查找
        {
            var order = from o in list where o.OrderNum == num select o;
            if (order == null)
            {
                Console.WriteLine("不存在该订单号的订单");
            }
            else
            {
                foreach (OrderDetails o in order)
                {
                    Console.WriteLine(o.OrderNum + " " + o.ProductName + " " + o.Customer + " " + o.sum);
                }
            }
        }
        public void InquireByCustomer(String cus)                           //按客户查找
        {
            var order = from o in list where o.Customer == cus select o;
            if (order == null)
            {
                Console.WriteLine("不存在该商品名的订单");
            }
            else
            {
                foreach (OrderDetails o in order)
                {
                    Console.WriteLine(o.OrderNum + " " + o.ProductName + " " + o.Customer + " " + o.sum);
                }
            }
        }
        public void InquireBySum(int sum)                           //按金额超过一万查找
        {
            var order = from o in list where o.sum > 10000 select o;
            if (order == null)
            {
                Console.WriteLine("不存在金额超过一万的订单");
            }
            else
            {
                foreach (OrderDetails o in order)
                {
                    Console.WriteLine(o.OrderNum + " " + o.ProductName + " " + o.Customer + " " + o.sum);
                }
            }
        }
    }
}

