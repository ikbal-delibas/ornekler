﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
