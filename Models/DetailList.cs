namespace AvaKids_188269.Models
{
    public class DetailList
    {
        public string Name {get; set;}
        public List<ItemDescription> Description {get;set;}
        public DetailList(){
            this.Name="";
            this.Description=new List<ItemDescription>(){};
        }
    }
}