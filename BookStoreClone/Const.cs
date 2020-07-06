using BookStoreClone.Model;
using BookStoreClone.ViewModel;
using System.Linq;

namespace BookStoreClone
{
    public class Const : BaseViewModel
    {
        public static int QuyDinh_TonToiThieuSauKhiBan { set; get; } = DataProvider.Ins.DB.QuyDinhs.First().SoLuongSachTonToiThieuSauKhiBan;
        public static int QuyDinh_TienNoToiDa { set; get; } = DataProvider.Ins.DB.QuyDinhs.First().TienNoToiDa;
        public static int QuyDinh_SoLuongSachTonToiThieuDeNhap { get; set; } = DataProvider.Ins.DB.QuyDinhs.First().SoLuongSachTonToiThieuDeNhap;
        public static int QuyDinh_SoLuongSachNhapToiThieu { get; set; } = DataProvider.Ins.DB.QuyDinhs.First().SoLuongSachNhapToiThieu;
        public static int QuyDinh_HeSoDonGia { get; set; } = 115;
        public static int QuyDinh_SoLuongSachNhapToiDa { get; set; } = 300;
        public static string IDNguoiDung { get; set; } = DataProvider.Ins.DB.NguoiDungs.First().TenDangNhap;
    }
}