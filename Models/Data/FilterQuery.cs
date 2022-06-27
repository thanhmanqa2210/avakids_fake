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
        public decimal Page { get; set; }
        public decimal totalPages { get; set; }


        public FilterQuery()
        {
            this.FilterValue = "";
            this.Order = "";
            this.NameFilter="";
            this.ArrayValueAmount = 0;
            this.Page = 0;
            this.totalPages = 0;

        }
    }
}