#pragma checksum "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8290284c6e82f39e64617c7431fd37817348c6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
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
#line 1 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\_ViewImports.cshtml"
using Exam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\_ViewImports.cshtml"
using Exam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8290284c6e82f39e64617c7431fd37817348c6f", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2110cd27d8939d717276b40bc632c0f27945b210", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<h2>Create</h2>\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Member</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 15 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 17 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 19 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
       Write(Html.LabelFor(model => model.DepartmentId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
           Write(Html.DropDownListFor(model => model.DepartmentId, ViewBag.DepartmentId as SelectList, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.DepartmentId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 35 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
       Write(Html.LabelFor(model => model.Salary, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 37 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
           Write(Html.EditorFor(model => model.Salary, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 38 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Salary, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>


        
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
               
            </div>
        </div>
    </div>
");
#nullable restore
#line 51 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 54 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\Create.cshtml"
Write(Html.ActionLink("Back to List", "ListEmployees"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591