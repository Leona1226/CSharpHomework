using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails()
        { }
        public String OrderNum { set; get; }
        public String ProductName { set; get; }
        public String Customer { set; get; }
        public int sum { set; get; }
        public String PhoneNum { set; get; }
        public OrderDetails(String num, String name, String cus, int sum,String PNum)
        {
            OrderNum = num;
            ProductName = name;
            Customer = cus;
            PhoneNum = PNum;
            this.sum = sum;
        }
        public override string ToString()
        {
            return OrderNum + " " + ProductName + " " + Customer + " " + sum + " " + PhoneNum;
        }
    }
}
