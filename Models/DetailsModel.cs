
namespace AvaKids_188269.Models
{
    public class DetailsModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public long Price_old { get; set; }
        public List<string> imgs { get; set; }
        public int Price_percent { get; set; }
        public string Product_code { get; set; }
        public string PromotionDate { get; set; }
        public List<DetailList> DetailsInfo { get; set; }
        public ProductTutorial Tutorials { get; set; }
        public SalientFeatures Features { get; set; }

        public DetailsModel()
        {
            this.ID = 1;
            this.Title = "";
            this.imgs = new List<string>() { };
            this.Price_old = 0;
            this.Price_percent = 0;
            this.Product_code = "";
            this.PromotionDate = "";
            this.DetailsInfo = new List<DetailList>() { };
            this.Tutorials = new ProductTutorial() { };
            this.Features = new SalientFeatures() { };

        }

        public float calculate()
        {
            var price_new = Price_old - (Price_old * Price_percent) / 100;
            return price_new - price_new % 100;
        }
        public string convert(double value)
        {
            int length = value.ToString().Length;
            var string_price = value.ToString();
            int i = length;
            while (i >= 0)
            {
                if (i - 3 > 0)
                {
                    string_price = string_price.Insert(i - 3, ".");
                }
                i = i - 3;
            }
            return string_price;
        }
        public string priceNew()
        {

            return convert(calculate());
        }
        public string priceOld()
        {
            return convert(Price_old);
        }

    }
}
