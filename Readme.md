
# Dashboard for MVC - How to Apply Master Filter on the Client

This example shows how to apply a master filter in the [ASP.NET MVC Dashboard](https://docs.devexpress.com/Dashboard/16977) on the client.

![Web Dashboard - Apply Master Filtering values](images/master-filtering-example.png)

- The [ViewerApiExtension.setMasterFilter](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.ViewerApiExtension?p=netframework#js_devexpress_dashboard_viewerapiextension_setmasterfilter_itemname_values_) method call applies the Master Filter values to the Grid item.
- The [ViewerApiExtension.setRange](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.ViewerApiExtension#js_devexpress_dashboard_viewerapiextension_setrange_itemname_range_) method call applies the range to the Range Filter item.

The [dxButton](https://js.devexpress.com/DevExtreme/ApiReference/UI_Components/dxButton/)'s `onClick` event handler calls these methods.

## Files to Review

* [MasterFiltering.js](./CS/MVCxDashboard_ApplyMasterFilter/Scripts/MasterFiltering.js) (VB: [MasterFiltering.js](./VB/MVCxDashboard_ApplyMasterFilter/Scripts/MasterFiltering.js))
* [Index.cshtml](./CS/MVCxDashboard_ApplyMasterFilter/Views/Home/Index.cshtml) (VB: [Index.vbhtml](./VB/MVCxDashboard_ApplyMasterFilter/Views/Home/Index.vbhtml))
* [_rootLayout.cshtml](./CS/MVCxDashboard_ApplyMasterFilter/Views/Shared/_rootLayout.cshtml) (VB: [_rootLayout.vbhtml](./VB/MVCxDashboard_ApplyMasterFilter/Views/Shared/_rootLayout.vbhtml)

## Documentation

- [Interactivity in the Web Dashboard](https://docs.devexpress.com/Dashboard/116985/web-dashboard/create-dashboards-on-the-web/interactivity?p=netframework)

## More Examples

- [Dashboard for Web Forms - How to apply Master Filtering in OLAP mode](https://github.com/DevExpress-Examples/web-forms-dashboard-apply-master-filtering-in-olap)
- [Dashboard for Web Forms - How to Apply Master Filter on the Client](https://github.com/DevExpress-Examples/asp-net-web-forms-dashboard-apply-master-filter-in-code)
- [Dashboard for Web Forms - How to Drill-Down on the Client](https://github.com/DevExpress-Examples/asp-net-web-forms-dashboard-perform-drill-down-in-code)
- [Dashboard for MVC - How to Drill-Down on the Client](https://github.com/DevExpress-Examples/mvc-dashboard-drill-down-in-code)
