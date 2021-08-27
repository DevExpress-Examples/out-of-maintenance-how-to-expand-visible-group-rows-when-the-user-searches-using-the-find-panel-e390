<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628644/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3903)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainForm.cs](./CS/FindPanelExample/MainForm.cs) (VB: [MainForm.vb](./VB/FindPanelExample/MainForm.vb))
<!-- default file list end -->
# How to expand visible group rows when the user searches using the Find Panel


<p>This example demonstrates how to immediately show to the user found data when rows might be collapsed in groups. The straightforward approach to implement this feature is to handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseBaseView_RowCountChangedtopic"><u>GridView.RowCountChanged</u></a> event, and expand all records via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_ExpandAllGroupstopic"><u>GridView.ExpandAllGroups</u></a> method.</p><p>Sometimes, found data might contain a lot of rows, and expanding all rows can take a while. In this specific case, use the solution demonstrated in this example.</p>


<h3>Description</h3>

<p>Starting from version 11 vol 2, DevExpress WinForms controls no longer support Visual Studio 2005 and .NET Framework 2.0 and 3.0: <a href="http://www.devexpress.com/Support/WhatsNew/DXperience/files/11.2.5.bc.xml#BC-FW"><u>For WinForms and ASP.NET Controls</u></a>.</p>

<br/>


