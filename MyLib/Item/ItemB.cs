using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Item
{
    public class ItemB : IItem
    {
        private string _sName = "ItemB";
        private decimal _dPrice = 15.00m; 

        public string Name
        {
            get
            {
                return _sName;
            }
            set
            {
                _sName = Name;
            }
        }

        public decimal Price
        {
            get
            {
                return _dPrice;
            }
            set
            {
                _dPrice = Price;
            }
        }

        public ItemB() 
        {
        }

        public ItemB(string sName)
        {
            _sName = sName;
        }

        public ItemB(string sName, decimal dPrice)
        {
            _sName = sName;
            _dPrice = dPrice;
        }
    }
}
