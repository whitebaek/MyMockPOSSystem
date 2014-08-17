using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.DBAccessLayer
{
    class LocalDAC : IDAC
    {
        public int Add(string statements)
        {
            int nKey = ExecuteSQL(statements);
            return nKey;
        }

        public int Update(string statements)
        {
            int nKey = ExecuteSQL(statements);
            return nKey;
        }

        public int Delete(string statements)
        {
            int nKey = ExecuteSQL(statements);

            return nKey;
        }

        public IQueryable Select(string statements)
        {
            IQueryable lstData = RetriveData(statements);
            return lstData;
        }

        private IQueryable RetriveData(string statements)
        {
            //Excute statement
            return null;
        }

        private int ExecuteSQL(string statements)
        {
            //Excute statement
            return -1;
        }
    }
}
