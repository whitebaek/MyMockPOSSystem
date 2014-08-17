using MyLib.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Panel
{
    class HallPanel : IPanel
    {
        private string _sName = "Hall Panel";
        private List<ISale> _lstSale = null;

        public HallPanel(string sName, List<ISale> lstSale)
        {
            _sName = sName;
            _lstSale = lstSale;
        }

        public void AddSale(ISale oSale)
        {
            if (_lstSale == null)
            {
                _lstSale = new List<ISale>();
            }
            
            _lstSale.Add(oSale);
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

        public decimal CurrentPrice
        {
            get { throw new NotImplementedException(); }
        }
    }
}
