using Domain.Models;
using Infrastructure.Services;

var brand = new Category();
brand.Id = 1;
brand.Name = "Brand";
brand.CreatedAt = new DateTime(2020, 12, 28);


var post1 = new Post()
{
    Id = 1,
    Title = "Nike",
    CategoryId = 1,
    CreatedAt = new DateTime(2022, 8, 14)
};
var post2 = new Post()
{
    Id = 2,
    Title = "Adidas",
    CategoryId = 1,
    CreatedAt = new DateTime(2023, 10, 20)
};

var post3 = new Post()
{
    Id = 3,
    Title = "Lora Piano",
    CategoryId = 1,
    CreatedAt = DateTime.UtcNow
};

brand.Posts.Add(post1);
brand.Posts.Add(post2);
brand.Posts.Add(post3);

CategoryServices.CreateCategory(brand);

foreach (var category in CategoryServices.GetCategories())
{
    System.Console.WriteLine("CATEGORIES: ");
    System.Console.WriteLine(category.Id);
    System.Console.WriteLine(category.Name);
    System.Console.WriteLine(category.CreatedAt);
    System.Console.WriteLine();
    System.Console.WriteLine("POSTS: ");
    foreach (var post in brand.Posts)
    {
        System.Console.WriteLine(post.Id);
        System.Console.WriteLine(post.Title);
        System.Console.WriteLine(post.CreatedAt);
        System.Console.WriteLine("---------------------------");
    }
}
