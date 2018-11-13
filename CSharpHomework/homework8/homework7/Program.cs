using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            os.AddOrder("20181111001", "LeoZB", "Leona", 1000, "13986262878");
            os.AddOrder("20181010003", "JohnnyZB", "wotslb", 2000, "18765438899");

            //xml序列化
            XmlSerializer xmlser = new XmlSerializer(typeof(List<OrderDetails>));
            String xmlFileName = "s.xml";
            XmlSerialize(xmlser, xmlFileName, os.list);

            //Xml反序列化
            List<OrderDetails> list = XmlDeserialize(xmlser, xmlFileName) as List<OrderDetails>;
            foreach (OrderDetails od in list)
                Console.WriteLine(od);

            os.RemoveOrder("20181010003", "JohnnyZB", "wotslb", 2000);
            os.AmendOrder("20181111001", "LeoZB", "Leona", 1000, "20181010003", "JohnnyZB", "wotslb", 2000);
            os.InquireByCustomer("wotslb");
            os.InquireByNum("20181111001");
            os.InquireByName("JohnnyZB");
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\OrderList.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"..\..\OrderList.xslt");

                FileStream outFileStream = File.OpenWrite(@"..\..\OrderList.html");
                XmlTextWriter writer =
                    new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);


            }
            catch (XmlException e)
            {
                Console.WriteLine("XML Exception:" + e.ToString());
            }
            catch (XsltException e)
            {
                Console.WriteLine("XSLT Exception:" + e.ToString());
            }
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
