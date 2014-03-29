﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/_Paging.cshtml")]
    public partial class Paging : System.Web.Mvc.WebViewPage<Ilaro.Admin.ViewModels.PagerInfo>
    {

#line 95 "..\..\Views\IlaroAdmin\_Paging.cshtml"
public System.Web.WebPages.HelperResult PagerLink(string linkText, int pageNumber, string url, string rel = "", string @classes = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 96 "..\..\Views\IlaroAdmin\_Paging.cshtml"
 
    url = string.Format(url, pageNumber);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 3015), Tuple.Create("\"", 3031)

#line 98 "..\..\Views\IlaroAdmin\_Paging.cshtml"
, Tuple.Create(Tuple.Create("", 3023), Tuple.Create<System.Object, System.Int32>(classes

#line default
#line hidden
, 3023), false)
);

WriteLiteralTo(__razor_helper_writer, "><a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 3035), Tuple.Create("\"", 3046)

#line 98 "..\..\Views\IlaroAdmin\_Paging.cshtml"
, Tuple.Create(Tuple.Create("", 3042), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 3042), false)
);

WriteAttributeTo(__razor_helper_writer, "rel", Tuple.Create(" rel=\"", 3047), Tuple.Create("\"", 3057)

#line 98 "..\..\Views\IlaroAdmin\_Paging.cshtml"
, Tuple.Create(Tuple.Create("", 3053), Tuple.Create<System.Object, System.Int32>(rel

#line default
#line hidden
, 3053), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 98 "..\..\Views\IlaroAdmin\_Paging.cshtml"
                     WriteTo(__razor_helper_writer, linkText);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></li>\r\n");


#line 99 "..\..\Views\IlaroAdmin\_Paging.cshtml"


#line default
#line hidden
});

#line 99 "..\..\Views\IlaroAdmin\_Paging.cshtml"
}
#line default
#line hidden

        public Paging()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\IlaroAdmin\_Paging.cshtml"
 if (Model.TotalPages <= 1)
{
    return;
}

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\IlaroAdmin\_Paging.cshtml"
  var nrOfPagesToDisplay = 10;
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n    <ul>\r\n");

            
            #line 18 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\IlaroAdmin\_Paging.cshtml"
          
            // Make some calculation
            var start = 1;
            var end = Model.TotalPages;
            
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\IlaroAdmin\_Paging.cshtml"
             if (Model.TotalPages > nrOfPagesToDisplay)
            {
                var middle = (int)Math.Ceiling(nrOfPagesToDisplay / 2d) - 1;
                var below = (Model.Current - middle);
                var above = (Model.Current + middle);

                if (below < 4)
                {
                    above = nrOfPagesToDisplay;
                    below = 1;
                }
                else if (above > (Model.TotalPages - 4))
                {
                    above = Model.TotalPages;
                    below = (Model.TotalPages - nrOfPagesToDisplay);
                }

                start = below;
                end = above;
            }
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\IlaroAdmin\_Paging.cshtml"
             
        
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        ");

WriteLiteral("\r\n");

            
            #line 45 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\IlaroAdmin\_Paging.cshtml"
         if (Model.Current > 1)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 47 "..\..\Views\IlaroAdmin\_Paging.cshtml"
             Write(PagerLink("«", Model.Current - 1, Model.Url, "prev"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 48 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        }
        else
        { 

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"disabled\"");

WriteLiteral("><span>«</span></li>\r\n");

            
            #line 52 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        ");

WriteLiteral("\r\n");

            
            #line 55 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        
            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\IlaroAdmin\_Paging.cshtml"
         if (start > 3)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 57 "..\..\Views\IlaroAdmin\_Paging.cshtml"
             Write(PagerLink("1", 1, Model.Url));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 58 "..\..\Views\IlaroAdmin\_Paging.cshtml"
             Write(PagerLink("2", 2, Model.Url));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            <li");

WriteLiteral(" class=\"disabled\"");

WriteLiteral("><span>...</span></li>\r\n");

            
            #line 60 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        }

        
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\IlaroAdmin\_Paging.cshtml"
                          

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 63 "..\..\Views\IlaroAdmin\_Paging.cshtml"
         for (var i = start; i <= end; i++)
        {
            if (i == Model.Current || (Model.Current <= 0 && i == 0))
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 67 "..\..\Views\IlaroAdmin\_Paging.cshtml"
                 Write(PagerLink(i.ToString(), i, Model.Url, "", "active"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 68 "..\..\Views\IlaroAdmin\_Paging.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 71 "..\..\Views\IlaroAdmin\_Paging.cshtml"
                 Write(PagerLink(i.ToString(), i, Model.Url));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 72 "..\..\Views\IlaroAdmin\_Paging.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        ");

WriteLiteral("\r\n");

            
            #line 76 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\IlaroAdmin\_Paging.cshtml"
         if (end < (Model.TotalPages - 3))
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"disabled\"");

WriteLiteral("><span>...</span></li>\r\n");

WriteLiteral("            ");

            
            #line 79 "..\..\Views\IlaroAdmin\_Paging.cshtml"
             Write(PagerLink((Model.TotalPages - 1).ToString(), Model.TotalPages - 1, Model.Url));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 80 "..\..\Views\IlaroAdmin\_Paging.cshtml"
             Write(PagerLink(Model.TotalPages.ToString(), Model.TotalPages, Model.Url));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 81 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        }

        
            
            #line default
            #line hidden
            
            #line 83 "..\..\Views\IlaroAdmin\_Paging.cshtml"
                       

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 84 "..\..\Views\IlaroAdmin\_Paging.cshtml"
         if (Model.Current < Model.TotalPages)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 86 "..\..\Views\IlaroAdmin\_Paging.cshtml"
             Write(PagerLink("»", Model.Current + 1, Model.Url, "next"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 87 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        }
        else
        { 

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"disabled\"");

WriteLiteral("><span>»</span></li>\r\n");

            
            #line 91 "..\..\Views\IlaroAdmin\_Paging.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
