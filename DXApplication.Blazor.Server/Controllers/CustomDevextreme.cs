using DevExpress.DashboardBlazor;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Dashboards.Blazor.Components;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXApplication.Blazor.Server.Controllers
{
    public class MyController : ViewController<DetailView>
    {
        protected override void OnActivated()
        {
            base.OnActivated();
            View.CustomizeViewItemControl<BlazorDashboardViewerViewItem>(this, CustomizeDashboardViewerViewItem);
        }
        void CustomizeDashboardViewerViewItem(BlazorDashboardViewerViewItem dashboardViewItem)
        {
            if (dashboardViewItem.Control is DxDashboardViewerAdapter adapter)
            {
                adapter.JSCustomizationModel.OnScriptsLoading =
                    EventCallback.Factory.Create<ScriptsLoadingEventArgs>(this, OnScriptsLoading);
            }
        }
        private void OnScriptsLoading(ScriptsLoadingEventArgs args)
        {
            args.Scripts.Remove(ScriptIdentifiers.JQuery);
            args.Scripts.Remove(ScriptIdentifiers.Knockout);
            args.Scripts.Remove(ScriptIdentifiers.DevExtreme);
        }
    }
}
