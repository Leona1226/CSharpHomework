using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace homework7
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails()
        { }
        [Key]
        public string OrderNum { set; get; }
        public String ProductName { set; get; }
        public String Customer { set; get; }
        public int sum { set; get; }
        public OrderDetails(string num, String name, String cus, int sum)
        {
            OrderNum = num;
            ProductName = name;
            Customer = cus;
            this.sum = sum;
        }
        public override string ToString()
        {
            return OrderNum + " " + ProductName + " " + Customer + " " + sum;
        }
    }
}
