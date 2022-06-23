namespace AvaKids_188269.Models.Pagination
{
    public class Pagination
    {
        public int countPages { get; set; } = 1;
        public int currentPage { get; set; } = 1;
        public Func<int?, string> generateUrl { get; set; } = (int? p) => "page=" + p;

    }
}