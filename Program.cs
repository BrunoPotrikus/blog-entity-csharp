using BlogEntity.Data;
using BlogEntity.Models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        using(var context = new BlogDataContext())
        {
            //Create (INSERT)
            //var tag = new Tag { Name="ASP.NET", Slug="aspnet" };
            //context.Tags.Add(tag);
            //context.SaveChanges();

            //UPDATE
            //var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
            //tag.Name = ".NET";
            //tag.Slug = "dotnet";
            //context.Update(tag);
            //context.SaveChanges();

            //DELETE
            //var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
            //context.Remove(tag);
            //context.SaveChanges();

            //Read (SELECT)
            var tags = context.Tags.AsNoTracking().ToList();

            foreach(var tag in tags)
            {
                Console.WriteLine(tag.Name);
            }

            //Leitura (SELECT) de dados recomendado usar AsNoTracking
            // UPDATE e DELETE nunca usar AsNoTracking

            var tag1 = context
                        .Tags
                        .AsNoTracking()
                        .FirstOrDefault(x => x.Id == 5);

            Console.WriteLine(tag1?.Name);
        }
    }
}