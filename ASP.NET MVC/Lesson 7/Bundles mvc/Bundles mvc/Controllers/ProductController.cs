using Bundles_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bundles_mvc.Controllers
{
    public class ProductController : Controller
    {
        List<ProductViewModel> listProducts;
        public ProductController()
        {
            listProducts = new List<ProductViewModel>();
            listProducts.Add(new ProductViewModel
            {
                Name = "IPhone XR",
                Image = "https://cdn.comfy.ua/media/catalog/product/cache/4/image/1440x1080/62defc7f46f3fbfc8afcd112227d1181/a/p/apple_iphone_xr_black_07_2.jpg",
                Price = 600
            });

            listProducts.Add(new ProductViewModel
            {
                Name = "IPhone X Max Pro",
                Price = 1000,
                Image = "https://store.storeimages.cdn-apple.com/8756/as-images.apple.com/is/iphone-12-pro-max-gold-hero?wid=940&hei=1112&fmt=png-alpha&qlt=80&.v=1604021660000"
            });

            listProducts.Add(new ProductViewModel
            {
                Name = "IPhone XS",
                Price = 700,
                Image = "https://sintetiki.net/images/product/19473/593/Apple-iphone-xs-max-black.png"
            });

            listProducts.Add(new ProductViewModel
            {
                Name = "IPhone X",
                Price = 500,
                Image = "https://ilounge.ua/files/products/apple-iphone-x-64gb-used-silver-2.1000x.jpg"
            });

            listProducts.Add(new ProductViewModel
            {
                Name = "IPhone 12",
                Price = 1200,
                Image = "https://i.citrus.ua/imgcache/size_500/uploads/shop/2/1/21c6dc6eebbbbdf5a291e66367f81acc.jpg"
            });

            listProducts.Add(new ProductViewModel
            {
                Name = "IPhone 12 mini",
                Price = 800,
                Image = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/iphone-12-mini-blue-select-2020?wid=470&hei=556&fmt=jpeg&qlt=95&op_usm=0.5,0.5&.v=1604343706000"
            });
        }


        public ActionResult Index()
        {
            return View(listProducts);
        }
    }
}