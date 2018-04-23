# How to expand visible group rows when the user searches using the Find Panel


<p>This example demonstrates how to immediately show to the user found data when rows might be collapsed in groups. The straightforward approach to implement this feature is to handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseBaseView_RowCountChangedtopic"><u>GridView.RowCountChanged</u></a> event, and expand all records via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_ExpandAllGroupstopic"><u>GridView.ExpandAllGroups</u></a> method.</p><p>Sometimes, found data might contain a lot of rows, and expanding all rows can take a while. In this specific case, use the solution demonstrated in this example.</p>

<br/>


