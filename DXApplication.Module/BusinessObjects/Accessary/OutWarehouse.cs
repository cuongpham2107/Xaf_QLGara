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
    [XafDisplayName("Xuất")]
    [DefaultProperty(nameof(TenPhieu))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.MenuAccessary)]
    public class OutWarehouse : Bill
    { 
        public OutWarehouse(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        int tongSoLuong;
        [XafDisplayName("Tổng số lượng")]
        public int TongSoLuong
        {
            get => tongSoLuong;
            set => SetPropertyValue(nameof(TongSoLuong), ref tongSoLuong, value);
        }

        TrangThaiXuat trangThaiXuat;

        [XafDisplayName("Trạng thái")]
        public TrangThaiXuat TrangThaiXuat
        {
            get => trangThaiXuat;
            set => SetPropertyValue(nameof(TrangThaiXuat), ref trangThaiXuat, value);
        }

        [Association("OutWarehouse-Accessarys")]
        [XafDisplayName("Danh sách phụ tùng xuất")]
        public XPCollection<Accessaries> Accessarys
        {
            get
            {
                return GetCollection<Accessaries>(nameof(Accessarys));
            }
        }
    }
}