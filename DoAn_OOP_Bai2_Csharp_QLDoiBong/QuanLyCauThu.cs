using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class QuanLyCauThu
    {
        private List<CauThu> lDsCauThu;
        public List<CauThu> LDsCauThu { get => lDsCauThu; set => lDsCauThu = value; }

        public QuanLyCauThu(List<CauThu> DsCauThu)
        {
            this.lDsCauThu = DsCauThu;
        }

        public void Sort()
        {
            int choose = 0;
            Console.WriteLine("=============================");
            Console.WriteLine("1: Ho ten");
            Console.WriteLine("2: Tuoi");
            Console.WriteLine("3: Ngay gia nhap");
            Console.WriteLine("4: Thoi han hop dong con lai");
            Console.WriteLine("5: So ao");
            Console.WriteLine("6: TT the luc");
            Console.WriteLine("7: TT Suc Khoe");
            Console.WriteLine("Ban muon sap xep danh sach theo cai gi: ");
            choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                {
                    lDsCauThu.Sort((x, y) => x.sHoTen.CompareTo(y.sHoTen));
                    break;
                }
                case 2:
                {
                    lDsCauThu.Sort((x, y) => x.TinhTuoi().CompareTo(y.TinhTuoi()));
                    break;
                }
                case 3:
                {
                    //lDsCauThu.Sort((x, y) => x.dNgayGiaNhap.CompareTo(y.dNgayGiaNhap));   
                    break;
                }
                case 4:
                {
                    //lDsCauThu.Sort((x, y) => x.ThoiGianHopDongConLai().CompareTo(y.ThoiGianHopDongConLai());
                    break;
                }
                case 5:
                {
                    lDsCauThu.Sort((x, y) => x.SoAo.CompareTo(y.SoAo));
                    break;
                }
                case 6:
                {
                    lDsCauThu.Sort((x, y) => x.TinhTrangTheLuc.CompareTo(y.TinhTrangTheLuc));
                    break;
                }
                case 7:
                {
                    lDsCauThu.Sort((x, y) => x.TinhTrangSucKhoe.CompareTo(y.TinhTrangSucKhoe));
                    break;
                }
                case 8:
                {
                    break;
                }
                default:
                {
                    lDsCauThu.Sort((x, y) => x.sHoTen.CompareTo(y.sHoTen));
                    break;
                }
            }    

        }
        public List<CauThu> Loc()
        {
            int choose = 0;
            List<CauThu> temp = new List<CauThu>();
            Console.WriteLine("=============================");
            Console.WriteLine("1: Danh sach cau thu thuan chan trai");
            Console.WriteLine("2: Danh sach cau thu thuan chan phai");
            Console.WriteLine("3: Danh sach cau thu co the da tien dao");
            Console.WriteLine("4: Danh sach cau thu co the da tien ve");
            Console.WriteLine("5: So ao");
            Console.WriteLine("6: TT the luc");
            Console.WriteLine("7: TT Suc Khoe");
            Console.WriteLine("Ban muon sap xep danh sach theo cai gi: ");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                {
                    foreach (var item in LDsCauThu)
                        if (item.ChanThuan == "trai")
                            temp.Add(item);
                    break;
                }
                case 2:
                {
                    lDsCauThu.Sort((x, y) => x.TinhTuoi().CompareTo(y.TinhTuoi()));
                    break;
                }
                case 3:
                {
                    //lDsCauThu.Sort((x, y) => x.dNgayGiaNhap.CompareTo(y.dNgayGiaNhap));   
                    break;
                }
                case 4:
                {
                    //lDsCauThu.Sort((x, y) => x.ThoiGianHopDongConLai().CompareTo(y.ThoiGianHopDongConLai());
                    break;
                }
                case 5:
                {
                    lDsCauThu.Sort((x, y) => x.SoAo.CompareTo(y.SoAo));
                    break;
                }
                case 6:
                {
                    lDsCauThu.Sort((x, y) => x.TinhTrangTheLuc.CompareTo(y.TinhTrangTheLuc));
                    break;
                }
                case 7:
                {
                    lDsCauThu.Sort((x, y) => x.TinhTrangSucKhoe.CompareTo(y.TinhTrangSucKhoe));
                    break;
                }
                case 8:
                {
                    break;
                }
                default:
                {
                    lDsCauThu.Sort((x, y) => x.sHoTen.CompareTo(y.sHoTen));
                    break;
                }
               
            }
            return temp;
        }
        
        public void xuat()
        {
            foreach (var item in lDsCauThu)
            {
                item.Xuat();
                Console.WriteLine("=============================");
            }
        }
    }
}
