﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    public class NVVeSinh : CaNhan
    {
        private int iShift;
        private double dThuong;

        public int ThoiGianLamTrongNgay
        {
            get { return this.iShift; }
            set { this.iShift = value; }
        }

        public double Thuong
        {
            get { return this.dThuong; }
            set { this.dThuong = value; }
        }

        public NVVeSinh() : base() { }

        public NVVeSinh(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int ca, double thuong) : base(hoten, thoigianhopdong
            , luongcoban, cmnd, namsinh)
        {
            this.iShift = ca;
            this.dThuong = thuong;
        }

        public NVVeSinh(string hoten, double luongcoban, string cmnd, int time) : base(hoten, luongcoban, cmnd)
        {
            this.iShift = time;
        }

        public override void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin Nhan Vien Ve Sinh ~~ ");
            base.Nhap();

            Console.Write("Moi nhap Ca lam viec cua Nhan Vien Ve Sinh: ");
            this.iShift = int.Parse(Console.ReadLine());

            Console.Write("Moi nhap Luong thuong cua Nhan Vien Ve Sinh: ");
            this.dThuong = double.Parse(Console.ReadLine());
        }

        public void Nhap(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int time, double thuong)
        {
            base.Nhap(hoten, thoigianhopdong
            , luongcoban, cmnd, namsinh);
            this.iShift = time;
            this.dThuong = thuong;
        }

        public void Nhap(string hoten, double luongcoban, string cmnd, int time)
        {
            base.Nhap(hoten, luongcoban, cmnd);
            this.iShift = time;
        }

        public override double TinhLuong()
        {
            return base.dLuongCoBan + this.dThuong;
        }
        //NVVeSinh luong < 11tr => ko phai doi tuong nop thue
        public override double TinhThue()
        {
            throw new NotImplementedException();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ca lam cua Nhan Vien Ve Sinh la: " + this.iShift);
            Console.WriteLine("Luong thuong them cua Nhan Vien Ve Sinh la: " + this.dThuong + " VND");
        }
    }
}
