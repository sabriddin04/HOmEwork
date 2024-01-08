using System.Dynamic;
using Domain.Models;
namespace Infrastructure.Services;
 public static class CategoryServices
{
   static List<Category>categories=new List<Category>();   
  public static void CreateCategory(Category category){
    categories.Add(category);
  }

   public static List<Category> GetCategories(){
    return categories;
   }
       public static Category GetCategoryById(int id){

       return categories.FirstOrDefault(x=>x.Id==id);
    }

       public static Category GetCategoryByName(string name){

       return categories.FirstOrDefault(x=>x.Name==name);
    }

    public static List<Category> GetCategoryByDate(DateTime date){
        return categories.FindAll(x=>x.CreatedAt==date);
    }


     public static void DeleteCategory(int id){
        categories.RemoveAll(x=>x.Id==id);
    }
}