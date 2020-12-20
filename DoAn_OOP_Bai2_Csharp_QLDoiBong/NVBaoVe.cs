﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    public class NVBaoVe : CaNhan
    {
        private const double hesoluong = 1.0;
        private int iThoiGianLamTrongNgay;
        private string sMauDongPhuc;

        public int ThoiGianLamTrongNgay
        {
            get { return this.iThoiGianLamTrongNgay; }
            set { this.iThoiGianLamTrongNgay = value; }
        }

        public string MauDongPhuc
        {
            get { return this.sMauDongPhuc; }
            set { this.sMauDongPhuc = value; }
        }

        public NVBaoVe() : base() { }

        public NVBaoVe(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int time, string color) : base(hoten, thoigianhopdong
            , luongcoban, cmnd, namsinh)
        {
            this.iThoiGianLamTrongNgay = time;
            this.sMauDongPhuc = color;
        }

        public NVBaoVe(string hoten, double luongcoban, string cmnd, int time) : base(hoten, luongcoban, cmnd) 
        {
            this.iThoiGianLamTrongNgay = time;
        }

        public override void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin Nhan Vien Bao Ve ~~ ");
            base.Nhap();

            Console.Write("Moi nhap Thoi Gian Lam Viec/Ngay cua Nhan Vien Bao Ve: ");
            this.iThoiGianLamTrongNgay = int.Parse(Console.ReadLine());

            Console.Write("Moi nhap Mau Dong Phuc hom nay cu Nhan Vien Bao Ve: ");
            this.sMauDongPhuc = Console.ReadLine();
        }

        public void Nhap(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int time, string color)
        {
            base.Nhap(hoten, thoigianhopdong
            , luongcoban, cmnd, namsinh);
            this.iThoiGianLamTrongNgay = time;
            this.sMauDongPhuc = color;
        }

        public void Nhap(string hoten, double luongcoban, string cmnd, int time)
        {
            base.Nhap(hoten, luongcoban, cmnd);
            this.iThoiGianLamTrongNgay = time;
        }

        public override double TinhLuong()
        {
            return base.dLuongCoBan;
        }
        //NVBaoVe luong < 11tr => ko phai doi tuong nop thue
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Tong thoi gian lam tren mot ngay la: " + this.iThoiGianLamTrongNgay);
            Console.WriteLine("Mau Dong Phuc NV Bao Ve: " + this.sMauDongPhuc);
        }
    }
}
