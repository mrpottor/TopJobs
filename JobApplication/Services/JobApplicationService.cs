using JobApplication.Exceptions;
using JobApplication.Models;
using JobApplication.Repo;



namespace JobApplication.Services
{
    public class JobApplicationServices : IJobApplicationService
    {
        private readonly IJobApplicationRepo repo;
        public JobApplicationServices(IJobApplicationRepo _repo)
        {
            repo = _repo;
        }
        public int AddProduct(Class user)
        {
            if (repo.GetUser(user.JobSeekerId) != null)
            {
                throw new JobTitleNotFoundException($"Customer with customer id {user.JobSeekerId} already exists");
            }
            return repo.Addproduct(user);
        }
        public int DeleteProduct(int id)
        {
            if (repo.GetUser(id) == null)
            {
                throw new JobTitleNotFoundException($"Customer with customer id {id} does not exists");
            }
            return repo.Deleteproduct(id);
        }
        public Class GetUsers(int id)
        {
            Class c = repo.GetUser(id);
            if (c == null)
            {
                throw new JobTitleNotFoundException($"Customer with customer id {id} does not exists");
            }
            return c;
        }
        public Class GetProduct(int id)
        {
            return repo.GetUser(id);
        }
        public List<Class> GetProducts()
        {
            return repo.GetUsers();
        }
        public int UpdateProduct(int id, Class user)
        {
            if (repo.GetUser(id) == null)
            {
                throw new JobTitleNotFoundException($"Customer with customer id {id} does not exists");
            }
            return repo.Updateproduct(id, user);
        }
    }
}
