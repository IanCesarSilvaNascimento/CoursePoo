using System;
using CoursePoo.ContentContext;

namespace CoursePoo
{
    public class Program
    {
        static void Main(String[] args)
        {
            var articles = new List<Article>();
            
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));
            
            
            foreach(var article in articles )
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                
            }

            var courses = new List<Course>();
            var courseOop = new Course("fundamentos de OOP", "fundamentos");

            var courseCsharp = new Course("fundamentos de C#", "fundamentos");
            
            var courseDotnet = new Course("fundamentos de asp.net", "fundamentos");

            courses.Add(courseOop);
            
            courses.Add(courseCsharp);

            courses.Add(courseDotnet);


            var careers = new List<Career>();

            var careerDotnet = new Career("Especialista .Net", "especialista-dotnet");

            var careerItem = new CareerItem(1,"Comece por aqui","",courseOop);

            var careerItem2 = new CareerItem(2,"Aprenda Csharp","",courseCsharp);

            var careerItem3 = new CareerItem(3,"Aprenda .NET","",courseDotnet);

            careerDotnet.Items.Add(careerItem);
            
            careerDotnet.Items.Add(careerItem2);
            
            careerDotnet.Items.Add(careerItem3);

            careers.Add(careerDotnet);
            
            foreach(var career in careers)
            {
                Console.WriteLine(career.Title);
                    foreach(var item in career.Items.OrderBy(x=> x.Order))
                    {
                        Console.WriteLine($"{item.Order} - {item.Title}");
                        Console.WriteLine(item.Course.Title);    
                        Console.WriteLine(item.Course.Level);        
                    }
            }


        }
    }
}