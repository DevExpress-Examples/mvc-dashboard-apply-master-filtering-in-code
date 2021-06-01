<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/MvcDashboard_SetMasterFilter/Controllers/HomeController.cs)
* [Global.asax.cs](./CS/MvcDashboard_SetMasterFilter/Global.asax.cs)
* [MasterFiltering.js](./CS/MvcDashboard_SetMasterFilter/Scripts/MasterFiltering.js)
* [Index.cshtml](./CS/MvcDashboard_SetMasterFilter/Views/Home/Index.cshtml)
* [_Layout.cshtml](./CS/MvcDashboard_SetMasterFilter/Views/Shared/_Layout.cshtml)
<!-- default file list end -->

# ASP.NET MVC Dashboard - How to: Apply Master Filter in Code


This example demonstrates how to apply a master filter in the [ASP.NET MVC Dashboard](https://docs.devexpress.com/Dashboard/16977) on the [client side](https://docs.devexpress.com/Dashboard/116302) 

In this example, the [ASPxClientDashboard.SetMasterFilter](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_ASPxClientDashboard_SetMasterFilter_itemName_values_) method selects rows in the [Grid](https://docs.devexpress.com/Dashboard/117161/) dashboard item while the [ASPxClientDashboard.SetRange](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_ASPxClientDashboard_SetRange_itemName_range_)  method selects the range in the [Range Filter](https://docs.devexpress.com/Dashboard/117168/) dashboard item. These methods are called in the Button's  [onClick](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxButton/Configuration/#onClick) event handler.



