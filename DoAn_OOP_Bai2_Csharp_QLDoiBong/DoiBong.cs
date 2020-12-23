using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class DoiBong
    {
        private string sTenDoiBong;
        private string sTenNhaTaiTro;
        private List<CaNhan> lDoiBong;
        private List<BacSi> lBacsi;
        private List<HLVChienThuat> lHLVChienThuat;
        private List<HLVTheLuc> lHLVTheLuc;
        private San sanDoiBong;
        private QuanLyCauThu lCauThu;

        public string NhaTaiTro
        {
            get { return this.sTenNhaTaiTro; }
            set { this.sTenNhaTaiTro = value; }
        }
        public string TenDoiBong
        {
            get { return this.sTenDoiBong; }
            set { this.sTenDoiBong = value; }
        }
        public List<CaNhan> listDoiBong
        {
            get { return this.lDoiBong; }
            set { this.lDoiBong = value; }
        }

        public San SanDoiBong
        {
            get { return this.sanDoiBong; }
            set { this.sanDoiBong = value; }
        }

        public QuanLyCauThu listCauThu
        {
            get { return this.lCauThu; }
            set { this.lCauThu = value; }
        }

        internal List<BacSi> LBacsi { get => this.lBacsi; set => this.lBacsi = value; }
        internal List<HLVChienThuat> LHLVChienThuat { get => this.lHLVChienThuat; set => this.lHLVChienThuat = value; }
        internal List<HLVTheLuc> LHLVTheLuc { get => this.lHLVTheLuc; set => this.lHLVTheLuc = value; }

        public DoiBong()
        {
            this.lDoiBong = new List<CaNhan>();
            this.sanDoiBong = new San();
            this.lCauThu = new QuanLyCauThu();
        }

        public DoiBong(string tendoibong, string nhataitro, List<CaNhan> listdoibong, San sandoibong)
        {
            this.lDoiBong = listdoibong;
            this.sTenNhaTaiTro = nhataitro;
            this.lDoiBong = listdoibong;
            this.sanDoiBong = sandoibong;
        }

        public void Nhap()
        {
            //double temp = 0;
            Console.Write("Moi nhap Ten Doi Bong: ");
            this.sTenDoiBong = Console.ReadLine();

            Console.Write("Moi nhap ten Nha Tai Tro cua Doi Bong: ");
            this.sTenNhaTaiTro = Console.ReadLine();

            Console.Write("Moi nhap so luong Cau Thu trong Doi Bong: ");
            int cauthu = int.Parse(Console.ReadLine());
            for (int i = 0; i < cauthu; i++)
            {
                CauThu temp = new CauThu();
                temp.Nhap();
                this.lDoiBong.Add(temp);
                this.lCauThu.LDsCauThu.Add(temp);
            }

            Console.Write("Moi nhap so luong HLV The Luc trong Doi Bong: ");
            int HLVTL = int.Parse(Console.ReadLine());
            for (int i = 0; i < HLVTL; i++)
            {
                HLVTheLuc temp = new HLVTheLuc();
                temp.Nhap();
                this.lDoiBong.Add(temp);
                this.LHLVTheLuc.Add(temp);
            }

            Console.Write("Moi nhap so luong HLV Chien Thuat trong Doi Bong: ");
            int HLVCT = int.Parse(Console.ReadLine());
            for (int i = 0; i < HLVCT; i++)
            {
                HLVChienThuat temp = new HLVChienThuat();
                temp.Nhap();
                this.lDoiBong.Add(temp);
            }

            Console.Write("Moi nhap so luong Bac Si trong Doi Bong: ");
            int BS = int.Parse(Console.ReadLine());
            for (int i = 0; i < BS; i++)
            {
                BacSi temp = new BacSi();
                temp.Nhap();
                this.lDoiBong.Add(temp);
            }

            
        }

        public void Xuat()
        {
            Console.WriteLine("Ten Doi Bong la: " + this.sTenDoiBong);
            Console.WriteLine("Ten Nha Tai Tro cua Doi Bong la: " + this.sTenNhaTaiTro);
            foreach (CaNhan item in this.lDoiBong)
            {
                item.Xuat();
            }
            this.sanDoiBong.Xuat();
        }

    }
}
