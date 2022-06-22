using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AvaKids_188269.Models;
using System.Linq;
using AvaKids_188269.Models.Data;
namespace AvaKids_188269.Controllers
{
    public class LayoutController : Controller
    {
        private readonly ILogger<LayoutController> _logger;
        public LayoutController(ILogger<LayoutController> logger)
        {
            _logger = logger;
        }
        public IActionResult Header()
        {
            return View();
        }

        public IActionResult Footer()
        {
            return View();
        }
        public IActionResult Commitments()
        {
            return View();
        }
        public List<DetailsModel> List()
        {
            var list = new List<DetailsModel>() {
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
                new DetailsModel(){
                    ID=8,Title="Kẹo mút hữu cơ Yumearth 4 vị trái cây gói 241g",
                    Price_old=220000,Price_percent=10,Product_code="#236611",
                    PromotionDate="30/06",
                    imgs=new List<string>{
                        "https://cdn.tgdd.vn/Products/Images/2687/236611/keo-mut-huu-co-4-huong-vi-trai-cay-yumearth-goi-241g-1.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
                    },
                    DetailsInfo=new List<DetailList>(){}
                },
                 new DetailsModel(){
                    ID=9,Title="Khăn tắm sợi tre KACHOOBABY 1,2 mét màu ngẫu nhiên",
                    Price_old=158000,Price_percent=20,Product_code="#279960",
                    PromotionDate="30/06",
                    imgs=new List<string>{
                        "https://cdn.tgdd.vn/Products/Images/11056/279960/kha%CC%86nta%CC%86%CC%81mso%CC%9B%CC%A3itrekachoobaby12me%CC%81t-1.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
                    },
                    DetailsInfo=new List<DetailList>(){}
                },
                 new DetailsModel(){
                    ID=10,Title="Khăn tắm sợi tre KACHOOBABY 1 mét màu ngẫu nhiên",
                    Price_old=109000,Price_percent=20,Product_code="#279959",
                    PromotionDate="30/06",
                    imgs=new List<string>{
                        "https://cdn.tgdd.vn/Products/Images/11056/279959/kha%CC%86nta%CC%86%CC%81mso%CC%9B%CC%A3itrekachoobaby1me%CC%81t-1.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
                    },
                    DetailsInfo=new List<DetailList>(){}
                },
                 new DetailsModel(){
                    ID=11,Title="Đồng hồ Trẻ em Q&Q VQ94J024Y",
                    Price_old=490000,Price_percent=1,Product_code="#213775",
                    PromotionDate="30/06",
                    imgs=new List<string>{
                        "https://cdn.tgdd.vn/Products/Images/7264/213775/q-q-vq94j024y-nam-2-3.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
                    },
                    DetailsInfo=new List<DetailList>(){}
                },
                new DetailsModel(){
                    ID=12,Title="Thùng 48 hộp sữa pha sẵn Optimum Gold 110 ml",
                    Price_old=427000,Price_percent=20,Product_code="#86067",
                    PromotionDate="30/06",
                    imgs=new List<string>{
                        "https://cdn.tgdd.vn/Products/Images/9080/86067/thung-48-hop-sua-uong-dinh-duong-optimum-gold-hop-110ml-4.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-1.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-2.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-3.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-4.jpg",
                        "https://cdn.tgdd.vn/Products/Images/10421/258905/do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-5.jpg"
                    },
                    DetailsInfo=new List<DetailList>(){}
                }
             };
            return list;
        }
        public List<Search> ListAll()
        {
            var ListProduct = new List<Search>() { };
            foreach (var i in List())
            {
                ListProduct.Add(
                    new Search()
                    {
                        ID = i.ID,
                        Title = i.Title,
                        _priceOld = $"{i.priceOld()}",
                        _priceNew = $"{i.priceNew()}",
                        imgs = i.imgs,
                        Price_percent = i.Price_percent,
                        Product_code = i.Product_code,
                        PromotionDate = i.PromotionDate,
                        DetailsInfo = new List<DetailList>() { }
                    }
                );
            }
            return ListProduct;
        }
        public JsonResult Data(string searchString = "")
        {
            Console.WriteLine(searchString);
            var value = from search in ListAll()
                        where search.Title.ToLower().IndexOf(searchString.ToLower()) >= 0
                        select search;
            return Json(value);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}