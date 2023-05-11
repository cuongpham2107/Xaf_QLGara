using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DXApplication.Blazor.Common;
using DXApplication.Module.BusinessObjects.Car;
using DXApplication.Module.BusinessObjects.Customer;
using DXApplication.Module.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DXApplication.Module.BusinessObjects.Service
{
    [DefaultClassOptions]
    [XafDisplayName("Dịch vụ")]
    [DefaultProperty(nameof(TenDichVu))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.MenuAccessary)]
    public class CarService : BaseObject, IListViewInline
    { 
        public CarService(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        string ghiChu;
        int gia;
        Customers customers;
        Cars cars;
        string tenDichVu;
        [XafDisplayName("Tên dịch vụ")]
        [RuleRequiredField("Bắt buộc phải có CarService.TenDichVu", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenDichVu
        {
            get => tenDichVu;
            set => SetPropertyValue(nameof(TenDichVu), ref tenDichVu, value);
        }
        [XafDisplayName("Xe")]
        public Cars Cars
        {
            get => cars;
            set => SetPropertyValue(nameof(Cars), ref cars, value);
        }
        [XafDisplayName("Khách hàng")]
        public Customers Customers
        {
            get => customers;
            set => SetPropertyValue(nameof(Customers), ref customers, value);
        }
        [XafDisplayName("Giá")]
        public int Gia
        {
            get => gia;
            set => SetPropertyValue(nameof(Gia), ref gia, value);
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