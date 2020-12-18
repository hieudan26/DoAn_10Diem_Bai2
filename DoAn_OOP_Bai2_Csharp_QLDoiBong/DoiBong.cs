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
        private San sanDoiBong;

        public string NhaTaiTro
        {
            get;set;
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

        public DoiBong()
        {
            this.lDoiBong = new List<CaNhan>();
            this.sanDoiBong = new San();
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
            Console.Write("Moi nhap Ten Doi Bong: ");
            this.sTenDoiBong = Console.ReadLine();

            Console.Write("Moi nhap ten Nha Tai Tro cua Doi Bong: ");
            this.sTenNhaTaiTro = Console.ReadLine();

            Console.Write("Moi nhap so luong Cau Thu trong Doi Bong: ");
            int cauthu = int.Parse(Console.ReadLine());
            for (int i = 0; i < cauthu; i++)
            {
                CauThu a = new CauThu();
                a.Nhap();
                this.lDoiBong.Add(a);
            }

            Console.Write("Moi nhap so luong HLV The Luc trong Doi Bong: ");
            int HLVTL = int.Parse(Console.ReadLine());
            for (int i = 0; i < HLVTL; i++)
            {
                HLVTheLuc b = new HLVTheLuc();
                b.Nhap();
                this.lDoiBong.Add(b);
            }

            Console.Write("Moi nhap so luong HLV Chien Thuat trong Doi Bong: ");
            int HLVCT = int.Parse(Console.ReadLine());
            for (int i = 0; i < HLVCT; i++)
            {
                HLVChienThuat c = new HLVChienThuat();
                c.Nhap();
                this.lDoiBong.Add(c);
            }

            Console.Write("Moi nhap so luong Bac Si trong Doi Bong: ");
            int BS = int.Parse(Console.ReadLine());
            for (int i = 0; i < BS; i++)
            {
                BacSi d = new BacSi();
                d.Nhap();
                this.lDoiBong.Add(d);
            }

            Console.Write("1_Chon San Co Real || 2_Chon San FUTSAL/San Co Nhan Tao => your choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                this.sanDoiBong = new SanCoReal();
                this.sanDoiBong.Nhap();
            }
            else
            {
                this.sanDoiBong = new SanFUTSAL();
                this.sanDoiBong.Nhap();
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
