namespace AvaKids_188269.Models.Data
{
    public class Search : DetailsModel
    {
        public string _priceOld { get; set; }
        public string _priceNew { get; set; }
        public Search(){
            this._priceOld = "";
            this._priceNew="";
        }

    }
}