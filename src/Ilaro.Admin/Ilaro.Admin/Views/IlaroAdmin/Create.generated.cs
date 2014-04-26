﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ilaro.Admin.Views.IlaroAdmin
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin.Commons.Paging;
    using Ilaro.Admin.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/Create.cshtml")]
    public partial class Create : System.Web.Mvc.WebViewPage<Ilaro.Admin.ViewModels.CreateViewModel>
    {
        public Create()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\IlaroAdmin\Create.cshtml"
  
	Layout = "~/Views/IlaroAdmin/_Layout.cshtml";
	ViewBag.Title = string.Format(Resources.IlaroAdminResources.Create_Title, Model.Entity.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Breadcrumb", () => {

WriteLiteral("\r\n\t<ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n\t\t<li>");

            
            #line 11 "..\..\Views\IlaroAdmin\Create.cshtml"
 Write(Html.ActionLink(Resources.IlaroAdminResources.Index_Title, "Index"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\t\t<li>");

            
            #line 12 "..\..\Views\IlaroAdmin\Create.cshtml"
 Write(Html.ActionLink(Model.Entity.GroupName, "Group", new { groupName = Model.Entity.GroupName }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\t\t<li>");

            
            #line 13 "..\..\Views\IlaroAdmin\Create.cshtml"
 Write(Html.ActionLink(Model.Entity.Plural, "Details", new { entityName = Model.Entity.Name }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\t\t<li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\IlaroAdmin\Create.cshtml"
                Write(string.Format(Resources.IlaroAdminResources.Create_Title, Model.Entity.Name));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\t</ul>\r\n");

});

WriteLiteral("\r\n<h2>");

            
            #line 18 "..\..\Views\IlaroAdmin\Create.cshtml"
Write(Model.Entity.Singular);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\r\n");

            
            #line 20 "..\..\Views\IlaroAdmin\Create.cshtml"
 using (Html.BeginForm("Create", "IlaroAdmin", FormMethod.Post, new { enctype = "multipart/form-data", @class = "form-horizontal", role = "form" }))
{
	
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\IlaroAdmin\Create.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\IlaroAdmin\Create.cshtml"
                         
	
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\IlaroAdmin\Create.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\IlaroAdmin\Create.cshtml"
                              

	if (Model.PropertiesGroups.Count > 1)
	{
		foreach (var group in Model.PropertiesGroups)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<fieldset>\r\n\t\t\t\t<legend>");

            
            #line 30 "..\..\Views\IlaroAdmin\Create.cshtml"
       Write(group.GroupName);

            
            #line default
            #line hidden
WriteLiteral(" <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn pull-right\"");

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 1096), Tuple.Create("\"", 1207)
            
            #line 30 "..\..\Views\IlaroAdmin\Create.cshtml"
    , Tuple.Create(Tuple.Create("", 1104), Tuple.Create<System.Object, System.Int32>(Html.Condition(group.IsCollapsed, () => "glyphicon glyphicon-plus", () => "glyphicon glyphicon-minus")
            
            #line default
            #line hidden
, 1104), false)
);

WriteLiteral("></i></button></legend>\r\n\t\t\t\t<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1241), Tuple.Create("\"", 1304)
, Tuple.Create(Tuple.Create("", 1249), Tuple.Create("fields", 1249), true)
            
            #line 31 "..\..\Views\IlaroAdmin\Create.cshtml"
, Tuple.Create(Tuple.Create(" ", 1255), Tuple.Create<System.Object, System.Int32>(Html.Condition(group.IsCollapsed, () => "hide")
            
            #line default
            #line hidden
, 1256), false)
);

WriteLiteral(">\r\n");

            
            #line 32 "..\..\Views\IlaroAdmin\Create.cshtml"
					
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\IlaroAdmin\Create.cshtml"
      foreach (var property in group.Properties)
					{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t\t\t\t");

            
            #line 35 "..\..\Views\IlaroAdmin\Create.cshtml"
  Write(Html.EditorFor(m => property, property.EditorTemplateName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 36 "..\..\Views\IlaroAdmin\Create.cshtml"
							
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\IlaroAdmin\Create.cshtml"
        if (property.IsForeignKey)
							{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t\t<button");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" type=\"button\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></span></button>\r\n");

            
            #line 39 "..\..\Views\IlaroAdmin\Create.cshtml"
							}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t</div>\r\n");

            
            #line 41 "..\..\Views\IlaroAdmin\Create.cshtml"
					}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</fieldset>\r\n");

            
            #line 44 "..\..\Views\IlaroAdmin\Create.cshtml"
		}
	}
	else if (Model.PropertiesGroups.Count == 1)
	{
		foreach (var property in Model.PropertiesGroups[0].Properties)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 51 "..\..\Views\IlaroAdmin\Create.cshtml"
Write(Html.EditorFor(m => property, property.EditorTemplateName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 52 "..\..\Views\IlaroAdmin\Create.cshtml"
				
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\IlaroAdmin\Create.cshtml"
     if (property.IsForeignKey)
				{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<button");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" type=\"button\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></span></button>\r\n");

            
            #line 55 "..\..\Views\IlaroAdmin\Create.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t</div>\r\n");

            
            #line 57 "..\..\Views\IlaroAdmin\Create.cshtml"
		}
	}

	
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\IlaroAdmin\Create.cshtml"
Write(Html.Hidden("EntityName", Model.Entity.Name));

            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\IlaroAdmin\Create.cshtml"
                                              


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"form-action\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"col-md-offset-2\"");

WriteLiteral(">\r\n\t\t\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 64 "..\..\Views\IlaroAdmin\Create.cshtml"
                                            Write(Resources.IlaroAdminResources.Save);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\t\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" name=\"ContinueEdit\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral("></i> ");

            
            #line 65 "..\..\Views\IlaroAdmin\Create.cshtml"
                                                                                                         Write(Resources.IlaroAdminResources.SaveAndContinueEdit);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\t\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" name=\"AddNext\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></i> ");

            
            #line 66 "..\..\Views\IlaroAdmin\Create.cshtml"
                                                                                                    Write(Resources.IlaroAdminResources.SaveAndAddNext);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 2627), Tuple.Create("\"", 2696)
            
            #line 67 "..\..\Views\IlaroAdmin\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2634), Tuple.Create<System.Object, System.Int32>(Url.Action("Details", new { entityName = Model.Entity.Name })
            
            #line default
            #line hidden
, 2634), false)
);

WriteLiteral(" class=\"btn btn-link\"");

WriteLiteral(">");

            
            #line 67 "..\..\Views\IlaroAdmin\Create.cshtml"
                                                                                            Write(Resources.IlaroAdminResources.Cancel);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\t\t</div>\r\n\t</div>\r\n");

            
            #line 70 "..\..\Views\IlaroAdmin\Create.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
