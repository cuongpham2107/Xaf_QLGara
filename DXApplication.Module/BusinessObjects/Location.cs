using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DXApplication.Module.BusinessObjects
{
    [DefaultClassOptions]
  
    public class Location : BaseObject
    { 
        public Location(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
           
        }
        private string tieuDe;
        [XafDisplayName("Tieu de")]
        public string TieuDe
        {
            get
            {
                return tieuDe;
            }
            set { SetPropertyValue(nameof(TieuDe), ref tieuDe, value); }
        }
        private string toaDo;
        [XafDisplayName("Toạ độ")]
        [Size(SizeAttribute.Unlimited)]
        public string ToaDo
        {
            get 
            {
                if (!IsLoading && !IsSaving)
                {
                    if (LatLong != null)
                    {
                        return LatLong;
                    }
                }
                return null;
            }
            set { SetPropertyValue(nameof(ToaDo), ref toaDo, value); }
        }
       

        string latLong;
        [XafDisplayName("Vị trí")]
        [ModelDefault("PropertyEditorType", "DXApplication.Blazor.Server.Editors.CustomStringPropertyEditor")]
        [Size(SizeAttribute.Unlimited)]
        public string LatLong 
        { 
            get => latLong;
            set => SetPropertyValue(nameof(LatLong), ref latLong, value); 
        }
    }
}