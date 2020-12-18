using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class TrongTai : CaNhan
    {
        private string sChungChi;
        private int iSoLuongTGianCamCoi;

        public int SoLuongTGianCamCoi
        {
            get { return this.iSoLuongTGianCamCoi; }
            set { this.iSoLuongTGianCamCoi = value; }
        }

        public string ChungChi
        {
            get { return this.sChungChi; }
            set { this.sChungChi = value; }
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

        public TrongTai() : base() { }
        public TrongTai(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string chungchi, int time) : base(hoten, thoigianhopdong
            , luongcoban, cmnd, namsinh)
        {
            this.sChungChi = chungchi;
            this.iSoLuongTGianCamCoi = time;
        }

        public TrongTai(string hoten, double luongcoban, string cmnd, int time) : base(hoten, luongcoban, cmnd) 
        {
            this.iSoLuongTGianCamCoi = time;
        }

        public override void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin Trong Tai ~~ ");
            base.Nhap();

            Console.Write("Moi nhap ten Chung Chi cua Trong Tai duoc FIFA cap: ");
            this.sChungChi = Console.ReadLine();

            Console.Write("Moi nhap Thoi Gian Cam Coi cua Trong Tai: ");
            this.iSoLuongTGianCamCoi = int.Parse(Console.ReadLine());
        }

        public void Nhap(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string chungchi, int time)
        {
            base.Nhap(hoten, thoigianhopdong
            , luongcoban, cmnd, namsinh);
            this.sChungChi = chungchi;
            this.iSoLuongTGianCamCoi = time;
        }

        public void Nhap(string hoten, double luongcoban, string cmnd, int time)
        {
            base.Nhap(hoten, luongcoban, cmnd);
            this.iSoLuongTGianCamCoi = time;
        }

        public override double TinhLuong()
        {
            double luong = this.dLuongCoBan + this.dLuongCoBan * 0.1;
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

            //Console.WriteLine("Tuoi cua Trong Tai: " + this.TinhTuoi());

            Console.WriteLine("Loai Chung Chi cua Trong Tai la: " + this.sChungChi);

            Console.WriteLine("Thoi Gian Cam Coi cua Trong Tai la: " + this.iSoLuongTGianCamCoi);

            Console.WriteLine("Luong cua Trong Tai: " + this.TinhLuong());

            if (this.TinhLuong() > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua Trong Tai la: " + this.TinhThue());
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }
    }
}
