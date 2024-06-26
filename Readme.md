<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/MvcDashboard_SetMasterFilter/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcDashboard_SetMasterFilter/Controllers/HomeController.vb))
* [Global.asax.cs](./CS/MvcDashboard_SetMasterFilter/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_SetMasterFilter/Global.asax.vb))
* [MasterFiltering.js](./CS/MvcDashboard_SetMasterFilter/Scripts/MasterFiltering.js) (VB: [MasterFiltering.js](./VB/MvcDashboard_SetMasterFilter/Scripts/MasterFiltering.js))
* [Index.cshtml](./CS/MvcDashboard_SetMasterFilter/Views/Home/Index.cshtml)
* [_Layout.cshtml](./CS/MvcDashboard_SetMasterFilter/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# ASP.NET MVC Dashboard - How to apply master filtering in code


<p>The following example demonstrates how to apply master filtering in the <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument16977">ASP.NET MVC Dashboard</a> on the client side.</p>
<p><br>In this example, the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboard_SetMasterFiltertopic">ASPxClientDashboard.SetMasterFilter</a> method is used to select required rows in the <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument117161">Grid</a> dashboard item while the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboard_SetRangetopic">ASPxClientDashboard.SetRange</a> method is called to select the required range in the <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument117168">Range Filter</a> dashboard item. These methods are called in the <a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxButton/Configuration/#onClick">onClick</a> event handler of the dxButton.</p>

<br/>


