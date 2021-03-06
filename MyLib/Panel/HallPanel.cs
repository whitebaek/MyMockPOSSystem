﻿using MyLib.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Panel
{
    public class HallPanel : AbstractPanel
    {

        public HallPanel(string sName) : base(sName) { }
        public HallPanel(string sName, decimal dToitalAmount) : base(sName, dToitalAmount) { }

        public override decimal GetCurrentTotalAmount()
        {
            return _dTotalAmount;
        }

        public override void Update(decimal dAmount)
        {
            _dTotalAmount += dAmount;
            //Console.WriteLine("Changes on sales");
            Console.WriteLine("Hall - TotalPrice:{0}", CurrentTotalPrice);
        }
    }
}
