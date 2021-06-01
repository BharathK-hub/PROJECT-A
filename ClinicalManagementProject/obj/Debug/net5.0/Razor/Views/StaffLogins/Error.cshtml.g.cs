#pragma checksum "C:\Users\Admin\source\repos\Evaluation\ClinicalManagementProject\Views\StaffLogins\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ca3c1effebc87860e7b207bd6ae1fc405d2b1e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StaffLogins_Error), @"mvc.1.0.view", @"/Views/StaffLogins/Error.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\Evaluation\ClinicalManagementProject\Views\_ViewImports.cshtml"
using ClinicalManagementProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\Evaluation\ClinicalManagementProject\Views\_ViewImports.cshtml"
using ClinicalManagementProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ca3c1effebc87860e7b207bd6ae1fc405d2b1e1", @"/Views/StaffLogins/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40dc8212ad252e6880853f9c7afc66386c9aba1", @"/Views/_ViewImports.cshtml")]
    public class Views_StaffLogins_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicalManagementProject.Models.StaffLogin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\Evaluation\ClinicalManagementProject\Views\StaffLogins\Error.cshtml"
  
    Layout = "~/Views/Shared/LayoutOut.cshtml";
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<svg width=""380px"" height=""500px"" viewBox=""0 0 837 1045"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" xmlns:sketch=""http://www.bohemiancoding.com/sketch/ns"">
    <g id=""Page-1"" stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"" sketch:type=""MSPage"">
        <path d=""M353,9 L626.664028,170 L626.664028,487 L353,642 L79.3359724,487 L79.3359724,170 L353,9 Z"" id=""Polygon-1"" stroke=""#007FB2"" stroke-width=""6"" sketch:type=""MSShapeGroup""></path>
        <path d=""M78.5,529 L147,569.186414 L147,648.311216 L78.5,687 L10,648.311216 L10,569.186414 L78.5,529 Z"" id=""Polygon-2"" stroke=""#EF4A5B"" stroke-width=""6"" sketch:type=""MSShapeGroup""></path>
        <path d=""M773,186 L827,217.538705 L827,279.636651 L773,310 L719,279.636651 L719,217.538705 L773,186 Z"" id=""Polygon-3"" stroke=""#795D9C"" stroke-width=""6"" sketch:type=""MSShapeGroup""></path>
        <path d=""M639,529 L773,607.846761 L773,763.091627 L639,839 L505,763.091627 L505,607.846761 L639,529 Z"" id=""Polygon-4"" ");
            WriteLiteral(@"stroke=""#F2773F"" stroke-width=""6"" sketch:type=""MSShapeGroup""></path>
        <path d=""M281,801 L383,861.025276 L383,979.21169 L281,1037 L179,979.21169 L179,861.025276 L281,801 Z"" id=""Polygon-5"" stroke=""#36B455"" stroke-width=""6"" sketch:type=""MSShapeGroup""></path>
    </g>
</svg>
<div class=""message-box"">
    <h3>LOGIN FAILED :(</h3>
    <b><p>UserName and Password mismatch!</p></b>
    <div class=""buttons-con"">
        <div class=""action-link-wrap"">
            <h5>Please try again!</h5>
            <a href=""http://localhost:39242/"" class=""link-button"">Go to Login Page</a>
        </div>
    </div>
</div>
<style>
    body {
        background-color: #2F3242;
    }

    svg {
        position: absolute;
        top: 50%;
        left: 50%;
        margin-top: -250px;
        margin-left: -400px;
    }

    .message-box {
        height: 200px;
        width: 380px;
        position: absolute;
        top: 50%;
        left: 50%;
        margin-top: -100px;
        margin-left: ");
            WriteLiteral(@"50px;
        color: #FFF;
        font-family: Roboto;
        font-weight: 300;
    }

        .message-box h1 {
            font-size: 60px;
            line-height: 46px;
            margin-bottom: 40px;
        }

    .buttons-con .action-link-wrap {
        margin-top: 40px;
    }

        .buttons-con .action-link-wrap a {
            background: #68c950;
            padding: 8px 25px;
            border-radius: 4px;
            color: #FFF;
            font-weight: bold;
            font-size: 14px;
            transition: all 0.3s linear;
            cursor: pointer;
            text-decoration: none;
            margin-right: 10px
        }

            .buttons-con .action-link-wrap a:hover {
                background: #5A5C6C;
                color: #fff;
            }

    #Polygon-1, #Polygon-2, #Polygon-3, #Polygon-4, #Polygon-4, #Polygon-5 {
        animation: float 1s infinite ease-in-out alternate;
    }

    #Polygon-2 {
        animation-delay: .2s;
            WriteLiteral("\n    }\r\n\r\n    #Polygon-3 {\r\n        animation-delay: .4s;\r\n    }\r\n\r\n    #Polygon-4 {\r\n        animation-delay: .6s;\r\n    }\r\n\r\n    #Polygon-5 {\r\n        animation-delay: .8s;\r\n    }\r\n\r\n    ");
            WriteLiteral("@keyframes float {\r\n        100% {\r\n            transform: translateY(20px);\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@media (max-width: 450px) {
        svg {
            position: absolute;
            top: 50%;
            left: 50%;
            margin-top: -250px;
            margin-left: -190px;
        }

        .message-box {
            top: 50%;
            left: 50%;
            margin-top: -100px;
            margin-left: -190px;
            text-align: center;
        }
    }
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicalManagementProject.Models.StaffLogin> Html { get; private set; }
    }
}
#pragma warning restore 1591