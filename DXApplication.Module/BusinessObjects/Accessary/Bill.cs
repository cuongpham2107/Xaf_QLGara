using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DXApplication.Blazor.Common;
using DXApplication.Module.BusinessObjects.Service;
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
            
        }

        int nam;
        int thang;
        private int tongTien;
        string ghiChu;
        
        DateTime ngay;
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
                if (!IsLoading && !IsSaving)
                {
                    if (Ngay != null)
                    {
                        return Ngay.Month;
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
        [Association("Bill-CarServices")]
        [XafDisplayName("Danh sách dịch vụ")]
        public XPCollection<CarService> CarServices
        {
            get
            {
                return GetCollection<CarService>(nameof(CarServices));
            }
        }
    }
}