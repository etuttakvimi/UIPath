#pragma checksum "/Users/muratvuranok/Desktop/UIPath/Views/Groups/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33982298114afbeaeae44a475fb84f9a048580ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UIPath.Models.Groups.Views_Groups_Index), @"mvc.1.0.view", @"/Views/Groups/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Groups/Index.cshtml", typeof(UIPath.Models.Groups.Views_Groups_Index))]
namespace UIPath.Models.Groups
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33982298114afbeaeae44a475fb84f9a048580ea", @"/Views/Groups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a33e199e0293895cae26f96bb7e43f54127debf", @"/Views/_ViewImports.cshtml")]
    public class Views_Groups_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2798, true);
            WriteLiteral(@"<div class=""row mb-5"">

    <div class=""col d-flex justify-content-end"">
        <a href=""/Groups/Create"" class=""btn btn-outline-success   mr-2""><i class=""fa fa-pencil""></i> Yeni Ekle</a>

    </div>
</div>
<div class=""row"">
    <div class=""col"">
        <table class=""table shadow-sm"" id=""example"">
            <thead class=""thead-dark"">
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle""
    aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Zümre</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
          ");
            WriteLiteral(@"  <div class=""modal-body"">
                <div class=""row ml-4"">
                    <div class=""col-3 my-1 mt-1 "">
                        <div class=""custom-control custom-checkbox mr-sm-2"">
                            <input type=""checkbox"" value=""yazilim"" class=""custom-control-input zumre"" id=""yazilim"">
                            <label class=""custom-control-label"" for=""yazilim"">Yazılım</label>
                        </div>
                    </div>
                    <div class=""col-3 my-1 mt-1 "">
                        <div class=""custom-control custom-checkbox mr-sm-2"">
                            <input type=""checkbox"" value=""muhasebe"" class=""custom-control-input zumre"" id=""muhasebe"">
                            <label class=""custom-control-label"" for=""muhasebe"">Muhasebe</label>
                        </div>
                    </div>
                    <div class=""col-3 my-1 mt-1 "">
                        <div class=""custom-control custom-checkbox mr-sm-2"">
                            <input");
            WriteLiteral(@" type=""checkbox"" value=""sistem"" class=""custom-control-input zumre"" id=""sistem"">
                            <label class=""custom-control-label"" for=""sistem"">Sistem</label>
                        </div>
                    </div>
                    <div class=""col-3 my-1 mt-1 "">
                        <div class=""custom-control custom-checkbox mr-sm-2"">
                            <input type=""checkbox"" value=""ofis"" class=""custom-control-input zumre"" id=""ofis"">
                            <label class=""custom-control-label"" for=""ofis"">Ofis</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">

            </div>
        </div>

    </div>
</div>

");
            EndContext();
            DefineSection("js", async() => {
                BeginContext(2810, 4939, true);
                WriteLiteral(@"


<script src=""https://code.jquery.com/jquery-3.4.1.min.js""
    integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="" crossorigin=""anonymous""></script>
<script src=""https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.16/js/dataTables.bootstrap4.min.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.1/js/dataTables.buttons.min.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.1/js/buttons.flash.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.32/pdfmake.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.32/vfs_fonts.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.1/js/buttons.html5.min.js""></script>
<script src=""https://cdn.datatables.net/buttons/1.5.1/js/buttons.print.min.js""></script>
<script src=""/js/colVis.js""></script>
<script>
   ");
                WriteLiteral(@" $(document).ready(function () {
        $(""#example"").DataTable({
            ajax: {
                url: '/Groups/_Index',
                dataSrc: '',
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                type: 'GET'
            },
            columns: [
                { ""title"": ""Grup Adı"", data: ""GroupName"" },
                { ""title"": ""Eğitmen"", data: ""Consultant"" },
                { ""title"": ""Başlangıç Tarihi"", data: ""StartDate"" },
                { ""title"": ""Bitiş Tarihi"", data: ""EndDate"" },
                { ""title"": ""Öğrenci Sayısı"", data: ""StudentsCount"" },
                {
                    ""title"": ""Grup Durumu"", ""mRender"": function (data, type, row) {


                        var cls = """";
                        switch (row.Status) {
                            case 0:
                                 cls = ""fa-check btn btn-success"";
                                break;
                            case 1:
                   ");
                WriteLiteral(@"           cls = ""fa-hourglass btn btn-warning"";
                                break;
                            case 2:
                                cls = ""fa-lock btn btn-danger"";
                                break;
                        }
                        return ""<i class='disabled btn-sm fa "" + cls + ""'></i>"";
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
 
    <a data-id='`+ row.ID + `' class=""dropdown-item edit"" href=""/Groups/Edit/` + row.ID + `""><i class=""fa fa-pencil""></i> &nbsp; Düzenle</a> 
    <a data-id='`+ row.ID + `' class=""dropdown-item edit"" href=""/Students");
                WriteLiteral(@"/List/` + row.ID + `""><i class=""fa fa fa-users""></i> &nbsp; Öğrenciler</a> 
    <a data-id='`+ row.ID + `' class=""dropdown-item delete"" href=""#""><i class=""fa fa-trash""></i> &nbsp; Sil</a> 
  </div>
</div>
`

                        return template;
                    }
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

                },
                'colvis'
            ]
        });

        $(""#example"").removeClass().addClass(""table table-hover mt-3"");
        $("".dt-button"").removeClass().addClass(""btn btn-outline-seco");
                WriteLiteral(@"ndary"");
    })
</script>


<script>
    $(document).on(""click"", "".delete"", function () {
        var id = $(this).data(""id"");
        $.ajax({
            url: ""/Groups/_Remove/"" + id,
            dataType: ""json"",
            type: ""post"",
            success: function (result) {
                var table = $(""#example"").DataTable();
                table.ajax.reload();
            }
        })
    })
</script>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""
    integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1""
    crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""
    integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM""
    crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(7751, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(7765, 289, true);
                WriteLiteral(@"
<link href=""https://cdn.datatables.net/1.10.16/css/dataTables.bootstrap4.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/buttons/1.5.1/css/buttons.dataTables.min.css"" rel=""stylesheet"" />
<style>
    .modal-dialog {
        max-width: 1300px !important;
    }
</style>
");
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
