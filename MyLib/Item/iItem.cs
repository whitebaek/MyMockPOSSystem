﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Item
{
    public interface IItem
    {
        string Name { get; set; }
        decimal Price { get; set; }

    }
}
