using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class OrderDetails
    {
        public int OrderNum { set; get; }
        public String ProductName { set; get; }
        public String Customer { set; get; }
        public int sum  {set ; get; }
        public OrderDetails(int num, String name, String cus,int sum)
        {
            OrderNum = num;
            ProductName = name;
            Customer = cus;
            this.sum = sum;
        }
    }
}
