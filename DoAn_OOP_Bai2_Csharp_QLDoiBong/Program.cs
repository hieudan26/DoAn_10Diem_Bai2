﻿using System;
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
            /*
            List<CauThu> list= new List<CauThu>();
            List<CauThu> list2;
            Random a = new Random();
            Random b = new Random();
            Random c = new Random();
            Random d = new Random();
            for (int i=0;i<10;i++)
            {
                
                var x = a.Next(100);
                string t;
                if (x % 2 == 0)
                    t = "trai";
                else
                    t = "phai";
                Console.WriteLine("=============================: "+x);
                CauThu temp = new CauThu(x.ToString(), new DateTime(a.Next(1, 2020), a.Next(1, 12), a.Next(1,28)) ,a.Next(10), a.Next(10000000,100000000), a.Next(10000000).ToString(), a.Next(2020), a.Next(100), a.Next(100), a.Next(100), t, x.ToString());
                list.Add(temp);
            }
            QuanLyCauThu temp2 = new QuanLyCauThu(list);
            temp2.Sort();
            temp2.xuat();

            list2=temp2.Loc();
            QuanLyCauThu temp3 = new QuanLyCauThu(list2);
            temp3.xuat();
            CauThu temp4 = temp2.Search();
            if (temp4 != null)
            {
                temp4.Xuat();
            }
            temp2.XemtinhTrangtheLuc();
            temp2.XemtinhTrangSucKhoe();
            temp2.CauThuCoTheLucTotNhat().Xuat();
            temp2.CauThuCoTheSucKhoeYeuNhat().Xuat();
            Console.WriteLine("Tong luong toan cau tu: " + temp2.TongLuongToanCauThu());
            DoiBong temp5 = new DoiBong();
            temp5.Nhap();
            Console.WriteLine("Tong luong doi bong: " + temp5.TongLuongDoiBong());*/

            DoiBong DB = new DoiBong();
            DB.Nhap();
            DB.Xuat();
            Console.WriteLine("Tong luong doi bong: " + DB.TongLuongDoiBong());
            DB.listCauThu.Sort();
            DB.listCauThu.Xuat();
            DB.listCauThu.Loc();
            DB.listCauThu.Xuat();
        }
    }
}
