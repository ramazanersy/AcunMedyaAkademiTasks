﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOdev.IOdemeYontemi
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Kredi Kartı ile {tutar:C} ödendi.";
        }
    }
}
