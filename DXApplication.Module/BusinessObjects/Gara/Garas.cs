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

namespace DXApplication.Module.BusinessObjects.Gara
{
    [DefaultClassOptions]
    //[ImageName("checklist")]
    [XafDisplayName("Gara")]
    [DefaultProperty(nameof(TenGara))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.MenuAccessary)]
    public class Garas : BaseObject, IListViewInline
    { 
        public Garas(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            
        }

        string diaChi;
        string ghiChu;
        string tenGara;
        [XafDisplayName("Tên Gara")]
        [RuleRequiredField("Bắt buộc phải có Garas.TenGara", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenGara
        {
            get => tenGara;
            set => SetPropertyValue(nameof(TenGara), ref tenGara, value);
        }
        [XafDisplayName("Địa chỉ")]
        public string DiaChi
        {
            get => diaChi;
            set => SetPropertyValue(nameof(DiaChi), ref diaChi, value);
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