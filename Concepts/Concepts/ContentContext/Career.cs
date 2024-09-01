namespace Balta.ContentContext
{
    public class Career : Content
    {

        public Career(string tile, string url)
            : base (tile, url)
        
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }

        // Using Expression Body
        public int TotalCourses => Items.Count;
        // {
        //     get{
        //         return Items.Count;
        //     }
        // }
    }  

}

