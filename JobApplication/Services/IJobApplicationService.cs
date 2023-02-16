
using JobApplication.Models;

namespace JobApplication.Services
{
    
    
        public interface IJobApplicationService
        {
            List<Class> GetProducts();
            Class GetProduct(int id);
            int AddProduct(Class c);
            int UpdateProduct(int id, Class c);
            int DeleteProduct(int id);
        }
    
}

