using CodeChallenge.Models;
using System.Threading.Tasks;

namespace CodeChallenge.Repositories
{
    public interface ICompensationRepository
    {
        public Compensation Add(Compensation compensation);
        public Compensation GetById(string id);
        public Task SaveAsync();
    }
}
