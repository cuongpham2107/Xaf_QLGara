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
    [XafDisplayName("Nhập")]
    [DefaultProperty(nameof(TenPhieu))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.MenuAccessary)]
    public class InWarehouse : Bill
    { 
        public InWarehouse(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }

        private TrangThaiNhap trangThaiNhap;


        [XafDisplayName("Trạng thái")]
        public TrangThaiNhap TrangThaiNhap
        {
            get => trangThaiNhap;
            set => SetPropertyValue(nameof(TrangThaiNhap), ref trangThaiNhap, value);
        }

        //[Association("Bill-Accessarys")]
        //[XafDisplayName("Danh sách phụ tùng")]
        //public XPCollection<Accessaries> Accessarys
        //{
        //    get
        //    {
        //        return GetCollection<Accessaries>(nameof(Accessarys));
        //    }
        //}
    }
}