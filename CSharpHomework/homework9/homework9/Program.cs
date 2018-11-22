using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace homework9
{
    public class Program
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            string startUrl = "http://www.baidu.com/";
            if (args.Length >= 1) startUrl = args[0];
            myProgram.urls.Add(startUrl, false);     //加入初始页面
            Task[] tasks = { Task.Run(() =>myProgram.Crawl()), };
            new Thread(myProgram.Crawl).Start();     //开始爬行
        }
        private void Crawl()
        {
            Console.WriteLine("开始爬行了...");
            while(true)
            {
                string current = null;
                foreach(string url in urls.Keys)          //找到一个还没下载过的链接
                {
                    if ((bool)urls[url]) continue;        //已经下载过的不再下载
                    current = url;
                }
                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面！");
                string html = DownLoad(current);
                urls[current] = true;
                count++;
                Prase(html);
            }
            Console.WriteLine("爬行结束");
        }
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        public void Prase(string html)
        {

            string strRef = @"(href|HERF)[]* = []*[""'][^""'#>] + [""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=')+1).Trim('"','\"','#',' ','>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
