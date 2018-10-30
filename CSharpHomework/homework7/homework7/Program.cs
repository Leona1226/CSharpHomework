using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            os.AddOrder(1, "LeoZB", "Leona", 1000);
            os.AddOrder(2, "JohnnyZB", "wotslb", 2000);

            //xml序列化
            XmlSerializer xmlser = new XmlSerializer(typeof(List<OrderDetails>));
            String xmlFileName = "s.xml";
            XmlSerialize(xmlser, xmlFileName, os.list);

            //Xml反序列化
            List<OrderDetails> list = XmlDeserialize(xmlser, xmlFileName) as List<OrderDetails>;
            foreach (OrderDetails od in list)
                Console.WriteLine(od);

            os.RemoveOrder(2, "JohnnyZB", "wotslb", 2000);
            os.AmendOrder(1, "LeoZB", "Leona", 1000, 2, "JohnnyZB", "wotslb", 2000);
            os.InquireByCustomer("wotslb");
            os.InquireByNum(1);
            os.InquireByName("JohnnyZB");
        }
        public static void XmlSerialize(XmlSerializer ser, String fileName, object obj)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
        public static object XmlDeserialize(XmlSerializer ser, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            object obj = ser.Deserialize(fs);
            fs.Close();
            return obj;
        }
    }
}
