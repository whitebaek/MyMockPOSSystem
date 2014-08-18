using MyLib.Item;
using MyLib.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Panel
{
    public interface IPanel
    {
        string Name { get; set; }
        decimal CurrentTotalPrice { get; }
        void Update(decimal dAmount);

    }
}
