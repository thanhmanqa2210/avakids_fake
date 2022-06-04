namespace AvaKids_188269.Models
{
    public class ItemDescription
    {
        public List<string> ListDs=new List<string>(){};
        public ItemDescription(){
        this.ListDs=new List<string>(){};
        }
        public int quantity(){
            return ListDs.Count();
        }
    }
}