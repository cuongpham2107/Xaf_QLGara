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

namespace DXApplication.Module.BusinessObjects.Customer
{
    [DefaultClassOptions]
    //[ImageName("checklist")]
    [XafDisplayName("Khách hàng")]
    [DefaultProperty(nameof(TenKhachHang))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.MenuCustomer)]
    [CustomDetailView(Tabbed = true)]

    public class Customers : BaseObject, IListViewPopup
    { 
        public Customers(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }

        string ghiChu;
        string address;
        string soDienThoai;
        string tenKhachHang;
        [XafDisplayName("Tên khách hàng")]
        [RuleRequiredField("Bắt buộc phải có Customers.TenKhachHang", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenKhachHang
        {
            get => tenKhachHang;
            set => SetPropertyValue(nameof(TenKhachHang), ref tenKhachHang, value);
        }
        [XafDisplayName("Số điện thoại")]
        [RuleRequiredField("Bắt buộc phải có Customers.SoDienThoai", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string SoDienThoai
        {
            get => soDienThoai;
            set => SetPropertyValue(nameof(SoDienThoai), ref soDienThoai, value);
        }
        [XafDisplayName("Địa chỉ")]
        public string Address
        {
            get => address;
            set => SetPropertyValue(nameof(Address), ref address, value);
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
