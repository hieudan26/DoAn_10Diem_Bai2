using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class SanFUTSAL : San
    {
        //private int iSoLuongCauThuTrenSan;
        //private int iSoLuongKhanGia;
        //private double dGiaVe;

        public SanFUTSAL() : base() { }

        public SanFUTSAL(List<NVBaoVe> ListBv, List<NVVeSinh> ListVs, int soluong, double giave) : base(ListBv, ListVs, soluong, giave) { }

        public override void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin San FUTSAL/San Co Nhan Tao ~~ ");
            base.Nhap();
        }

        public new void Nhap(List<NVBaoVe> ListBv, List<NVVeSinh> ListVs, int soluong, double giave)
        {
            base.Nhap(ListBv, ListVs, soluong, giave);
        }

        public override void Xuat()
        {
            base.Xuat();
        }
    }
}
