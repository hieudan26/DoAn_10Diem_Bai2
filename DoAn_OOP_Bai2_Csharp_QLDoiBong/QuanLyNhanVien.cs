using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class QuanLyNhanVien
    {
        private List<CaNhan> lcaNhans;
        private List<BacSi> lbacsi;
        private List<HLVChienThuat> lHLVCT;
        private List<HLVTheLuc> lHLVTL;
        public List<CaNhan> LcaNhans { get => this.lcaNhans; set => this.lcaNhans = value; }

        public double TinhLuongToanBoNV()
        {
            double temp = 0;
            foreach (var item in lbacsi)
                temp = item + temp;
            foreach (var item in lHLVCT)
                temp = item + temp;
            foreach (var item in lHLVTL)
                temp = item + temp;
            return temp;
        }
        public void SapxepTheoLuong()
        {
            this.lcaNhans.Sort((x, y) => x.dLuongCoBan.CompareTo(y.dLuongCoBan));
        }
        public void XuatDsBacSi()
        {
            foreach (var item in lbacsi)
                Console.WriteLine("Ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
        }
        public void XuatDsHLVTL()
        {
            foreach (var item in lHLVTL)
                Console.WriteLine("Ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
        }
        public void XuatDsHLVCT()
        {
            foreach (var item in lHLVCT)
                Console.WriteLine("Ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
        }
        public void XuatDsNhanVien()
        {
            foreach (var item in lcaNhans)
                Console.WriteLine("Ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
        }
        public CaNhan TimkiemNVtheoTen()
        { 
            Console.Write("Nhap ten NV tim kiem : ");
            string key = Console.ReadLine();
            CaNhan temp = this.lcaNhans.Find(x => x.sHoTen == key);
            return temp;
        }
        public List<CaNhan> LocTheoLuongLon()
        {
            Console.Write("Nhap Luong (x) de co danh sach cau thu luong > x: ");

            int x = int.Parse(Console.ReadLine());
            List<CaNhan> temp= new List<CaNhan>();
            foreach (var item in lcaNhans)
                if (item.dLuongCoBan < x)
                    temp.Add(item);
            return temp;
        }
        public List<CaNhan> LocTheoLuongBe()
        {
            Console.Write("Nhap Luong (x) de co danh sach cau thu luong < x: ");

            int x = int.Parse(Console.ReadLine());
            List<CaNhan> temp = new List<CaNhan>();
            foreach (var item in lcaNhans)
                if(item.dLuongCoBan < x)
                    temp.Add(item);
            return temp;
        }
        public void XemcaNhan()
        {
            this.XuatDsNhanVien();
            Console.Write("Ban Muon Xem Nhan Vien thu may: !");
            int x = int.Parse(Console.ReadLine());
            if(this.lcaNhans[x].sNghe == "bacsi")
            {
                BacSi temp = lbacsi.Find(a => a.sHoTen == this.lcaNhans[x].sHoTen);
                temp.Xuat();
            }
            else if (this.lcaNhans[x].sNghe == "HLVTL")
            {
                HLVTheLuc temp = lHLVTL.Find(a => a.sHoTen == this.lcaNhans[x].sHoTen);
                temp.Xuat();
            }
            else if(this.lcaNhans[x].sNghe == "HLVCT")
            {
                HLVChienThuat temp = lHLVCT.Find(a => a.sHoTen == this.lcaNhans[x].sHoTen);
                temp.Xuat();
            }
        }
    }
}
