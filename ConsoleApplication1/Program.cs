using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process [] pro=Process.GetProcesses();
            //foreach(var item in pro)
            //{
            //    Console.WriteLine(item.ProcessName);

            //}
            Console.WriteLine("请输入要");
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\yangyi\Desktop\万马网段.txt");
           // Process.Start("calc");
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();
            Console.ReadKey();
        }
    }
    class BaseFile
    {
        //字段、属性、构造函数、函数、索引器
        //字段：存储数据
        //属性：保护字段 get set
        //构造函数：初始化对象
        private string _filePath;


        public String FileName { get; set; }

        public string FilePath
        {
            get
            {
                return _filePath;
            }

            set
            {
                _filePath = value;
            }
        }

        public BaseFile(string filePath, string fileName)
        {
            this._filePath = filePath;
            this.FileName = FileName;

        }
    }
}
