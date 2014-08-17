using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.DBAccessLayer;
using MyLib;
using MyLib.Item;

namespace MyMockPOSSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependency Injection - 서버 커녁션 확인후 DB access layer 처리 
            MockPOS myMockPOS = new MockPOS(Utils.GetDAC());
            Console.WriteLine(myMockPOS.CheckConnection());
            
            //Decorative Pattern : Combine ItemA and ItemB
            List<IItem> lstItems = new List<IItem>();
            List<IItem> lstItems2 = new List<IItem>();
            lstItems2.Add(new ItemA());
            lstItems2.Add(new ItemB());

            lstItems.Add(new ItemA());
            lstItems.Add(new ItemB());
            lstItems.Add(new CombinedItem(lstItems2));

            foreach (IItem item in lstItems)
            {
                Console.WriteLine(string.Format("Name:{0} , Price:{1}", item.Name, item.Price));
            }

            //Observer Pattern 

            
            //대기 
            Console.ReadLine();
        }
    }

    class MockPOS
    {
        private IDAC myDAC;
        public MockPOS(IDAC oDAC)
        {
            this.myDAC = oDAC;
        }

        public string CheckConnection()
        {
            return myDAC.ToString();
        }

    }

    interface IPanel
    {

    }
}
