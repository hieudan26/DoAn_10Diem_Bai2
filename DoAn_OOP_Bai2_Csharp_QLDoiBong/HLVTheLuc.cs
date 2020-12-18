using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class HLVTheLuc : CaNhan
    {
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
            return this.dLuongCoBan + this.dLuongCoBan * 0.2;
        }


        public double GiamTru()
        {
            double GiamTruGiaCanhBanThan = 11000000;
            //8% BHXH, 1.5% BHYT, 1% BHTN
            double BaoHiem = this.TinhLuong() * (0.08 + 0.015 + 0.01);
            double GiamTru = GiamTruGiaCanhBanThan + BaoHiem;
            return GiamTru;
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
            //Console.WriteLine("Tuoi cua HVL The Luc la: " + this.TinhTuoi());
            base.Xuat();
            Console.WriteLine("Chieu cao cua HLV The Luc la: " + this.dChieuCao + " cm");

            Console.WriteLine("Can Nang cua HLV The Luc la: " + this.dCanNang + " kg");

            Console.WriteLine("HLV the luc den tu: " + this.sNoiSinh);

            Console.WriteLine("Luong cua HLV The Luc la: " + this.TinhLuong() + " VND");

            if (this.TinhLuong() > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua HLV The Luc la: " + this.TinhThue() + " VND");
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }
        public void HuanLuyenTheLuc(CauThu A)
        {
            A.TinhTrangTheLuc++;
        }
    }
    
}
