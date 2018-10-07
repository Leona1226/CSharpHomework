using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    public class EventArgs                                                   //定义参数类型
    {
    }
    public delegate void EventHandler(object sender, EventArgs e);           //定义委托
    public class Clock
    {
        public event EventHandler Clocking;                                  //定义事件
        private int myHour, myMinute;
        EventArgs e = new EventArgs();
        public Clock(int hour,int minute)
        {
            myHour = hour;
            myMinute = minute;
        }
        public void ClockNow()
        {
            int h, m;
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            while(h!= myHour||m!= myMinute)
            {
                h = DateTime.Now.Hour;
                m = DateTime.Now.Minute;
            }
            Clocking(this, e);                                     //生成并调用事件
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //设置时间时分
            Clock ClockTime = new Clock(0,26);
            ClockTime.Clocking += TimeIsUp;                           //注册事件
            ClockTime.ClockNow();
            
        }
        static void TimeIsUp(object sender, EventArgs e)              //事件处理方法
        {
            Console.WriteLine("时间到了");
        }
    }
}
