﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3A1
{
    internal class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS Yollandı...");
        }
    }
}
