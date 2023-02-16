namespace JobApplication.Exceptions
{
    public class JobTitleNotFoundException : ApplicationException
    {
        public JobTitleNotFoundException() { }
        public JobTitleNotFoundException(string msg) : base(msg) { }
    }
}
