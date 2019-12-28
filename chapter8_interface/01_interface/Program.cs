﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_interface
{

    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger //콘솔로거
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0}{1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger //파일로거
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0}{1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class ClimateMoniter
    {
        private ILogger logger;

        public ClimateMoniter(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while(true)
            {
                Console.Write("온도를 입력해주세요. : ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재온도 : " + temperature);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClimateMoniter moniter = new ClimateMoniter(new FileLogger("MyLog.txt"));
            moniter.Start();
        }
    }
}