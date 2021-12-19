# CoursePoo
 Teste fundamentos de POO
 
## Program.cs
Contém o método principal para inicializar o algoritmo. 

#ContentContext
 As classes Base e Content são abstracts e não podem ser instanciadas.As demais classes formam o contexto de conteúdo: Lectures, Modules, Articles, Course, CareerItem e Career. 
 
#NotificationContext
 Contém classes incompletas para notificações ao usuário.
 
##Base.cs
 Construtor de ID global
```Code
 using System;

 using CoursePoo.NotificationContext;    

 namespace CoursePoo.ContentContext
 {

     public abstract class Base : Notifiable
     {   
         public Base()
         {
             Id = Guid.NewGuid();
         }

         public Guid Id { get; set; }
     }
 }
```
##ContentContext.cs
 Construtor de Title e Url além de herdar atributos da Base.cs
```Code
 namespace CoursePoo.ContentContext
{
    public abstract class Content : Base
    {

        public Content(string title, string url)
        {
           
            Title = title;
            Url = url;
        }
   
        public string? Title { get; set; }

        public string? Url { get; set; }

    }
}
```

##Article.cs
 Construtor recebe parâmetros herdados de Content.cs
```Code
   
namespace CoursePoo.ContentContext
{
    public class Article : Content 
    {
        public Article(string title, string url)
             :base(title, url)
        {
            
        }

    }
}
```
##Module.cs
  Possui atributos Int Order, String Title e Lista Lectures. Construtor incializa objeto Lectures.  
```Code
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
```

## Utilização
Para utilizar a aplicação simplesmente use o comando dentro do diretório no terminal:

```bash
dotnet run
```

## Contribuição

Dicas sobre organização de código e melhoras de perfomance são bem vindas, porém pull request's não serão analisados.O objetivo deste conteúdo é treinar e aplicar alguns fundamentos da POO. 


