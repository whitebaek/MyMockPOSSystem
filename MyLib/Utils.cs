using MyLib.DBAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    //Singleton
    public class Utils
    {
        private Utils()
        {

        }

        public static IDAC GetDAC()
        {
            if (true == CheckConnection())
            {
                return new RemoteDAC();
            }
            else
            {
                return new LocalDAC();
            }
        }

        private static bool CheckConnection()
        {
            //Check DB connection 
            if(true)
            {
                return true;
            }

            return false;
        }

    }
}
