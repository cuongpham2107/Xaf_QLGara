using DevExpress.ExpressApp.DC;

namespace DXApplication.Blazor.Common;


public class Enums{
   
    public enum TinhTrang
    {
        [XafDisplayName("Còn hàng")] conHang = 0,
        [XafDisplayName("Hết hàng")] hetHang = 1,
        [XafDisplayName("Ngừng kinh doanh")] ngungKinhDoanh = 2
    }
    public enum TrangThaiNhap
    {
        [XafDisplayName("Nháp")] nhap = 0,
        [XafDisplayName("Đã thanh toán")] daThanhToan = 1,
        [XafDisplayName("Chưa thanh toán")] chuaThanhToan = 2
    }
    public enum TrangThaiXuat
    {
        [XafDisplayName("Nháp")] nhap = 0,
        [XafDisplayName("Đã thanh toán")] daThanhToan = 1,
        [XafDisplayName("Chưa thanh toán")] chuaThanhToan = 2

    }
    public enum LoaiCongNo
    {
        [XafDisplayName("Phải thu")] phaiThu = 0,
        [XafDisplayName("Phải trả")] phaiTra = 1,
    }
}