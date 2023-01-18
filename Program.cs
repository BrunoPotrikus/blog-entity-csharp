using BlogEntity.Data;
using BlogEntity.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        using var context = new BlogDataContext();

        //var user = new User
        //{
        //    Name = "Bruno Potrikus",
        //    Slug = "bruno-potrikus",
        //    Email = "bruno@email.com",
        //    Bio = "Estudante Ciência da Computação",
        //    Image = "https://image",
        //    PasswordHash = "passwordhash123"
        //};

        //var category = new Category
        //{
        //    Name = "Backend",
        //    Slug = "backend"
        //};

        //var post = new Post
        //{
        //    Author = user,
        //    Category = category,
        //    Body = "<p>Hello World</p>",
        //    Slug = "estudando-ef-core",
        //    Summary = "Projeto utilizando EF Core",
        //    Title = "Estudando EF Core",
        //    CreateDate = DateTime.Now,
        //    LastUpdateDate = DateTime.Now
        //};

        //context.Posts.Add(post);
        //context.SaveChanges();

        //var posts = context
        //            .Posts
        //            .AsNoTracking()
        //            .Include(x => x.Author)
        //            .Include(x => x.Category)
        //            .OrderBy(x => x.LastUpdateDate)
        //            .ToList();

        //foreach(var post in posts)
        //{
        //    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
        //}

        var post = context
                    .Posts
                    //.AsNoTracking()
                    .Include(x => x.Author)
                    .Include(x => x.Category)
                    .OrderByDescending(x => x.LastUpdateDate)
                    .FirstOrDefault();

        post.Author.Name = "Teste";
        context.Posts.Update(post);
        context.SaveChanges();
    }
}