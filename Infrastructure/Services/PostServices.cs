using System.Security.Cryptography.X509Certificates;
using Domain.Models;
namespace Infrastructure.Services;
class PostServices
{
    List<Post> posts=new List<Post>();

    public void CreatePost(Post post){
        posts.Add(post);
    }

    public List<Post> GetPosts(){
        return posts;
    }

    public Post GetPostById(int id){

       return posts.FirstOrDefault(x=>x.Id==id);
    }

       public Post GetPostByName(string name){

       return posts.FirstOrDefault(x=>x.Title==name);
    }

    public List<Post> GetPostsByDate(DateTime date){
        return posts.FindAll(x=>x.CreatedAt==date);
    }
     
    public List<Post> GetPostsByCategoryId(int id){
         
         return posts.FindAll(x=>x.Id==id);
        
    }

    public void DeletePost(int id){
        posts.RemoveAll(x=>x.Id==id);
    }









}