using MyLib.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Panel
{
    public class KitchenPanel : AbstractPanel
    {
        public KitchenPanel(string sName) : base(sName) { }

        public KitchenPanel(string sName, decimal dToitalAmount) : base(sName, dToitalAmount) { }

        public override decimal GetCurrentTotalAmount()
        {
            return _dTotalAmount;
        }

        public override void Update(decimal dAmount)
        {
            _dTotalAmount += dAmount;

            //Console.WriteLine("Changes on sales");
            Console.WriteLine("Kitchen - TotalPrice:{0}", CurrentTotalPrice);
        }
    }
}
