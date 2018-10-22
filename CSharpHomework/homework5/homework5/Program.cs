using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            os.AddOrder(1, "LeoZB", "Leona",1000);
            os.AddOrder(2, "JohnnyZB", "wotslb",2000);
            os.RemoveOrder(2, "JohnnyZB", "wotslb",2000);
            os.AmendOrder(1, "LeoZB", "Leona",1000, 2, "JohnnyZB", "wotslb",2000);
            os.InquireByCustomer("wotslb");
            os.InquireByNum(1);
            os.InquireByName("JohnnyZB");
        }
    }
}
