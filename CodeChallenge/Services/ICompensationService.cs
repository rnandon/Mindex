using CodeChallenge.Models;

namespace CodeChallenge.Services
{
    public interface ICompensationService
    {
        public Compensation Create(Compensation compensation);
        public Compensation GetById(string id);
    }
}
