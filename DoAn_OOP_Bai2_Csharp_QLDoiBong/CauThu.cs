using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{

    public class CauThu : CaNhan
    {
        private int iSoAo;
        private int iTinhTrangTheLuc;
        private int iTinhTrangSucKhoe;
        private string sChanThuan;
        private string sViTriDaChinh;
        private string sViTriPhu;

        public int SoAo
        {
            get { return this.iSoAo; }
            set { this.iSoAo = value; }
        }

        public int TinhTrangTheLuc
        {
            get { return this.iTinhTrangTheLuc; }
            set { this.iTinhTrangTheLuc = value; }
        }

        public int TinhTrangSucKhoe
        {
            get { return this.iTinhTrangSucKhoe; }
            set { this.iTinhTrangSucKhoe = value; }
        }
        
        public string ChanThuan 
        {
            get { return this.sChanThuan; }
            set { this.sChanThuan = value; }
        }

        public string ViTriDaChinh 
        {
            get { return this.sViTriDaChinh; }
            set { this.sViTriDaChinh = value; }
        }

        public string ViTriPhu
        {
            get { return this.sViTriPhu; }
            set { this.sViTriPhu = value; }
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

        public CauThu() : base() 
        {
        }

        public CauThu(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int soao, int tinhtrangsuckhoe, int tinhtrangtheluc,  string chanthuan, string vitridachinh, string vitriphu) : base(hoten, thoigianhopdong
            , luongcoban, cmnd, namsinh)
        {
            this.iSoAo = soao;
            this.iTinhTrangSucKhoe = tinhtrangsuckhoe;
            this.iTinhTrangTheLuc = tinhtrangtheluc;
            this.sChanThuan = chanthuan;
            this.sViTriDaChinh = vitridachinh;
            this.sViTriPhu = vitriphu;
        }

        public CauThu(string hoten, double luongcoban, string cmnd, int soao) : base(hoten, luongcoban, cmnd)
        {
            this.iSoAo = soao;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap Thong Tin Cau Thu ~~");
            base.Nhap();
            Console.Write("So ao cua Cau Thu la: ");
            this.iSoAo = int.Parse(Console.ReadLine());

            Console.Write("Tinh Trang The Luc cua Cau Thu: ");
            this.iTinhTrangTheLuc = int.Parse(Console.ReadLine());

            Console.Write("Tinh Trang Suc Khoe cua Cau Tu: ");
            this.iTinhTrangSucKhoe = int.Parse(Console.ReadLine());

            Console.Write("Chan thuan cua Cau Thu la: ");
            this.sChanThuan = Console.ReadLine();

            Console.Write("Vi tri Da Chinh trong doi hinh cua Cau Thu la: ");
            this.sViTriDaChinh = Console.ReadLine();

            Console.Write("Vi tri Da Phu trong doi hinh cua Cau Thu la: ");
            this.sViTriPhu = Console.ReadLine();
        }

        public void Nhap(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int soao, int tinhtrangsuckhoe, int tinhtrangtheluc, string chanthuan, string vitridachinh, string vitriphu)
        {
            base.Nhap(hoten, thoigianhopdong, luongcoban, cmnd, namsinh);
            this.iSoAo = soao;
            this.iTinhTrangTheLuc = tinhtrangtheluc;
            this.iTinhTrangSucKhoe = tinhtrangsuckhoe;
            this.sChanThuan = chanthuan;
            this.sViTriDaChinh = vitridachinh;
            this.sViTriPhu = vitriphu;
        }

        public void Nhap(string hoten, double luongcoban, string cmnd, int soao)
        {
            base.Nhap(hoten, luongcoban, cmnd);
            this.iSoAo = soao;
        }

        public override void Xuat()
        {
            Console.WriteLine("Thong Tin Cau Thu ~~ ");
            base.Xuat();

            //Console.WriteLine("Tuoi cua Cau Thu la: " + this.TinhTuoi());
            Console.WriteLine("So Ao co dinh cua Cau Thu la: " + this.iSoAo);
            Console.WriteLine("Chan Thuan cua Cau Thu la: " + this.sChanThuan);
            Console.WriteLine("Vi tri Da Chinh trong doi hinh la: " + this.sViTriDaChinh);
            Console.WriteLine("Vi tri Da Phu trong doi hinh la: " + this.sViTriPhu);
            Console.WriteLine("Luong cua Cau Thu la: " + this.TinhLuong() + " VND");

            if (this.TinhLuong() > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua Cau Thu la: " + this.TinhThue() + " VND");
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }

        public override double TinhLuong()
        {
            double luong = this.dLuongCoBan + this.dLuongCoBan * 0.3;
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
    }
}
