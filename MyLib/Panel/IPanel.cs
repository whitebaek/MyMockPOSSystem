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
        decimal CurrentPrice { get; }

    }
}
