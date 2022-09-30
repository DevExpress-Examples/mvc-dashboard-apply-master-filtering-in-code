<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579079/21.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T490955)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

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
- [Dashboard for MVC - How to Apply Master Filter on the Client](https://github.com/DevExpress-Examples/mvc-dashboard-apply-master-filtering-in-code)