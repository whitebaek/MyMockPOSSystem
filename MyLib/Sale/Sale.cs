using MyLib.Item;
using MyLib.Panel;
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
        private int _nKey = -1;
        private List<IPanel> _lstPanels = null;

        public Sale(int nkey , List<IItem> lstItem)
        {
            _nKey = nkey;
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

        public int Key
        {
            get { return _nKey; }
        }


        public List<IItem> LstItem
        {
            get { return _lstItem; }
        }

        public void Notify(decimal dAmount)
        {
            if (_lstPanels != null)
            {
                foreach (var oPanel in _lstPanels)
                {
                    oPanel.Update(dAmount);
                }
            }
            
        }

        public List<IPanel> ListPanels
        {
            get { return _lstPanels; }
        }


        public void AttachPanel(IPanel oPanel)
        {
            if (_lstPanels == null)
            {
                _lstPanels = new List<IPanel>();
            }
            _lstPanels.Add(oPanel);
        }

        public void DetachPanel(IPanel oPanel)
        {
            if (_lstPanels != null)
            {
                _lstPanels.Remove(oPanel);
            }
        }

        public void AddItem(IItem item)
        {
            if (_lstItem == null)
            {
                _lstItem = new List<IItem>();
            }
            _lstItem.Add(item);
            Notify(item.Price); 
        }

        public void RemoveItem(IItem item)
        {
            if (_lstItem != null)
            {
                _lstItem.Remove(item);
                Notify(-item.Price); 
            }
            
        }
    }
}
