using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class SanCoReal : San
    {
        private int iKhuVucKhanDai;
        //private int iSoLuongKhanGia;
        //private double dGiaVe;
        private double dGiaBanThucAn;
        private double dGiaBanNuocUong;

        public int KhuVucKhanDai
        {
            get { return this.iKhuVucKhanDai; }
            set { this.iKhuVucKhanDai = value; }
        }

        public double GiaBanThucAn
        {
            get { return this.dGiaBanThucAn; }
            set { this.dGiaBanThucAn = value; }
        }

        public double GiaBanThucUong
        {
            get { return this.dGiaBanNuocUong; }
            set { this.dGiaBanNuocUong = value; }
        }

        public SanCoReal() : base() { }

        public SanCoReal(List<NVBaoVe> ListBv, List<NVVeSinh> ListVs, int soluong, double GiaVe, int soKhuVuc, double giabanthucan, double giabannuoc) : base(ListBv, ListVs, soluong,GiaVe)
        {
            this.iKhuVucKhanDai = soKhuVuc;
            //this.dGiaVe = GiaVe;
            this.dGiaBanThucAn = giabanthucan;
            this.dGiaBanNuocUong = giabannuoc;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin San Co Real ~~ ");
            base.Nhap();

            Console.Write("Moi nhap so Khu Vuc tren Khan Dai: ");
            this.iKhuVucKhanDai = int.Parse(Console.ReadLine());

            Console.Write("Moi nhap Gia ban thuc an ngoai san: ");
            this.dGiaBanThucAn = double.Parse(Console.ReadLine());

            Console.Write("Moi nhap Gia ban nuoc uong ngoai san: ");
            this.dGiaBanNuocUong = double.Parse(Console.ReadLine());
        }

        public void Nhap(List<NVBaoVe> ListBv, List<NVVeSinh> ListVs, int soluong, double GiaVe, int soKhuVuc, double giabanthucan, double giabannuoc)
        {
            base.Nhap(ListBv, ListVs, soluong, GiaVe);
            this.iKhuVucKhanDai = soKhuVuc;
            //this.dGiaVe = GiaVe;
            this.dGiaBanThucAn = giabanthucan;
            this.dGiaBanNuocUong = giabannuoc;
        }
        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine("Co {0} Khu Vuc Tren Khan Dai ", this.iKhuVucKhanDai);//khu A,B,C,D..
            //Console.WriteLine("Gia ve vao san co Real la: " + this.dGiaVe);
            Console.WriteLine("Gia ban thuc an: " + this.dGiaBanThucAn);
            Console.WriteLine("Gia ban thuc uong: " + this.dGiaBanNuocUong);
        }
    }
}
