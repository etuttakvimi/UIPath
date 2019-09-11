#pragma checksum "/Users/muratvuranok/Desktop/UIPath/Views/Students/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc2dca9550e859ff6be85c83896147bb97bbd098"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UIPath.Models.Students.Views_Students_List), @"mvc.1.0.view", @"/Views/Students/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/List.cshtml", typeof(UIPath.Models.Students.Views_Students_List))]
namespace UIPath.Models.Students
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2dca9550e859ff6be85c83896147bb97bbd098", @"/Views/Students/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a33e199e0293895cae26f96bb7e43f54127debf", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 590, true);
            WriteLiteral(@"<div class=""row mb-5"">
    <div class=""col d-flex justify-content-start"">
        <a href=""/Students/Index"" class=""btn btn-outline-info   mr-2""><i class=""fa fa-list""></i> Kayıtlı Öğrenciler</a>
    </div>
    <div class=""col d-flex justify-content-end"">
        <a href=""/Students/Create"" class=""btn btn-outline-success   mr-2""><i class=""fa fa-pencil""></i> Yeni Ekle</a>
    </div>
</div>
<div class=""row"">
    <div class=""col"">
        <table class=""table"" id=""example"">
            <thead>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</div>

");
            EndContext();
            DefineSection("js", async() => {
                BeginContext(602, 4660, true);
                WriteLiteral(@"


<script src=""https://code.jquery.com/jquery-3.4.1.min.js""  integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="" crossorigin=""anonymous""></script>
<script src=""https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.16/js/dataTables.bootstrap4.min.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.1/js/dataTables.buttons.min.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.1/js/buttons.flash.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.32/pdfmake.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.32/vfs_fonts.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.1/js/buttons.html5.min.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.1/js/buttons.print.min.js""></script>

<script>
    $(document).ready(function () {
       ");
                WriteLiteral(@" $(""#example"").DataTable({
            ajax: {
                url: '/Students/_List',
                dataSrc: '',
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                type: 'GET'
            },
            columns: [
                { ""title"": ""Adı"", data: ""Adi"" },
                { ""title"": ""Soyadı"", data: ""Soyadi"" },
                { ""title"": ""TCKN"", data: ""TCKN"" },
                { ""title"": ""Telefon"", data: ""Telefon"" },
                { ""title"": ""Mail"", data: ""Mail"" },
                { ""title"": ""Seans"", data: ""Seans"" },
                { ""title"": ""Zümre"", data: ""Brans"" },
                { ""title"": ""Başlangıç"", data: ""StartDate"" },
                { ""title"": ""Bitiş"", data: ""EndDate"" },
                {
                    ""title"": ""Öğrenci"", ""mRender"": function (data, type, row) {
                        var css = """";
                        if (row.IsStudent == true) {
                            css = ""success"";
                        }");
                WriteLiteral(@"
                        else {
                            css = ""danger"";
                        }
                        return ""<a href='#' class='disabled btn-sm btn btn-outline-"" + css + ""'> <i class='fa fa-user'><i/> </a>"";
                    }
                },
                {
                    ""title"": ""#"", ""mRender"": function (data, type, row) {

                        var template = `
 <div class=""dropdown"">
  <button class=""btn-sm btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
   <i class=""fa fa-cogs""> </i>
  </button>
  <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
 
    <a data-id='`+ row.ID + `' class=""dropdown-item edit"" href=""/Students/Edit/`+ row.ID + `""><i class=""fa fa-pencil""></i> &nbsp; Düzenle</a> 
    <a data-id='`+ row.ID + `' class=""dropdown-item delete"" href=""#""><i class=""fa fa-trash""></i> &nbsp; Sil</a> 
  </div>
</div>
`

                        return template;
");
                WriteLiteral(@"                    }
                }
            ],
            dom: 'Bfrtip',
            ""iDisplayLength"": 5,
            buttons: [
                {
                    extend: 'copyHtml5',
                    exportOptions: {
                        columns: [0, ':visible']
                    }
                },
                {
                    extend: 'excelHtml5',
                    exportOptions: {
                        columns: ':visible'
                    }
                },
                {
                    extend: 'pdfHtml5'

                }
            ]
        });

        $(""#example"").removeClass().addClass(""table table-hover mt-3"");
        $("".dt-button"").removeClass().addClass(""btn btn-outline-secondary"");
    })
</script>


<script>
    $(document).on(""click"", "".delete"", function () { 
        var id = $(this).data(""id"");
        $.ajax({
            url: ""/Students/_Remove/"" + id,
            dataType: ""json"",
            type: ""post"",
            success: function ");
                WriteLiteral(@"(result) {
                var table = $(""#example"").DataTable();
                table.ajax.reload();
            }
        })
    })
</script>
 
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""   integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1""   crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""  integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM""   crossorigin=""anonymous""></script>
 ");
                EndContext();
            }
            );
            BeginContext(5264, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(5278, 208, true);
                WriteLiteral("\n<link href=\"https://cdn.datatables.net/1.10.16/css/dataTables.bootstrap4.min.css\" rel=\"stylesheet\" />\n<link href=\"https://cdn.datatables.net/buttons/1.5.1/css/buttons.dataTables.min.css\" rel=\"stylesheet\" />\n");
                EndContext();
            }
            );
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
