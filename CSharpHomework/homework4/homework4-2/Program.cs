using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            os.AddOrder(1, "LeoZB", "Leona");
            os.AddOrder(2, "JohnnyZB", "wotslb");
            os.RemoveOrder(2, "JohnnyZB", "wotslb");
            os.AmendOrder(1, "LeoZB", "Leona", 2, "JohnnyZB", "wotslb");
            os.InquireByCustomer("wotslb");
            os.InquireByNum(1);
            os.InquireByName("JohnnyZB");
        }
    }
}
