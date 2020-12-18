using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    //hello ban thang minh la dan
    class BacSi : CaNhan
    {
        private string sRank;
        private string sTruongDaoTao;

        public string Rank
        {
            get { return this.sRank; }
            set { this.sRank = value; }
        }

        public string TruongDaoTao
        {
            get { return this.sTruongDaoTao; }
            set { this.sTruongDaoTao = value; }
        }

        public BacSi() : base() { }

        public BacSi(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string rank, string tentruong) : base(hoten, thoigianhopdong, luongcoban, cmnd, namsinh) 
        {
            this.sRank = rank;
            this.sTruongDaoTao = tentruong;
        }

        public BacSi(string hoten, double luongcoban, string cmnd, string tentruong) : base(hoten, luongcoban, cmnd) 
        {
            this.sTruongDaoTao = tentruong;
        }

        enum Bac
        {
            Bac1 = 1,
            Bac2,
            Bac3,
            Bac4,
            Bac5,
            Bac6,
            Bac7
        }

        public override void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin Bac Si ~~ ");
            base.Nhap();

            Console.Write("Moi nhap loai bang cua Bac Si: ");
            this.sRank = Console.ReadLine();

            Console.Write("Moi nhap truong dao tao Bac Si: ");
            this.sTruongDaoTao = Console.ReadLine();
        }

        public void Nhap(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string rank, string tentruong)
        {
            base.Nhap(hoten, thoigianhopdong, luongcoban, cmnd, namsinh);
            this.sRank = rank;
            this.sTruongDaoTao = tentruong;
        }

        public void Nhap(string hoten, double luongcoban, string cmnd, string tentruong)
        {
            base.Nhap(hoten, luongcoban, cmnd);
            this.sTruongDaoTao = tentruong;
        }

        public override double TinhLuong()
        {
            double luong = this.dLuongCoBan + this.dLuongCoBan * 0.15;
            return luong;
        }

        public double GiamTru()
        {
            double GiamTruGiaCanhBanThan = 11000000;
            //8% BHXH, 1.5% BHYT, 1% BHTN
            double BaoHiem = this.TinhLuong() * (0.08 + 0.015 + 0.01);
            double GiamTru = GiamTruGiaCanhBanThan + BaoHiem;
            return GiamTru;
        }

        public void Kham(ref CauThu a)
        {
            Console.Write("Moi nhap Tinh Trang Cau Thu: ");
            a.TinhTrangTheLuc = int.Parse(Console.ReadLine());
            if (a.TinhTrangTheLuc < 50)
                Console.WriteLine("Cau thu bi chan thuong !!");
            else
                Console.WriteLine("Cau thu dang o tinh trang the luc tot !!");
        }
        public void ChuaBenh(ref CauThu a)
        {
            a.TinhTrangTheLuc = 100;
            Console.WriteLine("Cau thu dang o tinh trang the luc tot nhat !!");
        }
        public int XacDinhBacThue()
        {
            double ThuNhapTinhThue = this.TinhLuong() - this.GiamTru();
            if (ThuNhapTinhThue <= 5000000)
                return (int)Bac.Bac1;
            else

            {
                if (ThuNhapTinhThue <= 10000000)
                {
                    return (int)Bac.Bac2;
                }
                else
                {
                    if (ThuNhapTinhThue <= 18000000)
                    {
                        return (int)Bac.Bac3;
                    }
                    else
                    {
                        if (ThuNhapTinhThue <= 32000000)
                        {
                            return (int)Bac.Bac4;
                        }
                        else
                        {
                            if (ThuNhapTinhThue <= 52000000)
                            {
                                return (int)Bac.Bac5;
                            }
                            else
                            {
                                if (ThuNhapTinhThue <= 80000000)
                                {
                                    return (int)Bac.Bac6;
                                }
                                else
                                    return (int)Bac.Bac7;
                            }
                        }
                    }
                }
            }
        }

        public override double TinhThue()
        {
            double ThuNhapTinhThue = this.TinhLuong() - this.GiamTru();
            int Bac = XacDinhBacThue();
            double SoThuePhaiNop = 0;
            switch (Bac)
            {
                case 1:
                    {
                        SoThuePhaiNop = ThuNhapTinhThue * 0.05;
                        break;
                    }
                case 2:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.1) - 250000;
                        break;
                    }
                case 3:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.15) - 750000;
                        break;
                    }
                case 4:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.2) - 1650000;
                        break;
                    }
                case 5:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.25) - 3250000;
                        break;
                    }
                case 6:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.3) - 5850000;
                        break;
                    }
                default:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.35) - 9850000;
                        break;
                    }
            }
            return SoThuePhaiNop;
        }

        public override void Xuat()
        {
            base.Xuat();
            //Console.WriteLine("Tuoi cua Bac Si la: " + this.TinhTuoi());
            Console.WriteLine("Bang cua Bac Si hang: " + this.sRank);
            Console.WriteLine("Truong dao tao cua Bac Si la: " + this.sTruongDaoTao);
            Console.WriteLine("Luong cua Bac Si la: " + this.TinhLuong() + " VND");
            if (this.TinhLuong() > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua Cau Thu la: " + this.TinhThue() + " VND");
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }
    }
}
