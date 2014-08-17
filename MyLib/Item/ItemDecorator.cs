using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Item
{
    public abstract class ItemDecorator : IItem
    {
        public List<IItem> _lstItem;

        //public ItemDecorator()
        //{
        //    _lstItem = null;
        //}

        public ItemDecorator(List<IItem> lstItem)
        {
            _lstItem = lstItem;
        }

        public abstract string GetName();
        public abstract decimal GetPrice(); 

        public string Name
        {
            get { return GetName(); }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal Price
        {
            get { return GetPrice(); }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
