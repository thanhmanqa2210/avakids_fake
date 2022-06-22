namespace AvaKids_188269.Models.Data
{
    public class Products
    {
        public int ID { get; set; }
        public string HangSp { get; set; }
        public string priceSp { get; set; }
        public List<string> LoaiSp { get; set; }
            public string Size { get; set; }
        public string CN { get; set; }
        public string DoNgot { get; set; }
        public string HuongVi { get; set; }
        public string DongGoi { get; set; }
        public string CongDung { get; set; }
        public string LoaiTC { get; set; }
        public Products()
        {
            this.HangSp = "";
            this.priceSp = "";
            this.CongDung = "";
            this.CN = "";
            this.DoNgot = "";
            this.HuongVi = "";
            this.DongGoi = "";
            this.Size = "";
            this.LoaiTC = "";
            this.LoaiSp= new List<string>(){};
        }

    }
}