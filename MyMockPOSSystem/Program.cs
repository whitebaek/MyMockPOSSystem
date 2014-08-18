using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.DBAccessLayer;
using MyLib;
using MyLib.Item;
using MyLib.Sale;
using MyLib.Panel;

namespace MyMockPOSSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependency Injection - 서버 커녁션 확인후 DB access layer 처리 
            MockPOS myMockPOS = new MockPOS(Utils.GetDAC());
            Console.WriteLine("----- Get DAC -----");
            Console.WriteLine(myMockPOS.CheckConnection());
            
            
            
            //Decorative Pattern : Combine ItemA and ItemB
            List<IItem> lstItems2 = new List<IItem>();
            lstItems2.Add(new ItemA());
            lstItems2.Add(new ItemB());

            List<IItem> lstItems = new List<IItem>();
            lstItems.Add(new ItemA());
            lstItems.Add(new ItemB());
            lstItems.Add(new CombinedItem(lstItems2));

            List<IItem> lstItems3 = new List<IItem>();
            lstItems3.Add(new ItemA());
            lstItems3.Add(new ItemB());
            lstItems3.Add(new CombinedItem(lstItems2));

            Console.WriteLine("----- Check Price -----");
            foreach (IItem item in lstItems)
            {
                Console.WriteLine("Name:{0} , Price:{1}", item.Name, item.Price);
            }

            //Observer Pattern 
            var oHallPanel = new HallPanel("Hall Panel");
            var oKitchenPanel = new KitchenPanel("Hall Panel");
            
            var sale1 = new Sale(1, lstItems);
            sale1.AttachPanel(oHallPanel);
            sale1.AttachPanel(oKitchenPanel);

            var sale2 = new Sale(2, lstItems3);
            sale2.AttachPanel(oHallPanel);
            sale2.AttachPanel(oKitchenPanel);
            
            Console.WriteLine("----- Add Sales -----");
            myMockPOS.AddSale(1, sale1);
            myMockPOS.AddSale(2, sale2);

            Console.WriteLine("----- update Sales 1 -----");
            myMockPOS.AddItemOnSale(1, new ItemA());
            myMockPOS.AddItemOnSale(1, new ItemA());
            Console.WriteLine("----- update Sales 2 -----");
            myMockPOS.AddItemOnSale(2, new ItemA());
            myMockPOS.AddItemOnSale(2, new ItemB());



            //대기 
            Console.ReadLine();
        }
    }

    class MockPOS
    {
        private IDAC myDAC;
        private SortedList<int, ISale> slSale;

        public MockPOS(IDAC oDAC)
        {
            this.myDAC = oDAC;
        }

        public string CheckConnection()
        {
            return myDAC.ToString();
        }

        public void AddSale(int key, ISale oSale)
        {
            if (slSale == null)
            {
                slSale = new SortedList<int, ISale>();
            }
            slSale.Add(key,oSale);
        }

        public void AddItemOnSale(int key, IItem oItem)
        {
            if (slSale != null && slSale.ContainsKey(key))
            {
                slSale[key].AddItem(oItem);
            }
        }

        public void RemoveItemOnSale(int key, IItem oItem)
        {
            if (slSale != null && slSale.ContainsKey(key))
            {
                slSale[key].RemoveItem(oItem);
            }
        }

        public void RemoveSale(int key)
        {
            if (slSale != null && slSale.ContainsKey(key))
            {
                slSale.Remove(key);
            }
        }
       
    }
}
