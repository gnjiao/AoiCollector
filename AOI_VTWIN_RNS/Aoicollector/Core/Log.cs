﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using CollectorPackage.Src.Config;

namespace CollectorPackage.Aoicollector.Core
{
    public class Log
    {
        public static bool autoscroll = true;

        public static RichLog system { get; set; }

        public RichLog area { get; set; }

        public static void Stack(string msg, object objeto, Exception ex)
        {
            system.stack(msg,objeto,ex);
        }
    }
}
