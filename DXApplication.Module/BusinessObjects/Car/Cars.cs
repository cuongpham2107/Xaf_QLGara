using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DXApplication.Module.BusinessObjects.Customer;
using System.ComponentModel;
using DXApplication.Module.BusinessObjects.Accessary;
using DXApplication.Module.BusinessObjects.Gara;
using DXApplication.Blazor.Common;
using DXApplication.Module.Extension;
using DevExpress.Persistent.Validation;

namespace DXApplication.Module.BusinessObjects.Car
{
    [DefaultClassOptions]
    //[ImageName("checklist")]
    [XafDisplayName("Xe")]
    [DefaultProperty(nameof(TenXe))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [ListViewFindPanel(true)]
    [LookupEditorMode(LookupEditorMode.AllItemsWithSearch)]
    [NavigationItem(Menu.MenuAccessary)]
    public class Cars : BaseObject, IListViewPopup
    { 
        public Cars(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        Garas garas;
        string ghiChu;
        string tenXe;
        Customers _customer;
        [XafDisplayName("Khách hàng")]
        [RuleRequiredField("Bắt buộc phải có Cars.Customer", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public Customers Customer
        {
            get { return _customer; }
            set { SetPropertyValue(nameof(Customer), ref _customer, value); }
        }
        [XafDisplayName("Tên xe")]
        [RuleRequiredField("Bắt buộc phải có Cars.TenXe", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string TenXe
        {
            get => tenXe;
            set => SetPropertyValue(nameof(TenXe), ref tenXe, value);
        }
        private string _loaiXe;
        [XafDisplayName("Loại xe")]
        public string LoaiXe
        {
            get { return _loaiXe; }
            set { SetPropertyValue(nameof(LoaiXe), ref _loaiXe, value); }
        }
        private string _kieuXe;
        [XafDisplayName("Kiểu xe")]
        public string KieuXe
        {
            get { return _kieuXe; }
            set { SetPropertyValue(nameof(KieuXe), ref _kieuXe, value); }
        }
        private string _mauSon;
        [XafDisplayName("Mầu sơn")]
        public string MauSon
        {
            get { return _mauSon; }
            set { SetPropertyValue(nameof(MauSon), ref _mauSon, value); }
        }
        private int _doiXe;
        [XafDisplayName("Đời xe")]
        public int DoiXe
        {
            get { return _doiXe; }
            set { SetPropertyValue(nameof(DoiXe), ref _doiXe, value); }
        }
        private string _bienSo;
        [XafDisplayName("Biển số")]
        [RuleRequiredField("Bắt buộc phải có Cars.BienSo", DefaultContexts.Save, "Trường dữ liệu không được để trống")]
        public string BienSo
        {
            get { return _bienSo; }
            set { SetPropertyValue(nameof(BienSo), ref _bienSo, value); }
        }

        [XafDisplayName("Thuộc Gara")]
        public Garas Garas
        {
            get => garas;
            set => SetPropertyValue(nameof(Garas), ref garas, value);
        }
        [XafDisplayName("Ghi chú")]
        [Size(SizeAttribute.Unlimited)]
        public string GhiChu
        {
            get => ghiChu;
            set => SetPropertyValue(nameof(GhiChu), ref ghiChu, value);
        }

        [XafDisplayName("Danh sách phụ tùng")]
        [Association("Car-Accessarys")]
        public XPCollection<Accessaries> Accessarys
        {
            get
            {
                return GetCollection<Accessaries>(nameof(Accessarys));
            }
        }

    }
}