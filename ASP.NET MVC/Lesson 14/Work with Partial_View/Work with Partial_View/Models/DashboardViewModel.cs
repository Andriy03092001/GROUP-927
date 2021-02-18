using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Work_with_Partial_View.Models
{
    public class DashboardViewModel
    {
        
        public List<ProductViewModel> Products { get; set; }
        public List<OrderViewModel> Orders { get; set; }

        public DashboardViewModel()
        {
            Products = new List<ProductViewModel>();
            Orders = new List<OrderViewModel>();
        }

        public void InitList()
        {

            //Orders:
            Orders.Add(new OrderViewModel()
            {
                Address = "Rivne Soborna 16",
                CountProducts = 2,
                FullName = "Andrii Riabii Sergiyovich",
                Id = 1,
                NameProduct = "Samsung 21",
                Price = 40000
            });

            Orders.Add(new OrderViewModel()
            {
                Address = "Rivne Gabrilivska 16",
                CountProducts = 1,
                FullName = "Oksentiuk Dmitro Igorovich",
                Id = 2,
                NameProduct = "IPhone 11",
                Price = 24000
            });

            Orders.Add(new OrderViewModel()
            {
                Address = "Lviv Centralna 12",
                CountProducts = 10,
                FullName = "Ivanov Sergiy Oleksiyovich",
                Id = 3,
                NameProduct = "IPhone 12 Pro Max",
                Price = 450000
            });


            //Products:
            Products.Add(new ProductViewModel()
            {
                Id = 1,
                Name = "IPhone 12 Pro Max",
                Price = 40000,
                Image = "https://i.citrus.ua/imgcache/size_500/uploads/shop/d/2/d21fc7834096ee92025677dcd757bb81.jpg"
            });

            Products.Add(new ProductViewModel()
            {
                Id = 2,
                Name = "Samsung Galaxy S21",
                Price = 28000,
                Image = "https://i.citrus.ua/imgcache/size_500/uploads/shop/d/f/df9eb2bface7288e651936227d11403a.jpg"
            });

            Products.Add(new ProductViewModel()
            {
                Id = 3,
                Name = "Iphone 11",
                Price = 24000,
                Image = "https://estore.ua/media/catalog/product/cache/8/image/650x650/9df78eab33525d08d6e5fb8d27136e95/i/p/iphone11-white-select1-2019_2.jpeg"
            });

            Products.Add(new ProductViewModel()
            {
                Id = 4,
                Name = "Samsung Galaxy S21 Ultra",
                Price = 31000,
                Image = "https://i.allo.ua/media/catalog/product/cache/1/image/600x415/602f0fa2c1f0d1ba5e241f914e856ff9/s/m/sm-g990_g991_s21_phantom_violet_back_201110f.jpg"
            });




        }

    }
}