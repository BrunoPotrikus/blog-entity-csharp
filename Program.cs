using BlogEntity.Data;
using BlogEntity.Models;

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

        }
    }
}