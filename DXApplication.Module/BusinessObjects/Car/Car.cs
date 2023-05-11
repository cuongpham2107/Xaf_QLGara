using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace DXApplication.Module.BusinessObjects.Car
{
    [DefaultClassOptions]
   
    public class Car : BaseObject
    { 
        public Car(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        Customer _customer;

        public Customer Customer
        {
            get { return _customer; }
            set { SetPropertyValue(nameof(Customer), ref _customer, value); }
        }
       
        private string _loaiXe;

        public string LoaiXe
        {
            get { return _loaiXe; }
            set { SetPropertyValue(nameof(LoaiXe), ref _loaiXe, value); }
        }
        private string _kieuXe;

        public string KieuXe
        {
            get { return _kieuXe; }
            set { SetPropertyValue(nameof(KieuXe), ref _kieuXe, value); }
        }
        private string _mauSon;

        public string MauSon
        {
            get { return _mauSon; }
            set { SetPropertyValue(nameof(MauSon), ref _mauSon, value); }
        }
        private int _doiXe;

        public int DoiXe
        {
            get { return _doiXe; }
            set { SetPropertyValue(nameof(DoiXe), ref _doiXe, value); }
        }
        private string _bienSo;

        public string BienSo
        {
            get { return _bienSo; }
            set { SetPropertyValue(nameof(BienSo), ref _bienSo, value); }
        }







    }
}