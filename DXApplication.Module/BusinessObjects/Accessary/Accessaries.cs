using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DevExpress.XtraPrinting.Native;
using DXApplication.Blazor.Common;
using DXApplication.Module.BusinessObjects.Car;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static DXApplication.Blazor.Common.Enums;

namespace DXApplication.Module.BusinessObjects.Accessary
{
    [DefaultClassOptions]
    [XafDisplayName("Phụ tùng")]
    [DefaultProperty(nameof(TenPhuTung))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.MenuAccessary)]

    [Appearance("TinhTrang_1", BackColor = "LimeGreen", FontColor = "Black", FontStyle = System.Drawing.FontStyle.Bold,
        Criteria = "[TinhTrang] = ##Enum#DXApplication.Blazor.Common.Enums+TinhTrang,conHang#", 
        TargetItems = "TinhTrang", Context = "Any", Priority = 0)]
    [Appearance("TinhTrang_2", BackColor = "Gold", FontColor = "Black", FontStyle = System.Drawing.FontStyle.Bold,
        Criteria = "[TinhTrang] = ##Enum#DXApplication.Blazor.Common.Enums+TinhTrang,hetHang#",
        TargetItems = "TinhTrang", Context = "Any", Priority = 0)]
    [Appearance("TinhTrang_3", BackColor = "255,0,0", FontColor = "Black", FontStyle = System.Drawing.FontStyle.Bold,
        Criteria = "[TinhTrang] = ##Enum#DXApplication.Blazor.Common.Enums+TinhTrang,ngungKinhDoanh#",
        TargetItems = "TinhTrang", Context = "DetailView", Priority = 0)]
    [Appearance("HideEdit", AppearanceItemType = "ViewItem", TargetItems = "*", FontStyle = System.Drawing.FontStyle.Bold,
        BackColor = "255,0,0", FontColor = "Black",
        Criteria = "[TinhTrang] = ##Enum#DXApplication.Blazor.Common.Enums+TinhTrang,ngungKinhDoanh#",
        Context = "ListView", Priority = 1)]
    public class Accessaries : BaseObject
    {
        public Accessaries(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        int nam;
        int thang;
        DateTime ngay;
        string nhaCungCap;
        string hangSanXuat;
        DateTime? hanSuDung;
        TinhTrang tinhTrang;
        int giaBan;
        byte[] hinhAnh;
        int giaNhap;
        int soLuong;
        string tenPhuTung;
        [XafDisplayName("Tên phụ tùng")]
        [RuleRequiredField("Bắt buộc phải có Accessaries.TenPhuTung", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenPhuTung
        {
            get => tenPhuTung;
            set => SetPropertyValue(nameof(TenPhuTung), ref tenPhuTung, value);
        }
        [XafDisplayName("Hãng sản xuất")]
        public string HangSanXuat
        {
            get => hangSanXuat;
            set => SetPropertyValue(nameof(HangSanXuat), ref hangSanXuat, value);
        }
        [XafDisplayName("Nhà cung cấp")]
        public string NhaCungCap
        {
            get => nhaCungCap;
            set => SetPropertyValue(nameof(NhaCungCap), ref nhaCungCap, value);
        }
        [XafDisplayName("Ngày")]
        public DateTime Ngay
        {
            get => DateTime.Now;
            set => SetPropertyValue(nameof(Ngay), ref ngay, value);
        }
        [XafDisplayName("Tháng")]
        public int Thang
        {
            get
            {
                if(!IsLoading && !IsSaving)
                {
                    if (Ngay != null)
                    {
                        return  Ngay.Month;
                    }
                }
                return 0;
               
            }
            set => SetPropertyValue(nameof(Thang), ref thang, value);
        }
        [XafDisplayName("Năm")]
        public int Nam
        {
            get
            {
                if (!IsLoading && !IsSaving)
                {
                    if (Ngay != null)
                    {
                        return Ngay.Year;
                    }
                }
                return 0;

            }
            set => SetPropertyValue(nameof(Nam), ref nam, value);
        }
        [XafDisplayName("Số lượng")]
        public int SoLuong
        {
            get => soLuong;
            set => SetPropertyValue(nameof(SoLuong), ref soLuong, value);
        }
        [XafDisplayName("Giá nhập")]
        public int GiaNhap
        {
            get => giaNhap;
            set => SetPropertyValue(nameof(GiaNhap), ref giaNhap, value);
        }
        [XafDisplayName("Giá bán")]
        public int GiaBan
        {
            get => giaBan;
            set => SetPropertyValue(nameof(GiaBan), ref giaBan, value);
        }
        [XafDisplayName("Hạn sử dụng")]
        public DateTime? HanSuDung
        {
            get => hanSuDung;
            set => SetPropertyValue(nameof(HanSuDung), ref hanSuDung, value);
        }
        [XafDisplayName("Hình ảnh")]
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PictureEdit,
            DetailViewImageEditorMode = ImageEditorMode.PictureEdit, 
            ListViewImageEditorCustomHeight = 40)]
        public byte[] HinhAnh
        {
            get => hinhAnh;
            set => SetPropertyValue(nameof(HinhAnh), ref hinhAnh, value);
        }
        [XafDisplayName("Tình trạng")]
        public TinhTrang TinhTrang
        {
            get => tinhTrang;
            set => SetPropertyValue(nameof(TinhTrang), ref tinhTrang, value);
        }
       
        [Association("Car-Accessarys")]
        [XafDisplayName("Danh sách xe")]
        public XPCollection<Cars> Cars
        {
            get
            {
                return GetCollection<Cars>(nameof(Cars));
            }
        }

        //[Association("Bill-Accessarys")]
        //[XafDisplayName("Danh sách Hoá đơn")]
        //public XPCollection<Bill> Bills
        //{
        //    get
        //    {
        //        return GetCollection<Bill>(nameof(Bills));
        //    }
        //}
       
    }

}