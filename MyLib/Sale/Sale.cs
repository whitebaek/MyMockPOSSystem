using MyLib.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Sale
{
    public class Sale : ISale
    {
        private List<IItem> _lstItem = null;

        public Sale(List<IItem> lstItem)
        {
            _lstItem = lstItem;
        }

        public decimal TotalPrice
        {
            get 
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
}
