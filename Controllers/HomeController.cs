using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AvaKids_188269.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using AvaKids_188269.data;
using AvaKids_188269.Models.Data;


namespace AvaKids_188269.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {

        return View();
    }
    public List<DetailsModel> productList()
    {
        return new List<DetailsModel>(){
            new DetailsModel(){ID=1,
            Title="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
            Price_old=1399000,Price_percent=29,Product_code="#258922",
            PromotionDate="31/05",DetailsInfo=new List<DetailList>(){},
             imgs=new List<string>{
                 "https://cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-8.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-4.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258922/do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg"
            }},

            new DetailsModel(){ID=2,
            Title="Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
            Price_old=1399000,Price_percent=29,Product_code="#258927",
            PromotionDate="31/05",DetailsInfo=new List<DetailList>(){},
            imgs=new List<string>{
                 "https://cdn.tgdd.vn/Products/Images/10421/258927/do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-1.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258927/do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-2.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258927/do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-3.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258927/do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-4.jpg",
                 "https://cdn.tgdd.vn/Products/Images/10421/258927/do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-9.jpg"
            }},

            new DetailsModel(){ID=3,
            Title="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
            Price_old=1349000,Price_percent=26,Product_code="#258905",
            PromotionDate="31/05",DetailsInfo=new List<DetailList>(){},
             imgs=new List<string>{
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
            }},

            new DetailsModel(){ID=4,
            Title="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
            Price_old=1319000,Price_percent=24,Product_code="#258959",
            PromotionDate="31/05",DetailsInfo=new List<DetailList>(){},
             imgs=new List<string>{
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
            }
            },

            new DetailsModel(){ID=5,
            Title="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
            Price_old=1299000,Price_percent=20,Product_code="#258981",
            PromotionDate="31/05",DetailsInfo=new List<DetailList>(){},
             imgs=new List<string>{
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
            }},

            new DetailsModel(){ID=6,
            Title="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
            Price_old=1299000,Price_percent=22,Product_code="#258978",
            PromotionDate="31/05",DetailsInfo=new List<DetailList>(){},
             imgs=new List<string>{
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
            }},

            new DetailsModel(){ID=7,
            Title="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
            Price_old=1269000,Price_percent=21,Product_code="#258963",
            PromotionDate="31/05",DetailsInfo=new List<DetailList>(){},
             imgs=new List<string>{
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
            }},
            };
    }
    public IActionResult ProductDetails(decimal id)
    {

        CollectionDataModel model = new CollectionDataModel();
        foreach (var p in productList())
        {
            if (id == p.ID)
            {
                model.Details = new DetailsModel()
                {
                    ID = p.ID,
                    Title = p.Title,
                    Price_old = p.Price_old,
                    Price_percent = p.Price_percent,
                    Product_code = p.Product_code,
                    PromotionDate = p.PromotionDate,
                    imgs = p.imgs,
                    DetailsInfo = new List<DetailList>() { }
                };
            }
        }

        model.Details.DetailsInfo = new List<DetailList>() {
            new DetailList() { Name = "Thương hiệu", Description =new List<ItemDescription>(){new ItemDescription(){
            ListDs = new List<string>() { "Lego (Đan Mạch)" }
            }} },
            new DetailList() { Name = "Loại", Description =new List<ItemDescription>(){new ItemDescription(){
              ListDs  =  new List<string>(){"Đồ chơi bé trai","Đồ chơi lắp ráp"}
               }} },
            new DetailList() { Name = "Độ tuổi", Description =new List<ItemDescription>(){new ItemDescription(){
              ListDs  =  new List<string>(){"Từ 5 tuổi trở lên"}
               }} },
            new DetailList() { Name = "Chất liệu", Description =new List<ItemDescription>(){new ItemDescription(){
              ListDs  =  new List<string>(){"Nhựa"}
               }} },
            new DetailList() { Name = "Kích thước hộp", Description =new List<ItemDescription>(){new ItemDescription(){
              ListDs  =  new List<string>(){"38x26x6 cm"}
               }} },
            new DetailList() { Name = "Trọng lượng", Description =new List<ItemDescription>(){new ItemDescription(){
              ListDs  =  new List<string>(){"724 g"}
               }} },
            new DetailList() { Name = "Lưu ý khi sử dụng", Description =new List<ItemDescription>(){new ItemDescription(){
              ListDs  =  new List<string>(){"Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai"}
               }} },
            new DetailList() { Name = "Nơi sản xuất", Description =new List<ItemDescription>(){new ItemDescription(){
              ListDs  =  new List<string>(){"Trung Quốc"}
               }} },

            };
        model.Details.Features.SalientFeature = new List<ProductsInfo>() {
            new ProductsInfo(){ProductLink="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308",ProductDescription = "bao gồm 297 chi tiết."},
            new ProductsInfo(){ProductLink="",ProductDescription = "Bé có thể sáng tạo và tưởng tượng câu chuyện của mình."},
            new ProductsInfo(){ProductLink="Đồ chơi lắp ráp",ProductDescription = " giúp rèn luyện tính rỉ mỉ, sáng tạo của bé khi lắp ráp."},
            new ProductsInfo(){ProductLink="Đồ chơi Lego City",ProductDescription = " không có góc nhọn, thành phần độc hại nên an toàn cho bé."},
        };
        model.Details.Tutorials.Tutorial = new List<ProductsInfo>() {
            new ProductsInfo(){ProductLink="Đồ chơi",ProductDescription = " không dùng pin."},
            new ProductsInfo(){ProductLink="",ProductDescription = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."},
            new ProductsInfo(){ProductLink="",ProductDescription = "Có thể sáng tạo theo trí tưởng tượng của bé."},
        };
        model.ProductsOthers = new List<ProductsOtherModel>(){
            new ProductsOtherModel(){ID=2,Title="Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",Price_old=1399000,Price_percent=29,img="https://cdn.tgdd.vn/Products/Images/10421/258927/do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"},
            new ProductsOtherModel(){ID=3,Title="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",Price_old=1349000,Price_percent=26,img="https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"},
            new ProductsOtherModel(){ID=4,Title="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",Price_old=1319000,Price_percent=24,img="https://cdn.tgdd.vn/Products/Images/10421/258959/do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"},
            new ProductsOtherModel(){ID=5,Title="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",Price_old=1299000,Price_percent=20,img="https://cdn.tgdd.vn/Products/Images/10421/258981/do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"},
            new ProductsOtherModel(){ID=6,Title="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",Price_old=1299000,Price_percent=23,img="https://cdn.tgdd.vn/Products/Images/10421/258978/do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"},
            new ProductsOtherModel(){ID=7,Title="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",Price_old=1269000,Price_percent=21,img="https://cdn.tgdd.vn/Products/Images/10421/258963/do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"},
        };
        return View(model);
    }
    public IActionResult Products()
    {
        return View();

    }
    [HttpGet]

    public IActionResult ProductItem(FilterQuery FilterItem)
    {
        var listProducts = new ListProducts();
        var ListData = new List<DetailsModel>();
        var data = from dataItem in listProducts.Products()
                   select dataItem;
        var data1 = from dataItem in listProducts.Products()
                    select dataItem;
        string[] newNameFilter = { };
        string[] newFilterValue = { };
        // int index = 0;
        if (FilterItem.FilterValue != null && FilterItem.NameFilter != null)
        {
            data = from dataItem in listProducts.Products()
                   from x in dataItem.DetailsInfo
                   where x.Name.ToUpper() == ""
                   from y in x.Description
                   from z in y.ListDs
                   where z.ToUpper() == FilterItem.FilterValue.ToUpper()
                   select dataItem;
            newFilterValue = FilterItem.FilterValue.Split(", ");
            newNameFilter = FilterItem.NameFilter.Split(", ");
            // ---------------------------------------------------------------------
            // Một Filter
            if (newNameFilter.Count() == 1)
            {
                if (newFilterValue.Count() <= 1)
                {
                    data = from dataItem in listProducts.Products()
                           from x in dataItem.DetailsInfo
                           where x.Name.ToUpper() == FilterItem.NameFilter.ToUpper()
                           from y in x.Description
                           from z in y.ListDs
                           where z.ToUpper() == FilterItem.FilterValue.ToUpper()
                           select dataItem;
                    ListData = data.ToList();
                }
                else
                {
                    foreach (var item in newFilterValue)
                    {

                        data1 = from dataItem in listProducts.Products()
                                from x in dataItem.DetailsInfo
                                where x.Name.ToUpper() == FilterItem.NameFilter.ToUpper()
                                from y in x.Description
                                from z in y.ListDs
                                where z.ToUpper() == item.ToUpper()
                                select dataItem;
                        foreach (var idata1 in data1.ToList())
                        {
                            ListData.Add(idata1);
                        }
                    }
                }
            }
            // ----------------------------------------------------------------------
            // hơn 1 filterName
            else
            {
                var datax = from dataItem in listProducts.Products()
                            select dataItem;
                var ListVirtual = new List<DetailsModel>();
                var ListVirtualx = new List<DetailsModel>();
                ListVirtualx = datax.ToList();
                foreach (var itemName in newNameFilter)
                {
                    // index += 1;

                    foreach (var itemValue in newFilterValue)
                    {
                        data = from dataItem in ListVirtualx
                               from x in dataItem.DetailsInfo
                               where x.Name.ToUpper() == itemName.ToUpper()
                               from y in x.Description
                               from z in y.ListDs
                               where z.ToUpper() == itemValue.ToUpper()
                               select dataItem;
                        foreach (var idata in data.ToList())
                        {
                            ListVirtual.Add(idata);
                        }
                    }
                    ListVirtualx = ListVirtual;
                    ListVirtual = new List<DetailsModel>();
                    // if (index > 1)
                    // {

                    // }

                }
                foreach (var idata in ListVirtualx)
                {
                    ListData.Add(idata);
                }
            }

        }
        else
        {
            ListData = data.ToList();
        }

        Console.WriteLine(ListData.Count);
        var newListData = new List<DetailsModel>();
        if (FilterItem.Order.ToUpper() == "% GIẢM NHIỀU")
        {
            var ListDataVirtual = from item in ListData
                                  orderby item.Price_percent descending
                                  select item;
            newListData = ListDataVirtual.ToList();
        }
        else if (FilterItem.Order.ToUpper() == "GIÁ CAO ĐẾN THẤP")
        {
            var ListDataVirtual = from item in ListData
                                  orderby item.calculate() descending
                                  select item;
            newListData = ListDataVirtual.ToList();
        }
        else if (FilterItem.Order.ToUpper() == "GIÁ THẤP ĐẾN CAO")
        {
            var ListDataVirtual = from item in ListData
                                  orderby item.calculate()
                                  select item;
            newListData = ListDataVirtual.ToList();
        }
        else
        {
            newListData = ListData;
        }
        return PartialView("~/Views/Home/ProductItem.cshtml", newListData);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
