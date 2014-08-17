using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Item
{
    public class CombinedItem : ItemDecorator
    {
        public CombinedItem(List<IItem> lstItems) : base(lstItems) { }

        public override string GetName()
        {
            if (_lstItem == null)
            {
                return "Null";
            }
            var sbName = new StringBuilder();
            bool isFirst = true;
            foreach (IItem item in _lstItem)
            {
                if (isFirst == false) sbName.Append("|");
                sbName.Append(item.Name);
                if (isFirst == true) isFirst = false;
            }

            return sbName.ToString();
        }

        public override decimal GetPrice()
        {
            if (_lstItem == null)
            {
                return 0m;
            }

            var dPrice = 0m;
            foreach (IItem item in _lstItem)
            {
                dPrice += item.Price;
            }

            return dPrice;
        }


    }
}
