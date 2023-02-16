using JobApplication.Models;
using JobApplication.Services;
using Microsoft.EntityFrameworkCore;

namespace Employer.Repo
{
    public class JobApplicationRepo
    {
        
            private readonly DataContext _dbcontext;
            public JobApplicationRepo(DataContext dbcontext)
            {
                _dbcontext = dbcontext;
            }


            public int Addproduct(Class user)
            {
                _dbcontext.Classs.Add(user);


                return _dbcontext.SaveChanges();
            }

            public int Deleteproduct(int id)
            {
                throw new NotImplementedException();
            }

            public Class GetUser(int id)
            {
                return _dbcontext.Classs.Where(n => n.JobSeekerId == id).FirstOrDefault();
            }

            public List<Class> GetUsers()
            {
                return _dbcontext.Classs.ToList();
            }

            public int Updateproduct(int id, Class c)
            {
                var prod = _dbcontext.Classs.Where(p => p.JobSeekerId == id).FirstOrDefault();
                prod.JobSeekerUserName = c.JobSeekerUserName;
                prod.JobSeekerQualification= c.JobSeekerQualification;
                prod.JobSeekerTotalExp = c.JobSeekerTotalExp;
                prod.JobSeekerYOP = c.JobSeekerYOP;
                _dbcontext.Entry<Class>(prod).State = EntityState.Modified;
                return _dbcontext.SaveChanges();
            }
    }
}
