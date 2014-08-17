using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Item
{
    public class ItemA : IItem
    {
        private string _sName = "ItemA";
        private decimal _dPrice = 10.00m; 

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

        public ItemA() 
        {
        }

        public ItemA(string sName)
        {
            _sName = sName;
        }

        public ItemA(string sName, decimal dPrice)
        {
            _sName = sName;
            _dPrice = dPrice;
        }
    }
}
