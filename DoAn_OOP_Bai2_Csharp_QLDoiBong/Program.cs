using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CauThu> list= new List<CauThu>();
            Random a = new Random();
            for (int i=0;i<10;i++)
            {
                
                var x = a.Next(101);
                Console.WriteLine("=============================: "+x);
                CauThu temp = new CauThu(x.ToString(), x, x, x.ToString(), x, x, x, x, x.ToString(), x.ToString(), x.ToString());
                list.Add(temp);
            }
            QuanLyCauThu temp2 = new QuanLyCauThu(list);
            temp2.Sort();
            temp2.xuat();
            
            
        }
    }
}
