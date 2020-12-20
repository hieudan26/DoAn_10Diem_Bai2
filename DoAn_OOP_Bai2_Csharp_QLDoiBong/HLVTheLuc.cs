using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class HLVTheLuc : CaNhan
    {
        private const double hesoluong = 1.3;
        private double dChieuCao;
        private double dCanNang;
        private string sNoiSinh;

        public double ChieuCao
        {
            get { return this.dChieuCao; }
            set { this.dChieuCao = value; }
        }

        public double CanNang
        {
            get { return this.dCanNang; }
            set { this.dCanNang = value; }
        }

        public string NoiSinh
        {
            get { return this.sNoiSinh; }
            set { this.sNoiSinh = value; }
        }

        public HLVTheLuc() : base() { }

        public HLVTheLuc(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, double chieucao, double cannang, string noisinh) : base(hoten, thoigianhopdong, luongcoban, cmnd , namsinh)
        {
            this.dChieuCao = chieucao;
            this.dCanNang = cannang;
            this.sNoiSinh = noisinh;
        }

        public HLVTheLuc(string hoten, double luongcoban, string cmnd, double chieucao, double cannang, string noisinh) : base(hoten, luongcoban, cmnd)
        {
            this.dChieuCao = chieucao;
            this.dCanNang = cannang;
            this.sNoiSinh = noisinh;
        }
        public override void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin HLV The Luc ~~ ");
            base.Nhap();

            Console.Write("Moi nhap Chieu Cao cua HLV The Luc: ");
            this.dChieuCao = double.Parse(Console.ReadLine());

            Console.Write("Moi nhap Can Nang cua HLV The Luc: ");
            this.dCanNang = double.Parse(Console.ReadLine());

            Console.Write("Moi nhap Quoc Gia cua HLV The Luc: ");
            this.sNoiSinh = Console.ReadLine();
        }

        public void Nhap(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, double chieucao, double cannang, string noisinh)
        {
            base.Nhap(hoten, thoigianhopdong, luongcoban, cmnd, namsinh);
            this.dChieuCao = chieucao;
            this.dCanNang = cannang;
            this.sNoiSinh = noisinh;
        }

        public void Nhap(string hoten, double luongcoban, string cmnd, double chieucao, double cannang, string noisinh)
        {
            base.Nhap(hoten, luongcoban, cmnd);
            this.dChieuCao = chieucao;
            this.dCanNang = cannang;
            this.sNoiSinh = noisinh;
        }

        public override double TinhLuong()
        {
            return this.dLuongCoBan * hesoluong - this.TinhThue(hesoluong);
        }


       
        public override void Xuat()
        {
            //Console.WriteLine("Tuoi cua HVL The Luc la: " + this.TinhTuoi());
            base.Xuat();
            Console.WriteLine("Chieu cao cua HLV The Luc la: " + this.dChieuCao + " cm");

            Console.WriteLine("Can Nang cua HLV The Luc la: " + this.dCanNang + " kg");

            Console.WriteLine("HLV the luc den tu: " + this.sNoiSinh);

            Console.WriteLine("Luong cua HLV The Luc la: " + this.TinhLuong() + " VND");

            if (this.TinhLuong() > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua HLV The Luc la: " + this.TinhThue(hesoluong) + " VND");
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }
        public void HuanLuyenTheLuc(CauThu A)
        {
            A.TinhTrangTheLuc++;
        }
    }
    
}
