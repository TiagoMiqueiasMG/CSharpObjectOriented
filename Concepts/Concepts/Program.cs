using System;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace MeuPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .Net", "dotnet"));


            // foreach(var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();
            var courseOOP = new Course ("Fundamentos OOP", "fundamentos - oop");
            var courseCsharp = new Course ("Fundamentos C#", "fundamentos - csharp");
            var courseAspNet = new Course ("Fundamentos ASP.NET", "fundamentos - aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            
            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(3, "Aprenda .Net", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);
            
            foreach(var carrer in careers){
                Console.WriteLine(carrer.Title);
                // Usaremos o Order para ordenação de listas
                foreach(var item in carrer.Items.OrderBy(x => x.Order)){
                    Console.WriteLine($"{item.Order}-{item.Title}");                    
                    Console.WriteLine(item.Course?.Level);
                    Console.WriteLine(item.Course?.Title);

                    foreach(var notification in item.Notifications){
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }   

                var PayPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(PayPalSubscription);
            }

        }
    }

}

    



