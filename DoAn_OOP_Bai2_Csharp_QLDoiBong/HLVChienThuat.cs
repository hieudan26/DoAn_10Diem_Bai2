using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class HLVChienThuat : CaNhan
    {
        private string sRank;
        private string sQuocGia;
        private int iKinhNghiem;

        public string Rank
        {
            get { return this.sRank; }
            set { this.sRank = value; }
        }

        public string QuocGia
        {
            get { return this.sQuocGia; }
            set { this.sQuocGia = value; }
        }

        public int KinhNghiem
        {
            get { return this.iKinhNghiem; }
            set { this.iKinhNghiem = value; }
        }

        public HLVChienThuat() : base() { }

        public HLVChienThuat(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string rank, string quocgia, int kinhnghiem) : base(hoten, thoigianhopdong, luongcoban, cmnd, namsinh) 
        {
            this.sRank = rank;
            this.sQuocGia = quocgia;
            this.iKinhNghiem = kinhnghiem;
        }

        public HLVChienThuat(string hoten, double luongcoban, string cmnd, string rank) : base(hoten, luongcoban, cmnd)
        {
            this.sRank = rank;
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
            Console.WriteLine("Moi nhap thong tin HLV Chien Thuat ~~ ");
            base.Nhap();

            Console.Write("Moi nhap han cua HLV //Hang: C_B_A_Pro : ");
            this.sRank = Console.ReadLine();

            Console.Write("Moi nhap Quoc Gia cua HLV: ");
            this.sQuocGia = Console.ReadLine();

            Console.Write("Moi nhap so doi ma HLV da tung cong tac: ");
            this.iKinhNghiem = int.Parse(Console.ReadLine());
        }

        public void Nhap(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string rank, string quocgia, int kinhnghiem)
        {
            base.Nhap(hoten, thoigianhopdong, luongcoban, cmnd, namsinh);

            this.sRank = rank;
            this.sQuocGia = quocgia;
            this.iKinhNghiem = kinhnghiem;
        }

        public void Nhap(string hoten, double luongcoban, string cmnd, string rank)
        {
            base.Nhap(hoten, luongcoban, cmnd);
            this.sRank = rank;
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
            base.Xuat();

            Console.WriteLine("Hang cua HLV Chien Thuat la: " + this.sRank);

            Console.WriteLine("HLV Chien Thuat den tu: " + this.sQuocGia);

            Console.WriteLine("So doi bong HLV nay tung dan dat: " + this.iKinhNghiem);

            Console.WriteLine("Luong cua HLV Chien Thuat: " + this.TinhLuong() + " VND");

            if (this.TinhLuong() > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua HLV Chien Thuat la: " + this.TinhThue() + " VND");
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }
    }
}
