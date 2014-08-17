using MyLib.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Sale
{
    public interface ISale
    {
        decimal TotalPrice { get; }
    }
}
