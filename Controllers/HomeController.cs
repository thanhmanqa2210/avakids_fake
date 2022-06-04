using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AvaKids_188269.Models;


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
            // else{
            //     model.Details =   new DetailsModel(){ ID = 1, Title = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)", Price_old = 1399000, Price_percent = 29, Product_code = "#258922", PromotionDate = "31/5", DetailsInfo = new List<DetailList>() { } };
            // }
        }

        model.Details.DetailsInfo = new List<DetailList>() {
            new DetailList() { Name = "Thương hiệu", Description =new ItemDescription(){
            ListDs = new List<string>() { "Lego (Đan Mạch)" }
            } },
            new DetailList() { Name = "Loại", Description =new ItemDescription(){
              ListDs  =  new List<string>(){"Đồ chơi bé trai","Đồ chơi lắp ráp"}
               } },
            new DetailList() { Name = "Độ tuổi", Description =new ItemDescription(){
              ListDs  =  new List<string>(){"Từ 5 tuổi trở lên"}
               } },
            new DetailList() { Name = "Chất liệu", Description =new ItemDescription(){
              ListDs  =  new List<string>(){"Nhựa"}
               } },
            new DetailList() { Name = "Kích thước hộp", Description =new ItemDescription(){
              ListDs  =  new List<string>(){"38x26x6 cm"}
               } },
            new DetailList() { Name = "Trọng lượng", Description =new ItemDescription(){
              ListDs  =  new List<string>(){"724 g"}
               } },
            new DetailList() { Name = "Lưu ý khi sử dụng", Description =new ItemDescription(){
              ListDs  =  new List<string>(){"Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai"}
               } },
            new DetailList() { Name = "Nơi sản xuất", Description =new ItemDescription(){
              ListDs  =  new List<string>(){"Trung Quốc"}
               } },

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
