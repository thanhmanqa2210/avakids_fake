namespace AvaKids_188269.Models.Data
{
    public class FilterProducts
    {
        public string id { get; set; }
        public List<string> filter { get; set; }
        public List<string> popular { get; set; }
        public List<string> imgPopular {get;set;}
        public FilterProducts()
        {
            this.id = "xxx";
            this.filter = new List<string>() { };
            this.popular = new List<string>() { };
            this.imgPopular=new List<string>(){};
        }
    }
}