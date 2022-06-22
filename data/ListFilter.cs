using AvaKids_188269.Models.Data;
public class ListFilter
{
    public List<FilterProducts> product()
    {
        return new List<FilterProducts>(){
            new FilterProducts(){
               id="a1",
               filter=new List<string>(){
                "Hãng","Loại"
               },
               popular=new List<string>(){
                "Đồ chơi bé trai","Đồ chơi bé gái","Đồ chơi điều khiển","Đồ chơi sơ sinh","Đồ chơi lắp ráp","Đồ chơi nhà tắm","Đồ chơi nhập vai","Đồ chơi vận động","Đồ chơi học tập"
               },
               imgPopular=new List<string>(){
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-053019.png",
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-053214.png",
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-053503.png",
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-053659.png",
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-053812.png",
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-054002.png",
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-054011.png",
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-054110.png",
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-054215.png",
                @"https://cdn.tgdd.vn/Category/Quicklink/10421/17\130522-054303.png",
               },
            },
        };
    }
}