using System;
using System.Collections.Generic;

namespace AvaKids_188269.Models.Data
{
    public class FilterQuery
    {
        public string NameFilter {get;set;}
        public string FilterValue { get; set; }
        public int ArrayValueAmount { get; set; }
        public string Order { get; set; }
        public string Price { get; set; }

        public FilterQuery()
        {
            this.FilterValue = "";
            this.Price = "";
            this.Order = "";
            this.NameFilter="";
            this.ArrayValueAmount = 0;
        }
    }
}