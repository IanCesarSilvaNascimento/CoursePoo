using CoursePoo.ContentContext.Enums;

namespace CoursePoo.ContentContext
{
    public class Course : Content 
    {
        public Course(string title, string url)
            :base(title,url)
        {
            Modules = new List<Module>();            
        }
        public int Tag { get; set; }
        
        public int DurationInMinute { get; set; }

        public EContentLevel Level { get; set; }
        public IList<Module> Modules { get; set; }
    }

    

  
}