#pragma checksum "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c71177fabb665a132bd87eac2f06b0e54993b1d"
// <auto-generated/>
#pragma warning disable 1591
namespace PhranksArt.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
using PhranksArt.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
using PhranksArt.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
   foreach (var product in ProductService.GetProducts())
  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "  ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n    \r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 14 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                                                          product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n      ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 16 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                              product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n      ");
            __builder.OpenElement(18, "h6");
            __builder.AddAttribute(19, "class", "card-header-pills");
            __builder.AddContent(20, "Made by ");
            __builder.AddContent(21, 
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                                             product.Maker

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n  ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card-footer");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "small");
            __builder.AddAttribute(29, "class", "text-muted");
            __builder.AddMarkupContent(30, "\r\n      ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                        (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "data-toggle", "modal");
            __builder.AddAttribute(34, "data-target", "#productModal");
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddContent(36, "More Info");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "  ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "modal fade");
            __builder.AddAttribute(44, "id", "productModal");
            __builder.AddAttribute(45, "tabindex", "-1");
            __builder.AddAttribute(46, "role", "dialog");
            __builder.AddAttribute(47, "aria-labelledby", "productTitle");
            __builder.AddAttribute(48, "aria-hidden", "true");
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(52, "role", "document");
            __builder.AddMarkupContent(53, "\r\n      ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-content");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "modal-header");
            __builder.AddMarkupContent(59, "\r\n          ");
            __builder.OpenElement(60, "h5");
            __builder.AddAttribute(61, "class", "modal-title");
            __builder.AddAttribute(62, "id", "productTitle");
            __builder.AddContent(63, 
#nullable restore
#line 34 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                                                     selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n          ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "type", "button");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                                          (e => Stop(selectedProduct.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "class", "close");
            __builder.AddAttribute(69, "data-dismiss", "modal");
            __builder.AddAttribute(70, "aria-label", "Close");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.AddMarkupContent(72, "<span aria-hidden=\"true\">&times;</span>\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "modal-body");
            __builder.AddMarkupContent(77, "\r\n          ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "card");
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "id", 
#nullable restore
#line 41 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                      selectedProduct.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(83, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 41 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                                                                          selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddAttribute(84, "class", "card-img");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "modal-footer");
            __builder.AddMarkupContent(90, "\r\n          ");
            __builder.OpenElement(91, "small");
            __builder.AddAttribute(92, "class", "text-muted");
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                              (e => Start(selectedProduct.Id, selectedProduct.ThreeDObject))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "class", "btn btn-primary");
            __builder.AddContent(97, "View in 3D");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
           if (voteCount == 0)
          {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "            ");
            __builder.AddMarkupContent(101, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
          }
          else
          {

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "            ");
            __builder.OpenElement(103, "span");
            __builder.AddContent(104, 
#nullable restore
#line 54 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                   voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(105, " ");
            __builder.AddContent(106, 
#nullable restore
#line 54 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                              voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 55 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
           for (int i = 1; i < 6; i++)
          {
            var currentStar = i;
            if (i <= currentRating)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "              ");
            __builder.OpenElement(109, "span");
            __builder.AddAttribute(110, "class", "fa fa-star checked");
            __builder.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                                                         (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 62 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "              ");
            __builder.OpenElement(114, "span");
            __builder.AddAttribute(115, "class", "fa fa-star");
            __builder.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
                                                 (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 66 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
            }
          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 72 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(123, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Computer_Science\WebApps\ASP.NET\PhranksArt\PhranksArt\Components\ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    void initializeModal()
    {
      selectedProduct = ProductService.GetProducts().First(x => x.Id == x.Id);

    }
    void SelectProduct(string productId)
    {
      
      selectedProductId = productId;
      selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
      GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
      if (selectedProduct.Ratings == null)
      {
        currentRating = 0;
        voteCount = 0;
      }
      else
      {
        voteCount = selectedProduct.Ratings.Count();
        voteLabel = voteCount > 1 ? "Votes" : "Vote";
        currentRating = selectedProduct.Ratings.Sum() / voteCount;
      }

      System.Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
      System.Console.WriteLine($"Rating received for {selectedProduct.Id}: {rating}");
      ProductService.AddRating(selectedProductId, rating);
      SelectProduct(selectedProductId);
    }

    public async Task Start(string id, string link)
    {
      await JSRuntime.InvokeVoidAsync("ThreeJSFunctions.load",id, link);
    }
    public async Task Stop(string id)
    {
      await JSRuntime.InvokeVoidAsync("ThreeJSFunctions.stop", id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
