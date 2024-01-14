using System;
using Balta.ContentContext;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {

      var articles = new List<Article>();
      articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
      articles.Add(new Article("Artigo sobre Java", "java"));
      articles.Add(new Article("Artigo sobre C#", "csharp"));

      // foreach (var article in articles)
      // {
      //   Console.WriteLine(article.Id);
      //   Console.WriteLine(article.Title);
      //   Console.WriteLine(article.Url);
      // }

      var courses = new List<Course>();
      var courseOOP = new Course("Fundamentos OOP", "fudamentos-oop");
      var courseCsharp = new Course("Fundamentos Csharp", "fudamentos-oop");
      var courseAspNet = new Course("Fundamentos OOP", "fudamentos-oop");

      courses.Add(courseOOP);
      courses.Add(courseCsharp);
      courses.Add(courseAspNet);

      var carrers = new List<Carrer>();
      var carrerDotNet = new Carrer("Especialista .NET", "especialista-dotnet");
      var carrerItem1 = new CarrerItem(1, "Comece por aqui", "O inicio", courseOOP);
      var carrerItem2 = new CarrerItem(2, "Proximo passo", "Avançando no .NET", courseCsharp);
      var carrerItem3 = new CarrerItem(3, "Indo além", "Avançando com ASP .NET", null);
      carrerDotNet.Items.Add(carrerItem3);
      carrerDotNet.Items.Add(carrerItem2);
      carrerDotNet.Items.Add(carrerItem1);
      carrers.Add(carrerDotNet);

      foreach (var carrer in carrers)
      {
        Console.WriteLine(carrer.Title);
        foreach (var item in carrer.Items.OrderBy(x => x.Ordem))
        {
          Console.WriteLine($"{item.Ordem}-{item.Title}");
          Console.WriteLine($"{item.Course?.Title}-{item.Course?.Level}");
          foreach (var notification in item.Notifications)
          {
            Console.WriteLine($"{notification.Property}-{notification.Message}");
          }
        }

      }
    }
  }
}