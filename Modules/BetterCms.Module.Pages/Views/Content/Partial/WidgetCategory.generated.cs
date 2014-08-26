﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Pages.Views.Content.Partial
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
    
    #line 1 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
    using BetterCms.Core.DataContracts.Enums;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
    using BetterCms.Module.Pages.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/Partial/WidgetCategory.cshtml")]
    public partial class WidgetCategory : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Widgets.WidgetCategoryViewModel>
    {
        public WidgetCategory()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"bcms-category bcms-content-sliders\"");

WriteLiteral(">           \r\n    <div");

WriteLiteral(" class=\"bcms-category-titles\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                 Write(Model.CategoryName);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    <div");

WriteLiteral(" class=\"bcms-slider-box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-slides-container\"");

WriteLiteral(">\r\n");

            
            #line 15 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
             if (Model.Widgets != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("<div class=\"bcms-slides-single-slide\">\r\n");

            
            #line 18 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                
                for (int i = 0; i < Model.Widgets.Count; i++)
                {
                    var widget = Model.Widgets[i];
                    
                    if (i % 3 == 0 && i != 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("</div>\r\n");

WriteLiteral("                        ");

WriteLiteral("<div class=\"bcms-slides-single-slide\">\r\n");

            
            #line 27 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                    }


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"bcms-preview-block\"");

WriteLiteral(" \r\n                         data-id=\"");

            
            #line 30 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                             Write(widget.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("                          \r\n                         data-original-id=\"");

            
            #line 31 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                      Write(widget.OriginalId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("                          \r\n                         data-version=\"");

            
            #line 32 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                  Write(widget.Version);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("       \r\n                         data-original-version=\"");

            
            #line 33 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                           Write(widget.OriginalVersion);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("       \r\n                         data-type=\"");

            
            #line 34 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                               Write(widget.WidgetType);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                         data-category-id=\"");

            
            #line 35 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                       Write(widget.CategoryId ?? Guid.Empty);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"bcms-title-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                                        Write(widget.Name);

            
            #line default
            #line hidden
WriteLiteral("</div>                                                 \r\n                        " +
"</div>\r\n");

            
            #line 39 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                         if (!string.IsNullOrWhiteSpace(widget.PreviewImageUrl))
                        {
                            
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                       Write(Html.PreviewContentBox(widget.PreviewImageUrl, widget.PreviewImageUrl, widget.Name, true));

            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                                                                                                      
                        }
                        else
                        {
                            var url1 = Html.BuildUrlFromExpression<WidgetsController>(f => f.PreviewWidget(widget.Id.ToString(), false));
                            var url2 = Html.BuildUrlFromExpression<WidgetsController>(f => f.PreviewWidget(widget.Id.ToString(), true));
                            
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                       Write(Html.PreviewContentBox(url1, url2, widget.Name));

            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                                                            
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"bcms-controls-holder\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"bcms-btn-small bcms-content-insert-button\"");

WriteLiteral(" >");

            
            #line 51 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                                                               Write(PagesGlobalization.AddPageContent_WidgetTab_InsertButton);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 52 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                             if ((ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.Administration))
                            {
                                if (!widget.Status.Equals(ContentStatus.Published.ToString()))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" class=\"bcms-icn-edit bcms-content-edit-button bcms-edit-draft\"");

WriteLiteral(">");

            
            #line 56 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                                                                                 Write(PagesGlobalization.AddPageContent_WidgetTab_EditButton);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 57 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" class=\"bcms-icn-edit bcms-content-edit-button\"");

WriteLiteral(">");

            
            #line 60 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                                                                 Write(PagesGlobalization.AddPageContent_WidgetTab_EditButton);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 61 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteLiteral(" class=\"bcms-icn-delete bcms-content-delete-button\"");

WriteLiteral(">");

            
            #line 62 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                                                                                 Write(PagesGlobalization.AddPageContent_WidgetTab_DeleteButton);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 63 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n                    </div>\r\n");

            
            #line 66 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
                }
                

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("</div>\r\n");

            
            #line 69 "..\..\Views\Content\Partial\WidgetCategory.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591