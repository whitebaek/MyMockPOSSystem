using MyLib.Item;
using MyLib.Panel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Sale
{
    public interface ISale
    {
        int Key { get; }
        decimal TotalPrice { get; }
        List<IItem> LstItem { get; }
        
        //List for Notification 
        List<IPanel> ListPanels { get;}
        void AttachPanel(IPanel oPanel);
        void DetachPanel(IPanel oPanel);
        
        void AddItem(IItem item);
        void RemoveItem(IItem item);

        void Notify(decimal dAmount );
    }
}
