#pragma checksum "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\ListEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "053cf19277b5eb76afc9f6258f5f3f499c5a7913"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ListEmployees), @"mvc.1.0.view", @"/Views/Employee/ListEmployees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"053cf19277b5eb76afc9f6258f5f3f499c5a7913", @"/Views/Employee/ListEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2110cd27d8939d717276b40bc632c0f27945b210", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ListEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Exam.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-2"">
    <a type=""button"" class=""btn btn-success"" href=""/Employee/Create"">Create</a>
    </div>
</div>

<div class=""table-responsive"" >
    <table class=""table table-bordered table-hover"" width=""100%"" cellspacing=""0"">
        <thead>
            <tr>
                <th>ID</th>
                <th>EmployeeName</th>
                <th>Department</th>
                <th>Salary</th>
            </tr>
        </thead>
");
#nullable restore
#line 19 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\ListEmployees.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\ListEmployees.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\ListEmployees.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\ListEmployees.cshtml"
                   Write(item.Department.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\ListEmployees.cshtml"
                   Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 29 "C:\Users\ASUS\OneDrive\Desktop\Exam\Views\Employee\ListEmployees.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Exam.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
