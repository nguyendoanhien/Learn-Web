<%@ Page Language="C#" %>
<%@ Register TagPrefix="Sagara" Namespace="Sagara.BreadCrumbs" Assembly="BreadCrumbs" %>
<html>
<head>
	<title>ASP.NET Breadcrumbs</title>
<style type="text/css">
	a {
		color: #0000ff;
	}
</style>
</head> 

<body>
<h1>ASP.NET Breadcrumbs</h1>
<h2>Using C#</h2>

<Sagara:BreadCrumbControl id="breadcrumb" runat="Server" />

<h4>Navigate:</h4>
<ul>
	<li><a href="/">Web site root</a></li>
	<li><a href="/subdir">Sub Directory</a></li>
	<li><a href="/subdir/subsubdir">Sub Sub Directory</a></li>
</ul>

</body>
</html>