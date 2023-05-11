using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DXApplication.Blazor.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static DXApplication.Blazor.Common.Enums;

namespace DXApplication.Module.BusinessObjects.Accessary
{
    [DefaultClassOptions]
    [XafDisplayName("Hoá đơn")]
    [DefaultProperty(nameof(TenPhieu))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.MenuAccessary)]
    public partial class Bill : BaseObject
    { 
        public Bill(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        int nam;
        int thang;
        private int tongTien;
        string ghiChu;
        int tongSoLuong;
        DateTime? ngay;
        string tenPhieu;
        string maPhieu;
        [XafDisplayName("Mã hoá đơn")]
        [RuleRequiredField("Bắt buộc phải có Bill.MaPhieu", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string MaPhieu
        {
            get => maPhieu;
            set => SetPropertyValue(nameof(MaPhieu), ref maPhieu, value);
        }
        [XafDisplayName("Tên hoá đơn")]
        [RuleRequiredField("Bắt buộc phải có InWarehouse.TenPhieuNhap", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenPhieu
        {
            get => tenPhieu;
            set => SetPropertyValue(nameof(TenPhieu), ref tenPhieu, value);
        }
        [XafDisplayName("Ngày")]
        public DateTime? Ngay
        {
            get => ngay;
            set => SetPropertyValue(nameof(Ngay), ref ngay, value);
        }
        [XafDisplayName("Tháng")]
        public int Thang
        {
            get => thang;
            set => SetPropertyValue(nameof(Thang), ref thang, value);
        }
        [XafDisplayName("Năm")]
        public int Nam
        {
            get => nam;
            set => SetPropertyValue(nameof(Nam), ref nam, value);
        }
        [XafDisplayName("Tổng số lượng")]
        public int TongSoLuong
        {
            get => tongSoLuong;
            set => SetPropertyValue(nameof(TongSoLuong), ref tongSoLuong, value);
        }

        [XafDisplayName("Tổng tiền")]
        public int TongTien
        {
            get => tongTien;
            set => SetPropertyValue(nameof(TongTien), ref tongTien, value);
        }
        [XafDisplayName("Ghi chú")]
        [Size(SizeAttribute.Unlimited)]
        public string GhiChu
        {
            get => ghiChu;
            set => SetPropertyValue(nameof(GhiChu), ref ghiChu, value);
        }
    }
}