using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DXApplication.Blazor.Common;
using DXApplication.Module.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using static DXApplication.Blazor.Common.Enums;

namespace DXApplication.Module.BusinessObjects.Customer
{
    [DefaultClassOptions]
    //[ImageName("checklist")]
    [XafDisplayName("Công nợ")]
    [DefaultProperty(nameof(SoChungTu))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.MenuCustomer)]
    [CustomDetailView(Tabbed = true)]

    public class Debt : BaseObject
    { 
        public Debt(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        int tongSoTien;
        bool trangThai;
        string ghiChu;
        int nam;
        int thang;
        DateTime? ngay;
        string noiDung;
        string soChungTu;
        LoaiCongNo loaiCongNo;
        [XafDisplayName("Loại Công nợ")]
        public LoaiCongNo LoaiCongNo
        {
            get => loaiCongNo;
            set => SetPropertyValue(nameof(LoaiCongNo), ref loaiCongNo, value);
        }
        [XafDisplayName("Số chứng từ")]
        public string SoChungTu
        {
            get => soChungTu;
            set => SetPropertyValue(nameof(SoChungTu), ref soChungTu, value);
        }
        [XafDisplayName("Nội dung")]
        public string NoiDung
        {
            get => noiDung;
            set => SetPropertyValue(nameof(NoiDung), ref noiDung, value);
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
        [XafDisplayName("Tổng số tiền")]
        public int TongSoTien
        {
            get => tongSoTien;
            set => SetPropertyValue(nameof(TongSoTien), ref tongSoTien, value);
        }
        [XafDisplayName("Trạng thái")]
        public bool TrangThai
        {
            get => trangThai;
            set => SetPropertyValue(nameof(TrangThai), ref trangThai, value);
        }
        [XafDisplayName("Ghi chú")]
        public string GhiChu
        {
            get => ghiChu;
            set => SetPropertyValue(nameof(GhiChu), ref ghiChu, value);
        }

    }
}