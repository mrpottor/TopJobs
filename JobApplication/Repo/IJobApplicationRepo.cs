using JobApplication.Models;
using JobApplication.Services;


namespace JobApplication.Repo
{
    public interface IJobApplicationRepo
    {
        List<Class> GetUsers();
        Class GetUser(int id);
        int Addproduct(Class c);
        int Updateproduct(int id, Class c);
        int Deleteproduct(int id);
    }
}
