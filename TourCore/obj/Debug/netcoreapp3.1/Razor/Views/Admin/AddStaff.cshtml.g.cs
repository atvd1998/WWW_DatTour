#pragma checksum "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\AddStaff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ac7c249589cdf4e19749be7ab2730200e6b700c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddStaff), @"mvc.1.0.view", @"/Views/Admin/AddStaff.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ac7c249589cdf4e19749be7ab2730200e6b700c", @"/Views/Admin/AddStaff.cshtml")]
    public class Views_Admin_AddStaff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\AddStaff.cshtml"
  
    ViewData["Title"] = "AddStaff";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    input[type=submit] {
        font-size: 20px;
    }
    input[type=date]
    {
        font-size:20px;
    }

    input {
        width: 50%;
        height: 50px;
        border-radius: 2px;
    }
    select{
        font-size:20px;
    }
</style>
");
#nullable restore
#line 24 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\AddStaff.cshtml"
 using (Html.BeginForm("AddStaff", "Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <div class=""col-3"">
        <label style=""font-size:20px"">Tên nhân viên </label>
    </div>
    <div class=""col-6"">
        <input type=""text"" name=""Name"" />
    </div>
    <br />
    <div>
        <label style=""font-size:20px"">Địa chỉ</label>
    </div>
    <div>
        <input type=""text"" name=""Address"" />
    </div>
    <br />
    <div>
        <label style=""font-size:20px"">Ngày sinh</label>
    </div>
    <div>
        <input type=""date"" name=""DOB"" />
    </div>
    <br />
    <div>
        <label style=""font-size:20px"">Số điện thoại</label>
    </div>
    <div>
        <input type=""number"" name=""Phone"" />
    </div>
    <br />
    <br />
    <div>
        <label style=""font-size:20px"">Chọn giới tính</label>
        <select name=""Gender"">
            <option value=""true"">Nam</option>
            <option value=""false"">Nữ</option>
        </select>
    </div>
    <br />
    <br />
    <div>
        <input type=""submit"" value=""Lưu thông tin"" class=""btn btn-su");
            WriteLiteral("ccess\" />\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 69 "D:\Desktop\TourCore\TourCore\TourCore\TourCore\Views\Admin\AddStaff.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
