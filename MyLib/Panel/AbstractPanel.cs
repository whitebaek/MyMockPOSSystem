using MyLib.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Panel
{
    public abstract class AbstractPanel : IPanel
    {
        protected string _sName = "Abstract Panel";
        protected decimal _dTotalAmount = 0m; 

        public AbstractPanel(string sName)
        {
            _sName = sName;
        }

        public AbstractPanel(string sName, decimal dTotalAmount)
        {
            _sName = sName;
            _dTotalAmount = dTotalAmount;
        }

        public void AddSale(decimal dAmount)
        {
            _dTotalAmount += dAmount;
        }

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

        public decimal CurrentTotalPrice
        {
            get { return GetCurrentTotalAmount(); }
        }

        public  abstract decimal GetCurrentTotalAmount(); 

        public abstract void Update(decimal dAmount); 

    }
}
