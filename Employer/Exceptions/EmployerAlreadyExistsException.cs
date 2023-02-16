namespace Employer.Exceptions
{
    public class EmployerAlreadyExistsException:ApplicationException
    {
        public EmployerAlreadyExistsException(string message) : base(message) { }
        public EmployerAlreadyExistsException() { }
    }
}
