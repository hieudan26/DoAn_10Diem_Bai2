using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    public abstract class CaNhan
    {
        public string sHoTen;
        public DateTime dNgayGiaNhap;
        public int iThoiGianHopDong;
        public double dLuongCoBan;
        public string sCMND;
        public int iNamSinh;

        public abstract double TinhThue();

        public abstract double TinhLuong();
        public CaNhan() { }

        public CaNhan(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh)
        {
            this.sHoTen = hoten;
            this.iThoiGianHopDong = thoigianhopdong;
            this.dLuongCoBan = luongcoban;
            this.sCMND = cmnd;
            this.iNamSinh = namsinh;
        }

        public CaNhan(string hoten, double luongcoban, string cmnd)
        {
            this.sHoTen = hoten;
            this.dLuongCoBan = luongcoban;
            this.sCMND = cmnd;
        }

        public virtual void Nhap()
        {
            Console.Write("Moi nhap Ho Ten thanh vien: ");
            this.sHoTen = Console.ReadLine();

            Console.Write("Moi nhap Thoi Gian Hop Dong con lai: ");
            this.iThoiGianHopDong = int.Parse(Console.ReadLine());

            Console.Write("Moi nhap Luong Co Ban cua thanh vien: ");
            this.dLuongCoBan = double.Parse(Console.ReadLine());

            Console.Write("Moi nhap so CMND cua thanh vien: ");
            this.sCMND = Console.ReadLine();

            Console.Write("Moi nhap Nam Sinh cua thanh vien: ");
            this.iNamSinh = int.Parse(Console.ReadLine());
        }

        public void Nhap(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh)
        {
            this.sHoTen = hoten;
            this.iThoiGianHopDong = thoigianhopdong;
            this.dLuongCoBan = luongcoban;
            this.sCMND = cmnd;
            this.iNamSinh = namsinh;
        }

        public void Nhap(string hoten, double luongcoban, string cmnd)
        {
            this.sHoTen = hoten;
            this.dLuongCoBan = luongcoban;
            this.sCMND = cmnd;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ho Ten thanh vien la: " + this.sHoTen);
            Console.WriteLine("Thoi gian het han Hop Dong cua thanh vien la: " + this.iThoiGianHopDong);
            Console.WriteLine("Luong co ban cua thanh vien la: " + this.dLuongCoBan + " VND");
            Console.WriteLine("So CMND cua thanh vien la: " + this.sCMND);
            Console.WriteLine("Nam sinh cua thanh vien la: " + this.iNamSinh);
            Console.WriteLine("Tuoi cua thanh vien la: " + this.TinhTuoi());
        }

        public int TinhTuoi()
        {
            return 2020 - this.iNamSinh;
        }
        public int ThoiGianHopDongConLai()
        {
            DateTime temp = new DateTime(this.iThoiGianHopDong+this.dNgayGiaNhap.Year, this.dNgayGiaNhap.Month, this.dNgayGiaNhap.Day);
            DateTime now = DateTime.Now;
            TimeSpan res = temp - now;
            Console.WriteLine(res.TotalDays);
            return (int)res.TotalDays;
        }
    }
}
