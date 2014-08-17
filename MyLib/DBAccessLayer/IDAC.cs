using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.DBAccessLayer
{
    public interface IDAC
    {
        int Add(string statements);
        int Update(string statements);
        int Delete(string statements);
        IQueryable Select(string statements);
    }
}
