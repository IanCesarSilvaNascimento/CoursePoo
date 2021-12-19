namespace CoursePoo.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();    
        }
        public int Order { get; set; }

        public String? Title { get; set; }

        public IList<Lecture> Lectures { get; set; }
        
    }
}