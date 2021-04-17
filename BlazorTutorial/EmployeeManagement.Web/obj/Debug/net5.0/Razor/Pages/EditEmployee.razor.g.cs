#pragma checksum "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea24b8fb70897f4c8cd0db4af3ee7d8561da5d52"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using PragimTech.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                  Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<h3>Edit Employee</h3>\n    <hr>\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group row");
                __builder2.AddMarkupContent(6, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\n            First Name\n        </label>\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "id", "firstName");
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "placeholder", "First Name");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group row");
                __builder2.AddMarkupContent(19, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\n            Last Name\n        </label>\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "lastName");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "placeholder", "Last Name");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group row");
                __builder2.AddMarkupContent(32, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\n            Email\n        </label>\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "id", "email");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "placeholder", "Email");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group row");
                __builder2.AddMarkupContent(45, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\n            Department\n        </label>\n\n        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-sm-10");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateCustomInputSelect_0(__builder2, 48, 49, "department", 50, "form-control", 51, 
#nullable restore
#line 41 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                                            Employee.DepartmentId

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.DepartmentId = __value, Employee.DepartmentId)), 53, () => Employee.DepartmentId, 54, (__builder3) => {
#nullable restore
#line 42 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                 foreach (var dept in Departments)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(55, "option");
                    __builder3.AddAttribute(56, "value", 
#nullable restore
#line 44 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    dept.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(57, 
#nullable restore
#line 44 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                                        dept.DepartmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 45 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n    ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group row");
                __builder2.AddMarkupContent(61, "<label for=\"gender\" class=\"col-sm-2 col-form-label\">\n            Gender\n        </label>\n\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col-sm-10");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateInputSelect_1(__builder2, 64, 65, 
#nullable restore
#line 55 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                      Employee.Gender

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Gender = __value, Employee.Gender)), 67, () => Employee.Gender, 68, (__builder3) => {
#nullable restore
#line 56 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                 foreach (var gender in Enum.GetValues(typeof(Gender)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(69, "option");
                    __builder3.AddAttribute(70, "value", 
#nullable restore
#line 58 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                    gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(71, 
#nullable restore
#line 58 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                             gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 59 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n    ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group row");
                __builder2.AddMarkupContent(75, "<label for=\"dateOfBirth\" class=\"col-sm-2\" col-form-label\">\n        Date of Birth\n    </label>\n    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-sm-10");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateInputDate_2(__builder2, 78, 79, "form-control", 80, 
#nullable restore
#line 68 "C:\Dev\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                               Employee.DateOfBrith

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.DateOfBrith = __value, Employee.DateOfBrith)), 82, () => Employee.DateOfBrith);
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.EmployeeManagement.Web.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::PragimTech.Components.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
